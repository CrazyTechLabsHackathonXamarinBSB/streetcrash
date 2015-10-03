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

namespace StreetCrash.DAO.LinqToSql
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="streetcrash_db")]
	public partial class StreetCrashDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSTATUS(STATUS instance);
    partial void UpdateSTATUS(STATUS instance);
    partial void DeleteSTATUS(STATUS instance);
    partial void InsertOCORRENCIA(OCORRENCIA instance);
    partial void UpdateOCORRENCIA(OCORRENCIA instance);
    partial void DeleteOCORRENCIA(OCORRENCIA instance);
    partial void InsertIMAGEM(IMAGEM instance);
    partial void UpdateIMAGEM(IMAGEM instance);
    partial void DeleteIMAGEM(IMAGEM instance);
    partial void InsertCOMENTARIO(COMENTARIO instance);
    partial void UpdateCOMENTARIO(COMENTARIO instance);
    partial void DeleteCOMENTARIO(COMENTARIO instance);
    #endregion
		
		public StreetCrashDataContext() : 
				base(global::StreetCrash.DAO.Properties.Settings.Default.streetcrash_dbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public StreetCrashDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StreetCrashDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StreetCrashDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StreetCrashDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<STATUS> STATUS
		{
			get
			{
				return this.GetTable<STATUS>();
			}
		}
		
		public System.Data.Linq.Table<OCORRENCIA> OCORRENCIAs
		{
			get
			{
				return this.GetTable<OCORRENCIA>();
			}
		}
		
		public System.Data.Linq.Table<IMAGEM> IMAGEMs
		{
			get
			{
				return this.GetTable<IMAGEM>();
			}
		}
		
		public System.Data.Linq.Table<COMENTARIO> COMENTARIOs
		{
			get
			{
				return this.GetTable<COMENTARIO>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.STATUS")]
	public partial class STATUS : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CODE;
		
		private string _DESCRICAO;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCODEChanging(int value);
    partial void OnCODEChanged();
    partial void OnDESCRICAOChanging(string value);
    partial void OnDESCRICAOChanged();
    #endregion
		
		public STATUS()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODE", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CODE
		{
			get
			{
				return this._CODE;
			}
			set
			{
				if ((this._CODE != value))
				{
					this.OnCODEChanging(value);
					this.SendPropertyChanging();
					this._CODE = value;
					this.SendPropertyChanged("CODE");
					this.OnCODEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DESCRICAO", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string DESCRICAO
		{
			get
			{
				return this._DESCRICAO;
			}
			set
			{
				if ((this._DESCRICAO != value))
				{
					this.OnDESCRICAOChanging(value);
					this.SendPropertyChanging();
					this._DESCRICAO = value;
					this.SendPropertyChanged("DESCRICAO");
					this.OnDESCRICAOChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OCORRENCIA")]
	public partial class OCORRENCIA : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CODE;
		
		private System.Nullable<decimal> _LATITUDE;
		
		private System.Nullable<decimal> _LONGITUDE;
		
		private string _ENDERECO;
		
		private System.Nullable<System.DateTime> _DATA_CADASTRO;
		
		private long _CODE_CATEGORIA;
		
		private string _OUTRO;
		
		private System.Nullable<short> _STATUS;
		
		private bool _RESOLVIDO;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCODEChanging(int value);
    partial void OnCODEChanged();
    partial void OnLATITUDEChanging(System.Nullable<decimal> value);
    partial void OnLATITUDEChanged();
    partial void OnLONGITUDEChanging(System.Nullable<decimal> value);
    partial void OnLONGITUDEChanged();
    partial void OnENDERECOChanging(string value);
    partial void OnENDERECOChanged();
    partial void OnDATA_CADASTROChanging(System.Nullable<System.DateTime> value);
    partial void OnDATA_CADASTROChanged();
    partial void OnCODE_CATEGORIAChanging(long value);
    partial void OnCODE_CATEGORIAChanged();
    partial void OnOUTROChanging(string value);
    partial void OnOUTROChanged();
    partial void OnSTATUSChanging(System.Nullable<short> value);
    partial void OnSTATUSChanged();
    partial void OnRESOLVIDOChanging(bool value);
    partial void OnRESOLVIDOChanged();
    #endregion
		
		public OCORRENCIA()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODE", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CODE
		{
			get
			{
				return this._CODE;
			}
			set
			{
				if ((this._CODE != value))
				{
					this.OnCODEChanging(value);
					this.SendPropertyChanging();
					this._CODE = value;
					this.SendPropertyChanged("CODE");
					this.OnCODEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LATITUDE", DbType="Decimal(15,15)")]
		public System.Nullable<decimal> LATITUDE
		{
			get
			{
				return this._LATITUDE;
			}
			set
			{
				if ((this._LATITUDE != value))
				{
					this.OnLATITUDEChanging(value);
					this.SendPropertyChanging();
					this._LATITUDE = value;
					this.SendPropertyChanged("LATITUDE");
					this.OnLATITUDEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LONGITUDE", DbType="Decimal(15,15)")]
		public System.Nullable<decimal> LONGITUDE
		{
			get
			{
				return this._LONGITUDE;
			}
			set
			{
				if ((this._LONGITUDE != value))
				{
					this.OnLONGITUDEChanging(value);
					this.SendPropertyChanging();
					this._LONGITUDE = value;
					this.SendPropertyChanged("LONGITUDE");
					this.OnLONGITUDEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ENDERECO", DbType="NVarChar(MAX)")]
		public string ENDERECO
		{
			get
			{
				return this._ENDERECO;
			}
			set
			{
				if ((this._ENDERECO != value))
				{
					this.OnENDERECOChanging(value);
					this.SendPropertyChanging();
					this._ENDERECO = value;
					this.SendPropertyChanged("ENDERECO");
					this.OnENDERECOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DATA_CADASTRO", DbType="Date")]
		public System.Nullable<System.DateTime> DATA_CADASTRO
		{
			get
			{
				return this._DATA_CADASTRO;
			}
			set
			{
				if ((this._DATA_CADASTRO != value))
				{
					this.OnDATA_CADASTROChanging(value);
					this.SendPropertyChanging();
					this._DATA_CADASTRO = value;
					this.SendPropertyChanged("DATA_CADASTRO");
					this.OnDATA_CADASTROChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODE_CATEGORIA", DbType="BigInt NOT NULL")]
		public long CODE_CATEGORIA
		{
			get
			{
				return this._CODE_CATEGORIA;
			}
			set
			{
				if ((this._CODE_CATEGORIA != value))
				{
					this.OnCODE_CATEGORIAChanging(value);
					this.SendPropertyChanging();
					this._CODE_CATEGORIA = value;
					this.SendPropertyChanged("CODE_CATEGORIA");
					this.OnCODE_CATEGORIAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OUTRO", DbType="NVarChar(MAX)")]
		public string OUTRO
		{
			get
			{
				return this._OUTRO;
			}
			set
			{
				if ((this._OUTRO != value))
				{
					this.OnOUTROChanging(value);
					this.SendPropertyChanging();
					this._OUTRO = value;
					this.SendPropertyChanged("OUTRO");
					this.OnOUTROChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STATUS", DbType="SmallInt")]
		public System.Nullable<short> STATUS
		{
			get
			{
				return this._STATUS;
			}
			set
			{
				if ((this._STATUS != value))
				{
					this.OnSTATUSChanging(value);
					this.SendPropertyChanging();
					this._STATUS = value;
					this.SendPropertyChanged("STATUS");
					this.OnSTATUSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RESOLVIDO", DbType="Bit NOT NULL")]
		public bool RESOLVIDO
		{
			get
			{
				return this._RESOLVIDO;
			}
			set
			{
				if ((this._RESOLVIDO != value))
				{
					this.OnRESOLVIDOChanging(value);
					this.SendPropertyChanging();
					this._RESOLVIDO = value;
					this.SendPropertyChanged("RESOLVIDO");
					this.OnRESOLVIDOChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.IMAGEM")]
	public partial class IMAGEM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CODE;
		
		private long _CODE_OCORRENCIA;
		
		private System.Data.Linq.Binary _IMAGEM1;
		
		private string _DESCRICAO;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCODEChanging(int value);
    partial void OnCODEChanged();
    partial void OnCODE_OCORRENCIAChanging(long value);
    partial void OnCODE_OCORRENCIAChanged();
    partial void OnIMAGEM1Changing(System.Data.Linq.Binary value);
    partial void OnIMAGEM1Changed();
    partial void OnDESCRICAOChanging(string value);
    partial void OnDESCRICAOChanged();
    #endregion
		
		public IMAGEM()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODE", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CODE
		{
			get
			{
				return this._CODE;
			}
			set
			{
				if ((this._CODE != value))
				{
					this.OnCODEChanging(value);
					this.SendPropertyChanging();
					this._CODE = value;
					this.SendPropertyChanged("CODE");
					this.OnCODEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODE_OCORRENCIA", DbType="BigInt NOT NULL")]
		public long CODE_OCORRENCIA
		{
			get
			{
				return this._CODE_OCORRENCIA;
			}
			set
			{
				if ((this._CODE_OCORRENCIA != value))
				{
					this.OnCODE_OCORRENCIAChanging(value);
					this.SendPropertyChanging();
					this._CODE_OCORRENCIA = value;
					this.SendPropertyChanged("CODE_OCORRENCIA");
					this.OnCODE_OCORRENCIAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="IMAGEM", Storage="_IMAGEM1", DbType="Image NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary IMAGEM1
		{
			get
			{
				return this._IMAGEM1;
			}
			set
			{
				if ((this._IMAGEM1 != value))
				{
					this.OnIMAGEM1Changing(value);
					this.SendPropertyChanging();
					this._IMAGEM1 = value;
					this.SendPropertyChanged("IMAGEM1");
					this.OnIMAGEM1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DESCRICAO", DbType="NVarChar(100)")]
		public string DESCRICAO
		{
			get
			{
				return this._DESCRICAO;
			}
			set
			{
				if ((this._DESCRICAO != value))
				{
					this.OnDESCRICAOChanging(value);
					this.SendPropertyChanging();
					this._DESCRICAO = value;
					this.SendPropertyChanged("DESCRICAO");
					this.OnDESCRICAOChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.COMENTARIOS")]
	public partial class COMENTARIO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CODE;
		
		private long _CODE_OCORRENCIA;
		
		private string _DESCRICAO;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCODEChanging(int value);
    partial void OnCODEChanged();
    partial void OnCODE_OCORRENCIAChanging(long value);
    partial void OnCODE_OCORRENCIAChanged();
    partial void OnDESCRICAOChanging(string value);
    partial void OnDESCRICAOChanged();
    #endregion
		
		public COMENTARIO()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODE", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CODE
		{
			get
			{
				return this._CODE;
			}
			set
			{
				if ((this._CODE != value))
				{
					this.OnCODEChanging(value);
					this.SendPropertyChanging();
					this._CODE = value;
					this.SendPropertyChanged("CODE");
					this.OnCODEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODE_OCORRENCIA", DbType="BigInt NOT NULL")]
		public long CODE_OCORRENCIA
		{
			get
			{
				return this._CODE_OCORRENCIA;
			}
			set
			{
				if ((this._CODE_OCORRENCIA != value))
				{
					this.OnCODE_OCORRENCIAChanging(value);
					this.SendPropertyChanging();
					this._CODE_OCORRENCIA = value;
					this.SendPropertyChanged("CODE_OCORRENCIA");
					this.OnCODE_OCORRENCIAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DESCRICAO", DbType="NVarChar(200)")]
		public string DESCRICAO
		{
			get
			{
				return this._DESCRICAO;
			}
			set
			{
				if ((this._DESCRICAO != value))
				{
					this.OnDESCRICAOChanging(value);
					this.SendPropertyChanging();
					this._DESCRICAO = value;
					this.SendPropertyChanged("DESCRICAO");
					this.OnDESCRICAOChanged();
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
