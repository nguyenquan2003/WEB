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

namespace khuong.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QL_NhanSuN")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserttbl_Employee(tbl_Employee instance);
    partial void Updatetbl_Employee(tbl_Employee instance);
    partial void Deletetbl_Employee(tbl_Employee instance);
    partial void Inserttbl_Deparment(tbl_Deparment instance);
    partial void Updatetbl_Deparment(tbl_Deparment instance);
    partial void Deletetbl_Deparment(tbl_Deparment instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QL_NhanSuNConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tbl_Employee> tbl_Employees
		{
			get
			{
				return this.GetTable<tbl_Employee>();
			}
		}
		
		public System.Data.Linq.Table<tbl_Deparment> tbl_Deparments
		{
			get
			{
				return this.GetTable<tbl_Deparment>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_Employee")]
	public partial class tbl_Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Gender;
		
		private string _City;
		
		private string _Image;
		
		private System.Nullable<int> _DeptId;
		
		private EntityRef<tbl_Deparment> _tbl_Deparment;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnImageChanging(string value);
    partial void OnImageChanged();
    partial void OnDeptIdChanging(System.Nullable<int> value);
    partial void OnDeptIdChanged();
    #endregion
		
		public tbl_Employee()
		{
			this._tbl_Deparment = default(EntityRef<tbl_Deparment>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="NVarChar(3)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(20)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="NChar(20)")]
		public string Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if ((this._Image != value))
				{
					this.OnImageChanging(value);
					this.SendPropertyChanging();
					this._Image = value;
					this.SendPropertyChanged("Image");
					this.OnImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeptId", DbType="Int")]
		public System.Nullable<int> DeptId
		{
			get
			{
				return this._DeptId;
			}
			set
			{
				if ((this._DeptId != value))
				{
					if (this._tbl_Deparment.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDeptIdChanging(value);
					this.SendPropertyChanging();
					this._DeptId = value;
					this.SendPropertyChanged("DeptId");
					this.OnDeptIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_Deparment_tbl_Employee", Storage="_tbl_Deparment", ThisKey="DeptId", OtherKey="DeptId", IsForeignKey=true)]
		public tbl_Deparment tbl_Deparment
		{
			get
			{
				return this._tbl_Deparment.Entity;
			}
			set
			{
				tbl_Deparment previousValue = this._tbl_Deparment.Entity;
				if (((previousValue != value) 
							|| (this._tbl_Deparment.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbl_Deparment.Entity = null;
						previousValue.tbl_Employees.Remove(this);
					}
					this._tbl_Deparment.Entity = value;
					if ((value != null))
					{
						value.tbl_Employees.Add(this);
						this._DeptId = value.DeptId;
					}
					else
					{
						this._DeptId = default(Nullable<int>);
					}
					this.SendPropertyChanged("tbl_Deparment");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_Deparment")]
	public partial class tbl_Deparment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DeptId;
		
		private string _Name;
		
		private EntitySet<tbl_Employee> _tbl_Employees;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDeptIdChanging(int value);
    partial void OnDeptIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public tbl_Deparment()
		{
			this._tbl_Employees = new EntitySet<tbl_Employee>(new Action<tbl_Employee>(this.attach_tbl_Employees), new Action<tbl_Employee>(this.detach_tbl_Employees));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeptId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int DeptId
		{
			get
			{
				return this._DeptId;
			}
			set
			{
				if ((this._DeptId != value))
				{
					this.OnDeptIdChanging(value);
					this.SendPropertyChanging();
					this._DeptId = value;
					this.SendPropertyChanged("DeptId");
					this.OnDeptIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_Deparment_tbl_Employee", Storage="_tbl_Employees", ThisKey="DeptId", OtherKey="DeptId")]
		public EntitySet<tbl_Employee> tbl_Employees
		{
			get
			{
				return this._tbl_Employees;
			}
			set
			{
				this._tbl_Employees.Assign(value);
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
		
		private void attach_tbl_Employees(tbl_Employee entity)
		{
			this.SendPropertyChanging();
			entity.tbl_Deparment = this;
		}
		
		private void detach_tbl_Employees(tbl_Employee entity)
		{
			this.SendPropertyChanging();
			entity.tbl_Deparment = null;
		}
	}
}
#pragma warning restore 1591
