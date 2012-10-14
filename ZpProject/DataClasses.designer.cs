﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZpProject
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Base")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPaymentType(PaymentType instance);
    partial void UpdatePaymentType(PaymentType instance);
    partial void DeletePaymentType(PaymentType instance);
    partial void InsertDepartment(Department instance);
    partial void UpdateDepartment(Department instance);
    partial void DeleteDepartment(Department instance);
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    partial void InsertPaymentEmployee(PaymentEmployee instance);
    partial void UpdatePaymentEmployee(PaymentEmployee instance);
    partial void DeletePaymentEmployee(PaymentEmployee instance);
    partial void InsertPaymentPeriod(PaymentPeriod instance);
    partial void UpdatePaymentPeriod(PaymentPeriod instance);
    partial void DeletePaymentPeriod(PaymentPeriod instance);
    partial void InsertPayment(Payment instance);
    partial void UpdatePayment(Payment instance);
    partial void DeletePayment(Payment instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::ZpProject.Properties.Settings.Default.BaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<PaymentType> PaymentTypes
		{
			get
			{
				return this.GetTable<PaymentType>();
			}
		}
		
		public System.Data.Linq.Table<Department> Departments
		{
			get
			{
				return this.GetTable<Department>();
			}
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
		
		public System.Data.Linq.Table<PaymentEmployee> PaymentEmployees
		{
			get
			{
				return this.GetTable<PaymentEmployee>();
			}
		}
		
		public System.Data.Linq.Table<PaymentPeriod> PaymentPeriods
		{
			get
			{
				return this.GetTable<PaymentPeriod>();
			}
		}
		
		public System.Data.Linq.Table<Payment> Payments
		{
			get
			{
				return this.GetTable<Payment>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PaymentTypes")]
	public partial class PaymentType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private int _Code;
		
		private bool _IsIncrement;
		
		private EntitySet<Payment> _Payments;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnCodeChanging(int value);
    partial void OnCodeChanged();
    partial void OnIsIncrementChanging(bool value);
    partial void OnIsIncrementChanged();
    #endregion
		
		public PaymentType()
		{
			this._Payments = new EntitySet<Payment>(new Action<Payment>(this.attach_Payments), new Action<Payment>(this.detach_Payments));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Code", DbType="Int NOT NULL")]
		public int Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				if ((this._Code != value))
				{
					this.OnCodeChanging(value);
					this.SendPropertyChanging();
					this._Code = value;
					this.SendPropertyChanged("Code");
					this.OnCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsIncrement", DbType="Bit NOT NULL")]
		public bool IsIncrement
		{
			get
			{
				return this._IsIncrement;
			}
			set
			{
				if ((this._IsIncrement != value))
				{
					this.OnIsIncrementChanging(value);
					this.SendPropertyChanging();
					this._IsIncrement = value;
					this.SendPropertyChanged("IsIncrement");
					this.OnIsIncrementChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PaymentType_Payment", Storage="_Payments", ThisKey="ID", OtherKey="PaymentTypeID")]
		public EntitySet<Payment> Payments
		{
			get
			{
				return this._Payments;
			}
			set
			{
				this._Payments.Assign(value);
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
		
		private void attach_Payments(Payment entity)
		{
			this.SendPropertyChanging();
			entity.PaymentType = this;
		}
		
		private void detach_Payments(Payment entity)
		{
			this.SendPropertyChanging();
			entity.PaymentType = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Departments")]
	public partial class Department : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private EntitySet<Employee> _Employees;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Department()
		{
			this._Employees = new EntitySet<Employee>(new Action<Employee>(this.attach_Employees), new Action<Employee>(this.detach_Employees));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(256) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Department_Employee", Storage="_Employees", ThisKey="ID", OtherKey="DepartmentID")]
		public EntitySet<Employee> Employees
		{
			get
			{
				return this._Employees;
			}
			set
			{
				this._Employees.Assign(value);
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
		
		private void attach_Employees(Employee entity)
		{
			this.SendPropertyChanging();
			entity.Department = this;
		}
		
		private void detach_Employees(Employee entity)
		{
			this.SendPropertyChanging();
			entity.Department = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employees")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _FIO;
		
		private int _DepartmentID;
		
		private byte _Status;
		
		private byte _Category;
		
		private EntitySet<PaymentEmployee> _PaymentEmployees;
		
		private EntityRef<Department> _Department;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnFIOChanging(string value);
    partial void OnFIOChanged();
    partial void OnDepartmentIDChanging(int value);
    partial void OnDepartmentIDChanged();
    partial void OnStatusChanging(byte value);
    partial void OnStatusChanged();
    partial void OnCategoryChanging(byte value);
    partial void OnCategoryChanged();
    #endregion
		
		public Employee()
		{
			this._PaymentEmployees = new EntitySet<PaymentEmployee>(new Action<PaymentEmployee>(this.attach_PaymentEmployees), new Action<PaymentEmployee>(this.detach_PaymentEmployees));
			this._Department = default(EntityRef<Department>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FIO", DbType="NVarChar(256) NOT NULL", CanBeNull=false)]
		public string FIO
		{
			get
			{
				return this._FIO;
			}
			set
			{
				if ((this._FIO != value))
				{
					this.OnFIOChanging(value);
					this.SendPropertyChanging();
					this._FIO = value;
					this.SendPropertyChanged("FIO");
					this.OnFIOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartmentID", DbType="Int NOT NULL")]
		public int DepartmentID
		{
			get
			{
				return this._DepartmentID;
			}
			set
			{
				if ((this._DepartmentID != value))
				{
					if (this._Department.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDepartmentIDChanging(value);
					this.SendPropertyChanging();
					this._DepartmentID = value;
					this.SendPropertyChanged("DepartmentID");
					this.OnDepartmentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="TinyInt NOT NULL")]
		public byte Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Category", DbType="TinyInt NOT NULL")]
		public byte Category
		{
			get
			{
				return this._Category;
			}
			set
			{
				if ((this._Category != value))
				{
					this.OnCategoryChanging(value);
					this.SendPropertyChanging();
					this._Category = value;
					this.SendPropertyChanged("Category");
					this.OnCategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Employee_PaymentEmployee", Storage="_PaymentEmployees", ThisKey="ID", OtherKey="EmployeeID")]
		public EntitySet<PaymentEmployee> PaymentEmployees
		{
			get
			{
				return this._PaymentEmployees;
			}
			set
			{
				this._PaymentEmployees.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Department_Employee", Storage="_Department", ThisKey="DepartmentID", OtherKey="ID", IsForeignKey=true)]
		public Department Department
		{
			get
			{
				return this._Department.Entity;
			}
			set
			{
				Department previousValue = this._Department.Entity;
				if (((previousValue != value) 
							|| (this._Department.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Department.Entity = null;
						previousValue.Employees.Remove(this);
					}
					this._Department.Entity = value;
					if ((value != null))
					{
						value.Employees.Add(this);
						this._DepartmentID = value.ID;
					}
					else
					{
						this._DepartmentID = default(int);
					}
					this.SendPropertyChanged("Department");
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
		
		private void attach_PaymentEmployees(PaymentEmployee entity)
		{
			this.SendPropertyChanging();
			entity.Employee = this;
		}
		
		private void detach_PaymentEmployees(PaymentEmployee entity)
		{
			this.SendPropertyChanging();
			entity.Employee = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PaymentEmployees")]
	public partial class PaymentEmployee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _PaymentPeriodID;
		
		private int _EmployeeID;
		
		private EntitySet<Payment> _Payments;
		
		private EntityRef<Employee> _Employee;
		
		private EntityRef<PaymentPeriod> _PaymentPeriod;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnPaymentPeriodIDChanging(int value);
    partial void OnPaymentPeriodIDChanged();
    partial void OnEmployeeIDChanging(int value);
    partial void OnEmployeeIDChanged();
    #endregion
		
		public PaymentEmployee()
		{
			this._Payments = new EntitySet<Payment>(new Action<Payment>(this.attach_Payments), new Action<Payment>(this.detach_Payments));
			this._Employee = default(EntityRef<Employee>);
			this._PaymentPeriod = default(EntityRef<PaymentPeriod>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaymentPeriodID", DbType="Int NOT NULL")]
		public int PaymentPeriodID
		{
			get
			{
				return this._PaymentPeriodID;
			}
			set
			{
				if ((this._PaymentPeriodID != value))
				{
					if (this._PaymentPeriod.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPaymentPeriodIDChanging(value);
					this.SendPropertyChanging();
					this._PaymentPeriodID = value;
					this.SendPropertyChanged("PaymentPeriodID");
					this.OnPaymentPeriodIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeID", DbType="Int NOT NULL")]
		public int EmployeeID
		{
			get
			{
				return this._EmployeeID;
			}
			set
			{
				if ((this._EmployeeID != value))
				{
					if (this._Employee.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEmployeeIDChanging(value);
					this.SendPropertyChanging();
					this._EmployeeID = value;
					this.SendPropertyChanged("EmployeeID");
					this.OnEmployeeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PaymentEmployee_Payment", Storage="_Payments", ThisKey="ID", OtherKey="PaymentEmployeeID")]
		public EntitySet<Payment> Payments
		{
			get
			{
				return this._Payments;
			}
			set
			{
				this._Payments.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Employee_PaymentEmployee", Storage="_Employee", ThisKey="EmployeeID", OtherKey="ID", IsForeignKey=true)]
		public Employee Employee
		{
			get
			{
				return this._Employee.Entity;
			}
			set
			{
				Employee previousValue = this._Employee.Entity;
				if (((previousValue != value) 
							|| (this._Employee.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Employee.Entity = null;
						previousValue.PaymentEmployees.Remove(this);
					}
					this._Employee.Entity = value;
					if ((value != null))
					{
						value.PaymentEmployees.Add(this);
						this._EmployeeID = value.ID;
					}
					else
					{
						this._EmployeeID = default(int);
					}
					this.SendPropertyChanged("Employee");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PaymentPeriod_PaymentEmployee", Storage="_PaymentPeriod", ThisKey="PaymentPeriodID", OtherKey="ID", IsForeignKey=true)]
		public PaymentPeriod PaymentPeriod
		{
			get
			{
				return this._PaymentPeriod.Entity;
			}
			set
			{
				PaymentPeriod previousValue = this._PaymentPeriod.Entity;
				if (((previousValue != value) 
							|| (this._PaymentPeriod.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PaymentPeriod.Entity = null;
						previousValue.PaymentEmployees.Remove(this);
					}
					this._PaymentPeriod.Entity = value;
					if ((value != null))
					{
						value.PaymentEmployees.Add(this);
						this._PaymentPeriodID = value.ID;
					}
					else
					{
						this._PaymentPeriodID = default(int);
					}
					this.SendPropertyChanged("PaymentPeriod");
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
		
		private void attach_Payments(Payment entity)
		{
			this.SendPropertyChanging();
			entity.PaymentEmployee = this;
		}
		
		private void detach_Payments(Payment entity)
		{
			this.SendPropertyChanging();
			entity.PaymentEmployee = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PaymentPeriods")]
	public partial class PaymentPeriod : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private short _Year;
		
		private byte _Month;
		
		private EntitySet<PaymentEmployee> _PaymentEmployees;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnYearChanging(short value);
    partial void OnYearChanged();
    partial void OnMonthChanging(byte value);
    partial void OnMonthChanged();
    #endregion
		
		public PaymentPeriod()
		{
			this._PaymentEmployees = new EntitySet<PaymentEmployee>(new Action<PaymentEmployee>(this.attach_PaymentEmployees), new Action<PaymentEmployee>(this.detach_PaymentEmployees));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="SmallInt NOT NULL")]
		public short Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this.OnYearChanging(value);
					this.SendPropertyChanging();
					this._Year = value;
					this.SendPropertyChanged("Year");
					this.OnYearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Month", DbType="TinyInt NOT NULL")]
		public byte Month
		{
			get
			{
				return this._Month;
			}
			set
			{
				if ((this._Month != value))
				{
					this.OnMonthChanging(value);
					this.SendPropertyChanging();
					this._Month = value;
					this.SendPropertyChanged("Month");
					this.OnMonthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PaymentPeriod_PaymentEmployee", Storage="_PaymentEmployees", ThisKey="ID", OtherKey="PaymentPeriodID")]
		public EntitySet<PaymentEmployee> PaymentEmployees
		{
			get
			{
				return this._PaymentEmployees;
			}
			set
			{
				this._PaymentEmployees.Assign(value);
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
		
		private void attach_PaymentEmployees(PaymentEmployee entity)
		{
			this.SendPropertyChanging();
			entity.PaymentPeriod = this;
		}
		
		private void detach_PaymentEmployees(PaymentEmployee entity)
		{
			this.SendPropertyChanging();
			entity.PaymentPeriod = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Payments")]
	public partial class Payment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _PaymentEmployeeID;
		
		private int _PaymentTypeID;
		
		private decimal _Value;
		
		private EntityRef<PaymentEmployee> _PaymentEmployee;
		
		private EntityRef<PaymentType> _PaymentType;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnPaymentEmployeeIDChanging(int value);
    partial void OnPaymentEmployeeIDChanged();
    partial void OnPaymentTypeIDChanging(int value);
    partial void OnPaymentTypeIDChanged();
    partial void OnValueChanging(decimal value);
    partial void OnValueChanged();
    #endregion
		
		public Payment()
		{
			this._PaymentEmployee = default(EntityRef<PaymentEmployee>);
			this._PaymentType = default(EntityRef<PaymentType>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaymentEmployeeID", DbType="Int NOT NULL")]
		public int PaymentEmployeeID
		{
			get
			{
				return this._PaymentEmployeeID;
			}
			set
			{
				if ((this._PaymentEmployeeID != value))
				{
					if (this._PaymentEmployee.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPaymentEmployeeIDChanging(value);
					this.SendPropertyChanging();
					this._PaymentEmployeeID = value;
					this.SendPropertyChanged("PaymentEmployeeID");
					this.OnPaymentEmployeeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaymentTypeID", DbType="Int NOT NULL")]
		public int PaymentTypeID
		{
			get
			{
				return this._PaymentTypeID;
			}
			set
			{
				if ((this._PaymentTypeID != value))
				{
					if (this._PaymentType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPaymentTypeIDChanging(value);
					this.SendPropertyChanging();
					this._PaymentTypeID = value;
					this.SendPropertyChanged("PaymentTypeID");
					this.OnPaymentTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Value", DbType="Decimal(18,2) NOT NULL")]
		public decimal Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				if ((this._Value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._Value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PaymentEmployee_Payment", Storage="_PaymentEmployee", ThisKey="PaymentEmployeeID", OtherKey="ID", IsForeignKey=true)]
		public PaymentEmployee PaymentEmployee
		{
			get
			{
				return this._PaymentEmployee.Entity;
			}
			set
			{
				PaymentEmployee previousValue = this._PaymentEmployee.Entity;
				if (((previousValue != value) 
							|| (this._PaymentEmployee.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PaymentEmployee.Entity = null;
						previousValue.Payments.Remove(this);
					}
					this._PaymentEmployee.Entity = value;
					if ((value != null))
					{
						value.Payments.Add(this);
						this._PaymentEmployeeID = value.ID;
					}
					else
					{
						this._PaymentEmployeeID = default(int);
					}
					this.SendPropertyChanged("PaymentEmployee");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PaymentType_Payment", Storage="_PaymentType", ThisKey="PaymentTypeID", OtherKey="ID", IsForeignKey=true)]
		public PaymentType PaymentType
		{
			get
			{
				return this._PaymentType.Entity;
			}
			set
			{
				PaymentType previousValue = this._PaymentType.Entity;
				if (((previousValue != value) 
							|| (this._PaymentType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PaymentType.Entity = null;
						previousValue.Payments.Remove(this);
					}
					this._PaymentType.Entity = value;
					if ((value != null))
					{
						value.Payments.Add(this);
						this._PaymentTypeID = value.ID;
					}
					else
					{
						this._PaymentTypeID = default(int);
					}
					this.SendPropertyChanged("PaymentType");
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
