﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/linq2db).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace LinqToDB.LINQPad
{
	public partial class ConnectionViewModel : INotifyPropertyChanged
	{
		#region Name : string

		private string _name;
		public  string  Name
		{
			get { return _name; }
			set
			{
				if (_name != value)
				{
					BeforeNameChanged(value);
					_name = value;
					AfterNameChanged();

					OnNameChanged();
				}
			}
		}

		#region INotifyPropertyChanged support

		partial void BeforeNameChanged(string newValue);
		partial void AfterNameChanged ();

		public const string NameOfName = "Name";

		private static readonly PropertyChangedEventArgs _nameChangedEventArgs = new PropertyChangedEventArgs(NameOfName);

		private void OnNameChanged()
		{
			OnPropertyChanged(_nameChangedEventArgs);
		}

		#endregion

		#endregion

		#region SelectedProvider : ProviderInfo

		private ProviderInfo _selectedProvider;
		public  ProviderInfo  SelectedProvider
		{
			get { return _selectedProvider; }
			set
			{
				if (_selectedProvider != value)
				{
					BeforeSelectedProviderChanged(value);
					_selectedProvider = value;
					AfterSelectedProviderChanged();

					OnSelectedProviderChanged();
				}
			}
		}

		#region INotifyPropertyChanged support

		partial void BeforeSelectedProviderChanged(ProviderInfo newValue);
		partial void AfterSelectedProviderChanged ();

		public const string NameOfSelectedProvider = "SelectedProvider";

		private static readonly PropertyChangedEventArgs _selectedProviderChangedEventArgs = new PropertyChangedEventArgs(NameOfSelectedProvider);

		private void OnSelectedProviderChanged()
		{
			OnPropertyChanged(_selectedProviderChangedEventArgs);
		}

		#endregion

		#endregion

		#region ConnectionString : string

		private string _connectionString;
		public  string  ConnectionString
		{
			get { return _connectionString; }
			set
			{
				if (_connectionString != value)
				{
					BeforeConnectionStringChanged(value);
					_connectionString = value;
					AfterConnectionStringChanged();

					OnConnectionStringChanged();
				}
			}
		}

		#region INotifyPropertyChanged support

		partial void BeforeConnectionStringChanged(string newValue);
		partial void AfterConnectionStringChanged ();

		public const string NameOfConnectionString = "ConnectionString";

		private static readonly PropertyChangedEventArgs _connectionStringChangedEventArgs = new PropertyChangedEventArgs(NameOfConnectionString);

		private void OnConnectionStringChanged()
		{
			OnPropertyChanged(_connectionStringChangedEventArgs);
		}

		#endregion

		#endregion

		#region CommandTimeout : int

		private int _commandTimeout;
		public  int  CommandTimeout
		{
			get { return _commandTimeout; }
			set
			{
				if (_commandTimeout != value)
				{
					BeforeCommandTimeoutChanged(value);
					_commandTimeout = value;
					AfterCommandTimeoutChanged();

					OnCommandTimeoutChanged();
				}
			}
		}

		#region INotifyPropertyChanged support

		partial void BeforeCommandTimeoutChanged(int newValue);
		partial void AfterCommandTimeoutChanged ();

		public const string NameOfCommandTimeout = "CommandTimeout";

		private static readonly PropertyChangedEventArgs _commandTimeoutChangedEventArgs = new PropertyChangedEventArgs(NameOfCommandTimeout);

		private void OnCommandTimeoutChanged()
		{
			OnPropertyChanged(_commandTimeoutChangedEventArgs);
		}

		#endregion

		#endregion

		#region Persist : bool

		private bool _persist;
		public  bool  Persist
		{
			get { return _persist; }
			set
			{
				if (_persist != value)
				{
					BeforePersistChanged(value);
					_persist = value;
					AfterPersistChanged();

					OnPersistChanged();
				}
			}
		}

		#region INotifyPropertyChanged support

		partial void BeforePersistChanged(bool newValue);
		partial void AfterPersistChanged ();

		public const string NameOfPersist = "Persist";

		private static readonly PropertyChangedEventArgs _persistChangedEventArgs = new PropertyChangedEventArgs(NameOfPersist);

		private void OnPersistChanged()
		{
			OnPropertyChanged(_persistChangedEventArgs);
		}

		#endregion

		#endregion

		#region IsProduction : bool

		private bool _isProduction;
		public  bool  IsProduction
		{
			get { return _isProduction; }
			set
			{
				if (_isProduction != value)
				{
					BeforeIsProductionChanged(value);
					_isProduction = value;
					AfterIsProductionChanged();

					OnIsProductionChanged();
				}
			}
		}

		#region INotifyPropertyChanged support

		partial void BeforeIsProductionChanged(bool newValue);
		partial void AfterIsProductionChanged ();

		public const string NameOfIsProduction = "IsProduction";

		private static readonly PropertyChangedEventArgs _isProductionChangedEventArgs = new PropertyChangedEventArgs(NameOfIsProduction);

		private void OnIsProductionChanged()
		{
			OnPropertyChanged(_isProductionChangedEventArgs);
		}

		#endregion

		#endregion

		#region Pluralize : bool

		private bool _pluralize;
		public  bool  Pluralize
		{
			get { return _pluralize; }
			set
			{
				if (_pluralize != value)
				{
					BeforePluralizeChanged(value);
					_pluralize = value;
					AfterPluralizeChanged();

					OnPluralizeChanged();
				}
			}
		}

		#region INotifyPropertyChanged support

		partial void BeforePluralizeChanged(bool newValue);
		partial void AfterPluralizeChanged ();

		public const string NameOfPluralize = "Pluralize";

		private static readonly PropertyChangedEventArgs _pluralizeChangedEventArgs = new PropertyChangedEventArgs(NameOfPluralize);

		private void OnPluralizeChanged()
		{
			OnPropertyChanged(_pluralizeChangedEventArgs);
		}

		#endregion

		#endregion

		#region Capitalize : bool

		private bool _capitalize;
		public  bool  Capitalize
		{
			get { return _capitalize; }
			set
			{
				if (_capitalize != value)
				{
					BeforeCapitalizeChanged(value);
					_capitalize = value;
					AfterCapitalizeChanged();

					OnCapitalizeChanged();
				}
			}
		}

		#region INotifyPropertyChanged support

		partial void BeforeCapitalizeChanged(bool newValue);
		partial void AfterCapitalizeChanged ();

		public const string NameOfCapitalize = "Capitalize";

		private static readonly PropertyChangedEventArgs _capitalizeChangedEventArgs = new PropertyChangedEventArgs(NameOfCapitalize);

		private void OnCapitalizeChanged()
		{
			OnPropertyChanged(_capitalizeChangedEventArgs);
		}

		#endregion

		#endregion

		#region IncludeRoutines : bool

		private bool _includeRoutines;
		public  bool  IncludeRoutines
		{
			get { return _includeRoutines; }
			set
			{
				if (_includeRoutines != value)
				{
					BeforeIncludeRoutinesChanged(value);
					_includeRoutines = value;
					AfterIncludeRoutinesChanged();

					OnIncludeRoutinesChanged();
				}
			}
		}

		#region INotifyPropertyChanged support

		partial void BeforeIncludeRoutinesChanged(bool newValue);
		partial void AfterIncludeRoutinesChanged ();

		public const string NameOfIncludeRoutines = "IncludeRoutines";

		private static readonly PropertyChangedEventArgs _includeRoutinesChangedEventArgs = new PropertyChangedEventArgs(NameOfIncludeRoutines);

		private void OnIncludeRoutinesChanged()
		{
			OnPropertyChanged(_includeRoutinesChangedEventArgs);
		}

		#endregion

		#endregion

		#region EncryptConnectionString : bool

		private bool _encryptConnectionString;
		public  bool  EncryptConnectionString
		{
			get { return _encryptConnectionString; }
			set
			{
				if (_encryptConnectionString != value)
				{
					BeforeEncryptConnectionStringChanged(value);
					_encryptConnectionString = value;
					AfterEncryptConnectionStringChanged();

					OnEncryptConnectionStringChanged();
				}
			}
		}

		#region INotifyPropertyChanged support

		partial void BeforeEncryptConnectionStringChanged(bool newValue);
		partial void AfterEncryptConnectionStringChanged ();

		public const string NameOfEncryptConnectionString = "EncryptConnectionString";

		private static readonly PropertyChangedEventArgs _encryptConnectionStringChangedEventArgs = new PropertyChangedEventArgs(NameOfEncryptConnectionString);

		private void OnEncryptConnectionStringChanged()
		{
			OnPropertyChanged(_encryptConnectionStringChangedEventArgs);
		}

		#endregion

		#endregion

		#region UseCustomFormatter : bool

		private bool _useCustomFormatter;
		public  bool  UseCustomFormatter
		{
			get { return _useCustomFormatter; }
			set
			{
				if (_useCustomFormatter != value)
				{
					BeforeUseCustomFormatterChanged(value);
					_useCustomFormatter = value;
					AfterUseCustomFormatterChanged();

					OnUseCustomFormatterChanged();
				}
			}
		}

		#region INotifyPropertyChanged support

		partial void BeforeUseCustomFormatterChanged(bool newValue);
		partial void AfterUseCustomFormatterChanged ();

		public const string NameOfUseCustomFormatter = "UseCustomFormatter";

		private static readonly PropertyChangedEventArgs _useCustomFormatterChangedEventArgs = new PropertyChangedEventArgs(NameOfUseCustomFormatter);

		private void OnUseCustomFormatterChanged()
		{
			OnPropertyChanged(_useCustomFormatterChangedEventArgs);
		}

		#endregion

		#endregion

		#region UseProviderSpecificTypes : bool

		private bool _useProviderSpecificTypes;
		public  bool  UseProviderSpecificTypes
		{
			get { return _useProviderSpecificTypes; }
			set
			{
				if (_useProviderSpecificTypes != value)
				{
					BeforeUseProviderSpecificTypesChanged(value);
					_useProviderSpecificTypes = value;
					AfterUseProviderSpecificTypesChanged();

					OnUseProviderSpecificTypesChanged();
				}
			}
		}

		#region INotifyPropertyChanged support

		partial void BeforeUseProviderSpecificTypesChanged(bool newValue);
		partial void AfterUseProviderSpecificTypesChanged ();

		public const string NameOfUseProviderSpecificTypes = "UseProviderSpecificTypes";

		private static readonly PropertyChangedEventArgs _useProviderSpecificTypesChangedEventArgs = new PropertyChangedEventArgs(NameOfUseProviderSpecificTypes);

		private void OnUseProviderSpecificTypesChanged()
		{
			OnPropertyChanged(_useProviderSpecificTypesChangedEventArgs);
		}

		#endregion

		#endregion

		#region AllowMultipleQuery : bool

		private bool _allowMultipleQuery;
		public  bool  AllowMultipleQuery
		{
			get { return _allowMultipleQuery; }
			set
			{
				if (_allowMultipleQuery != value)
				{
					BeforeAllowMultipleQueryChanged(value);
					_allowMultipleQuery = value;
					AfterAllowMultipleQueryChanged();

					OnAllowMultipleQueryChanged();
				}
			}
		}

		#region INotifyPropertyChanged support

		partial void BeforeAllowMultipleQueryChanged(bool newValue);
		partial void AfterAllowMultipleQueryChanged ();

		public const string NameOfAllowMultipleQuery = "AllowMultipleQuery";

		private static readonly PropertyChangedEventArgs _allowMultipleQueryChangedEventArgs = new PropertyChangedEventArgs(NameOfAllowMultipleQuery);

		private void OnAllowMultipleQueryChanged()
		{
			OnPropertyChanged(_allowMultipleQueryChangedEventArgs);
		}

		#endregion

		#endregion

		#region OptimizeJoins : bool

		private bool _optimizeJoins;
		public  bool  OptimizeJoins
		{
			get { return _optimizeJoins; }
			set
			{
				if (_optimizeJoins != value)
				{
					BeforeOptimizeJoinsChanged(value);
					_optimizeJoins = value;
					AfterOptimizeJoinsChanged();

					OnOptimizeJoinsChanged();
				}
			}
		}

		#region INotifyPropertyChanged support

		partial void BeforeOptimizeJoinsChanged(bool newValue);
		partial void AfterOptimizeJoinsChanged ();

		public const string NameOfOptimizeJoins = "OptimizeJoins";

		private static readonly PropertyChangedEventArgs _optimizeJoinsChangedEventArgs = new PropertyChangedEventArgs(NameOfOptimizeJoins);

		private void OnOptimizeJoinsChanged()
		{
			OnPropertyChanged(_optimizeJoinsChangedEventArgs);
		}

		#endregion

		#endregion

		#region IncludeSchemas : string

		private string _includeSchemas;
		public  string  IncludeSchemas
		{
			get { return _includeSchemas; }
			set
			{
				if (_includeSchemas != value)
				{
					BeforeIncludeSchemasChanged(value);
					_includeSchemas = value;
					AfterIncludeSchemasChanged();

					OnIncludeSchemasChanged();
				}
			}
		}

		#region INotifyPropertyChanged support

		partial void BeforeIncludeSchemasChanged(string newValue);
		partial void AfterIncludeSchemasChanged ();

		public const string NameOfIncludeSchemas = "IncludeSchemas";

		private static readonly PropertyChangedEventArgs _includeSchemasChangedEventArgs = new PropertyChangedEventArgs(NameOfIncludeSchemas);

		private void OnIncludeSchemasChanged()
		{
			OnPropertyChanged(_includeSchemasChangedEventArgs);
		}

		#endregion

		#endregion

		#region ExcludeSchemas : string

		private string _excludeSchemas;
		public  string  ExcludeSchemas
		{
			get { return _excludeSchemas; }
			set
			{
				if (_excludeSchemas != value)
				{
					BeforeExcludeSchemasChanged(value);
					_excludeSchemas = value;
					AfterExcludeSchemasChanged();

					OnExcludeSchemasChanged();
				}
			}
		}

		#region INotifyPropertyChanged support

		partial void BeforeExcludeSchemasChanged(string newValue);
		partial void AfterExcludeSchemasChanged ();

		public const string NameOfExcludeSchemas = "ExcludeSchemas";

		private static readonly PropertyChangedEventArgs _excludeSchemasChangedEventArgs = new PropertyChangedEventArgs(NameOfExcludeSchemas);

		private void OnExcludeSchemasChanged()
		{
			OnPropertyChanged(_excludeSchemasChangedEventArgs);
		}

		#endregion

		#endregion

		#region IncludeCatalogs : string

		private string _includeCatalogs;
		public  string  IncludeCatalogs
		{
			get { return _includeCatalogs; }
			set
			{
				if (_includeCatalogs != value)
				{
					BeforeIncludeCatalogsChanged(value);
					_includeCatalogs = value;
					AfterIncludeCatalogsChanged();

					OnIncludeCatalogsChanged();
				}
			}
		}

		#region INotifyPropertyChanged support

		partial void BeforeIncludeCatalogsChanged(string newValue);
		partial void AfterIncludeCatalogsChanged ();

		public const string NameOfIncludeCatalogs = "IncludeCatalogs";

		private static readonly PropertyChangedEventArgs _includeCatalogsChangedEventArgs = new PropertyChangedEventArgs(NameOfIncludeCatalogs);

		private void OnIncludeCatalogsChanged()
		{
			OnPropertyChanged(_includeCatalogsChangedEventArgs);
		}

		#endregion

		#endregion

		#region ExcludeCatalogs : string

		private string _excludeCatalogs;
		public  string  ExcludeCatalogs
		{
			get { return _excludeCatalogs; }
			set
			{
				if (_excludeCatalogs != value)
				{
					BeforeExcludeCatalogsChanged(value);
					_excludeCatalogs = value;
					AfterExcludeCatalogsChanged();

					OnExcludeCatalogsChanged();
				}
			}
		}

		#region INotifyPropertyChanged support

		partial void BeforeExcludeCatalogsChanged(string newValue);
		partial void AfterExcludeCatalogsChanged ();

		public const string NameOfExcludeCatalogs = "ExcludeCatalogs";

		private static readonly PropertyChangedEventArgs _excludeCatalogsChangedEventArgs = new PropertyChangedEventArgs(NameOfExcludeCatalogs);

		private void OnExcludeCatalogsChanged()
		{
			OnPropertyChanged(_excludeCatalogsChangedEventArgs);
		}

		#endregion

		#endregion

		#region CustomAssemblyPath : string

		private string _customAssemblyPath;
		public  string  CustomAssemblyPath
		{
			get { return _customAssemblyPath; }
			set
			{
				if (_customAssemblyPath != value)
				{
					BeforeCustomAssemblyPathChanged(value);
					_customAssemblyPath = value;
					AfterCustomAssemblyPathChanged();

					OnCustomAssemblyPathChanged();
				}
			}
		}

		#region INotifyPropertyChanged support

		partial void BeforeCustomAssemblyPathChanged(string newValue);
		partial void AfterCustomAssemblyPathChanged ();

		public const string NameOfCustomAssemblyPath = "CustomAssemblyPath";

		private static readonly PropertyChangedEventArgs _customAssemblyPathChangedEventArgs = new PropertyChangedEventArgs(NameOfCustomAssemblyPath);

		private void OnCustomAssemblyPathChanged()
		{
			OnPropertyChanged(_customAssemblyPathChangedEventArgs);
		}

		#endregion

		#endregion

		#region CustomTypeName : string

		private string _customTypeName;
		public  string  CustomTypeName
		{
			get { return _customTypeName; }
			set
			{
				if (_customTypeName != value)
				{
					BeforeCustomTypeNameChanged(value);
					_customTypeName = value;
					AfterCustomTypeNameChanged();

					OnCustomTypeNameChanged();
				}
			}
		}

		#region INotifyPropertyChanged support

		partial void BeforeCustomTypeNameChanged(string newValue);
		partial void AfterCustomTypeNameChanged ();

		public const string NameOfCustomTypeName = "CustomTypeName";

		private static readonly PropertyChangedEventArgs _customTypeNameChangedEventArgs = new PropertyChangedEventArgs(NameOfCustomTypeName);

		private void OnCustomTypeNameChanged()
		{
			OnPropertyChanged(_customTypeNameChangedEventArgs);
		}

		#endregion

		#endregion

		#region AppConfigPath : string

		private string _appConfigPath;
		public  string  AppConfigPath
		{
			get { return _appConfigPath; }
			set
			{
				if (_appConfigPath != value)
				{
					BeforeAppConfigPathChanged(value);
					_appConfigPath = value;
					AfterAppConfigPathChanged();

					OnAppConfigPathChanged();
				}
			}
		}

		#region INotifyPropertyChanged support

		partial void BeforeAppConfigPathChanged(string newValue);
		partial void AfterAppConfigPathChanged ();

		public const string NameOfAppConfigPath = "AppConfigPath";

		private static readonly PropertyChangedEventArgs _appConfigPathChangedEventArgs = new PropertyChangedEventArgs(NameOfAppConfigPath);

		private void OnAppConfigPathChanged()
		{
			OnPropertyChanged(_appConfigPathChangedEventArgs);
		}

		#endregion

		#endregion

		#region CustomConfiguration : string

		private string _customConfiguration;
		public  string  CustomConfiguration
		{
			get { return _customConfiguration; }
			set
			{
				if (_customConfiguration != value)
				{
					BeforeCustomConfigurationChanged(value);
					_customConfiguration = value;
					AfterCustomConfigurationChanged();

					OnCustomConfigurationChanged();
				}
			}
		}

		#region INotifyPropertyChanged support

		partial void BeforeCustomConfigurationChanged(string newValue);
		partial void AfterCustomConfigurationChanged ();

		public const string NameOfCustomConfiguration = "CustomConfiguration";

		private static readonly PropertyChangedEventArgs _customConfigurationChangedEventArgs = new PropertyChangedEventArgs(NameOfCustomConfiguration);

		private void OnCustomConfigurationChanged()
		{
			OnPropertyChanged(_customConfigurationChangedEventArgs);
		}

		#endregion

		#endregion

		#region IsDynamic : bool

		private bool _isDynamic;
		public  bool  IsDynamic
		{
			get { return _isDynamic; }
			set
			{
				if (_isDynamic != value)
				{
					BeforeIsDynamicChanged(value);
					_isDynamic = value;
					AfterIsDynamicChanged();

					OnIsDynamicChanged();
					OnDynamicVisibilityChanged();
					OnStaticVisibilityChanged();
				}
			}
		}

		#region INotifyPropertyChanged support

		partial void BeforeIsDynamicChanged(bool newValue);
		partial void AfterIsDynamicChanged ();

		public const string NameOfIsDynamic = "IsDynamic";

		private static readonly PropertyChangedEventArgs _isDynamicChangedEventArgs = new PropertyChangedEventArgs(NameOfIsDynamic);

		private void OnIsDynamicChanged()
		{
			OnPropertyChanged(_isDynamicChangedEventArgs);
		}

		#endregion

		#endregion

		#region DynamicVisibility : Visibility

		public Visibility DynamicVisibility
		{
			get { return IsDynamic ? Visibility.Visible : Visibility.Collapsed; }
		}

		#region INotifyPropertyChanged support

		public const string NameOfDynamicVisibility = "DynamicVisibility";

		private static readonly PropertyChangedEventArgs _dynamicVisibilityChangedEventArgs = new PropertyChangedEventArgs(NameOfDynamicVisibility);

		private void OnDynamicVisibilityChanged()
		{
			OnPropertyChanged(_dynamicVisibilityChangedEventArgs);
		}

		#endregion

		#endregion

		#region StaticVisibility : Visibility

		public Visibility StaticVisibility
		{
			get { return !IsDynamic ? Visibility.Visible : Visibility.Collapsed; }
		}

		#region INotifyPropertyChanged support

		public const string NameOfStaticVisibility = "StaticVisibility";

		private static readonly PropertyChangedEventArgs _staticVisibilityChangedEventArgs = new PropertyChangedEventArgs(NameOfStaticVisibility);

		private void OnStaticVisibilityChanged()
		{
			OnPropertyChanged(_staticVisibilityChangedEventArgs);
		}

		#endregion

		#endregion

		#region Providers : ObservableCollection<ProviderInfo>

		private ObservableCollection<ProviderInfo> _providers;
		public  ObservableCollection<ProviderInfo>  Providers
		{
			get { return _providers; }
			set
			{
				if (_providers != value)
				{
					BeforeProvidersChanged(value);
					_providers = value;
					AfterProvidersChanged();

					OnProvidersChanged();
				}
			}
		}

		#region INotifyPropertyChanged support

		partial void BeforeProvidersChanged(ObservableCollection<ProviderInfo> newValue);
		partial void AfterProvidersChanged ();

		public const string NameOfProviders = "Providers";

		private static readonly PropertyChangedEventArgs _providersChangedEventArgs = new PropertyChangedEventArgs(NameOfProviders);

		private void OnProvidersChanged()
		{
			OnPropertyChanged(_providersChangedEventArgs);
		}

		#endregion

		#endregion

		#region INotifyPropertyChanged support

#if !SILVERLIGHT
		[field : NonSerialized]
#endif
		public virtual event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string propertyName)
		{
			var propertyChanged = PropertyChanged;

			if (propertyChanged != null)
			{
#if SILVERLIGHT
				if (System.Windows.Deployment.Current.Dispatcher.CheckAccess())
					propertyChanged(this, new PropertyChangedEventArgs(propertyName));
				else
					System.Windows.Deployment.Current.Dispatcher.BeginInvoke(
						() =>
						{
							var pc = PropertyChanged;
							if (pc != null)
								pc(this, new PropertyChangedEventArgs(propertyName));
						});
#else
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
#endif
			}
		}

		protected void OnPropertyChanged(PropertyChangedEventArgs arg)
		{
			var propertyChanged = PropertyChanged;

			if (propertyChanged != null)
			{
#if SILVERLIGHT
				if (System.Windows.Deployment.Current.Dispatcher.CheckAccess())
					propertyChanged(this, arg);
				else
					System.Windows.Deployment.Current.Dispatcher.BeginInvoke(
						() =>
						{
							var pc = PropertyChanged;
							if (pc != null)
								pc(this, arg);
						});
#else
				propertyChanged(this, arg);
#endif
			}
		}

		#endregion
	}
}
