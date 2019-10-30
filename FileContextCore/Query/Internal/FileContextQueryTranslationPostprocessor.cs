﻿// Copyright (c) morrisjdev & .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;

namespace FileContextCore.Query.Internal
{
    public class FileContextQueryTranslationPostprocessor : QueryTranslationPostprocessor
    {
        public FileContextQueryTranslationPostprocessor(QueryTranslationPostprocessorDependencies dependencies)
            : base(dependencies)
        {
        }

        public override Expression Process(Expression query)
        {
            query = base.Process(query);

            return query;
        }
    }
}
