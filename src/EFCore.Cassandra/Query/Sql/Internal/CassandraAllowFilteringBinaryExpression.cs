// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.EntityFrameworkCore.Storage;

namespace EFCore.Cassandra.Query.Sql.Internal
{
    public class CassandraAllowFilteringBinaryExpression : SqlExpression
    {
        public CassandraAllowFilteringBinaryExpression(
            RelationalTypeMapping typeMapping,
            Type type,
            SqlExpression binaryExpression)
            : base(type, typeMapping)
        {
            BinaryExpression = binaryExpression;
        }

        public SqlExpression BinaryExpression { get; set; }

        protected override void Print(ExpressionPrinter expressionPrinter)
        {

        }

        protected override Expression VisitChildren(ExpressionVisitor visitor)
        {
            return this;
        }
    }
}
