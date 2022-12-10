package net.minecraft.command;

import net.minecraft.entity.Entity;
import net.minecraft.nbt.NBTTagCompound;
import net.minecraft.scoreboard.Score;
import net.minecraft.scoreboard.ScoreObjective;
import net.minecraft.scoreboard.Scoreboard;
import net.minecraft.util.BlockPos;
import net.minecraft.util.IChatComponent;
import net.minecraft.util.Vec3;
import net.minecraft.world.World;

public class CommandResultStats
{
    /** The number of result command result types that are possible. */
    private static final int NUM_RESULT_TYPES = CommandResultStats.Type.values().length;
    private static final String[] STRING_RESULT_TYPES = new String[NUM_RESULT_TYPES];
    /** List of entityID who set a stat, username for a player, UUID for all entities */
    private String[] entitiesID;
    /** List of all the Objectives names */
    private String[] objectives;

    public CommandResultStats()
    {
        this.entitiesID = STRING_RESULT_TYPES;
        this.objectives = STRING_RESULT_TYPES;
    }

    /**
     * Set the score on the ScoreBoard
     *  
     * @param scorePoint The score to set to the score board
     */
    public void setCommandStatScore(final ICommandSender sender, CommandResultStats.Type resultTypeIn, int scorePoint)
    {
        String s = this.entitiesID[resultTypeIn.getTypeID()];

        if (s != null)
        {
            ICommandSender icommandsender = new ICommandSender()
            {
                /**
                 * Get the name of this object. For players this returns their username
                 */
                public String getName()
                {
                    return sender.getName();
                }
                /**
                 * Get the formatted ChatComponent that will be used for the sender's username in chat
                 */
                public IChatComponent getDisplayName()
                {
                    return sender.getDisplayName();
                }
                /**
                 * Send a chat message to the CommandSender
                 */
                public void addChatMessage(IChatComponent component)
                {
                    sender.addChatMessage(component);
                }
                /**
                 * Returns {@code true} if the CommandSender is allowed to execute the command, {@code false} if not
                 */
                public boolean canCommandSenderUseCommand(int permLevel, String commandName)
                {
                    return true;
                }
                /**
                 * Get the position in the world. <b>{@code null} is not allowed!</b> If you are not an entity in the
                 * world, return the coordinates 0, 0, 0
                 */
                public BlockPos getPosition()
                {
                    return sender.getPosition();
                }
                /**
                 * Get the position vector. <b>{@code null} is not allowed!</b> If you are not an entity in the world,
                 * return 0.0D, 0.0D, 0.0D
                 */
                public Vec3 getPositionVector()
                {
                    return sender.getPositionVector();
                }
                /**
                 * Get the world, if available. <b>{@code null} is not allowed!</b> If you are not an entity in the
                 * world, return the overworld
                 */
                public World getEntityWorld()
                {
                    return sender.getEntityWorld();
                }
                /**
                 * Returns the entity associated with the command sender. MAY BE NULL!
                 */
                public Entity getCommandSenderEntity()
                {
                    return sender.getCommandSenderEntity();
                }
                /**
                 * Returns true if the command sender should be sent feedback about executed commands
                 */
                public boolean sendCommandFeedback()
                {
                    return sender.sendCommandFeedback();
                }
                public void setCommandStat(CommandResultStats.Type type, int amount)
                {
                    sender.setCommandStat(type, amount);
                }
            };
            String s1;

            try
            {
                s1 = CommandBase.getEntityName(icommandsender, s);
            }
            catch (EntityNotFoundException var11)
            {
                return;
            }

            String s2 = this.objectives[resultTypeIn.getTypeID()];

            if (s2 != null)
            {
                Scoreboard scoreboard = sender.getEntityWorld().getScoreboard();
                ScoreObjective scoreobjective = scoreboard.getObjective(s2);

                if (scoreobjective != null)
                {
                    if (scoreboard.entityHasObjective(s1, scoreobjective))
                    {
                        Score score = scoreboard.getValueFromObjective(s1, scoreobjective);
                        score.setScorePoints(scorePoint);
                    }
                }
            }
        }
    }

    public void readStatsFromNBT(NBTTagCompound tagcompound)
    {
        if (tagcompound.hasKey("CommandStats", 10))
        {
            NBTTagCompound nbttagcompound = tagcompound.getCompoundTag("CommandStats");

            for (CommandResultStats.Type commandresultstats$type : CommandResultStats.Type.values())
            {
                String s = commandresultstats$type.getTypeName() + "Name";
                String s1 = commandresultstats$type.getTypeName() + "Objective";

                if (nbttagcompound.hasKey(s, 8) && nbttagcompound.hasKey(s1, 8))
                {
                    String s2 = nbttagcompound.getString(s);
                    String s3 = nbttagcompound.getString(s1);
                    setScoreBoardStat(this, commandresultstats$type, s2, s3);
                }
            }
        }
    }

