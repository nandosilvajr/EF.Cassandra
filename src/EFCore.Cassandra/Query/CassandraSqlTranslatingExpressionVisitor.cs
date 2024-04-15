﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Linq.Expressions;

namespace EFCore.Cassandra.Query
{
    public class CassandraSqlTranslatingExpressionVisitor : RelationalSqlTranslatingExpressionVisitor
    {
        private readonly RelationalSqlTranslatingExpressionVisitorDependencies _dependencies;

        public CassandraSqlTranslatingExpressionVisitor(
            RelationalSqlTranslatingExpressionVisitorDependencies dependencies, 
            QueryCompilationContext queryCompilationContext, 
            IModel model, 
            QueryableMethodTranslatingExpressionVisitor queryableMethodTranslatingExpressionVisitor) : base(dependencies, queryCompilationContext, queryableMethodTranslatingExpressionVisitor)
        {
            _dependencies = dependencies;
        }

        public SqlExpression Translate(Expression expression)
        {
            return base.Translate(expression);
        }

        public override SqlExpression TranslateLongCount(SqlExpression expression = null)
        {
            return base.TranslateLongCount(expression);
        }
    }
}
