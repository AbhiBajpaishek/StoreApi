﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class StoreDBEntities : DbContext
    {
        public StoreDBEntities()
            : base("name=StoreDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tblCustomers> tblCustomers { get; set; }
        public virtual DbSet<tblProducts> tblProducts { get; set; }
        public virtual DbSet<tblCart> tblCart { get; set; }
        public virtual DbSet<tblLogin> tblLogin { get; set; }
        public virtual DbSet<tblOrder> tblOrder { get; set; }
    
        public virtual int spAddToCart(string emailID, Nullable<int> productId, Nullable<int> quantity)
        {
            var emailIDParameter = emailID != null ?
                new ObjectParameter("EmailID", emailID) :
                new ObjectParameter("EmailID", typeof(string));
    
            var productIdParameter = productId.HasValue ?
                new ObjectParameter("ProductId", productId) :
                new ObjectParameter("ProductId", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("Quantity", quantity) :
                new ObjectParameter("Quantity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddToCart", emailIDParameter, productIdParameter, quantityParameter);
        }
    
        public virtual int spCustomerRegistration(string email, string fName, string lName, string address, string password)
        {
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var fNameParameter = fName != null ?
                new ObjectParameter("FName", fName) :
                new ObjectParameter("FName", typeof(string));
    
            var lNameParameter = lName != null ?
                new ObjectParameter("LName", lName) :
                new ObjectParameter("LName", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spCustomerRegistration", emailParameter, fNameParameter, lNameParameter, addressParameter, passwordParameter);
        }
    }
}
