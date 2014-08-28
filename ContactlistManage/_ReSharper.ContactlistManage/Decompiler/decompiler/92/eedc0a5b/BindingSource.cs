// Type: System.Windows.Forms.BindingSource
// Assembly: System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Windows.Forms.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Globalization;
using System.Reflection;
using System.Runtime;
using System.Text;

namespace System.Windows.Forms
{
  [SRDescription("DescriptionBindingSource")]
  [Designer("System.Windows.Forms.Design.BindingSourceDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [DefaultProperty("DataSource")]
  [DefaultEvent("CurrentChanged")]
  [ComplexBindingProperties("DataSource", "DataMember")]
  public class BindingSource : Component, IBindingListView, IBindingList, IList, ICollection, IEnumerable, ITypedList, ICancelAddNew, ISupportInitializeNotification, ISupportInitialize, ICurrencyManagerProvider
  {
    private static readonly object EVENT_ADDINGNEW = new object();
    private static readonly object EVENT_BINDINGCOMPLETE = new object();
    private static readonly object EVENT_CURRENTCHANGED = new object();
    private static readonly object EVENT_CURRENTITEMCHANGED = new object();
    private static readonly object EVENT_DATAERROR = new object();
    private static readonly object EVENT_DATAMEMBERCHANGED = new object();
    private static readonly object EVENT_DATASOURCECHANGED = new object();
    private static readonly object EVENT_LISTCHANGED = new object();
    private static readonly object EVENT_POSITIONCHANGED = new object();
    private static readonly object EVENT_INITIALIZED = new object();
    private string dataMember = string.Empty;
    private bool raiseListChangedEvents = true;
    private bool allowNewSetValue = true;
    private int addNewPos = -1;
    private object dataSource;
    private string sort;
    private string filter;
    private CurrencyManager currencyManager;
    private bool parentsCurrentItemChanging;
    private bool disposedOrFinalized;
    private IList _innerList;
    private bool isBindingList;
    private bool listRaisesItemChangedEvents;
    private bool listExtractedFromEnumerable;
    private System.Type itemType;
    private ConstructorInfo itemConstructor;
    private PropertyDescriptorCollection itemShape;
    private Dictionary<string, BindingSource> relatedBindingSources;
    private bool allowNewIsSet;
    private object currentItemHookedForItemChange;
    private object lastCurrentItem;
    private EventHandler listItemPropertyChangedHandler;
    private bool initializing;
    private bool needToSetList;
    private bool recursionDetectionFlag;
    private bool innerListChanging;
    private bool endingEdit;

    [Browsable(false)]
    public virtual CurrencyManager CurrencyManager
    {
      get
      {
        return this.GetRelatedCurrencyManager((string) null);
      }
    }

    [Browsable(false)]
    public object Current
    {
      get
      {
        if (this.currencyManager.Count <= 0)
          return (object) null;
        else
          return this.currencyManager.Current;
      }
    }

    [RefreshProperties(RefreshProperties.Repaint)]
    [Editor("System.Windows.Forms.Design.DataMemberListEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof (UITypeEditor))]
    [SRCategory("CatData")]
    [DefaultValue("")]
    [SRDescription("BindingSourceDataMemberDescr")]
    public string DataMember
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.dataMember;
      }
      set
      {
        if (value == null)
          value = string.Empty;
        if (this.dataMember.Equals(value))
          return;
        this.dataMember = value;
        this.ResetList();
        this.OnDataMemberChanged(EventArgs.Empty);
      }
    }

    [SRCategory("CatData")]
    [SRDescription("BindingSourceDataSourceDescr")]
    [DefaultValue(null)]
    [RefreshProperties(RefreshProperties.Repaint)]
    [AttributeProvider(typeof (IListSource))]
    public object DataSource
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.dataSource;
      }
      set
      {
        if (this.dataSource == value)
          return;
        this.ThrowIfBindingSourceRecursionDetected(value);
        this.UnwireDataSource();
        this.dataSource = value;
        this.ClearInvalidDataMember();
        this.ResetList();
        this.WireDataSource();
        this.OnDataSourceChanged(EventArgs.Empty);
      }
    }

    private string InnerListFilter
    {
      get
      {
        IBindingListView bindingListView = this.List as IBindingListView;
        if (bindingListView != null && bindingListView.SupportsFiltering)
          return bindingListView.Filter;
        else
          return string.Empty;
      }
      set
      {
        if (this.initializing || this.DesignMode || string.Equals(value, this.InnerListFilter, StringComparison.Ordinal))
          return;
        IBindingListView bindingListView = this.List as IBindingListView;
        if (bindingListView == null || !bindingListView.SupportsFiltering)
          return;
        bindingListView.Filter = value;
      }
    }

    private string InnerListSort
    {
      get
      {
        ListSortDescriptionCollection sortsColln = (ListSortDescriptionCollection) null;
        IBindingListView bindingListView = this.List as IBindingListView;
        IBindingList bindingList = this.List as IBindingList;
        if (bindingListView != null && bindingListView.SupportsAdvancedSorting)
          sortsColln = bindingListView.SortDescriptions;
        else if (bindingList != null && bindingList.SupportsSorting && bindingList.IsSorted)
          sortsColln = new ListSortDescriptionCollection(new ListSortDescription[1]
          {
            new ListSortDescription(bindingList.SortProperty, bindingList.SortDirection)
          });
        return BindingSource.BuildSortString(sortsColln);
      }
      set
      {
        if (this.initializing || this.DesignMode || string.Compare(value, this.InnerListSort, false, CultureInfo.InvariantCulture) == 0)
          return;
        ListSortDescriptionCollection sorts = this.ParseSortString(value);
        IBindingListView bindingListView = this.List as IBindingListView;
        IBindingList bindingList = this.List as IBindingList;
        if (bindingListView != null && bindingListView.SupportsAdvancedSorting)
        {
          if (sorts.Count == 0)
            bindingListView.RemoveSort();
          else
            bindingListView.ApplySort(sorts);
        }
        else
        {
          if (bindingList == null || !bindingList.SupportsSorting)
            return;
          if (sorts.Count == 0)
          {
            bindingList.RemoveSort();
          }
          else
          {
            if (sorts.Count != 1)
              return;
            bindingList.ApplySort(sorts[0].PropertyDescriptor, sorts[0].SortDirection);
          }
        }
      }
    }

    [Browsable(false)]
    public bool IsBindingSuspended
    {
      get
      {
        return this.currencyManager.IsBindingSuspended;
      }
    }

    [Browsable(false)]
    public IList List
    {
      get
      {
        this.EnsureInnerList();
        return this._innerList;
      }
    }

    [Browsable(false)]
    [DefaultValue(-1)]
    public int Position
    {
      get
      {
        return this.currencyManager.Position;
      }
      set
      {
        if (this.currencyManager.Position == value)
          return;
        this.currencyManager.Position = value;
      }
    }

    [DefaultValue(true)]
    [Browsable(false)]
    public bool RaiseListChangedEvents
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.raiseListChangedEvents;
      }
      set
      {
        if (this.raiseListChangedEvents == value)
          return;
        this.raiseListChangedEvents = value;
      }
    }

    [SRCategory("CatData")]
    [SRDescription("BindingSourceSortDescr")]
    [DefaultValue(null)]
    public string Sort
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.sort;
      }
      set
      {
        this.sort = value;
        this.InnerListSort = value;
      }
    }

    bool ISupportInitializeNotification.IsInitialized
    {
      get
      {
        return !this.initializing;
      }
    }

    [Browsable(false)]
    public virtual int Count
    {
      get
      {
        try
        {
          if (this.disposedOrFinalized)
            return 0;
          if (this.recursionDetectionFlag)
            throw new InvalidOperationException(System.Windows.Forms.SR.GetString("BindingSourceRecursionDetected"));
          this.recursionDetectionFlag = true;
          return this.List.Count;
        }
        finally
        {
          this.recursionDetectionFlag = false;
        }
      }
    }

    [Browsable(false)]
    public virtual bool IsSynchronized
    {
      get
      {
        return this.List.IsSynchronized;
      }
    }

    [Browsable(false)]
    public virtual object SyncRoot
    {
      get
      {
        return this.List.SyncRoot;
      }
    }

    [Browsable(false)]
    public virtual object this[int index]
    {
      get
      {
        return this.List[index];
      }
      set
      {
        this.List[index] = value;
        if (this.isBindingList)
          return;
        this.OnSimpleListChanged(ListChangedType.ItemChanged, index);
      }
    }

    [Browsable(false)]
    public virtual bool IsFixedSize
    {
      get
      {
        return this.List.IsFixedSize;
      }
    }

    [Browsable(false)]
    public virtual bool IsReadOnly
    {
      get
      {
        return this.List.IsReadOnly;
      }
    }

    [Browsable(false)]
    public virtual bool AllowEdit
    {
      get
      {
        if (this.isBindingList)
          return ((IBindingList) this.List).AllowEdit;
        else
          return !this.List.IsReadOnly;
      }
    }

    [SRCategory("CatBehavior")]
    [SRDescription("BindingSourceAllowNewDescr")]
    public virtual bool AllowNew
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.AllowNewInternal(true);
      }
      set
      {
        if (this.allowNewIsSet && value == this.allowNewSetValue)
          return;
        if (value && !this.isBindingList && !this.IsListWriteable(false))
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("NoAllowNewOnReadOnlyList"));
        this.allowNewIsSet = true;
        this.allowNewSetValue = value;
        this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
      }
    }

    [Browsable(false)]
    public virtual bool AllowRemove
    {
      get
      {
        if (this.isBindingList)
          return ((IBindingList) this.List).AllowRemove;
        if (!this.List.IsReadOnly)
          return !this.List.IsFixedSize;
        else
          return false;
      }
    }

    [Browsable(false)]
    public virtual bool SupportsChangeNotification
    {
      get
      {
        return true;
      }
    }

    [Browsable(false)]
    public virtual bool SupportsSearching
    {
      get
      {
        if (this.isBindingList)
          return ((IBindingList) this.List).SupportsSearching;
        else
          return false;
      }
    }

    [Browsable(false)]
    public virtual bool SupportsSorting
    {
      get
      {
        if (this.isBindingList)
          return ((IBindingList) this.List).SupportsSorting;
        else
          return false;
      }
    }

    [Browsable(false)]
    public virtual bool IsSorted
    {
      get
      {
        if (this.isBindingList)
          return ((IBindingList) this.List).IsSorted;
        else
          return false;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    public virtual PropertyDescriptor SortProperty
    {
      get
      {
        if (this.isBindingList)
          return ((IBindingList) this.List).SortProperty;
        else
          return (PropertyDescriptor) null;
      }
    }

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual ListSortDirection SortDirection
    {
      get
      {
        if (this.isBindingList)
          return ((IBindingList) this.List).SortDirection;
        else
          return ListSortDirection.Ascending;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    public virtual ListSortDescriptionCollection SortDescriptions
    {
      get
      {
        IBindingListView bindingListView = this.List as IBindingListView;
        if (bindingListView != null)
          return bindingListView.SortDescriptions;
        else
          return (ListSortDescriptionCollection) null;
      }
    }

    [SRCategory("CatData")]
    [SRDescription("BindingSourceFilterDescr")]
    [DefaultValue(null)]
    public virtual string Filter
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.filter;
      }
      set
      {
        this.filter = value;
        this.InnerListFilter = value;
      }
    }

    [Browsable(false)]
    public virtual bool SupportsAdvancedSorting
    {
      get
      {
        IBindingListView bindingListView = this.List as IBindingListView;
        if (bindingListView != null)
          return bindingListView.SupportsAdvancedSorting;
        else
          return false;
      }
    }

    [Browsable(false)]
    public virtual bool SupportsFiltering
    {
      get
      {
        IBindingListView bindingListView = this.List as IBindingListView;
        if (bindingListView != null)
          return bindingListView.SupportsFiltering;
        else
          return false;
      }
    }

    [SRCategory("CatData")]
    [SRDescription("BindingSourceAddingNewEventHandlerDescr")]
    public event AddingNewEventHandler AddingNew
    {
      add
      {
        this.Events.AddHandler(BindingSource.EVENT_ADDINGNEW, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(BindingSource.EVENT_ADDINGNEW, (Delegate) value);
      }
    }

    [SRDescription("BindingSourceBindingCompleteEventHandlerDescr")]
    [SRCategory("CatData")]
    public event BindingCompleteEventHandler BindingComplete
    {
      add
      {
        this.Events.AddHandler(BindingSource.EVENT_BINDINGCOMPLETE, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(BindingSource.EVENT_BINDINGCOMPLETE, (Delegate) value);
      }
    }

    [SRDescription("BindingSourceDataErrorEventHandlerDescr")]
    [SRCategory("CatData")]
    public event BindingManagerDataErrorEventHandler DataError
    {
      add
      {
        this.Events.AddHandler(BindingSource.EVENT_DATAERROR, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(BindingSource.EVENT_DATAERROR, (Delegate) value);
      }
    }

    [SRCategory("CatData")]
    [SRDescription("BindingSourceDataSourceChangedEventHandlerDescr")]
    public event EventHandler DataSourceChanged
    {
      add
      {
        this.Events.AddHandler(BindingSource.EVENT_DATASOURCECHANGED, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(BindingSource.EVENT_DATASOURCECHANGED, (Delegate) value);
      }
    }

    [SRCategory("CatData")]
    [SRDescription("BindingSourceDataMemberChangedEventHandlerDescr")]
    public event EventHandler DataMemberChanged
    {
      add
      {
        this.Events.AddHandler(BindingSource.EVENT_DATAMEMBERCHANGED, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(BindingSource.EVENT_DATAMEMBERCHANGED, (Delegate) value);
      }
    }

    [SRDescription("BindingSourceCurrentChangedEventHandlerDescr")]
    [SRCategory("CatData")]
    public event EventHandler CurrentChanged
    {
      add
      {
        this.Events.AddHandler(BindingSource.EVENT_CURRENTCHANGED, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(BindingSource.EVENT_CURRENTCHANGED, (Delegate) value);
      }
    }

    [SRDescription("BindingSourceCurrentItemChangedEventHandlerDescr")]
    [SRCategory("CatData")]
    public event EventHandler CurrentItemChanged
    {
      add
      {
        this.Events.AddHandler(BindingSource.EVENT_CURRENTITEMCHANGED, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(BindingSource.EVENT_CURRENTITEMCHANGED, (Delegate) value);
      }
    }

    [SRCategory("CatData")]
    [SRDescription("BindingSourceListChangedEventHandlerDescr")]
    public event ListChangedEventHandler ListChanged
    {
      add
      {
        this.Events.AddHandler(BindingSource.EVENT_LISTCHANGED, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(BindingSource.EVENT_LISTCHANGED, (Delegate) value);
      }
    }

    [SRCategory("CatData")]
    [SRDescription("BindingSourcePositionChangedEventHandlerDescr")]
    public event EventHandler PositionChanged
    {
      add
      {
        this.Events.AddHandler(BindingSource.EVENT_POSITIONCHANGED, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(BindingSource.EVENT_POSITIONCHANGED, (Delegate) value);
      }
    }

    event EventHandler ISupportInitializeNotification.Initialized
    {
      add
      {
        this.Events.AddHandler(BindingSource.EVENT_INITIALIZED, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(BindingSource.EVENT_INITIALIZED, (Delegate) value);
      }
    }

    static BindingSource()
    {
    }

    public BindingSource()
      : this((object) null, string.Empty)
    {
    }

    public BindingSource(object dataSource, string dataMember)
    {
      this.dataSource = dataSource;
      this.dataMember = dataMember;
      this._innerList = (IList) new ArrayList();
      this.currencyManager = new CurrencyManager((object) this);
      this.WireCurrencyManager(this.currencyManager);
      this.listItemPropertyChangedHandler = new EventHandler(this.ListItem_PropertyChanged);
      this.ResetList();
      this.WireDataSource();
    }

    public BindingSource(IContainer container)
      : this()
    {
      if (container == null)
        throw new ArgumentNullException("container");
      container.Add((IComponent) this);
    }

    private bool AllowNewInternal(bool checkconstructor)
    {
      if (this.disposedOrFinalized)
        return false;
      if (this.allowNewIsSet)
        return this.allowNewSetValue;
      if (this.listExtractedFromEnumerable)
        return false;
      if (this.isBindingList)
        return ((IBindingList) this.List).AllowNew;
      else
        return this.IsListWriteable(checkconstructor);
    }

    public virtual CurrencyManager GetRelatedCurrencyManager(string dataMember)
    {
      this.EnsureInnerList();
      if (string.IsNullOrEmpty(dataMember))
        return this.currencyManager;
      if (dataMember.IndexOf(".") != -1)
        return (CurrencyManager) null;
      else
        return this.GetRelatedBindingSource(dataMember).CurrencyManager;
    }

    public void CancelEdit()
    {
      this.currencyManager.CancelCurrentEdit();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        this.UnwireDataSource();
        this.UnwireInnerList();
        this.UnhookItemChangedEventsForOldCurrent();
        this.UnwireCurrencyManager(this.currencyManager);
        this.dataSource = (object) null;
        this.sort = (string) null;
        this.dataMember = (string) null;
        this._innerList = (IList) null;
        this.isBindingList = false;
        this.needToSetList = true;
        this.raiseListChangedEvents = false;
      }
      this.disposedOrFinalized = true;
      base.Dispose(disposing);
    }

    public void EndEdit()
    {
      if (this.endingEdit)
        return;
      try
      {
        this.endingEdit = true;
        this.currencyManager.EndCurrentEdit();
      }
      finally
      {
        this.endingEdit = false;
      }
    }

    public int Find(string propertyName, object key)
    {
      PropertyDescriptor property = this.itemShape == null ? (PropertyDescriptor) null : this.itemShape.Find(propertyName, true);
      if (property != null)
        return this.Find(property, key);
      throw new ArgumentException(System.Windows.Forms.SR.GetString("DataSourceDataMemberPropNotFound", new object[1]
      {
        (object) propertyName
      }));
    }

    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public void MoveFirst()
    {
      this.Position = 0;
    }

    public void MoveLast()
    {
      this.Position = this.Count - 1;
    }

    public void MoveNext()
    {
      ++this.Position;
    }

    public void MovePrevious()
    {
      --this.Position;
    }

    protected virtual void OnAddingNew(AddingNewEventArgs e)
    {
      AddingNewEventHandler addingNewEventHandler = (AddingNewEventHandler) this.Events[BindingSource.EVENT_ADDINGNEW];
      if (addingNewEventHandler == null)
        return;
      addingNewEventHandler((object) this, e);
    }

    protected virtual void OnBindingComplete(BindingCompleteEventArgs e)
    {
      BindingCompleteEventHandler completeEventHandler = (BindingCompleteEventHandler) this.Events[BindingSource.EVENT_BINDINGCOMPLETE];
      if (completeEventHandler == null)
        return;
      completeEventHandler((object) this, e);
    }

    protected virtual void OnCurrentChanged(EventArgs e)
    {
      this.UnhookItemChangedEventsForOldCurrent();
      this.HookItemChangedEventsForNewCurrent();
      EventHandler eventHandler = (EventHandler) this.Events[BindingSource.EVENT_CURRENTCHANGED];
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    protected virtual void OnCurrentItemChanged(EventArgs e)
    {
      EventHandler eventHandler = (EventHandler) this.Events[BindingSource.EVENT_CURRENTITEMCHANGED];
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    protected virtual void OnDataError(BindingManagerDataErrorEventArgs e)
    {
      BindingManagerDataErrorEventHandler errorEventHandler = this.Events[BindingSource.EVENT_DATAERROR] as BindingManagerDataErrorEventHandler;
      if (errorEventHandler == null)
        return;
      errorEventHandler((object) this, e);
    }

    protected virtual void OnDataMemberChanged(EventArgs e)
    {
      EventHandler eventHandler = this.Events[BindingSource.EVENT_DATAMEMBERCHANGED] as EventHandler;
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    protected virtual void OnDataSourceChanged(EventArgs e)
    {
      EventHandler eventHandler = this.Events[BindingSource.EVENT_DATASOURCECHANGED] as EventHandler;
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    protected virtual void OnListChanged(ListChangedEventArgs e)
    {
      if (!this.raiseListChangedEvents || this.initializing)
        return;
      ListChangedEventHandler changedEventHandler = (ListChangedEventHandler) this.Events[BindingSource.EVENT_LISTCHANGED];
      if (changedEventHandler == null)
        return;
      changedEventHandler((object) this, e);
    }

    protected virtual void OnPositionChanged(EventArgs e)
    {
      EventHandler eventHandler = (EventHandler) this.Events[BindingSource.EVENT_POSITIONCHANGED];
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    public void RemoveCurrent()
    {
      if (!this.AllowRemove)
        throw new InvalidOperationException(System.Windows.Forms.SR.GetString("BindingSourceRemoveCurrentNotAllowed"));
      if (this.Position < 0 || this.Position >= this.Count)
        throw new InvalidOperationException(System.Windows.Forms.SR.GetString("BindingSourceRemoveCurrentNoCurrentItem"));
      this.RemoveAt(this.Position);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public virtual void ResetAllowNew()
    {
      this.allowNewIsSet = false;
      this.allowNewSetValue = true;
    }

    public void ResetBindings(bool metadataChanged)
    {
      if (metadataChanged)
        this.OnListChanged(new ListChangedEventArgs(ListChangedType.PropertyDescriptorChanged, (PropertyDescriptor) null));
      this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
    }

    public void ResetCurrentItem()
    {
      this.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemChanged, this.Position));
    }

    public void ResetItem(int itemIndex)
    {
      this.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemChanged, itemIndex));
    }

    public void ResumeBinding()
    {
      this.currencyManager.ResumeBinding();
    }

    public void SuspendBinding()
    {
      this.currencyManager.SuspendBinding();
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal virtual bool ShouldSerializeAllowNew()
    {
      return this.allowNewIsSet;
    }

    void ISupportInitialize.BeginInit()
    {
      this.initializing = true;
    }

    void ISupportInitialize.EndInit()
    {
      ISupportInitializeNotification initializeNotification = this.DataSource as ISupportInitializeNotification;
      if (initializeNotification != null && !initializeNotification.IsInitialized)
        initializeNotification.Initialized += new EventHandler(this.DataSource_Initialized);
      else
        this.EndInitCore();
    }

    public virtual IEnumerator GetEnumerator()
    {
      return this.List.GetEnumerator();
    }

    public virtual void CopyTo(Array arr, int index)
    {
      this.List.CopyTo(arr, index);
    }

    public virtual int Add(object value)
    {
      if (this.dataSource == null && this.List.Count == 0)
        this.SetList(BindingSource.CreateBindingList(value == null ? typeof (object) : value.GetType()), true, true);
      if (value != null && !this.itemType.IsAssignableFrom(value.GetType()))
        throw new InvalidOperationException(System.Windows.Forms.SR.GetString("BindingSourceItemTypeMismatchOnAdd"));
      if (value == null && this.itemType.IsValueType)
        throw new InvalidOperationException(System.Windows.Forms.SR.GetString("BindingSourceItemTypeIsValueType"));
      int newIndex = this.List.Add(value);
      this.OnSimpleListChanged(ListChangedType.ItemAdded, newIndex);
      return newIndex;
    }

    public virtual void Clear()
    {
      this.UnhookItemChangedEventsForOldCurrent();
      this.List.Clear();
      this.OnSimpleListChanged(ListChangedType.Reset, -1);
    }

    public virtual bool Contains(object value)
    {
      return this.List.Contains(value);
    }

    public virtual int IndexOf(object value)
    {
      return this.List.IndexOf(value);
    }

    public virtual void Insert(int index, object value)
    {
      this.List.Insert(index, value);
      this.OnSimpleListChanged(ListChangedType.ItemAdded, index);
    }

    public virtual void Remove(object value)
    {
      int newIndex = this.IndexOf(value);
      this.List.Remove(value);
      if (newIndex == -1)
        return;
      this.OnSimpleListChanged(ListChangedType.ItemDeleted, newIndex);
    }

    public virtual void RemoveAt(int index)
    {
      object obj = this[index];
      this.List.RemoveAt(index);
      this.OnSimpleListChanged(ListChangedType.ItemDeleted, index);
    }

    public virtual string GetListName(PropertyDescriptor[] listAccessors)
    {
      return ListBindingHelper.GetListName((object) this.List, listAccessors);
    }

    public virtual PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors)
    {
      object list = ListBindingHelper.GetList(this.dataSource);
      if (list is ITypedList && !string.IsNullOrEmpty(this.dataMember))
        return ListBindingHelper.GetListItemProperties(list, this.dataMember, listAccessors);
      else
        return ListBindingHelper.GetListItemProperties((object) this.List, listAccessors);
    }

    public virtual object AddNew()
    {
      if (!this.AllowNewInternal(false))
        throw new InvalidOperationException(System.Windows.Forms.SR.GetString("BindingSourceBindingListWrapperAddToReadOnlyList"));
      if (!this.AllowNewInternal(true))
      {
        throw new InvalidOperationException(System.Windows.Forms.SR.GetString("BindingSourceBindingListWrapperNeedToSetAllowNew", new object[1]
        {
          this.itemType == (System.Type) null ? (object) "(null)" : (object) this.itemType.FullName
        }));
      }
      else
      {
        int newIndex = this.addNewPos;
        this.EndEdit();
        if (newIndex != -1)
          this.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemAdded, newIndex));
        AddingNewEventArgs e = new AddingNewEventArgs();
        int count = this.List.Count;
        this.OnAddingNew(e);
        object obj1 = e.NewObject;
        if (obj1 == null)
        {
          if (this.isBindingList)
          {
            object obj2 = (this.List as IBindingList).AddNew();
            this.Position = this.Count - 1;
            return obj2;
          }
          else if (this.itemConstructor == (ConstructorInfo) null)
            throw new InvalidOperationException(System.Windows.Forms.SR.GetString("BindingSourceBindingListWrapperNeedAParameterlessConstructor", new object[1]
            {
              this.itemType == (System.Type) null ? (object) "(null)" : (object) this.itemType.FullName
            }));
          else
            obj1 = this.itemConstructor.Invoke((object[]) null);
        }
        if (this.List.Count > count)
        {
          this.addNewPos = this.Position;
        }
        else
        {
          this.addNewPos = this.Add(obj1);
          this.Position = this.addNewPos;
        }
        return obj1;
      }
    }

    void IBindingList.AddIndex(PropertyDescriptor property)
    {
      if (!this.isBindingList)
        throw new NotSupportedException(System.Windows.Forms.SR.GetString("OperationRequiresIBindingList"));
      ((IBindingList) this.List).AddIndex(property);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual void ApplySort(PropertyDescriptor property, ListSortDirection sort)
    {
      if (!this.isBindingList)
        throw new NotSupportedException(System.Windows.Forms.SR.GetString("OperationRequiresIBindingList"));
      ((IBindingList) this.List).ApplySort(property, sort);
    }

    public virtual int Find(PropertyDescriptor prop, object key)
    {
      if (this.isBindingList)
        return ((IBindingList) this.List).Find(prop, key);
      else
        throw new NotSupportedException(System.Windows.Forms.SR.GetString("OperationRequiresIBindingList"));
    }

    void IBindingList.RemoveIndex(PropertyDescriptor prop)
    {
      if (!this.isBindingList)
        throw new NotSupportedException(System.Windows.Forms.SR.GetString("OperationRequiresIBindingList"));
      ((IBindingList) this.List).RemoveIndex(prop);
    }

    public virtual void RemoveSort()
    {
      this.sort = (string) null;
      if (!this.isBindingList)
        return;
      ((IBindingList) this.List).RemoveSort();
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual void ApplySort(ListSortDescriptionCollection sorts)
    {
      IBindingListView bindingListView = this.List as IBindingListView;
      if (bindingListView == null)
        throw new NotSupportedException(System.Windows.Forms.SR.GetString("OperationRequiresIBindingListView"));
      bindingListView.ApplySort(sorts);
    }

    public virtual void RemoveFilter()
    {
      this.filter = (string) null;
      IBindingListView bindingListView = this.List as IBindingListView;
      if (bindingListView == null)
        return;
      bindingListView.RemoveFilter();
    }

    void ICancelAddNew.CancelNew(int position)
    {
      if (this.addNewPos >= 0 && this.addNewPos == position)
      {
        this.RemoveAt(this.addNewPos);
        this.addNewPos = -1;
      }
      else
      {
        ICancelAddNew cancelAddNew = this.List as ICancelAddNew;
        if (cancelAddNew == null)
          return;
        cancelAddNew.CancelNew(position);
      }
    }

    void ICancelAddNew.EndNew(int position)
    {
      if (this.addNewPos >= 0 && this.addNewPos == position)
      {
        this.addNewPos = -1;
      }
      else
      {
        ICancelAddNew cancelAddNew = this.List as ICancelAddNew;
        if (cancelAddNew == null)
          return;
        cancelAddNew.EndNew(position);
      }
    }

    private bool IsListWriteable(bool checkconstructor)
    {
      if (this.List.IsReadOnly || this.List.IsFixedSize)
        return false;
      if (checkconstructor)
        return this.itemConstructor != (ConstructorInfo) null;
      else
        return true;
    }

    private BindingSource GetRelatedBindingSource(string dataMember)
    {
      if (this.relatedBindingSources == null)
        this.relatedBindingSources = new Dictionary<string, BindingSource>();
      foreach (string a in this.relatedBindingSources.Keys)
      {
        if (string.Equals(a, dataMember, StringComparison.OrdinalIgnoreCase))
          return this.relatedBindingSources[a];
      }
      BindingSource bindingSource = new BindingSource((object) this, dataMember);
      this.relatedBindingSources[dataMember] = bindingSource;
      return bindingSource;
    }

    private static string BuildSortString(ListSortDescriptionCollection sortsColln)
    {
      if (sortsColln == null)
        return string.Empty;
      StringBuilder stringBuilder = new StringBuilder(sortsColln.Count);
      for (int index = 0; index < sortsColln.Count; ++index)
        stringBuilder.Append(sortsColln[index].PropertyDescriptor.Name + (sortsColln[index].SortDirection == ListSortDirection.Ascending ? " ASC" : " DESC") + (index < sortsColln.Count - 1 ? "," : string.Empty));
      return ((object) stringBuilder).ToString();
    }

    private void ThrowIfBindingSourceRecursionDetected(object newDataSource)
    {
      for (BindingSource bindingSource = newDataSource as BindingSource; bindingSource != null; bindingSource = bindingSource.DataSource as BindingSource)
      {
        if (bindingSource == this)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("BindingSourceRecursionDetected"));
      }
    }

    private void ClearInvalidDataMember()
    {
      if (this.IsDataMemberValid())
        return;
      this.dataMember = "";
      this.OnDataMemberChanged(EventArgs.Empty);
    }

    private static IList CreateBindingList(System.Type type)
    {
      return (IList) System.Windows.Forms.SecurityUtils.SecureCreateInstance(typeof (BindingList<>).MakeGenericType(new System.Type[1]
      {
        type
      }));
    }

    private static object CreateInstanceOfType(System.Type type)
    {
      object obj = (object) null;
      Exception innerException = (Exception) null;
      try
      {
        obj = System.Windows.Forms.SecurityUtils.SecureCreateInstance(type);
      }
      catch (TargetInvocationException ex)
      {
        innerException = (Exception) ex;
      }
      catch (MethodAccessException ex)
      {
        innerException = (Exception) ex;
      }
      catch (MissingMethodException ex)
      {
        innerException = (Exception) ex;
      }
      if (innerException != null)
        throw new NotSupportedException(System.Windows.Forms.SR.GetString("BindingSourceInstanceError"), innerException);
      else
        return obj;
    }

    private void CurrencyManager_PositionChanged(object sender, EventArgs e)
    {
      this.OnPositionChanged(e);
    }

    private void CurrencyManager_CurrentChanged(object sender, EventArgs e)
    {
      this.OnCurrentChanged(EventArgs.Empty);
    }

    private void CurrencyManager_CurrentItemChanged(object sender, EventArgs e)
    {
      this.OnCurrentItemChanged(EventArgs.Empty);
    }

    private void CurrencyManager_BindingComplete(object sender, BindingCompleteEventArgs e)
    {
      this.OnBindingComplete(e);
    }

    private void CurrencyManager_DataError(object sender, BindingManagerDataErrorEventArgs e)
    {
      this.OnDataError(e);
    }

    private void EnsureInnerList()
    {
      if (this.initializing || !this.needToSetList)
        return;
      this.needToSetList = false;
      this.ResetList();
    }

    private static IList GetListFromType(System.Type type)
    {
      return !typeof (ITypedList).IsAssignableFrom(type) || !typeof (IList).IsAssignableFrom(type) ? (!typeof (IListSource).IsAssignableFrom(type) ? BindingSource.CreateBindingList(ListBindingHelper.GetListItemType((object) type)) : (BindingSource.CreateInstanceOfType(type) as IListSource).GetList()) : BindingSource.CreateInstanceOfType(type) as IList;
    }

    private static IList GetListFromEnumerable(IEnumerable enumerable)
    {
      IList list = (IList) null;
      foreach (object obj in enumerable)
      {
        if (list == null)
          list = BindingSource.CreateBindingList(obj.GetType());
        list.Add(obj);
      }
      return list;
    }

    private bool IsDataMemberValid()
    {
      return this.initializing || string.IsNullOrEmpty(this.dataMember) || ListBindingHelper.GetListItemProperties(this.dataSource)[this.dataMember] != null;
    }

    private void InnerList_ListChanged(object sender, ListChangedEventArgs e)
    {
      if (this.innerListChanging)
        return;
      try
      {
        this.innerListChanging = true;
        this.OnListChanged(e);
      }
      finally
      {
        this.innerListChanging = false;
      }
    }

    private void ListItem_PropertyChanged(object sender, EventArgs e)
    {
      this.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemChanged, sender != this.currentItemHookedForItemChange ? this.IndexOf(sender) : this.Position));
    }

    private void OnSimpleListChanged(ListChangedType listChangedType, int newIndex)
    {
      if (this.isBindingList)
        return;
      this.OnListChanged(new ListChangedEventArgs(listChangedType, newIndex));
    }

    private void ParentCurrencyManager_CurrentItemChanged(object sender, EventArgs e)
    {
      if (this.initializing)
        return;
      if (this.parentsCurrentItemChanging)
        return;
      try
      {
        this.parentsCurrentItemChanging = true;
        bool success;
        this.currencyManager.PullData(out success);
      }
      finally
      {
        this.parentsCurrentItemChanging = false;
      }
      CurrencyManager currencyManager = (CurrencyManager) sender;
      if (!string.IsNullOrEmpty(this.dataMember))
      {
        object obj = (object) null;
        IList list = (IList) null;
        if (currencyManager.Count > 0)
        {
          PropertyDescriptor propertyDescriptor = currencyManager.GetItemProperties()[this.dataMember];
          if (propertyDescriptor != null)
          {
            obj = ListBindingHelper.GetList(propertyDescriptor.GetValue(currencyManager.Current));
            list = obj as IList;
          }
        }
        if (list != null)
          this.SetList(list, false, true);
        else if (obj != null)
          this.SetList(BindingSource.WrapObjectInBindingList(obj), false, false);
        else
          this.SetList(BindingSource.CreateBindingList(this.itemType), false, false);
        bool flag = this.lastCurrentItem == null || currencyManager.Count == 0 || this.lastCurrentItem != currencyManager.Current || this.Position >= this.Count;
        this.lastCurrentItem = currencyManager.Count > 0 ? currencyManager.Current : (object) null;
        if (flag)
          this.Position = this.Count > 0 ? 0 : -1;
      }
      this.OnCurrentItemChanged(EventArgs.Empty);
    }

    private void ParentCurrencyManager_MetaDataChanged(object sender, EventArgs e)
    {
      this.ClearInvalidDataMember();
      this.ResetList();
    }

    private ListSortDescriptionCollection ParseSortString(string sortString)
    {
      if (string.IsNullOrEmpty(sortString))
        return new ListSortDescriptionCollection();
      ArrayList arrayList = new ArrayList();
      PropertyDescriptorCollection itemProperties = this.currencyManager.GetItemProperties();
      string str1 = sortString;
      char[] chArray = new char[1]
      {
        ','
      };
      foreach (string str2 in str1.Split(chArray))
      {
        string str3 = str2.Trim();
        int length = str3.Length;
        bool flag = true;
        if (length >= 5 && string.Compare(str3, length - 4, " ASC", 0, 4, true, CultureInfo.InvariantCulture) == 0)
          str3 = str3.Substring(0, length - 4).Trim();
        else if (length >= 6 && string.Compare(str3, length - 5, " DESC", 0, 5, true, CultureInfo.InvariantCulture) == 0)
        {
          flag = false;
          str3 = str3.Substring(0, length - 5).Trim();
        }
        if (str3.StartsWith("["))
        {
          if (!str3.EndsWith("]"))
            throw new ArgumentException(System.Windows.Forms.SR.GetString("BindingSourceBadSortString"));
          str3 = str3.Substring(1, str3.Length - 2);
        }
        PropertyDescriptor property = itemProperties.Find(str3, true);
        if (property == null)
          throw new ArgumentException(System.Windows.Forms.SR.GetString("BindingSourceSortStringPropertyNotInIBindingList"));
        arrayList.Add((object) new ListSortDescription(property, flag ? ListSortDirection.Ascending : ListSortDirection.Descending));
      }
      ListSortDescription[] sorts = new ListSortDescription[arrayList.Count];
      arrayList.CopyTo((Array) sorts);
      return new ListSortDescriptionCollection(sorts);
    }

    private void ResetList()
    {
      if (this.initializing)
      {
        this.needToSetList = true;
      }
      else
      {
        this.needToSetList = false;
        object list1 = ListBindingHelper.GetList(this.dataSource is System.Type ? (object) BindingSource.GetListFromType(this.dataSource as System.Type) : this.dataSource, this.dataMember);
        this.listExtractedFromEnumerable = false;
        IList list2 = (IList) null;
        if (list1 is IList)
        {
          list2 = list1 as IList;
        }
        else
        {
          if (list1 is IListSource)
            list2 = (list1 as IListSource).GetList();
          else if (list1 is IEnumerable)
          {
            list2 = BindingSource.GetListFromEnumerable(list1 as IEnumerable);
            if (list2 != null)
              this.listExtractedFromEnumerable = true;
          }
          if (list2 == null)
          {
            if (list1 != null)
            {
              list2 = BindingSource.WrapObjectInBindingList(list1);
            }
            else
            {
              System.Type listItemType = ListBindingHelper.GetListItemType(this.dataSource, this.dataMember);
              list2 = BindingSource.GetListFromType(listItemType) ?? BindingSource.CreateBindingList(listItemType);
            }
          }
        }
        this.SetList(list2, true, true);
      }
    }

    private void SetList(IList list, bool metaDataChanged, bool applySortAndFilter)
    {
      if (list == null)
        list = BindingSource.CreateBindingList(this.itemType);
      this.UnwireInnerList();
      this.UnhookItemChangedEventsForOldCurrent();
      IList list1 = ListBindingHelper.GetList((object) list) as IList ?? list;
      this._innerList = list1;
      this.isBindingList = list1 is IBindingList;
      this.listRaisesItemChangedEvents = !(list1 is IRaiseItemChangedEvents) ? this.isBindingList : (list1 as IRaiseItemChangedEvents).RaisesItemChangedEvents;
      if (metaDataChanged)
      {
        this.itemType = ListBindingHelper.GetListItemType((object) this.List);
        this.itemShape = ListBindingHelper.GetListItemProperties((object) this.List);
        this.itemConstructor = this.itemType.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance, (Binder) null, new System.Type[0], (ParameterModifier[]) null);
      }
      this.WireInnerList();
      this.HookItemChangedEventsForNewCurrent();
      this.ResetBindings(metaDataChanged);
      if (!applySortAndFilter)
        return;
      if (this.Sort != null)
        this.InnerListSort = this.Sort;
      if (this.Filter == null)
        return;
      this.InnerListFilter = this.Filter;
    }

    private static IList WrapObjectInBindingList(object obj)
    {
      IList bindingList = BindingSource.CreateBindingList(obj.GetType());
      bindingList.Add(obj);
      return bindingList;
    }

    private void HookItemChangedEventsForNewCurrent()
    {
      if (this.listRaisesItemChangedEvents)
        return;
      if (this.Position >= 0 && this.Position <= this.Count - 1)
      {
        this.currentItemHookedForItemChange = this.Current;
        this.WirePropertyChangedEvents(this.currentItemHookedForItemChange);
      }
      else
        this.currentItemHookedForItemChange = (object) null;
    }

    private void UnhookItemChangedEventsForOldCurrent()
    {
      if (this.listRaisesItemChangedEvents)
        return;
      this.UnwirePropertyChangedEvents(this.currentItemHookedForItemChange);
      this.currentItemHookedForItemChange = (object) null;
    }

    private void WireCurrencyManager(CurrencyManager cm)
    {
      if (cm == null)
        return;
      cm.PositionChanged += new EventHandler(this.CurrencyManager_PositionChanged);
      cm.CurrentChanged += new EventHandler(this.CurrencyManager_CurrentChanged);
      cm.CurrentItemChanged += new EventHandler(this.CurrencyManager_CurrentItemChanged);
      cm.BindingComplete += new BindingCompleteEventHandler(this.CurrencyManager_BindingComplete);
      cm.DataError += new BindingManagerDataErrorEventHandler(this.CurrencyManager_DataError);
    }

    private void UnwireCurrencyManager(CurrencyManager cm)
    {
      if (cm == null)
        return;
      cm.PositionChanged -= new EventHandler(this.CurrencyManager_PositionChanged);
      cm.CurrentChanged -= new EventHandler(this.CurrencyManager_CurrentChanged);
      cm.CurrentItemChanged -= new EventHandler(this.CurrencyManager_CurrentItemChanged);
      cm.BindingComplete -= new BindingCompleteEventHandler(this.CurrencyManager_BindingComplete);
      cm.DataError -= new BindingManagerDataErrorEventHandler(this.CurrencyManager_DataError);
    }

    private void WireDataSource()
    {
      if (!(this.dataSource is ICurrencyManagerProvider))
        return;
      CurrencyManager currencyManager = (this.dataSource as ICurrencyManagerProvider).CurrencyManager;
      currencyManager.CurrentItemChanged += new EventHandler(this.ParentCurrencyManager_CurrentItemChanged);
      currencyManager.MetaDataChanged += new EventHandler(this.ParentCurrencyManager_MetaDataChanged);
    }

    private void UnwireDataSource()
    {
      if (!(this.dataSource is ICurrencyManagerProvider))
        return;
      CurrencyManager currencyManager = (this.dataSource as ICurrencyManagerProvider).CurrencyManager;
      currencyManager.CurrentItemChanged -= new EventHandler(this.ParentCurrencyManager_CurrentItemChanged);
      currencyManager.MetaDataChanged -= new EventHandler(this.ParentCurrencyManager_MetaDataChanged);
    }

    private void WireInnerList()
    {
      if (!(this._innerList is IBindingList))
        return;
      (this._innerList as IBindingList).ListChanged += new ListChangedEventHandler(this.InnerList_ListChanged);
    }

    private void UnwireInnerList()
    {
      if (!(this._innerList is IBindingList))
        return;
      (this._innerList as IBindingList).ListChanged -= new ListChangedEventHandler(this.InnerList_ListChanged);
    }

    private void WirePropertyChangedEvents(object item)
    {
      if (item == null || this.itemShape == null)
        return;
      for (int index = 0; index < this.itemShape.Count; ++index)
        this.itemShape[index].AddValueChanged(item, this.listItemPropertyChangedHandler);
    }

    private void UnwirePropertyChangedEvents(object item)
    {
      if (item == null || this.itemShape == null)
        return;
      for (int index = 0; index < this.itemShape.Count; ++index)
        this.itemShape[index].RemoveValueChanged(item, this.listItemPropertyChangedHandler);
    }

    private void EndInitCore()
    {
      this.initializing = false;
      this.EnsureInnerList();
      this.OnInitialized();
    }

    private void DataSource_Initialized(object sender, EventArgs e)
    {
      ISupportInitializeNotification initializeNotification = this.DataSource as ISupportInitializeNotification;
      if (initializeNotification != null)
        initializeNotification.Initialized -= new EventHandler(this.DataSource_Initialized);
      this.EndInitCore();
    }

    private void OnInitialized()
    {
      EventHandler eventHandler = (EventHandler) this.Events[BindingSource.EVENT_INITIALIZED];
      if (eventHandler == null)
        return;
      eventHandler((object) this, EventArgs.Empty);
    }
  }
}
