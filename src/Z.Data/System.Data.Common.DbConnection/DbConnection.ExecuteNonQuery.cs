// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using System.Data;
using System.Data.Common;

public static partial class Extensions
{
    /// <summary>
    ///     A DbConnection extension method that executes the non query operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <param name="transaction">The transaction.</param>
    public static void ExecuteNonQuery(this DbConnection @this, string cmdText, DbParameter[] parameters, CommandType commandType, DbTransaction transaction)
    {
        using (DbCommand command = @this.CreateCommand())
        {
            command.CommandText = cmdText;
            command.CommandType = commandType;
            command.Transaction = transaction;

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            command.ExecuteNonQuery();
        }
    }

    /// <summary>
    ///     A DbConnection extension method that executes the non query operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="commandFactory">The command factory.</param>
    public static void ExecuteNonQuery(this DbConnection @this, Action<DbCommand> commandFactory)
    {
        using (DbCommand command = @this.CreateCommand())
        {
            commandFactory(command);

            command.ExecuteNonQuery();
        }
    }

    /// <summary>
    ///     A DbConnection extension method that executes the non query operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    public static void ExecuteNonQuery(this DbConnection @this, string cmdText)
    {
        @this.ExecuteNonQuery(cmdText, null, CommandType.Text, null);
    }

    /// <summary>
    ///     A DbConnection extension method that executes the non query operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="transaction">The transaction.</param>
    public static void ExecuteNonQuery(this DbConnection @this, string cmdText, DbTransaction transaction)
    {
        @this.ExecuteNonQuery(cmdText, null, CommandType.Text, transaction);
    }

    /// <summary>
    ///     A DbConnection extension method that executes the non query operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="commandType">Type of the command.</param>
    public static void ExecuteNonQuery(this DbConnection @this, string cmdText, CommandType commandType)
    {
        @this.ExecuteNonQuery(cmdText, null, commandType, null);
    }

    /// <summary>
    ///     A DbConnection extension method that executes the non query operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <param name="transaction">The transaction.</param>
    public static void ExecuteNonQuery(this DbConnection @this, string cmdText, CommandType commandType, DbTransaction transaction)
    {
        @this.ExecuteNonQuery(cmdText, null, commandType, transaction);
    }

    /// <summary>
    ///     A DbConnection extension method that executes the non query operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    public static void ExecuteNonQuery(this DbConnection @this, string cmdText, DbParameter[] parameters)
    {
        @this.ExecuteNonQuery(cmdText, parameters, CommandType.Text, null);
    }

    /// <summary>
    ///     A DbConnection extension method that executes the non query operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <param name="transaction">The transaction.</param>
    public static void ExecuteNonQuery(this DbConnection @this, string cmdText, DbParameter[] parameters, DbTransaction transaction)
    {
        @this.ExecuteNonQuery(cmdText, parameters, CommandType.Text, transaction);
    }

    /// <summary>
    ///     A DbConnection extension method that executes the non query operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <param name="commandType">Type of the command.</param>
    public static void ExecuteNonQuery(this DbConnection @this, string cmdText, DbParameter[] parameters, CommandType commandType)
    {
        @this.ExecuteNonQuery(cmdText, parameters, commandType, null);
    }
}