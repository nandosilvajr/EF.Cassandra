// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Query;

namespace EFCore.Cassandra.Query.Sql.Internal
{
    public class CassandraQueryableMethodTranslatingExpressionVisitorFactory : IQueryableMethodTranslatingExpressionVisitorFactory
    {
        private readonly QueryableMethodTranslatingExpressionVisitorDependencies _dependencies;
        private readonly RelationalQueryableMethodTranslatingExpressionVisitorDependencies _relationalDependencies;
        private readonly SqlExpressionFactoryDependencies _sqlExpressionFactoryDependencies;

        public CassandraQueryableMethodTranslatingExpressionVisitorFactory(
            [NotNull] QueryableMethodTranslatingExpressionVisitorDependencies dependencies,
            [NotNull] RelationalQueryableMethodTranslatingExpressionVisitorDependencies relationalDependencies,
            [NotNull] SqlExpressionFactoryDependencies sqlExpressionFactoryDependencies)
        {
            _dependencies = dependencies;
            _relationalDependencies = relationalDependencies;
            _sqlExpressionFactoryDependencies = sqlExpressionFactoryDependencies;
        }

        public QueryableMethodTranslatingExpressionVisitor Create(QueryCompilationContext queryCompilationContext)
        {
            return new CassandraQueryableMethodTranslatingExpressionVisitor(_dependencies, _relationalDependencies, queryCompilationContext, _sqlExpressionFactoryDependencies);
        }
    }
}
