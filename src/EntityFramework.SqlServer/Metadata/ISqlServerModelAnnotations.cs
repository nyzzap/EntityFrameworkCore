// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Data.Entity.Metadata;

namespace Microsoft.Data.Entity.SqlServer.Metadata
{
    public interface ISqlServerModelAnnotations : IRelationalModelAnnotations
    {
        SqlServerIdentityStrategy? IdentityStrategy { get; }
        string HiLoSequenceName { get; }
        string HiLoSequenceSchema { get; }
        int? HiLoSequencePoolSize { get; }
    }
}
