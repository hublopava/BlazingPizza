﻿using System.Reflection;

// <auto-generated />
using System;
using System.Reflection;
using Duende.IdentityServer.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore.Metadata;

#pragma warning disable 219, 612, 618
#nullable disable

namespace BlazingPizza.Server.Models
{
    internal partial class PersistedGrantEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Duende.IdentityServer.EntityFramework.Entities.PersistedGrant",
                typeof(PersistedGrant),
                baseEntityType);

            var key = runtimeEntityType.AddProperty(
                "Key",
                typeof(string),
                propertyInfo: typeof(PersistedGrant).GetProperty("Key", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersistedGrant).GetField("<Key>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                maxLength: 200);

            var clientId = runtimeEntityType.AddProperty(
                "ClientId",
                typeof(string),
                propertyInfo: typeof(PersistedGrant).GetProperty("ClientId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersistedGrant).GetField("<ClientId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 200);

            var consumedTime = runtimeEntityType.AddProperty(
                "ConsumedTime",
                typeof(DateTime?),
                propertyInfo: typeof(PersistedGrant).GetProperty("ConsumedTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersistedGrant).GetField("<ConsumedTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);

            var creationTime = runtimeEntityType.AddProperty(
                "CreationTime",
                typeof(DateTime),
                propertyInfo: typeof(PersistedGrant).GetProperty("CreationTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersistedGrant).GetField("<CreationTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var data = runtimeEntityType.AddProperty(
                "Data",
                typeof(string),
                propertyInfo: typeof(PersistedGrant).GetProperty("Data", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersistedGrant).GetField("<Data>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 50000);

            var description = runtimeEntityType.AddProperty(
                "Description",
                typeof(string),
                propertyInfo: typeof(PersistedGrant).GetProperty("Description", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersistedGrant).GetField("<Description>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200);

            var expiration = runtimeEntityType.AddProperty(
                "Expiration",
                typeof(DateTime?),
                propertyInfo: typeof(PersistedGrant).GetProperty("Expiration", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersistedGrant).GetField("<Expiration>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);

            var sessionId = runtimeEntityType.AddProperty(
                "SessionId",
                typeof(string),
                propertyInfo: typeof(PersistedGrant).GetProperty("SessionId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersistedGrant).GetField("<SessionId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100);

            var subjectId = runtimeEntityType.AddProperty(
                "SubjectId",
                typeof(string),
                propertyInfo: typeof(PersistedGrant).GetProperty("SubjectId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersistedGrant).GetField("<SubjectId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200);

            var type = runtimeEntityType.AddProperty(
                "Type",
                typeof(string),
                propertyInfo: typeof(PersistedGrant).GetProperty("Type", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersistedGrant).GetField("<Type>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 50);

            var key0 = runtimeEntityType.AddKey(
                new[] { key });
            runtimeEntityType.SetPrimaryKey(key0);

            var index = runtimeEntityType.AddIndex(
                new[] { consumedTime });

            var index0 = runtimeEntityType.AddIndex(
                new[] { expiration });

            var index1 = runtimeEntityType.AddIndex(
                new[] { subjectId, clientId, type });

            var index2 = runtimeEntityType.AddIndex(
                new[] { subjectId, sessionId, type });

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "PersistedGrants");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
