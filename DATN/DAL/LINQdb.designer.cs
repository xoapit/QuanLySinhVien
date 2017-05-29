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

namespace DATN.DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dbDoAnTotNghiep")]
	public partial class LINQdbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDoAnTotNghiep(DoAnTotNghiep instance);
    partial void UpdateDoAnTotNghiep(DoAnTotNghiep instance);
    partial void DeleteDoAnTotNghiep(DoAnTotNghiep instance);
    partial void InsertGVHD(GVHD instance);
    partial void UpdateGVHD(GVHD instance);
    partial void DeleteGVHD(GVHD instance);
    partial void InsertHuongNghienCuu(HuongNghienCuu instance);
    partial void UpdateHuongNghienCuu(HuongNghienCuu instance);
    partial void DeleteHuongNghienCuu(HuongNghienCuu instance);
    #endregion
		
		public LINQdbDataContext() : 
				base(global::DATN.Properties.Settings.Default.dbDoAnTotNghiepConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LINQdbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQdbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQdbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQdbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DoAnTotNghiep> DoAnTotNghieps
		{
			get
			{
				return this.GetTable<DoAnTotNghiep>();
			}
		}
		
		public System.Data.Linq.Table<GVHD> GVHDs
		{
			get
			{
				return this.GetTable<GVHD>();
			}
		}
		
		public System.Data.Linq.Table<HuongNghienCuu> HuongNghienCuus
		{
			get
			{
				return this.GetTable<HuongNghienCuu>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.addDATN")]
		public int addDATN([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(10)")] string mada, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string tenda, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string sinhvienth, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> tinhtrang, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> nambaove, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(10)")] string mahuongNC)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), mada, tenda, sinhvienth, tinhtrang, nambaove, mahuongNC);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.deleteDATN")]
		public int deleteDATN([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(10)")] string mada)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), mada);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DoAnTotNghiep")]
	public partial class DoAnTotNghiep : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaDoAn;
		
		private string _TenDoAn;
		
		private string _TenSinhVienTH;
		
		private System.Nullable<int> _NamThucHien;
		
		private System.Nullable<bool> _TinhTrang;
		
		private string _MaHuongNC;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDoAnChanging(string value);
    partial void OnMaDoAnChanged();
    partial void OnTenDoAnChanging(string value);
    partial void OnTenDoAnChanged();
    partial void OnTenSinhVienTHChanging(string value);
    partial void OnTenSinhVienTHChanged();
    partial void OnNamThucHienChanging(System.Nullable<int> value);
    partial void OnNamThucHienChanged();
    partial void OnTinhTrangChanging(System.Nullable<bool> value);
    partial void OnTinhTrangChanged();
    partial void OnMaHuongNCChanging(string value);
    partial void OnMaHuongNCChanged();
    #endregion
		
		public DoAnTotNghiep()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDoAn", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaDoAn
		{
			get
			{
				return this._MaDoAn;
			}
			set
			{
				if ((this._MaDoAn != value))
				{
					this.OnMaDoAnChanging(value);
					this.SendPropertyChanging();
					this._MaDoAn = value;
					this.SendPropertyChanged("MaDoAn");
					this.OnMaDoAnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDoAn", DbType="NVarChar(50)")]
		public string TenDoAn
		{
			get
			{
				return this._TenDoAn;
			}
			set
			{
				if ((this._TenDoAn != value))
				{
					this.OnTenDoAnChanging(value);
					this.SendPropertyChanging();
					this._TenDoAn = value;
					this.SendPropertyChanged("TenDoAn");
					this.OnTenDoAnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSinhVienTH", DbType="NVarChar(50)")]
		public string TenSinhVienTH
		{
			get
			{
				return this._TenSinhVienTH;
			}
			set
			{
				if ((this._TenSinhVienTH != value))
				{
					this.OnTenSinhVienTHChanging(value);
					this.SendPropertyChanging();
					this._TenSinhVienTH = value;
					this.SendPropertyChanged("TenSinhVienTH");
					this.OnTenSinhVienTHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NamThucHien", DbType="Int")]
		public System.Nullable<int> NamThucHien
		{
			get
			{
				return this._NamThucHien;
			}
			set
			{
				if ((this._NamThucHien != value))
				{
					this.OnNamThucHienChanging(value);
					this.SendPropertyChanging();
					this._NamThucHien = value;
					this.SendPropertyChanged("NamThucHien");
					this.OnNamThucHienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinhTrang", DbType="Bit")]
		public System.Nullable<bool> TinhTrang
		{
			get
			{
				return this._TinhTrang;
			}
			set
			{
				if ((this._TinhTrang != value))
				{
					this.OnTinhTrangChanging(value);
					this.SendPropertyChanging();
					this._TinhTrang = value;
					this.SendPropertyChanged("TinhTrang");
					this.OnTinhTrangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHuongNC", DbType="NVarChar(10)")]
		public string MaHuongNC
		{
			get
			{
				return this._MaHuongNC;
			}
			set
			{
				if ((this._MaHuongNC != value))
				{
					this.OnMaHuongNCChanging(value);
					this.SendPropertyChanging();
					this._MaHuongNC = value;
					this.SendPropertyChanged("MaHuongNC");
					this.OnMaHuongNCChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.GVHD")]
	public partial class GVHD : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaGiangVien;
		
		private string _TenGiangVien;
		
		private string _MaHuongNC;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaGiangVienChanging(string value);
    partial void OnMaGiangVienChanged();
    partial void OnTenGiangVienChanging(string value);
    partial void OnTenGiangVienChanged();
    partial void OnMaHuongNCChanging(string value);
    partial void OnMaHuongNCChanged();
    #endregion
		
		public GVHD()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaGiangVien", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaGiangVien
		{
			get
			{
				return this._MaGiangVien;
			}
			set
			{
				if ((this._MaGiangVien != value))
				{
					this.OnMaGiangVienChanging(value);
					this.SendPropertyChanging();
					this._MaGiangVien = value;
					this.SendPropertyChanged("MaGiangVien");
					this.OnMaGiangVienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenGiangVien", DbType="NVarChar(50)")]
		public string TenGiangVien
		{
			get
			{
				return this._TenGiangVien;
			}
			set
			{
				if ((this._TenGiangVien != value))
				{
					this.OnTenGiangVienChanging(value);
					this.SendPropertyChanging();
					this._TenGiangVien = value;
					this.SendPropertyChanged("TenGiangVien");
					this.OnTenGiangVienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHuongNC", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaHuongNC
		{
			get
			{
				return this._MaHuongNC;
			}
			set
			{
				if ((this._MaHuongNC != value))
				{
					this.OnMaHuongNCChanging(value);
					this.SendPropertyChanging();
					this._MaHuongNC = value;
					this.SendPropertyChanged("MaHuongNC");
					this.OnMaHuongNCChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HuongNghienCuu")]
	public partial class HuongNghienCuu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaHuongNC;
		
		private string _TenHuongNC;
		
		private string _MaGiangVien;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHuongNCChanging(string value);
    partial void OnMaHuongNCChanged();
    partial void OnTenHuongNCChanging(string value);
    partial void OnTenHuongNCChanged();
    partial void OnMaGiangVienChanging(string value);
    partial void OnMaGiangVienChanged();
    #endregion
		
		public HuongNghienCuu()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHuongNC", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaHuongNC
		{
			get
			{
				return this._MaHuongNC;
			}
			set
			{
				if ((this._MaHuongNC != value))
				{
					this.OnMaHuongNCChanging(value);
					this.SendPropertyChanging();
					this._MaHuongNC = value;
					this.SendPropertyChanged("MaHuongNC");
					this.OnMaHuongNCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenHuongNC", DbType="NVarChar(50)")]
		public string TenHuongNC
		{
			get
			{
				return this._TenHuongNC;
			}
			set
			{
				if ((this._TenHuongNC != value))
				{
					this.OnTenHuongNCChanging(value);
					this.SendPropertyChanging();
					this._TenHuongNC = value;
					this.SendPropertyChanged("TenHuongNC");
					this.OnTenHuongNCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaGiangVien", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaGiangVien
		{
			get
			{
				return this._MaGiangVien;
			}
			set
			{
				if ((this._MaGiangVien != value))
				{
					this.OnMaGiangVienChanging(value);
					this.SendPropertyChanging();
					this._MaGiangVien = value;
					this.SendPropertyChanged("MaGiangVien");
					this.OnMaGiangVienChanged();
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
