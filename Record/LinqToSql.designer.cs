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

namespace Record
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DocumentManagement")]
	public partial class LinqToSqlDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDocumentTable(DocumentTable instance);
    partial void UpdateDocumentTable(DocumentTable instance);
    partial void DeleteDocumentTable(DocumentTable instance);
    partial void InsertGroupTable(GroupTable instance);
    partial void UpdateGroupTable(GroupTable instance);
    partial void DeleteGroupTable(GroupTable instance);
    partial void InsertUserTable(UserTable instance);
    partial void UpdateUserTable(UserTable instance);
    partial void DeleteUserTable(UserTable instance);
    #endregion
		
		public LinqToSqlDataContext() : 
				base(global::Record.Properties.Settings.Default.DocumentManagementConnectionString3, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSqlDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSqlDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSqlDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSqlDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DocumentTable> DocumentTables
		{
			get
			{
				return this.GetTable<DocumentTable>();
			}
		}
		
		public System.Data.Linq.Table<GroupTable> GroupTables
		{
			get
			{
				return this.GetTable<GroupTable>();
			}
		}
		
		public System.Data.Linq.Table<UserTable> UserTables
		{
			get
			{
				return this.GetTable<UserTable>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DocumentTable")]
	public partial class DocumentTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _doc_id;
		
		private string _doc_type;
		
		private string _scan_id;
		
		private string _filing_path;
		
		private string _file_id;
		
		private string _checkin_time;
		
		private string _checkout_time;
		
		private string _doc_name;
		
		private string _size;
		
		private int _total_share_in_group;
		
		private int _total_share_individual;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Ondoc_idChanging(string value);
    partial void Ondoc_idChanged();
    partial void Ondoc_typeChanging(string value);
    partial void Ondoc_typeChanged();
    partial void Onscan_idChanging(string value);
    partial void Onscan_idChanged();
    partial void Onfiling_pathChanging(string value);
    partial void Onfiling_pathChanged();
    partial void Onfile_idChanging(string value);
    partial void Onfile_idChanged();
    partial void Oncheckin_timeChanging(string value);
    partial void Oncheckin_timeChanged();
    partial void Oncheckout_timeChanging(string value);
    partial void Oncheckout_timeChanged();
    partial void Ondoc_nameChanging(string value);
    partial void Ondoc_nameChanged();
    partial void OnsizeChanging(string value);
    partial void OnsizeChanged();
    partial void Ontotal_share_in_groupChanging(int value);
    partial void Ontotal_share_in_groupChanged();
    partial void Ontotal_share_individualChanging(int value);
    partial void Ontotal_share_individualChanged();
    #endregion
		
		public DocumentTable()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_doc_id", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string doc_id
		{
			get
			{
				return this._doc_id;
			}
			set
			{
				if ((this._doc_id != value))
				{
					this.Ondoc_idChanging(value);
					this.SendPropertyChanging();
					this._doc_id = value;
					this.SendPropertyChanged("doc_id");
					this.Ondoc_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_doc_type", DbType="NVarChar(50)")]
		public string doc_type
		{
			get
			{
				return this._doc_type;
			}
			set
			{
				if ((this._doc_type != value))
				{
					this.Ondoc_typeChanging(value);
					this.SendPropertyChanging();
					this._doc_type = value;
					this.SendPropertyChanged("doc_type");
					this.Ondoc_typeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_scan_id", DbType="NVarChar(50)")]
		public string scan_id
		{
			get
			{
				return this._scan_id;
			}
			set
			{
				if ((this._scan_id != value))
				{
					this.Onscan_idChanging(value);
					this.SendPropertyChanging();
					this._scan_id = value;
					this.SendPropertyChanged("scan_id");
					this.Onscan_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_filing_path", DbType="NVarChar(50)")]
		public string filing_path
		{
			get
			{
				return this._filing_path;
			}
			set
			{
				if ((this._filing_path != value))
				{
					this.Onfiling_pathChanging(value);
					this.SendPropertyChanging();
					this._filing_path = value;
					this.SendPropertyChanged("filing_path");
					this.Onfiling_pathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_file_id", DbType="NVarChar(50)")]
		public string file_id
		{
			get
			{
				return this._file_id;
			}
			set
			{
				if ((this._file_id != value))
				{
					this.Onfile_idChanging(value);
					this.SendPropertyChanging();
					this._file_id = value;
					this.SendPropertyChanged("file_id");
					this.Onfile_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_checkin_time", DbType="NVarChar(50)")]
		public string checkin_time
		{
			get
			{
				return this._checkin_time;
			}
			set
			{
				if ((this._checkin_time != value))
				{
					this.Oncheckin_timeChanging(value);
					this.SendPropertyChanging();
					this._checkin_time = value;
					this.SendPropertyChanged("checkin_time");
					this.Oncheckin_timeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_checkout_time", DbType="NVarChar(50)")]
		public string checkout_time
		{
			get
			{
				return this._checkout_time;
			}
			set
			{
				if ((this._checkout_time != value))
				{
					this.Oncheckout_timeChanging(value);
					this.SendPropertyChanging();
					this._checkout_time = value;
					this.SendPropertyChanged("checkout_time");
					this.Oncheckout_timeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_doc_name", DbType="NVarChar(50)")]
		public string doc_name
		{
			get
			{
				return this._doc_name;
			}
			set
			{
				if ((this._doc_name != value))
				{
					this.Ondoc_nameChanging(value);
					this.SendPropertyChanging();
					this._doc_name = value;
					this.SendPropertyChanged("doc_name");
					this.Ondoc_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_size", DbType="NVarChar(50)")]
		public string size
		{
			get
			{
				return this._size;
			}
			set
			{
				if ((this._size != value))
				{
					this.OnsizeChanging(value);
					this.SendPropertyChanging();
					this._size = value;
					this.SendPropertyChanged("size");
					this.OnsizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_total_share_in_group", DbType="Int NOT NULL")]
		public int total_share_in_group
		{
			get
			{
				return this._total_share_in_group;
			}
			set
			{
				if ((this._total_share_in_group != value))
				{
					this.Ontotal_share_in_groupChanging(value);
					this.SendPropertyChanging();
					this._total_share_in_group = value;
					this.SendPropertyChanged("total_share_in_group");
					this.Ontotal_share_in_groupChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_total_share_individual", DbType="Int NOT NULL")]
		public int total_share_individual
		{
			get
			{
				return this._total_share_individual;
			}
			set
			{
				if ((this._total_share_individual != value))
				{
					this.Ontotal_share_individualChanging(value);
					this.SendPropertyChanging();
					this._total_share_individual = value;
					this.SendPropertyChanged("total_share_individual");
					this.Ontotal_share_individualChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.GroupTable")]
	public partial class GroupTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _group_id;
		
		private string _group_name;
		
		private string _admin_id;
		
		private int _total_member;
		
		private int _total_document;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Ongroup_idChanging(string value);
    partial void Ongroup_idChanged();
    partial void Ongroup_nameChanging(string value);
    partial void Ongroup_nameChanged();
    partial void Onadmin_idChanging(string value);
    partial void Onadmin_idChanged();
    partial void Ontotal_memberChanging(int value);
    partial void Ontotal_memberChanged();
    partial void Ontotal_documentChanging(int value);
    partial void Ontotal_documentChanged();
    #endregion
		
		public GroupTable()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_group_id", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string group_id
		{
			get
			{
				return this._group_id;
			}
			set
			{
				if ((this._group_id != value))
				{
					this.Ongroup_idChanging(value);
					this.SendPropertyChanging();
					this._group_id = value;
					this.SendPropertyChanged("group_id");
					this.Ongroup_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_group_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string group_name
		{
			get
			{
				return this._group_name;
			}
			set
			{
				if ((this._group_name != value))
				{
					this.Ongroup_nameChanging(value);
					this.SendPropertyChanging();
					this._group_name = value;
					this.SendPropertyChanged("group_name");
					this.Ongroup_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_admin_id", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string admin_id
		{
			get
			{
				return this._admin_id;
			}
			set
			{
				if ((this._admin_id != value))
				{
					this.Onadmin_idChanging(value);
					this.SendPropertyChanging();
					this._admin_id = value;
					this.SendPropertyChanged("admin_id");
					this.Onadmin_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_total_member", DbType="Int NOT NULL")]
		public int total_member
		{
			get
			{
				return this._total_member;
			}
			set
			{
				if ((this._total_member != value))
				{
					this.Ontotal_memberChanging(value);
					this.SendPropertyChanging();
					this._total_member = value;
					this.SendPropertyChanged("total_member");
					this.Ontotal_memberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_total_document", DbType="Int NOT NULL")]
		public int total_document
		{
			get
			{
				return this._total_document;
			}
			set
			{
				if ((this._total_document != value))
				{
					this.Ontotal_documentChanging(value);
					this.SendPropertyChanging();
					this._total_document = value;
					this.SendPropertyChanged("total_document");
					this.Ontotal_documentChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserTable")]
	public partial class UserTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _user_id;
		
		private string _user_name;
		
		private int _no_of_document;
		
		private string _password;
		
		private string _department;
		
		private string _email;
		
		private string _user_type;
		
		private string _user_image_path;
		
		private int _no_of_group;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onuser_idChanging(string value);
    partial void Onuser_idChanged();
    partial void Onuser_nameChanging(string value);
    partial void Onuser_nameChanged();
    partial void Onno_of_documentChanging(int value);
    partial void Onno_of_documentChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OndepartmentChanging(string value);
    partial void OndepartmentChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void Onuser_typeChanging(string value);
    partial void Onuser_typeChanged();
    partial void Onuser_image_pathChanging(string value);
    partial void Onuser_image_pathChanged();
    partial void Onno_of_groupChanging(int value);
    partial void Onno_of_groupChanged();
    #endregion
		
		public UserTable()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string user_id
		{
			get
			{
				return this._user_id;
			}
			set
			{
				if ((this._user_id != value))
				{
					this.Onuser_idChanging(value);
					this.SendPropertyChanging();
					this._user_id = value;
					this.SendPropertyChanged("user_id");
					this.Onuser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string user_name
		{
			get
			{
				return this._user_name;
			}
			set
			{
				if ((this._user_name != value))
				{
					this.Onuser_nameChanging(value);
					this.SendPropertyChanging();
					this._user_name = value;
					this.SendPropertyChanged("user_name");
					this.Onuser_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_no_of_document", DbType="Int NOT NULL")]
		public int no_of_document
		{
			get
			{
				return this._no_of_document;
			}
			set
			{
				if ((this._no_of_document != value))
				{
					this.Onno_of_documentChanging(value);
					this.SendPropertyChanging();
					this._no_of_document = value;
					this.SendPropertyChanged("no_of_document");
					this.Onno_of_documentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_department", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string department
		{
			get
			{
				return this._department;
			}
			set
			{
				if ((this._department != value))
				{
					this.OndepartmentChanging(value);
					this.SendPropertyChanging();
					this._department = value;
					this.SendPropertyChanged("department");
					this.OndepartmentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_type", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string user_type
		{
			get
			{
				return this._user_type;
			}
			set
			{
				if ((this._user_type != value))
				{
					this.Onuser_typeChanging(value);
					this.SendPropertyChanging();
					this._user_type = value;
					this.SendPropertyChanged("user_type");
					this.Onuser_typeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_image_path", DbType="NVarChar(50)")]
		public string user_image_path
		{
			get
			{
				return this._user_image_path;
			}
			set
			{
				if ((this._user_image_path != value))
				{
					this.Onuser_image_pathChanging(value);
					this.SendPropertyChanging();
					this._user_image_path = value;
					this.SendPropertyChanged("user_image_path");
					this.Onuser_image_pathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_no_of_group", DbType="Int NOT NULL")]
		public int no_of_group
		{
			get
			{
				return this._no_of_group;
			}
			set
			{
				if ((this._no_of_group != value))
				{
					this.Onno_of_groupChanging(value);
					this.SendPropertyChanging();
					this._no_of_group = value;
					this.SendPropertyChanged("no_of_group");
					this.Onno_of_groupChanged();
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
