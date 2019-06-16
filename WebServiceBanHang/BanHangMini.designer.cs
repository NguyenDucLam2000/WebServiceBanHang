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

namespace WebServiceBanHang
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BanHangMini")]
	public partial class BanHangMiniDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertLoaiSanPham(LoaiSanPham instance);
    partial void UpdateLoaiSanPham(LoaiSanPham instance);
    partial void DeleteLoaiSanPham(LoaiSanPham instance);
    partial void InsertSanPham(SanPham instance);
    partial void UpdateSanPham(SanPham instance);
    partial void DeleteSanPham(SanPham instance);
    #endregion
		
		public BanHangMiniDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["BanHangMiniConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BanHangMiniDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BanHangMiniDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BanHangMiniDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BanHangMiniDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<LoaiSanPham> LoaiSanPhams
		{
			get
			{
				return this.GetTable<LoaiSanPham>();
			}
		}
		
		public System.Data.Linq.Table<SanPham> SanPhams
		{
			get
			{
				return this.GetTable<SanPham>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LoaiSanPham")]
	public partial class LoaiSanPham : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaLoaiSanPham;
		
		private string _TenLoaiSanPham;
		
		private System.Data.Linq.Binary _HinhLoaiSanPham;
		
		private string _LinkHinhLoaiSanPham;
		
		private EntitySet<SanPham> _SanPhams;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaLoaiSanPhamChanging(int value);
    partial void OnMaLoaiSanPhamChanged();
    partial void OnTenLoaiSanPhamChanging(string value);
    partial void OnTenLoaiSanPhamChanged();
    partial void OnHinhLoaiSanPhamChanging(System.Data.Linq.Binary value);
    partial void OnHinhLoaiSanPhamChanged();
    partial void OnLinkHinhLoaiSanPhamChanging(string value);
    partial void OnLinkHinhLoaiSanPhamChanged();
    #endregion
		
		public LoaiSanPham()
		{
			this._SanPhams = new EntitySet<SanPham>(new Action<SanPham>(this.attach_SanPhams), new Action<SanPham>(this.detach_SanPhams));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLoaiSanPham", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaLoaiSanPham
		{
			get
			{
				return this._MaLoaiSanPham;
			}
			set
			{
				if ((this._MaLoaiSanPham != value))
				{
					this.OnMaLoaiSanPhamChanging(value);
					this.SendPropertyChanging();
					this._MaLoaiSanPham = value;
					this.SendPropertyChanged("MaLoaiSanPham");
					this.OnMaLoaiSanPhamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenLoaiSanPham", DbType="NVarChar(50)")]
		public string TenLoaiSanPham
		{
			get
			{
				return this._TenLoaiSanPham;
			}
			set
			{
				if ((this._TenLoaiSanPham != value))
				{
					this.OnTenLoaiSanPhamChanging(value);
					this.SendPropertyChanging();
					this._TenLoaiSanPham = value;
					this.SendPropertyChanged("TenLoaiSanPham");
					this.OnTenLoaiSanPhamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HinhLoaiSanPham", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary HinhLoaiSanPham
		{
			get
			{
				return this._HinhLoaiSanPham;
			}
			set
			{
				if ((this._HinhLoaiSanPham != value))
				{
					this.OnHinhLoaiSanPhamChanging(value);
					this.SendPropertyChanging();
					this._HinhLoaiSanPham = value;
					this.SendPropertyChanged("HinhLoaiSanPham");
					this.OnHinhLoaiSanPhamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LinkHinhLoaiSanPham", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string LinkHinhLoaiSanPham
		{
			get
			{
				return this._LinkHinhLoaiSanPham;
			}
			set
			{
				if ((this._LinkHinhLoaiSanPham != value))
				{
					this.OnLinkHinhLoaiSanPhamChanging(value);
					this.SendPropertyChanging();
					this._LinkHinhLoaiSanPham = value;
					this.SendPropertyChanged("LinkHinhLoaiSanPham");
					this.OnLinkHinhLoaiSanPhamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiSanPham_SanPham", Storage="_SanPhams", ThisKey="MaLoaiSanPham", OtherKey="MaLoaiSanPham")]
		public EntitySet<SanPham> SanPhams
		{
			get
			{
				return this._SanPhams;
			}
			set
			{
				this._SanPhams.Assign(value);
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
		
		private void attach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.LoaiSanPham = this;
		}
		
		private void detach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.LoaiSanPham = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SanPham")]
	public partial class SanPham : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaSanPham;
		
		private string _TenSanPham;
		
		private System.Nullable<int> _GiaSanPham;
		
		private System.Data.Linq.Binary _HinhSanPham;
		
		private string _MoTa;
		
		private System.Nullable<int> _MaLoaiSanPham;
		
		private string _LinkHinhSanPham;
		
		private EntityRef<LoaiSanPham> _LoaiSanPham;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSanPhamChanging(int value);
    partial void OnMaSanPhamChanged();
    partial void OnTenSanPhamChanging(string value);
    partial void OnTenSanPhamChanged();
    partial void OnGiaSanPhamChanging(System.Nullable<int> value);
    partial void OnGiaSanPhamChanged();
    partial void OnHinhSanPhamChanging(System.Data.Linq.Binary value);
    partial void OnHinhSanPhamChanged();
    partial void OnMoTaChanging(string value);
    partial void OnMoTaChanged();
    partial void OnMaLoaiSanPhamChanging(System.Nullable<int> value);
    partial void OnMaLoaiSanPhamChanged();
    partial void OnLinkHinhSanPhamChanging(string value);
    partial void OnLinkHinhSanPhamChanged();
    #endregion
		
		public SanPham()
		{
			this._LoaiSanPham = default(EntityRef<LoaiSanPham>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSanPham", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaSanPham
		{
			get
			{
				return this._MaSanPham;
			}
			set
			{
				if ((this._MaSanPham != value))
				{
					this.OnMaSanPhamChanging(value);
					this.SendPropertyChanging();
					this._MaSanPham = value;
					this.SendPropertyChanged("MaSanPham");
					this.OnMaSanPhamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSanPham", DbType="NVarChar(50)")]
		public string TenSanPham
		{
			get
			{
				return this._TenSanPham;
			}
			set
			{
				if ((this._TenSanPham != value))
				{
					this.OnTenSanPhamChanging(value);
					this.SendPropertyChanging();
					this._TenSanPham = value;
					this.SendPropertyChanged("TenSanPham");
					this.OnTenSanPhamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaSanPham", DbType="Int")]
		public System.Nullable<int> GiaSanPham
		{
			get
			{
				return this._GiaSanPham;
			}
			set
			{
				if ((this._GiaSanPham != value))
				{
					this.OnGiaSanPhamChanging(value);
					this.SendPropertyChanging();
					this._GiaSanPham = value;
					this.SendPropertyChanged("GiaSanPham");
					this.OnGiaSanPhamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HinhSanPham", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary HinhSanPham
		{
			get
			{
				return this._HinhSanPham;
			}
			set
			{
				if ((this._HinhSanPham != value))
				{
					this.OnHinhSanPhamChanging(value);
					this.SendPropertyChanging();
					this._HinhSanPham = value;
					this.SendPropertyChanged("HinhSanPham");
					this.OnHinhSanPhamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MoTa", DbType="NVarChar(50)")]
		public string MoTa
		{
			get
			{
				return this._MoTa;
			}
			set
			{
				if ((this._MoTa != value))
				{
					this.OnMoTaChanging(value);
					this.SendPropertyChanging();
					this._MoTa = value;
					this.SendPropertyChanged("MoTa");
					this.OnMoTaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLoaiSanPham", DbType="Int")]
		public System.Nullable<int> MaLoaiSanPham
		{
			get
			{
				return this._MaLoaiSanPham;
			}
			set
			{
				if ((this._MaLoaiSanPham != value))
				{
					if (this._LoaiSanPham.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaLoaiSanPhamChanging(value);
					this.SendPropertyChanging();
					this._MaLoaiSanPham = value;
					this.SendPropertyChanged("MaLoaiSanPham");
					this.OnMaLoaiSanPhamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LinkHinhSanPham", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string LinkHinhSanPham
		{
			get
			{
				return this._LinkHinhSanPham;
			}
			set
			{
				if ((this._LinkHinhSanPham != value))
				{
					this.OnLinkHinhSanPhamChanging(value);
					this.SendPropertyChanging();
					this._LinkHinhSanPham = value;
					this.SendPropertyChanged("LinkHinhSanPham");
					this.OnLinkHinhSanPhamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiSanPham_SanPham", Storage="_LoaiSanPham", ThisKey="MaLoaiSanPham", OtherKey="MaLoaiSanPham", IsForeignKey=true)]
		public LoaiSanPham LoaiSanPham
		{
			get
			{
				return this._LoaiSanPham.Entity;
			}
			set
			{
				LoaiSanPham previousValue = this._LoaiSanPham.Entity;
				if (((previousValue != value) 
							|| (this._LoaiSanPham.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LoaiSanPham.Entity = null;
						previousValue.SanPhams.Remove(this);
					}
					this._LoaiSanPham.Entity = value;
					if ((value != null))
					{
						value.SanPhams.Add(this);
						this._MaLoaiSanPham = value.MaLoaiSanPham;
					}
					else
					{
						this._MaLoaiSanPham = default(Nullable<int>);
					}
					this.SendPropertyChanged("LoaiSanPham");
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