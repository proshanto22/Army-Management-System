﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace Army_Management_System
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DatabaseEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DatabaseEntities object using the connection string found in the 'DatabaseEntities' section of the application configuration file.
        /// </summary>
        public DatabaseEntities() : base("name=DatabaseEntities", "DatabaseEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DatabaseEntities object.
        /// </summary>
        public DatabaseEntities(string connectionString) : base(connectionString, "DatabaseEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DatabaseEntities object.
        /// </summary>
        public DatabaseEntities(EntityConnection connection) : base(connection, "DatabaseEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
    }

    #endregion

    
}