    public void writeStatsToNBT(NBTTagCompound tagcompound)
    {
        NBTTagCompound nbttagcompound = new NBTTagCompound();

        for (CommandResultStats.Type commandresultstats$type : CommandResultStats.Type.values())
        {
            String s = this.entitiesID[commandresultstats$type.getTypeID()];
            String s1 = this.objectives[commandresultstats$type.getTypeID()];

            if (s != null && s1 != null)
            {
                nbttagcompound.setString(commandresultstats$type.getTypeName() + "Name", s);
                nbttagcompound.setString(commandresultstats$type.getTypeName() + "Objective", s1);
            }
        }

        if (!nbttagcompound.hasNoTags())
        {
            tagcompound.setTag("CommandStats", nbttagcompound);
        }
    }

    /**
     * Set a stat in the scoreboard
     *  
     * @param entityID The username of the player or the UUID of an Entity
     * @param objectiveName The name of the Objective
     */
    public static void setScoreBoardStat(CommandResultStats stats, CommandResultStats.Type resultType, String entityID, String objectiveName)
    {
        if (entityID != null && entityID.length() != 0 && objectiveName != null && objectiveName.length() != 0)
        {
            if (stats.entitiesID == STRING_RESULT_TYPES || stats.objectives == STRING_RESULT_TYPES)
            {
                stats.entitiesID = new String[NUM_RESULT_TYPES];
                stats.objectives = new String[NUM_RESULT_TYPES];
            }

            stats.entitiesID[resultType.getTypeID()] = entityID;
            stats.objectives[resultType.getTypeID()] = objectiveName;
        }
        else
        {
            removeScoreBoardStat(stats, resultType);
        }
    }

    /**
     * Remove a stat from the scoreboard
     */
    private static void removeScoreBoardStat(CommandResultStats resultStatsIn, CommandResultStats.Type resultTypeIn)
    {
        if (resultStatsIn.entitiesID != STRING_RESULT_TYPES && resultStatsIn.objectives != STRING_RESULT_TYPES)
        {
            resultStatsIn.entitiesID[resultTypeIn.getTypeID()] = null;
            resultStatsIn.objectives[resultTypeIn.getTypeID()] = null;
            boolean flag = true;

            for (CommandResultStats.Type commandresultstats$type : CommandResultStats.Type.values())
            {
                if (resultStatsIn.entitiesID[commandresultstats$type.getTypeID()] != null && resultStatsIn.objectives[commandresultstats$type.getTypeID()] != null)
                {
                    flag = false;
                    break;
                }
            }

            if (flag)
            {
                resultStatsIn.entitiesID = STRING_RESULT_TYPES;
                resultStatsIn.objectives = STRING_RESULT_TYPES;
            }
        }
    }

    /**
     * Add all stats in the CommandResultStats
     */
    public void addAllStats(CommandResultStats resultStatsIn)
    {
        for (CommandResultStats.Type commandresultstats$type : CommandResultStats.Type.values())
        {
            setScoreBoardStat(this, commandresultstats$type, resultStatsIn.entitiesID[commandresultstats$type.getTypeID()], resultStatsIn.objectives[commandresultstats$type.getTypeID()]);
        }
    }

    public static enum Type
    {
        SUCCESS_COUNT(0, "SuccessCount"),
        AFFECTED_BLOCKS(1, "AffectedBlocks"),
        AFFECTED_ENTITIES(2, "AffectedEntities"),
        AFFECTED_ITEMS(3, "AffectedItems"),
        QUERY_RESULT(4, "QueryResult");

        /** The integer ID of the Result Type. */
        final int typeID;
        /** The string representation of the type. */
        final String typeName;

        private Type(int id, String name)
        {
            this.typeID = id;
            this.typeName = name;
        }

        /**
         * Retrieves the integer ID of the result type.
         */
        public int getTypeID()
        {
            return this.typeID;
        }

        /**
         * Retrieves the name of the type.
         */
        public String getTypeName()
        {
            return this.typeName;
        }

        /**
         * Returns the names of all possible Result Types.
         */
        public static String[] getTypeNames()
        {
            String[] astring = new String[values().length];
            int i = 0;

            for (CommandResultStats.Type commandresultstats$type : values())
            {
                astring[i++] = commandresultstats$type.getTypeName();
            }

            return astring;
        }

        /**
         * Retrieves the Type indicated by the supplied name string.
         */
        public static CommandResultStats.Type getTypeByName(String name)
        {
            for (CommandResultStats.Type commandresultstats$type : values())
            {
                if (commandresultstats$type.getTypeName().equals(name))
                {
                    return commandresultstats$type;
                }
            }

            return null;
        }
    }
}