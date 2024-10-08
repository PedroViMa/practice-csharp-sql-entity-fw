﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Store")]
	public partial class StoreDataClassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void InsertPurchase(Purchase instance);
    partial void UpdatePurchase(Purchase instance);
    partial void DeletePurchase(Purchase instance);
    partial void InsertSale(Sale instance);
    partial void UpdateSale(Sale instance);
    partial void DeleteSale(Sale instance);
    #endregion
		
		public StoreDataClassDataContext() : 
				base(global::DAL.Properties.Settings.Default.StoreConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public StoreDataClassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StoreDataClassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StoreDataClassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StoreDataClassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<Purchase> Purchases
		{
			get
			{
				return this.GetTable<Purchase>();
			}
		}
		
		public System.Data.Linq.Table<Sale> Sales
		{
			get
			{
				return this.GetTable<Sale>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Product")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProductID;
		
		private string _ProductName;
		
		private string _Description;
		
		private decimal _Price;
		
		private int _StockQuantity;
		
		private EntitySet<Purchase> _Purchases;
		
		private EntitySet<Sale> _Sales;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductIDChanging(int value);
    partial void OnProductIDChanged();
    partial void OnProductNameChanging(string value);
    partial void OnProductNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    partial void OnStockQuantityChanging(int value);
    partial void OnStockQuantityChanged();
    #endregion
		
		public Product()
		{
			this._Purchases = new EntitySet<Purchase>(new Action<Purchase>(this.attach_Purchases), new Action<Purchase>(this.detach_Purchases));
			this._Sales = new EntitySet<Sale>(new Action<Sale>(this.attach_Sales), new Action<Sale>(this.detach_Sales));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProductID
		{
			get
			{
				return this._ProductID;
			}
			set
			{
				if ((this._ProductID != value))
				{
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._ProductID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductName", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string ProductName
		{
			get
			{
				return this._ProductName;
			}
			set
			{
				if ((this._ProductName != value))
				{
					this.OnProductNameChanging(value);
					this.SendPropertyChanging();
					this._ProductName = value;
					this.SendPropertyChanged("ProductName");
					this.OnProductNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Decimal(10,2) NOT NULL")]
		public decimal Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StockQuantity", DbType="Int NOT NULL")]
		public int StockQuantity
		{
			get
			{
				return this._StockQuantity;
			}
			set
			{
				if ((this._StockQuantity != value))
				{
					this.OnStockQuantityChanging(value);
					this.SendPropertyChanging();
					this._StockQuantity = value;
					this.SendPropertyChanged("StockQuantity");
					this.OnStockQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Purchase", Storage="_Purchases", ThisKey="ProductID", OtherKey="ProductID")]
		public EntitySet<Purchase> Purchases
		{
			get
			{
				return this._Purchases;
			}
			set
			{
				this._Purchases.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Sale", Storage="_Sales", ThisKey="ProductID", OtherKey="ProductID")]
		public EntitySet<Sale> Sales
		{
			get
			{
				return this._Sales;
			}
			set
			{
				this._Sales.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Purchases(Purchase entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_Purchases(Purchase entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
		
		private void attach_Sales(Sale entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_Sales(Sale entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Purchase")]
	public partial class Purchase : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PurchaseID;
		
		private System.Nullable<int> _ProductID;
		
		private int _QuantityPurchased;
		
		private System.DateTime _PurchaseDate;
		
		private decimal _TotalCost;
		
		private EntityRef<Product> _Product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPurchaseIDChanging(int value);
    partial void OnPurchaseIDChanged();
    partial void OnProductIDChanging(System.Nullable<int> value);
    partial void OnProductIDChanged();
    partial void OnQuantityPurchasedChanging(int value);
    partial void OnQuantityPurchasedChanged();
    partial void OnPurchaseDateChanging(System.DateTime value);
    partial void OnPurchaseDateChanged();
    partial void OnTotalCostChanging(decimal value);
    partial void OnTotalCostChanged();
    #endregion
		
		public Purchase()
		{
			this._Product = default(EntityRef<Product>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PurchaseID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PurchaseID
		{
			get
			{
				return this._PurchaseID;
			}
			set
			{
				if ((this._PurchaseID != value))
				{
					this.OnPurchaseIDChanging(value);
					this.SendPropertyChanging();
					this._PurchaseID = value;
					this.SendPropertyChanged("PurchaseID");
					this.OnPurchaseIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductID", DbType="Int")]
		public System.Nullable<int> ProductID
		{
			get
			{
				return this._ProductID;
			}
			set
			{
				if ((this._ProductID != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._ProductID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuantityPurchased", DbType="Int NOT NULL")]
		public int QuantityPurchased
		{
			get
			{
				return this._QuantityPurchased;
			}
			set
			{
				if ((this._QuantityPurchased != value))
				{
					this.OnQuantityPurchasedChanging(value);
					this.SendPropertyChanging();
					this._QuantityPurchased = value;
					this.SendPropertyChanged("QuantityPurchased");
					this.OnQuantityPurchasedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PurchaseDate", DbType="DateTime NOT NULL")]
		public System.DateTime PurchaseDate
		{
			get
			{
				return this._PurchaseDate;
			}
			set
			{
				if ((this._PurchaseDate != value))
				{
					this.OnPurchaseDateChanging(value);
					this.SendPropertyChanging();
					this._PurchaseDate = value;
					this.SendPropertyChanged("PurchaseDate");
					this.OnPurchaseDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalCost", DbType="Decimal(10,2) NOT NULL")]
		public decimal TotalCost
		{
			get
			{
				return this._TotalCost;
			}
			set
			{
				if ((this._TotalCost != value))
				{
					this.OnTotalCostChanging(value);
					this.SendPropertyChanging();
					this._TotalCost = value;
					this.SendPropertyChanged("TotalCost");
					this.OnTotalCostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Purchase", Storage="_Product", ThisKey="ProductID", OtherKey="ProductID", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.Purchases.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.Purchases.Add(this);
						this._ProductID = value.ProductID;
					}
					else
					{
						this._ProductID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Product");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Sales")]
	public partial class Sale : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SalesID;
		
		private System.Nullable<int> _ProductID;
		
		private int _QuantitySold;
		
		private System.DateTime _SaleDate;
		
		private decimal _TotalAmount;
		
		private EntityRef<Product> _Product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSalesIDChanging(int value);
    partial void OnSalesIDChanged();
    partial void OnProductIDChanging(System.Nullable<int> value);
    partial void OnProductIDChanged();
    partial void OnQuantitySoldChanging(int value);
    partial void OnQuantitySoldChanged();
    partial void OnSaleDateChanging(System.DateTime value);
    partial void OnSaleDateChanged();
    partial void OnTotalAmountChanging(decimal value);
    partial void OnTotalAmountChanged();
    #endregion
		
		public Sale()
		{
			this._Product = default(EntityRef<Product>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalesID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SalesID
		{
			get
			{
				return this._SalesID;
			}
			set
			{
				if ((this._SalesID != value))
				{
					this.OnSalesIDChanging(value);
					this.SendPropertyChanging();
					this._SalesID = value;
					this.SendPropertyChanged("SalesID");
					this.OnSalesIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductID", DbType="Int")]
		public System.Nullable<int> ProductID
		{
			get
			{
				return this._ProductID;
			}
			set
			{
				if ((this._ProductID != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._ProductID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuantitySold", DbType="Int NOT NULL")]
		public int QuantitySold
		{
			get
			{
				return this._QuantitySold;
			}
			set
			{
				if ((this._QuantitySold != value))
				{
					this.OnQuantitySoldChanging(value);
					this.SendPropertyChanging();
					this._QuantitySold = value;
					this.SendPropertyChanged("QuantitySold");
					this.OnQuantitySoldChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SaleDate", DbType="DateTime NOT NULL")]
		public System.DateTime SaleDate
		{
			get
			{
				return this._SaleDate;
			}
			set
			{
				if ((this._SaleDate != value))
				{
					this.OnSaleDateChanging(value);
					this.SendPropertyChanging();
					this._SaleDate = value;
					this.SendPropertyChanged("SaleDate");
					this.OnSaleDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalAmount", DbType="Decimal(10,2) NOT NULL")]
		public decimal TotalAmount
		{
			get
			{
				return this._TotalAmount;
			}
			set
			{
				if ((this._TotalAmount != value))
				{
					this.OnTotalAmountChanging(value);
					this.SendPropertyChanging();
					this._TotalAmount = value;
					this.SendPropertyChanged("TotalAmount");
					this.OnTotalAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Sale", Storage="_Product", ThisKey="ProductID", OtherKey="ProductID", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.Sales.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.Sales.Add(this);
						this._ProductID = value.ProductID;
					}
					else
					{
						this._ProductID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Product");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
