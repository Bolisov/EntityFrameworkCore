// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using JetBrains.Annotations;
using Microsoft.Data.Entity.Utilities;

namespace Microsoft.Data.Entity.Relational.Migrations.Operations
{
    public class DropTableOperation : MigrationOperation
    {
        public DropTableOperation(
            [NotNull] string name,
            [CanBeNull] string schema,
            [CanBeNull] IReadOnlyDictionary<string, string> annotations = null)
            : base(annotations)
        {
            Check.NotEmpty(name, nameof(name));

            Name = name;
            Schema = schema;
        }

        public virtual string Name { get; }
        public virtual string Schema { get; }
        public override bool IsDestructiveChange => true;
    }
}
