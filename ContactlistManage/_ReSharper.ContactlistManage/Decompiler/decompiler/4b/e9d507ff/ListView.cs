// Type: System.Windows.Forms.ListView
// Assembly: System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Windows.Forms.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms.Layout;
using System.Windows.Forms.VisualStyles;

namespace System.Windows.Forms
{
  [Designer("System.Windows.Forms.Design.ListViewDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [SRDescription("DescriptionListView")]
  [DefaultProperty("Items")]
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  [Docking(DockingBehavior.Ask)]
  [DefaultEvent("SelectedIndexChanged")]
  [ComVisible(true)]
  public class ListView : Control
  {
    private static readonly object EVENT_CACHEVIRTUALITEMS = new object();
    private static readonly object EVENT_COLUMNREORDERED = new object();
    private static readonly object EVENT_COLUMNWIDTHCHANGED = new object();
    private static readonly object EVENT_COLUMNWIDTHCHANGING = new object();
    private static readonly object EVENT_DRAWCOLUMNHEADER = new object();
    private static readonly object EVENT_DRAWITEM = new object();
    private static readonly object EVENT_DRAWSUBITEM = new object();
    private static readonly object EVENT_ITEMSELECTIONCHANGED = new object();
    private static readonly object EVENT_RETRIEVEVIRTUALITEM = new object();
    private static readonly object EVENT_SEARCHFORVIRTUALITEM = new object();
    private static readonly object EVENT_SELECTEDINDEXCHANGED = new object();
    private static readonly object EVENT_VIRTUALITEMSSELECTIONRANGECHANGED = new object();
    private static readonly object EVENT_RIGHTTOLEFTLAYOUTCHANGED = new object();
    private static readonly int PropDelayedUpdateItems = PropertyStore.CreateKey();
    private ListViewAlignment alignStyle = ListViewAlignment.Top;
    private BorderStyle borderStyle = BorderStyle.Fixed3D;
    private ColumnHeaderStyle headerStyle = ColumnHeaderStyle.Clickable;
    private string toolTipCaption = string.Empty;
    private Color odCacheForeColor = SystemColors.WindowText;
    private Color odCacheBackColor = SystemColors.Window;
    private IntPtr odCacheFontHandle = IntPtr.Zero;
    private Hashtable listItemsTable = new Hashtable();
    private ArrayList listItemsArray = new ArrayList();
    private Size tileSize = Size.Empty;
    private string backgroundImageFileName = string.Empty;
    private int bkImgFileNamesCount = -1;
    private int newWidthForColumnWidthChangingCancelled = -1;
    private ItemActivation activation;
    private SortOrder sorting;
    private View viewStyle;
    private BitVector32 listViewState;
    private BitVector32 listViewState1;
    private Font odCacheFont;
    private Control.FontHandleWrapper odCacheFontHandleWrapper;
    private ImageList imageListLarge;
    private ImageList imageListSmall;
    private ImageList imageListState;
    private MouseButtons downButton;
    private int itemCount;
    private int columnIndex;
    private int topIndex;
    private bool hoveredAlready;
    private bool rightToLeftLayout;
    private int virtualListSize;
    private ListViewGroup defaultGroup;
    private int updateCounter;
    private ColumnHeader[] columnHeaders;
    private System.Windows.Forms.ListView.ListViewItemCollection listItemCollection;
    private System.Windows.Forms.ListView.ColumnHeaderCollection columnHeaderCollection;
    private System.Windows.Forms.ListView.CheckedIndexCollection checkedIndexCollection;
    private System.Windows.Forms.ListView.CheckedListViewItemCollection checkedListViewItemCollection;
    private System.Windows.Forms.ListView.SelectedListViewItemCollection selectedListViewItemCollection;
    private System.Windows.Forms.ListView.SelectedIndexCollection selectedIndexCollection;
    private ListViewGroupCollection groups;
    private ListViewInsertionMark insertionMark;
    private LabelEditEventHandler onAfterLabelEdit;
    private LabelEditEventHandler onBeforeLabelEdit;
    private ColumnClickEventHandler onColumnClick;
    private EventHandler onItemActivate;
    private ItemCheckedEventHandler onItemChecked;
    private ItemDragEventHandler onItemDrag;
    private ItemCheckEventHandler onItemCheck;
    private ListViewItemMouseHoverEventHandler onItemMouseHover;
    private int nextID;
    private List<ListViewItem> savedSelectedItems;
    private List<ListViewItem> savedCheckedItems;
    private IComparer listItemSorter;
    private ListViewItem prevHoveredItem;
    private string[] bkImgFileNames;
    private ColumnHeader columnHeaderClicked;
    private int columnHeaderClickedWidth;
    private const int MASK_HITTESTFLAG = 247;
    private const int LISTVIEWSTATE_ownerDraw = 1;
    private const int LISTVIEWSTATE_allowColumnReorder = 2;
    private const int LISTVIEWSTATE_autoArrange = 4;
    private const int LISTVIEWSTATE_checkBoxes = 8;
    private const int LISTVIEWSTATE_fullRowSelect = 16;
    private const int LISTVIEWSTATE_gridLines = 32;
    private const int LISTVIEWSTATE_hideSelection = 64;
    private const int LISTVIEWSTATE_hotTracking = 128;
    private const int LISTVIEWSTATE_labelEdit = 256;
    private const int LISTVIEWSTATE_labelWrap = 512;
    private const int LISTVIEWSTATE_multiSelect = 1024;
    private const int LISTVIEWSTATE_scrollable = 2048;
    private const int LISTVIEWSTATE_hoverSelection = 4096;
    private const int LISTVIEWSTATE_nonclickHdr = 8192;
    private const int LISTVIEWSTATE_inLabelEdit = 16384;
    private const int LISTVIEWSTATE_showItemToolTips = 32768;
    private const int LISTVIEWSTATE_backgroundImageTiled = 65536;
    private const int LISTVIEWSTATE_columnClicked = 131072;
    private const int LISTVIEWSTATE_doubleclickFired = 262144;
    private const int LISTVIEWSTATE_mouseUpFired = 524288;
    private const int LISTVIEWSTATE_expectingMouseUp = 1048576;
    private const int LISTVIEWSTATE_comctlSupportsVisualStyles = 2097152;
    private const int LISTVIEWSTATE_comctlSupportsVisualStylesTested = 4194304;
    private const int LISTVIEWSTATE_showGroups = 8388608;
    private const int LISTVIEWSTATE_handleDestroyed = 16777216;
    private const int LISTVIEWSTATE_virtualMode = 33554432;
    private const int LISTVIEWSTATE_headerControlTracking = 67108864;
    private const int LISTVIEWSTATE_itemCollectionChangedInMouseDown = 134217728;
    private const int LISTVIEWSTATE_flipViewToLargeIconAndSmallIcon = 268435456;
    private const int LISTVIEWSTATE_headerDividerDblClick = 536870912;
    private const int LISTVIEWSTATE_columnResizeCancelled = 1073741824;
    private const int LISTVIEWSTATE1_insertingItemsNatively = 1;
    private const int LISTVIEWSTATE1_cancelledColumnWidthChanging = 2;
    private const int LISTVIEWSTATE1_disposingImageLists = 4;
    private const int LISTVIEWSTATE1_useCompatibleStateImageBehavior = 8;
    private const int LISTVIEWSTATE1_selectedIndexChangedSkipped = 16;
    private const int LVTOOLTIPTRACKING = 48;
    private const int MAXTILECOLUMNS = 20;
    private const int BKIMGARRAYSIZE = 8;

    [SRCategory("CatBehavior")]
    [DefaultValue(ItemActivation.Standard)]
    [SRDescription("ListViewActivationDescr")]
    public ItemActivation Activation
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.activation;
      }
      set
      {
        if (!System.Windows.Forms.ClientUtils.IsEnumValid((Enum) value, (int) value, 0, 2))
          throw new InvalidEnumArgumentException("value", (int) value, typeof (ItemActivation));
        if (this.HotTracking && value != ItemActivation.OneClick)
          throw new ArgumentException(System.Windows.Forms.SR.GetString("ListViewActivationMustBeOnWhenHotTrackingIsOn"), "value");
        if (this.activation == value)
          return;
        this.activation = value;
        this.UpdateExtendedStyles();
      }
    }

    [DefaultValue(ListViewAlignment.Top)]
    [Localizable(true)]
    [SRDescription("ListViewAlignmentDescr")]
    [SRCategory("CatBehavior")]
    public ListViewAlignment Alignment
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.alignStyle;
      }
      set
      {
        if (!System.Windows.Forms.ClientUtils.IsEnumValid_NotSequential((Enum) value, (int) value, 0, 2, 1, 5))
          throw new InvalidEnumArgumentException("value", (int) value, typeof (ListViewAlignment));
        if (this.alignStyle == value)
          return;
        this.alignStyle = value;
        this.RecreateHandleInternal();
      }
    }

    [SRDescription("ListViewAllowColumnReorderDescr")]
    [SRCategory("CatBehavior")]
    [DefaultValue(false)]
    public bool AllowColumnReorder
    {
      get
      {
        return this.listViewState[2];
      }
      set
      {
        if (this.AllowColumnReorder == value)
          return;
        this.listViewState[2] = value;
        this.UpdateExtendedStyles();
      }
    }

    [SRDescription("ListViewAutoArrangeDescr")]
    [SRCategory("CatBehavior")]
    [DefaultValue(true)]
    public bool AutoArrange
    {
      get
      {
        return this.listViewState[4];
      }
      set
      {
        if (this.AutoArrange == value)
          return;
        this.listViewState[4] = value;
        this.UpdateStyles();
      }
    }

    public override Color BackColor
    {
      get
      {
        if (this.ShouldSerializeBackColor())
          return base.BackColor;
        else
          return SystemColors.Window;
      }
      set
      {
        base.BackColor = value;
        if (!this.IsHandleCreated)
          return;
        this.SendMessage(4097, 0, ColorTranslator.ToWin32(this.BackColor));
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    public override ImageLayout BackgroundImageLayout
    {
      get
      {
        return base.BackgroundImageLayout;
      }
      set
      {
        base.BackgroundImageLayout = value;
      }
    }

    [DefaultValue(false)]
    [SRCategory("CatAppearance")]
    [SRDescription("ListViewBackgroundImageTiledDescr")]
    public bool BackgroundImageTiled
    {
      get
      {
        return this.listViewState[65536];
      }
      set
      {
        if (this.BackgroundImageTiled == value)
          return;
        this.listViewState[65536] = value;
        if (!this.IsHandleCreated || this.BackgroundImage == null)
          return;
        System.Windows.Forms.NativeMethods.LVBKIMAGE lParam = new System.Windows.Forms.NativeMethods.LVBKIMAGE();
        lParam.xOffset = 0;
        lParam.yOffset = 0;
        lParam.ulFlags = !this.BackgroundImageTiled ? 0 : 16;
        lParam.ulFlags |= 2;
        lParam.pszImage = this.backgroundImageFileName;
        lParam.cchImageMax = this.backgroundImageFileName.Length + 1;
        System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), System.Windows.Forms.NativeMethods.LVM_SETBKIMAGE, 0, lParam);
      }
    }

    [SRCategory("CatAppearance")]
    [DispId(-504)]
    [SRDescription("borderStyleDescr")]
    [DefaultValue(BorderStyle.Fixed3D)]
    public BorderStyle BorderStyle
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.borderStyle;
      }
      set
      {
        if (!System.Windows.Forms.ClientUtils.IsEnumValid((Enum) value, (int) value, 0, 2))
          throw new InvalidEnumArgumentException("value", (int) value, typeof (BorderStyle));
        if (this.borderStyle == value)
          return;
        this.borderStyle = value;
        this.UpdateStyles();
      }
    }

    [SRCategory("CatAppearance")]
    [SRDescription("ListViewCheckBoxesDescr")]
    [DefaultValue(false)]
    public bool CheckBoxes
    {
      get
      {
        return this.listViewState[8];
      }
      set
      {
        if (this.UseCompatibleStateImageBehavior)
        {
          if (this.CheckBoxes == value)
            return;
          if (value && this.View == View.Tile)
            throw new NotSupportedException(System.Windows.Forms.SR.GetString("ListViewCheckBoxesNotSupportedInTileView"));
          if (this.CheckBoxes)
          {
            this.savedCheckedItems = new List<ListViewItem>(this.CheckedItems.Count);
            ListViewItem[] listViewItemArray = new ListViewItem[this.CheckedItems.Count];
            this.CheckedItems.CopyTo((Array) listViewItemArray, 0);
            for (int index = 0; index < listViewItemArray.Length; ++index)
              this.savedCheckedItems.Add(listViewItemArray[index]);
          }
          this.listViewState[8] = value;
          this.UpdateExtendedStyles();
          if (this.CheckBoxes && this.savedCheckedItems != null)
          {
            if (this.savedCheckedItems.Count > 0)
            {
              foreach (ListViewItem listViewItem in this.savedCheckedItems)
                listViewItem.Checked = true;
            }
            this.savedCheckedItems = (List<ListViewItem>) null;
          }
          if (!this.AutoArrange)
            return;
          this.ArrangeIcons(this.Alignment);
        }
        else
        {
          if (this.CheckBoxes == value)
            return;
          if (value && this.View == View.Tile)
            throw new NotSupportedException(System.Windows.Forms.SR.GetString("ListViewCheckBoxesNotSupportedInTileView"));
          if (this.CheckBoxes)
          {
            this.savedCheckedItems = new List<ListViewItem>(this.CheckedItems.Count);
            ListViewItem[] listViewItemArray = new ListViewItem[this.CheckedItems.Count];
            this.CheckedItems.CopyTo((Array) listViewItemArray, 0);
            for (int index = 0; index < listViewItemArray.Length; ++index)
              this.savedCheckedItems.Add(listViewItemArray[index]);
          }
          this.listViewState[8] = value;
          if (!value && this.StateImageList != null && this.IsHandleCreated || !value && this.Alignment == ListViewAlignment.Left && this.IsHandleCreated || value && this.View == View.List && this.IsHandleCreated || value && (this.View == View.SmallIcon || this.View == View.LargeIcon) && this.IsHandleCreated)
            this.RecreateHandleInternal();
          else
            this.UpdateExtendedStyles();
          if (this.CheckBoxes && this.savedCheckedItems != null)
          {
            if (this.savedCheckedItems.Count > 0)
            {
              foreach (ListViewItem listViewItem in this.savedCheckedItems)
                listViewItem.Checked = true;
            }
            this.savedCheckedItems = (List<ListViewItem>) null;
          }
          if (this.IsHandleCreated && this.imageListState != null)
          {
            if (this.CheckBoxes)
              this.SendMessage(4099, 2, this.imageListState.Handle);
            else
              this.SendMessage(4099, 2, IntPtr.Zero);
          }
          if (!this.AutoArrange)
            return;
          this.ArrangeIcons(this.Alignment);
        }
      }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public System.Windows.Forms.ListView.CheckedIndexCollection CheckedIndices
    {
      get
      {
        if (this.checkedIndexCollection == null)
          this.checkedIndexCollection = new System.Windows.Forms.ListView.CheckedIndexCollection(this);
        return this.checkedIndexCollection;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public System.Windows.Forms.ListView.CheckedListViewItemCollection CheckedItems
    {
      get
      {
        if (this.checkedListViewItemCollection == null)
          this.checkedListViewItemCollection = new System.Windows.Forms.ListView.CheckedListViewItemCollection(this);
        return this.checkedListViewItemCollection;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [SRCategory("CatBehavior")]
    [Editor("System.Windows.Forms.Design.ColumnHeaderCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof (UITypeEditor))]
    [SRDescription("ListViewColumnsDescr")]
    [Localizable(true)]
    [MergableProperty(false)]
    public System.Windows.Forms.ListView.ColumnHeaderCollection Columns
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.columnHeaderCollection;
      }
    }

    bool ComctlSupportsVisualStyles
    {
      private get
      {
        if (!this.listViewState[4194304])
        {
          this.listViewState[4194304] = true;
          this.listViewState[2097152] = Application.ComCtlSupportsVisualStyles;
        }
        return this.listViewState[2097152];
      }
    }

    protected override CreateParams CreateParams
    {
      [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)] get
      {
        CreateParams createParams1 = base.CreateParams;
        createParams1.ClassName = "SysListView32";
        if (this.IsHandleCreated)
        {
          int num = (int) (long) System.Windows.Forms.UnsafeNativeMethods.GetWindowLong(new HandleRef((object) this, this.Handle), -16);
          createParams1.Style |= num & 3145728;
        }
        createParams1.Style |= 64;
        switch (this.alignStyle)
        {
          case ListViewAlignment.Left:
            createParams1.Style |= 2048;
            break;
          case ListViewAlignment.Top:
            CreateParams createParams2 = createParams1;
            int style = createParams2.Style;
            createParams2.Style = style;
            break;
        }
        if (this.AutoArrange)
          createParams1.Style |= 256;
        switch (this.borderStyle)
        {
          case BorderStyle.FixedSingle:
            createParams1.Style |= 8388608;
            break;
          case BorderStyle.Fixed3D:
            createParams1.ExStyle |= 512;
            break;
        }
        switch (this.headerStyle)
        {
          case ColumnHeaderStyle.None:
            createParams1.Style |= 16384;
            break;
          case ColumnHeaderStyle.Nonclickable:
            createParams1.Style |= 32768;
            break;
        }
        if (this.LabelEdit)
          createParams1.Style |= 512;
        if (!this.LabelWrap)
          createParams1.Style |= 128;
        if (!this.HideSelection)
          createParams1.Style |= 8;
        if (!this.MultiSelect)
          createParams1.Style |= 4;
        if (this.listItemSorter == null)
        {
          switch (this.sorting)
          {
            case SortOrder.Ascending:
              createParams1.Style |= 16;
              break;
            case SortOrder.Descending:
              createParams1.Style |= 32;
              break;
          }
        }
        if (this.VirtualMode)
          createParams1.Style |= 4096;
        if (this.viewStyle != View.Tile)
          createParams1.Style |= (int) this.viewStyle;
        if (this.RightToLeft == RightToLeft.Yes && this.RightToLeftLayout)
        {
          createParams1.ExStyle |= 4194304;
          createParams1.ExStyle &= -28673;
        }
        return createParams1;
      }
    }

    internal ListViewGroup DefaultGroup
    {
      get
      {
        if (this.defaultGroup == null)
          this.defaultGroup = new ListViewGroup(System.Windows.Forms.SR.GetString("ListViewGroupDefaultGroup", new object[1]
          {
            (object) "1"
          }));
        return this.defaultGroup;
      }
    }

    protected override Size DefaultSize
    {
      get
      {
        return new Size(121, 97);
      }
    }

    protected override bool DoubleBuffered
    {
      get
      {
        return base.DoubleBuffered;
      }
      set
      {
        if (this.DoubleBuffered == value)
          return;
        base.DoubleBuffered = value;
        this.UpdateExtendedStyles();
      }
    }

    internal bool ExpectingMouseUp
    {
      get
      {
        return this.listViewState[1048576];
      }
    }

    [SRDescription("ListViewFocusedItemDescr")]
    [SRCategory("CatAppearance")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public ListViewItem FocusedItem
    {
      get
      {
        if (this.IsHandleCreated)
        {
          int index = (int) (long) this.SendMessage(4108, -1, 1);
          if (index > -1)
            return this.Items[index];
        }
        return (ListViewItem) null;
      }
      set
      {
        if (!this.IsHandleCreated || value == null)
          return;
        value.Focused = true;
      }
    }

    public override Color ForeColor
    {
      get
      {
        if (this.ShouldSerializeForeColor())
          return base.ForeColor;
        else
          return SystemColors.WindowText;
      }
      set
      {
        base.ForeColor = value;
        if (!this.IsHandleCreated)
          return;
        this.SendMessage(4132, 0, ColorTranslator.ToWin32(this.ForeColor));
      }
    }

    private bool FlipViewToLargeIconAndSmallIcon
    {
      get
      {
        return this.listViewState[268435456];
      }
      set
      {
        this.listViewState[268435456] = value;
      }
    }

    [DefaultValue(false)]
    [SRCategory("CatAppearance")]
    [SRDescription("ListViewFullRowSelectDescr")]
    public bool FullRowSelect
    {
      get
      {
        return this.listViewState[16];
      }
      set
      {
        if (this.FullRowSelect == value)
          return;
        this.listViewState[16] = value;
        this.UpdateExtendedStyles();
      }
    }

    [SRCategory("CatAppearance")]
    [SRDescription("ListViewGridLinesDescr")]
    [DefaultValue(false)]
    public bool GridLines
    {
      get
      {
        return this.listViewState[32];
      }
      set
      {
        if (this.GridLines == value)
          return;
        this.listViewState[32] = value;
        this.UpdateExtendedStyles();
      }
    }

    [MergableProperty(false)]
    [SRDescription("ListViewGroupsDescr")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [SRCategory("CatBehavior")]
    [Localizable(true)]
    [Editor("System.Windows.Forms.Design.ListViewGroupCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof (UITypeEditor))]
    public ListViewGroupCollection Groups
    {
      get
      {
        if (this.groups == null)
          this.groups = new ListViewGroupCollection(this);
        return this.groups;
      }
    }

    internal bool GroupsEnabled
    {
      get
      {
        if (this.ShowGroups && this.groups != null && (this.groups.Count > 0 && this.ComctlSupportsVisualStyles))
          return !this.VirtualMode;
        else
          return false;
      }
    }

    [DefaultValue(ColumnHeaderStyle.Clickable)]
    [SRDescription("ListViewHeaderStyleDescr")]
    [SRCategory("CatBehavior")]
    public ColumnHeaderStyle HeaderStyle
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.headerStyle;
      }
      set
      {
        if (!System.Windows.Forms.ClientUtils.IsEnumValid((Enum) value, (int) value, 0, 2))
          throw new InvalidEnumArgumentException("value", (int) value, typeof (ColumnHeaderStyle));
        if (this.headerStyle == value)
          return;
        this.headerStyle = value;
        if (this.listViewState[8192] && value == ColumnHeaderStyle.Clickable || !this.listViewState[8192] && value == ColumnHeaderStyle.Nonclickable)
        {
          this.listViewState[8192] = !this.listViewState[8192];
          this.RecreateHandleInternal();
        }
        else
          this.UpdateStyles();
      }
    }

    [SRDescription("ListViewHideSelectionDescr")]
    [DefaultValue(true)]
    [SRCategory("CatBehavior")]
    public bool HideSelection
    {
      get
      {
        return this.listViewState[64];
      }
      set
      {
        if (this.HideSelection == value)
          return;
        this.listViewState[64] = value;
        this.UpdateStyles();
      }
    }

    [DefaultValue(false)]
    [SRDescription("ListViewHotTrackingDescr")]
    [SRCategory("CatBehavior")]
    public bool HotTracking
    {
      get
      {
        return this.listViewState[128];
      }
      set
      {
        if (this.HotTracking == value)
          return;
        this.listViewState[128] = value;
        if (value)
        {
          this.HoverSelection = true;
          this.Activation = ItemActivation.OneClick;
        }
        this.UpdateExtendedStyles();
      }
    }

    [DefaultValue(false)]
    [SRDescription("ListViewHoverSelectDescr")]
    [SRCategory("CatBehavior")]
    public bool HoverSelection
    {
      get
      {
        return this.listViewState[4096];
      }
      set
      {
        if (this.HoverSelection == value)
          return;
        if (this.HotTracking && !value)
          throw new ArgumentException(System.Windows.Forms.SR.GetString("ListViewHoverMustBeOnWhenHotTrackingIsOn"), "value");
        this.listViewState[4096] = value;
        this.UpdateExtendedStyles();
      }
    }

    internal bool InsertingItemsNatively
    {
      get
      {
        return this.listViewState1[1];
      }
    }

    [SRDescription("ListViewInsertionMarkDescr")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public ListViewInsertionMark InsertionMark
    {
      get
      {
        if (this.insertionMark == null)
          this.insertionMark = new ListViewInsertionMark(this);
        return this.insertionMark;
      }
    }

    private bool ItemCollectionChangedInMouseDown
    {
      get
      {
        return this.listViewState[134217728];
      }
      set
      {
        this.listViewState[134217728] = value;
      }
    }

    [Editor("System.Windows.Forms.Design.ListViewItemCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof (UITypeEditor))]
    [SRCategory("CatBehavior")]
    [Localizable(true)]
    [SRDescription("ListViewItemsDescr")]
    [MergableProperty(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public System.Windows.Forms.ListView.ListViewItemCollection Items
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.listItemCollection;
      }
    }

    [SRDescription("ListViewLabelEditDescr")]
    [SRCategory("CatBehavior")]
    [DefaultValue(false)]
    public bool LabelEdit
    {
      get
      {
        return this.listViewState[256];
      }
      set
      {
        if (this.LabelEdit == value)
          return;
        this.listViewState[256] = value;
        this.UpdateStyles();
      }
    }

    [Localizable(true)]
    [DefaultValue(true)]
    [SRDescription("ListViewLabelWrapDescr")]
    [SRCategory("CatBehavior")]
    public bool LabelWrap
    {
      get
      {
        return this.listViewState[512];
      }
      set
      {
        if (this.LabelWrap == value)
          return;
        this.listViewState[512] = value;
        this.UpdateStyles();
      }
    }

    [SRDescription("ListViewLargeImageListDescr")]
    [SRCategory("CatBehavior")]
    [DefaultValue(null)]
    public ImageList LargeImageList
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.imageListLarge;
      }
      set
      {
        if (value == this.imageListLarge)
          return;
        EventHandler eventHandler1 = new EventHandler(this.LargeImageListRecreateHandle);
        EventHandler eventHandler2 = new EventHandler(this.DetachImageList);
        EventHandler eventHandler3 = new EventHandler(this.LargeImageListChangedHandle);
        if (this.imageListLarge != null)
        {
          this.imageListLarge.RecreateHandle -= eventHandler1;
          this.imageListLarge.Disposed -= eventHandler2;
          this.imageListLarge.ChangeHandle -= eventHandler3;
        }
        this.imageListLarge = value;
        if (value != null)
        {
          value.RecreateHandle += eventHandler1;
          value.Disposed += eventHandler2;
          value.ChangeHandle += eventHandler3;
        }
        if (!this.IsHandleCreated)
          return;
        this.SendMessage(4099, (IntPtr) 0, value == null ? IntPtr.Zero : value.Handle);
        if (!this.AutoArrange || this.listViewState1[4])
          return;
        this.UpdateListViewItemsLocations();
      }
    }

    internal bool ListViewHandleDestroyed
    {
      get
      {
        return this.listViewState[16777216];
      }
      set
      {
        this.listViewState[16777216] = value;
      }
    }

    [SRDescription("ListViewItemSorterDescr")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [SRCategory("CatBehavior")]
    [Browsable(false)]
    public IComparer ListViewItemSorter
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.listItemSorter;
      }
      set
      {
        if (this.listItemSorter == value)
          return;
        this.listItemSorter = value;
        if (this.VirtualMode)
          return;
        this.Sort();
      }
    }

    [SRDescription("ListViewMultiSelectDescr")]
    [DefaultValue(true)]
    [SRCategory("CatBehavior")]
    public bool MultiSelect
    {
      get
      {
        return this.listViewState[1024];
      }
      set
      {
        if (this.MultiSelect == value)
          return;
        this.listViewState[1024] = value;
        this.UpdateStyles();
      }
    }

    [DefaultValue(false)]
    [SRDescription("ListViewOwnerDrawDescr")]
    [SRCategory("CatBehavior")]
    public bool OwnerDraw
    {
      get
      {
        return this.listViewState[1];
      }
      set
      {
        if (this.OwnerDraw == value)
          return;
        this.listViewState[1] = value;
        this.Invalidate(true);
      }
    }

    [Localizable(true)]
    [DefaultValue(false)]
    [SRDescription("ControlRightToLeftLayoutDescr")]
    [SRCategory("CatAppearance")]
    public virtual bool RightToLeftLayout
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.rightToLeftLayout;
      }
      set
      {
        if (value == this.rightToLeftLayout)
          return;
        this.rightToLeftLayout = value;
        using (new LayoutTransaction((Control) this, (IArrangedElement) this, PropertyNames.RightToLeftLayout))
          this.OnRightToLeftLayoutChanged(EventArgs.Empty);
      }
    }

    [DefaultValue(true)]
    [SRDescription("ListViewScrollableDescr")]
    [SRCategory("CatBehavior")]
    public bool Scrollable
    {
      get
      {
        return this.listViewState[2048];
      }
      set
      {
        if (this.Scrollable == value)
          return;
        this.listViewState[2048] = value;
        this.RecreateHandleInternal();
      }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public System.Windows.Forms.ListView.SelectedIndexCollection SelectedIndices
    {
      get
      {
        if (this.selectedIndexCollection == null)
          this.selectedIndexCollection = new System.Windows.Forms.ListView.SelectedIndexCollection(this);
        return this.selectedIndexCollection;
      }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [SRDescription("ListViewSelectedItemsDescr")]
    [SRCategory("CatAppearance")]
    public System.Windows.Forms.ListView.SelectedListViewItemCollection SelectedItems
    {
      get
      {
        if (this.selectedListViewItemCollection == null)
          this.selectedListViewItemCollection = new System.Windows.Forms.ListView.SelectedListViewItemCollection(this);
        return this.selectedListViewItemCollection;
      }
    }

    [DefaultValue(true)]
    [SRDescription("ListViewShowGroupsDescr")]
    [SRCategory("CatBehavior")]
    public bool ShowGroups
    {
      get
      {
        return this.listViewState[8388608];
      }
      set
      {
        if (value == this.ShowGroups)
          return;
        this.listViewState[8388608] = value;
        if (!this.IsHandleCreated)
          return;
        this.UpdateGroupView();
      }
    }

    [SRDescription("ListViewSmallImageListDescr")]
    [DefaultValue(null)]
    [SRCategory("CatBehavior")]
    public ImageList SmallImageList
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.imageListSmall;
      }
      set
      {
        if (this.imageListSmall == value)
          return;
        EventHandler eventHandler1 = new EventHandler(this.SmallImageListRecreateHandle);
        EventHandler eventHandler2 = new EventHandler(this.DetachImageList);
        if (this.imageListSmall != null)
        {
          this.imageListSmall.RecreateHandle -= eventHandler1;
          this.imageListSmall.Disposed -= eventHandler2;
        }
        this.imageListSmall = value;
        if (value != null)
        {
          value.RecreateHandle += eventHandler1;
          value.Disposed += eventHandler2;
        }
        if (!this.IsHandleCreated)
          return;
        this.SendMessage(4099, (IntPtr) 1, value == null ? IntPtr.Zero : value.Handle);
        if (this.View == View.SmallIcon)
        {
          this.View = View.LargeIcon;
          this.View = View.SmallIcon;
        }
        else if (!this.listViewState1[4])
          this.UpdateListViewItemsLocations();
        if (this.View != View.Details)
          return;
        this.Invalidate(true);
      }
    }

    [DefaultValue(false)]
    [SRDescription("ListViewShowItemToolTipsDescr")]
    [SRCategory("CatBehavior")]
    public bool ShowItemToolTips
    {
      get
      {
        return this.listViewState[32768];
      }
      set
      {
        if (this.ShowItemToolTips == value)
          return;
        this.listViewState[32768] = value;
        this.RecreateHandleInternal();
      }
    }

    [DefaultValue(SortOrder.None)]
    [SRDescription("ListViewSortingDescr")]
    [SRCategory("CatBehavior")]
    public SortOrder Sorting
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.sorting;
      }
      set
      {
        if (!System.Windows.Forms.ClientUtils.IsEnumValid((Enum) value, (int) value, 0, 2))
          throw new InvalidEnumArgumentException("value", (int) value, typeof (SortOrder));
        if (this.sorting == value)
          return;
        this.sorting = value;
        if (this.View == View.LargeIcon || this.View == View.SmallIcon)
        {
          if (this.listItemSorter == null)
            this.listItemSorter = (IComparer) new System.Windows.Forms.ListView.IconComparer(this.sorting);
          else if (this.listItemSorter is System.Windows.Forms.ListView.IconComparer)
            ((System.Windows.Forms.ListView.IconComparer) this.listItemSorter).SortOrder = this.sorting;
        }
        else if (value == SortOrder.None)
          this.listItemSorter = (IComparer) null;
        if (value == SortOrder.None)
          this.UpdateStyles();
        else
          this.RecreateHandleInternal();
      }
    }

    [SRDescription("ListViewStateImageListDescr")]
    [SRCategory("CatBehavior")]
    [DefaultValue(null)]
    public ImageList StateImageList
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.imageListState;
      }
      set
      {
        if (this.UseCompatibleStateImageBehavior)
        {
          if (this.imageListState == value)
            return;
          EventHandler eventHandler1 = new EventHandler(this.StateImageListRecreateHandle);
          EventHandler eventHandler2 = new EventHandler(this.DetachImageList);
          if (this.imageListState != null)
          {
            this.imageListState.RecreateHandle -= eventHandler1;
            this.imageListState.Disposed -= eventHandler2;
          }
          this.imageListState = value;
          if (value != null)
          {
            value.RecreateHandle += eventHandler1;
            value.Disposed += eventHandler2;
          }
          if (!this.IsHandleCreated)
            return;
          this.SendMessage(4099, 2, value == null ? IntPtr.Zero : value.Handle);
        }
        else
        {
          if (this.imageListState == value)
            return;
          EventHandler eventHandler1 = new EventHandler(this.StateImageListRecreateHandle);
          EventHandler eventHandler2 = new EventHandler(this.DetachImageList);
          if (this.imageListState != null)
          {
            this.imageListState.RecreateHandle -= eventHandler1;
            this.imageListState.Disposed -= eventHandler2;
          }
          if (this.IsHandleCreated && this.imageListState != null && this.CheckBoxes)
            this.SendMessage(4099, 2, IntPtr.Zero);
          this.imageListState = value;
          if (value != null)
          {
            value.RecreateHandle += eventHandler1;
            value.Disposed += eventHandler2;
          }
          if (!this.IsHandleCreated)
            return;
          if (this.CheckBoxes)
            this.RecreateHandleInternal();
          else
            this.SendMessage(4099, 2, this.imageListState == null || this.imageListState.Images.Count == 0 ? IntPtr.Zero : this.imageListState.Handle);
          if (this.listViewState1[4])
            return;
          this.UpdateListViewItemsLocations();
        }
      }
    }

    [Browsable(false)]
    [Bindable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override string Text
    {
      get
      {
        return base.Text;
      }
      set
      {
        base.Text = value;
      }
    }

    [SRCategory("CatAppearance")]
    [Browsable(true)]
    [SRDescription("ListViewTileSizeDescr")]
    public Size TileSize
    {
      get
      {
        if (!this.tileSize.IsEmpty)
          return this.tileSize;
        if (!this.IsHandleCreated)
          return Size.Empty;
        System.Windows.Forms.NativeMethods.LVTILEVIEWINFO lParam = new System.Windows.Forms.NativeMethods.LVTILEVIEWINFO();
        lParam.dwMask = 1;
        System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), 4259, 0, lParam);
        return new Size(lParam.sizeTile.cx, lParam.sizeTile.cy);
      }
      set
      {
        if (!(this.tileSize != value))
          return;
        if (value.IsEmpty || value.Height <= 0 || value.Width <= 0)
          throw new ArgumentOutOfRangeException("TileSize", System.Windows.Forms.SR.GetString("ListViewTileSizeMustBePositive"));
        this.tileSize = value;
        if (!this.IsHandleCreated)
          return;
        System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), 4258, 0, new System.Windows.Forms.NativeMethods.LVTILEVIEWINFO()
        {
          dwMask = 1,
          dwFlags = 3,
          sizeTile = new System.Windows.Forms.NativeMethods.SIZE(this.tileSize.Width, this.tileSize.Height)
        });
        if (!this.AutoArrange)
          return;
        this.UpdateListViewItemsLocations();
      }
    }

    [SRCategory("CatAppearance")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [SRDescription("ListViewTopItemDescr")]
    [Browsable(false)]
    public ListViewItem TopItem
    {
      get
      {
        if (this.viewStyle == View.LargeIcon || this.viewStyle == View.SmallIcon || this.viewStyle == View.Tile)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewGetTopItem"));
        if (!this.IsHandleCreated)
        {
          if (this.Items.Count > 0)
            return this.Items[0];
          else
            return (ListViewItem) null;
        }
        else
        {
          this.topIndex = (int) (long) this.SendMessage(4135, 0, 0);
          if (this.topIndex >= 0 && this.topIndex < this.Items.Count)
            return this.Items[this.topIndex];
          else
            return (ListViewItem) null;
        }
      }
      set
      {
        if (this.viewStyle == View.LargeIcon || this.viewStyle == View.SmallIcon || this.viewStyle == View.Tile)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewSetTopItem"));
        if (value == null || value.ListView != this)
          return;
        if (!this.IsHandleCreated)
          this.CreateHandle();
        if (value == this.TopItem)
          return;
        this.EnsureVisible(value.Index);
        ListViewItem topItem = this.TopItem;
        if (topItem == null && this.topIndex == this.Items.Count)
        {
          if (!this.Scrollable)
            return;
          this.EnsureVisible(0);
          this.Scroll(0, value.Index);
        }
        else
        {
          if (value.Index == topItem.Index || !this.Scrollable)
            return;
          this.Scroll(topItem.Index, value.Index);
        }
      }
    }

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DefaultValue(true)]
    public bool UseCompatibleStateImageBehavior
    {
      get
      {
        return this.listViewState1[8];
      }
      set
      {
        this.listViewState1[8] = value;
      }
    }

    [SRCategory("CatAppearance")]
    [SRDescription("ListViewViewDescr")]
    [DefaultValue(View.LargeIcon)]
    public View View
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.viewStyle;
      }
      set
      {
        if (value == View.Tile && this.CheckBoxes)
          throw new NotSupportedException(System.Windows.Forms.SR.GetString("ListViewTileViewDoesNotSupportCheckBoxes"));
        this.FlipViewToLargeIconAndSmallIcon = false;
        if (!System.Windows.Forms.ClientUtils.IsEnumValid((Enum) value, (int) value, 0, 4))
          throw new InvalidEnumArgumentException("value", (int) value, typeof (View));
        if (value == View.Tile && this.VirtualMode)
          throw new NotSupportedException(System.Windows.Forms.SR.GetString("ListViewCantSetViewToTileViewInVirtualMode"));
        if (this.viewStyle == value)
          return;
        this.viewStyle = value;
        if (this.IsHandleCreated && this.ComctlSupportsVisualStyles)
        {
          this.SendMessage(4238, (int) this.viewStyle, 0);
          this.UpdateGroupView();
          if (this.viewStyle == View.Tile)
            this.UpdateTileView();
        }
        else
          this.UpdateStyles();
        this.UpdateListViewItemsLocations();
      }
    }

    [SRDescription("ListViewVirtualListSizeDescr")]
    [SRCategory("CatBehavior")]
    [DefaultValue(0)]
    [RefreshProperties(RefreshProperties.Repaint)]
    public int VirtualListSize
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.virtualListSize;
      }
      set
      {
        if (value < 0)
        {
          throw new ArgumentException(System.Windows.Forms.SR.GetString("ListViewVirtualListSizeInvalidArgument", (object) "value", (object) value.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
        }
        else
        {
          if (value == this.virtualListSize)
            return;
          bool flag = this.IsHandleCreated && this.VirtualMode && this.View == View.Details && !this.DesignMode;
          int val1 = -1;
          if (flag)
            val1 = (int) (long) this.SendMessage(4135, 0, 0);
          this.virtualListSize = value;
          if (this.IsHandleCreated && this.VirtualMode && !this.DesignMode)
            this.SendMessage(4143, this.virtualListSize, 0);
          if (!flag)
            return;
          int index = Math.Min(val1, this.VirtualListSize - 1);
          if (index <= 0)
            return;
          this.TopItem = this.Items[index];
        }
      }
    }

    [SRDescription("ListViewVirtualModeDescr")]
    [SRCategory("CatBehavior")]
    [DefaultValue(false)]
    [RefreshProperties(RefreshProperties.Repaint)]
    public bool VirtualMode
    {
      get
      {
        return this.listViewState[33554432];
      }
      set
      {
        if (value == this.VirtualMode)
          return;
        if (value && this.Items.Count > 0)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewVirtualListViewRequiresNoItems"));
        if (value && this.CheckedItems.Count > 0)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewVirtualListViewRequiresNoCheckedItems"));
        if (value && this.SelectedItems.Count > 0)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewVirtualListViewRequiresNoSelectedItems"));
        if (value && this.View == View.Tile)
          throw new NotSupportedException(System.Windows.Forms.SR.GetString("ListViewCantSetVirtualModeWhenInTileView"));
        this.listViewState[33554432] = value;
        this.RecreateHandleInternal();
      }
    }

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new Padding Padding
    {
      get
      {
        return base.Padding;
      }
      set
      {
        base.Padding = value;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    public new event EventHandler BackgroundImageLayoutChanged
    {
      add
      {
        base.BackgroundImageLayoutChanged += value;
      }
      remove
      {
        base.BackgroundImageLayoutChanged -= value;
      }
    }

    [SRCategory("CatPropertyChanged")]
    [SRDescription("ControlOnRightToLeftLayoutChangedDescr")]
    public event EventHandler RightToLeftLayoutChanged
    {
      add
      {
        this.Events.AddHandler(System.Windows.Forms.ListView.EVENT_RIGHTTOLEFTLAYOUTCHANGED, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(System.Windows.Forms.ListView.EVENT_RIGHTTOLEFTLAYOUTCHANGED, (Delegate) value);
      }
    }

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public new event EventHandler TextChanged
    {
      add
      {
        base.TextChanged += value;
      }
      remove
      {
        base.TextChanged -= value;
      }
    }

    [SRCategory("CatBehavior")]
    [SRDescription("ListViewAfterLabelEditDescr")]
    public event LabelEditEventHandler AfterLabelEdit
    {
      add
      {
        this.onAfterLabelEdit += value;
      }
      remove
      {
        this.onAfterLabelEdit -= value;
      }
    }

    [SRDescription("ListViewBeforeLabelEditDescr")]
    [SRCategory("CatBehavior")]
    public event LabelEditEventHandler BeforeLabelEdit
    {
      add
      {
        this.onBeforeLabelEdit += value;
      }
      remove
      {
        this.onBeforeLabelEdit -= value;
      }
    }

    [SRCategory("CatAction")]
    [SRDescription("ListViewCacheVirtualItemsEventDescr")]
    public event CacheVirtualItemsEventHandler CacheVirtualItems
    {
      add
      {
        this.Events.AddHandler(System.Windows.Forms.ListView.EVENT_CACHEVIRTUALITEMS, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(System.Windows.Forms.ListView.EVENT_CACHEVIRTUALITEMS, (Delegate) value);
      }
    }

    [SRDescription("ListViewColumnClickDescr")]
    [SRCategory("CatAction")]
    public event ColumnClickEventHandler ColumnClick
    {
      add
      {
        this.onColumnClick += value;
      }
      remove
      {
        this.onColumnClick -= value;
      }
    }

    [SRDescription("ListViewColumnReorderedDscr")]
    [SRCategory("CatPropertyChanged")]
    public event ColumnReorderedEventHandler ColumnReordered
    {
      add
      {
        this.Events.AddHandler(System.Windows.Forms.ListView.EVENT_COLUMNREORDERED, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(System.Windows.Forms.ListView.EVENT_COLUMNREORDERED, (Delegate) value);
      }
    }

    [SRDescription("ListViewColumnWidthChangedDscr")]
    [SRCategory("CatPropertyChanged")]
    public event ColumnWidthChangedEventHandler ColumnWidthChanged
    {
      add
      {
        this.Events.AddHandler(System.Windows.Forms.ListView.EVENT_COLUMNWIDTHCHANGED, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(System.Windows.Forms.ListView.EVENT_COLUMNWIDTHCHANGED, (Delegate) value);
      }
    }

    [SRCategory("CatPropertyChanged")]
    [SRDescription("ListViewColumnWidthChangingDscr")]
    public event ColumnWidthChangingEventHandler ColumnWidthChanging
    {
      add
      {
        this.Events.AddHandler(System.Windows.Forms.ListView.EVENT_COLUMNWIDTHCHANGING, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(System.Windows.Forms.ListView.EVENT_COLUMNWIDTHCHANGING, (Delegate) value);
      }
    }

    [SRCategory("CatBehavior")]
    [SRDescription("ListViewDrawColumnHeaderEventDescr")]
    public event DrawListViewColumnHeaderEventHandler DrawColumnHeader
    {
      add
      {
        this.Events.AddHandler(System.Windows.Forms.ListView.EVENT_DRAWCOLUMNHEADER, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(System.Windows.Forms.ListView.EVENT_DRAWCOLUMNHEADER, (Delegate) value);
      }
    }

    [SRCategory("CatBehavior")]
    [SRDescription("ListViewDrawItemEventDescr")]
    public event DrawListViewItemEventHandler DrawItem
    {
      add
      {
        this.Events.AddHandler(System.Windows.Forms.ListView.EVENT_DRAWITEM, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(System.Windows.Forms.ListView.EVENT_DRAWITEM, (Delegate) value);
      }
    }

    [SRCategory("CatBehavior")]
    [SRDescription("ListViewDrawSubItemEventDescr")]
    public event DrawListViewSubItemEventHandler DrawSubItem
    {
      add
      {
        this.Events.AddHandler(System.Windows.Forms.ListView.EVENT_DRAWSUBITEM, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(System.Windows.Forms.ListView.EVENT_DRAWSUBITEM, (Delegate) value);
      }
    }

    [SRDescription("ListViewItemClickDescr")]
    [SRCategory("CatAction")]
    public event EventHandler ItemActivate
    {
      add
      {
        this.onItemActivate += value;
      }
      remove
      {
        this.onItemActivate -= value;
      }
    }

    [SRCategory("CatBehavior")]
    [SRDescription("CheckedListBoxItemCheckDescr")]
    public event ItemCheckEventHandler ItemCheck
    {
      add
      {
        this.onItemCheck += value;
      }
      remove
      {
        this.onItemCheck -= value;
      }
    }

    [SRDescription("ListViewItemCheckedDescr")]
    [SRCategory("CatBehavior")]
    public event ItemCheckedEventHandler ItemChecked
    {
      add
      {
        this.onItemChecked += value;
      }
      remove
      {
        this.onItemChecked -= value;
      }
    }

    [SRCategory("CatAction")]
    [SRDescription("ListViewItemDragDescr")]
    public event ItemDragEventHandler ItemDrag
    {
      add
      {
        this.onItemDrag += value;
      }
      remove
      {
        this.onItemDrag -= value;
      }
    }

    [SRCategory("CatAction")]
    [SRDescription("ListViewItemMouseHoverDescr")]
    public event ListViewItemMouseHoverEventHandler ItemMouseHover
    {
      add
      {
        this.onItemMouseHover += value;
      }
      remove
      {
        this.onItemMouseHover -= value;
      }
    }

    [SRDescription("ListViewItemSelectionChangedDescr")]
    [SRCategory("CatBehavior")]
    public event ListViewItemSelectionChangedEventHandler ItemSelectionChanged
    {
      add
      {
        this.Events.AddHandler(System.Windows.Forms.ListView.EVENT_ITEMSELECTIONCHANGED, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(System.Windows.Forms.ListView.EVENT_ITEMSELECTIONCHANGED, (Delegate) value);
      }
    }

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public new event EventHandler PaddingChanged
    {
      add
      {
        base.PaddingChanged += value;
      }
      remove
      {
        base.PaddingChanged -= value;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    public new event PaintEventHandler Paint
    {
      add
      {
        base.Paint += value;
      }
      remove
      {
        base.Paint -= value;
      }
    }

    [SRDescription("ListViewRetrieveVirtualItemEventDescr")]
    [SRCategory("CatAction")]
    public event RetrieveVirtualItemEventHandler RetrieveVirtualItem
    {
      add
      {
        this.Events.AddHandler(System.Windows.Forms.ListView.EVENT_RETRIEVEVIRTUALITEM, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(System.Windows.Forms.ListView.EVENT_RETRIEVEVIRTUALITEM, (Delegate) value);
      }
    }

    [SRDescription("ListViewSearchForVirtualItemDescr")]
    [SRCategory("CatAction")]
    public event SearchForVirtualItemEventHandler SearchForVirtualItem
    {
      add
      {
        this.Events.AddHandler(System.Windows.Forms.ListView.EVENT_SEARCHFORVIRTUALITEM, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(System.Windows.Forms.ListView.EVENT_SEARCHFORVIRTUALITEM, (Delegate) value);
      }
    }

    [SRDescription("ListViewSelectedIndexChangedDescr")]
    [SRCategory("CatBehavior")]
    public event EventHandler SelectedIndexChanged
    {
      add
      {
        this.Events.AddHandler(System.Windows.Forms.ListView.EVENT_SELECTEDINDEXCHANGED, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(System.Windows.Forms.ListView.EVENT_SELECTEDINDEXCHANGED, (Delegate) value);
      }
    }

    [SRCategory("CatBehavior")]
    [SRDescription("ListViewVirtualItemsSelectionRangeChangedDescr")]
    public event ListViewVirtualItemsSelectionRangeChangedEventHandler VirtualItemsSelectionRangeChanged
    {
      add
      {
        this.Events.AddHandler(System.Windows.Forms.ListView.EVENT_VIRTUALITEMSSELECTIONRANGECHANGED, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(System.Windows.Forms.ListView.EVENT_VIRTUALITEMSSELECTIONRANGECHANGED, (Delegate) value);
      }
    }

    static ListView()
    {
    }

    public ListView()
    {
      this.listViewState = new BitVector32(8392260);
      this.listViewState1 = new BitVector32(8);
      this.SetStyle(ControlStyles.UserPaint, false);
      this.SetStyle(ControlStyles.StandardClick, false);
      this.SetStyle(ControlStyles.UseTextForAccessibility, false);
      this.odCacheFont = this.Font;
      this.odCacheFontHandle = this.FontHandle;
      this.SetBounds(0, 0, 121, 97);
      this.listItemCollection = new System.Windows.Forms.ListView.ListViewItemCollection((System.Windows.Forms.ListView.ListViewItemCollection.IInnerList) new System.Windows.Forms.ListView.ListViewNativeItemCollection(this));
      this.columnHeaderCollection = new System.Windows.Forms.ListView.ColumnHeaderCollection(this);
    }

    public void ArrangeIcons(ListViewAlignment value)
    {
      if (this.viewStyle != View.SmallIcon)
        return;
      switch (value)
      {
        case ListViewAlignment.Default:
        case ListViewAlignment.Left:
        case ListViewAlignment.Top:
        case ListViewAlignment.SnapToGrid:
          if (this.IsHandleCreated)
            System.Windows.Forms.UnsafeNativeMethods.PostMessage(new HandleRef((object) this, this.Handle), 4118, (int) value, 0);
          if (this.VirtualMode || this.sorting == SortOrder.None)
            break;
          this.Sort();
          break;
        default:
          throw new ArgumentException(System.Windows.Forms.SR.GetString("InvalidArgument", (object) "value", (object) ((object) value).ToString()));
      }
    }

    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public void ArrangeIcons()
    {
      this.ArrangeIcons(ListViewAlignment.Default);
    }

    public void AutoResizeColumns(ColumnHeaderAutoResizeStyle headerAutoResize)
    {
      if (!this.IsHandleCreated)
        this.CreateHandle();
      this.UpdateColumnWidths(headerAutoResize);
    }

    public void AutoResizeColumn(int columnIndex, ColumnHeaderAutoResizeStyle headerAutoResize)
    {
      if (!this.IsHandleCreated)
        this.CreateHandle();
      this.SetColumnWidth(columnIndex, headerAutoResize);
    }

    public void BeginUpdate()
    {
      this.BeginUpdateInternal();
      if (this.updateCounter++ != 0 || this.Properties.GetObject(System.Windows.Forms.ListView.PropDelayedUpdateItems) != null)
        return;
      this.Properties.SetObject(System.Windows.Forms.ListView.PropDelayedUpdateItems, (object) new ArrayList());
    }

    public void Clear()
    {
      this.Items.Clear();
      this.Columns.Clear();
    }

    protected override void CreateHandle()
    {
      if (!this.RecreatingHandle)
      {
        IntPtr userCookie = System.Windows.Forms.UnsafeNativeMethods.ThemingScope.Activate();
        try
        {
          System.Windows.Forms.SafeNativeMethods.InitCommonControlsEx(new System.Windows.Forms.NativeMethods.INITCOMMONCONTROLSEX()
          {
            dwICC = 1
          });
        }
        finally
        {
          System.Windows.Forms.UnsafeNativeMethods.ThemingScope.Deactivate(userCookie);
        }
      }
      base.CreateHandle();
      if (this.BackgroundImage == null)
        return;
      this.SetBackgroundImage();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        if (this.imageListSmall != null)
        {
          this.imageListSmall.Disposed -= new EventHandler(this.DetachImageList);
          this.imageListSmall = (ImageList) null;
        }
        if (this.imageListLarge != null)
        {
          this.imageListLarge.Disposed -= new EventHandler(this.DetachImageList);
          this.imageListLarge = (ImageList) null;
        }
        if (this.imageListState != null)
        {
          this.imageListState.Disposed -= new EventHandler(this.DetachImageList);
          this.imageListState = (ImageList) null;
        }
        if (this.columnHeaders != null)
        {
          for (int index = this.columnHeaders.Length - 1; index >= 0; --index)
          {
            this.columnHeaders[index].OwnerListview = (System.Windows.Forms.ListView) null;
            this.columnHeaders[index].Dispose();
          }
          this.columnHeaders = (ColumnHeader[]) null;
        }
        this.Items.Clear();
        if (this.odCacheFontHandleWrapper != null)
        {
          this.odCacheFontHandleWrapper.Dispose();
          this.odCacheFontHandleWrapper = (Control.FontHandleWrapper) null;
        }
        if (!string.IsNullOrEmpty(this.backgroundImageFileName) || this.bkImgFileNames != null)
        {
          new FileIOPermission(PermissionState.Unrestricted).Assert();
          try
          {
            if (!string.IsNullOrEmpty(this.backgroundImageFileName))
            {
              FileInfo fileInfo = new FileInfo(this.backgroundImageFileName);
              try
              {
                fileInfo.Delete();
              }
              catch (IOException ex)
              {
              }
              this.backgroundImageFileName = string.Empty;
            }
            for (int index = 0; index <= this.bkImgFileNamesCount; ++index)
            {
              FileInfo fileInfo = new FileInfo(this.bkImgFileNames[index]);
              try
              {
                fileInfo.Delete();
              }
              catch (IOException ex)
              {
              }
            }
            this.bkImgFileNames = (string[]) null;
            this.bkImgFileNamesCount = -1;
          }
          finally
          {
            PermissionSet.RevertAssert();
          }
        }
      }
      base.Dispose(disposing);
    }

    public void EndUpdate()
    {
      if (--this.updateCounter == 0 && this.Properties.GetObject(System.Windows.Forms.ListView.PropDelayedUpdateItems) != null)
        this.ApplyUpdateCachedItems();
      this.EndUpdateInternal();
    }

    public void EnsureVisible(int index)
    {
      if (index < 0 || index >= this.Items.Count)
      {
        throw new ArgumentOutOfRangeException("index", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "index", (object) index.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
      }
      else
      {
        if (!this.IsHandleCreated)
          return;
        System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), 4115, index, 0);
      }
    }

    public ListViewItem FindItemWithText(string text)
    {
      if (this.Items.Count == 0)
        return (ListViewItem) null;
      else
        return this.FindItemWithText(text, true, 0, true);
    }

    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public ListViewItem FindItemWithText(string text, bool includeSubItemsInSearch, int startIndex)
    {
      return this.FindItemWithText(text, includeSubItemsInSearch, startIndex, true);
    }

    public ListViewItem FindItemWithText(string text, bool includeSubItemsInSearch, int startIndex, bool isPrefixSearch)
    {
      if (startIndex >= 0 && startIndex < this.Items.Count)
        return this.FindItem(true, text, isPrefixSearch, new Point(0, 0), SearchDirectionHint.Down, startIndex, includeSubItemsInSearch);
      throw new ArgumentOutOfRangeException("startIndex", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "startIndex", (object) startIndex.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
    }

    public ListViewItem FindNearestItem(SearchDirectionHint dir, Point point)
    {
      return this.FindNearestItem(dir, point.X, point.Y);
    }

    public ListViewItem FindNearestItem(SearchDirectionHint searchDirection, int x, int y)
    {
      if (this.View != View.SmallIcon && this.View != View.LargeIcon)
        throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewFindNearestItemWorksOnlyInIconView"));
      if (searchDirection < SearchDirectionHint.Left || searchDirection > SearchDirectionHint.Down)
      {
        throw new ArgumentOutOfRangeException("searchDirection", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "searchDirection", (object) ((object) searchDirection).ToString()));
      }
      else
      {
        ListViewItem itemAt = this.GetItemAt(x, y);
        if (itemAt != null)
        {
          Rectangle bounds = itemAt.Bounds;
          Rectangle itemRect = this.GetItemRect(itemAt.Index, ItemBoundsPortion.Icon);
          switch (searchDirection)
          {
            case SearchDirectionHint.Left:
              x = Math.Max(bounds.Left, itemRect.Left) - 1;
              break;
            case SearchDirectionHint.Up:
              y = Math.Max(bounds.Top, itemRect.Top) - 1;
              break;
            case SearchDirectionHint.Right:
              x = Math.Max(bounds.Left, itemRect.Left) + 1;
              break;
            case SearchDirectionHint.Down:
              y = Math.Max(bounds.Top, itemRect.Top) + 1;
              break;
          }
        }
        return this.FindItem(false, string.Empty, false, new Point(x, y), searchDirection, -1, false);
      }
    }

    public ListViewItem GetItemAt(int x, int y)
    {
      System.Windows.Forms.NativeMethods.LVHITTESTINFO lParam = new System.Windows.Forms.NativeMethods.LVHITTESTINFO();
      lParam.pt_x = x;
      lParam.pt_y = y;
      int index = (int) System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), 4114, 0, lParam);
      ListViewItem listViewItem = (ListViewItem) null;
      if (index >= 0 && (lParam.flags & 14) != 0)
        listViewItem = this.Items[index];
      return listViewItem;
    }

    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public Rectangle GetItemRect(int index)
    {
      return this.GetItemRect(index, ItemBoundsPortion.Entire);
    }

    public Rectangle GetItemRect(int index, ItemBoundsPortion portion)
    {
      if (index < 0 || index >= this.Items.Count)
      {
        throw new ArgumentOutOfRangeException("index", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "index", (object) index.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
      }
      else
      {
        if (!System.Windows.Forms.ClientUtils.IsEnumValid((Enum) portion, (int) portion, 0, 3))
          throw new InvalidEnumArgumentException("portion", (int) portion, typeof (ItemBoundsPortion));
        if (this.View == View.Details && this.Columns.Count == 0)
          return Rectangle.Empty;
        System.Windows.Forms.NativeMethods.RECT lparam = new System.Windows.Forms.NativeMethods.RECT();
        lparam.left = (int) portion;
        if ((int) (long) this.SendMessage(4110, index, ref lparam) != 0)
          return Rectangle.FromLTRB(lparam.left, lparam.top, lparam.right, lparam.bottom);
        throw new ArgumentException(System.Windows.Forms.SR.GetString("InvalidArgument", (object) "index", (object) index.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
      }
    }

    public ListViewHitTestInfo HitTest(Point point)
    {
      return this.HitTest(point.X, point.Y);
    }

    public ListViewHitTestInfo HitTest(int x, int y)
    {
      if (!this.ClientRectangle.Contains(x, y))
        return new ListViewHitTestInfo((ListViewItem) null, (ListViewItem.ListViewSubItem) null, ListViewHitTestLocations.None);
      System.Windows.Forms.NativeMethods.LVHITTESTINFO lParam = new System.Windows.Forms.NativeMethods.LVHITTESTINFO();
      lParam.pt_x = x;
      lParam.pt_y = y;
      int index = this.View != View.Details ? (int) (long) System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), 4114, 0, lParam) : (int) (long) System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), 4153, 0, lParam);
      ListViewItem hitItem = index == -1 ? (ListViewItem) null : this.Items[index];
      ListViewHitTestLocations hitLocation = hitItem != null || (8 & lParam.flags) != 8 ? (hitItem == null || (8 & lParam.flags) != 8 ? (ListViewHitTestLocations) lParam.flags : (ListViewHitTestLocations) (247 & lParam.flags | 512)) : (ListViewHitTestLocations) (247 & lParam.flags | 256);
      if (this.View != View.Details || hitItem == null)
        return new ListViewHitTestInfo(hitItem, (ListViewItem.ListViewSubItem) null, hitLocation);
      if (lParam.iSubItem < hitItem.SubItems.Count)
        return new ListViewHitTestInfo(hitItem, hitItem.SubItems[lParam.iSubItem], hitLocation);
      else
        return new ListViewHitTestInfo(hitItem, (ListViewItem.ListViewSubItem) null, hitLocation);
    }

    protected override bool IsInputKey(Keys keyData)
    {
      if ((keyData & Keys.Alt) == Keys.Alt)
        return false;
      switch (keyData & Keys.KeyCode)
      {
        case Keys.Prior:
        case Keys.Next:
        case Keys.End:
        case Keys.Home:
          return true;
        default:
          if (base.IsInputKey(keyData))
            return true;
          if (this.listViewState[16384])
          {
            switch (keyData & Keys.KeyCode)
            {
              case Keys.Return:
              case Keys.Escape:
                return true;
            }
          }
          return false;
      }
    }

    protected virtual void OnAfterLabelEdit(LabelEditEventArgs e)
    {
      if (this.onAfterLabelEdit == null)
        return;
      this.onAfterLabelEdit((object) this, e);
    }

    protected override void OnBackgroundImageChanged(EventArgs e)
    {
      if (this.IsHandleCreated)
        this.SetBackgroundImage();
      base.OnBackgroundImageChanged(e);
    }

    protected override void OnMouseLeave(EventArgs e)
    {
      this.hoveredAlready = false;
      base.OnMouseLeave(e);
    }

    protected override void OnMouseHover(EventArgs e)
    {
      ListViewItem listViewItem = (ListViewItem) null;
      if (this.Items.Count > 0)
      {
        Point point = this.PointToClientInternal(Cursor.Position);
        listViewItem = this.GetItemAt(point.X, point.Y);
      }
      if (listViewItem != this.prevHoveredItem && listViewItem != null)
      {
        this.OnItemMouseHover(new ListViewItemMouseHoverEventArgs(listViewItem));
        this.prevHoveredItem = listViewItem;
      }
      if (!this.hoveredAlready)
      {
        base.OnMouseHover(e);
        this.hoveredAlready = true;
      }
      this.ResetMouseEventArgs();
    }

    protected virtual void OnBeforeLabelEdit(LabelEditEventArgs e)
    {
      if (this.onBeforeLabelEdit == null)
        return;
      this.onBeforeLabelEdit((object) this, e);
    }

    protected virtual void OnCacheVirtualItems(CacheVirtualItemsEventArgs e)
    {
      CacheVirtualItemsEventHandler itemsEventHandler = (CacheVirtualItemsEventHandler) this.Events[System.Windows.Forms.ListView.EVENT_CACHEVIRTUALITEMS];
      if (itemsEventHandler == null)
        return;
      itemsEventHandler((object) this, e);
    }

    protected virtual void OnColumnClick(ColumnClickEventArgs e)
    {
      if (this.onColumnClick == null)
        return;
      this.onColumnClick((object) this, e);
    }

    protected virtual void OnColumnReordered(ColumnReorderedEventArgs e)
    {
      ColumnReorderedEventHandler reorderedEventHandler = (ColumnReorderedEventHandler) this.Events[System.Windows.Forms.ListView.EVENT_COLUMNREORDERED];
      if (reorderedEventHandler == null)
        return;
      reorderedEventHandler((object) this, e);
    }

    protected virtual void OnColumnWidthChanged(ColumnWidthChangedEventArgs e)
    {
      ColumnWidthChangedEventHandler changedEventHandler = (ColumnWidthChangedEventHandler) this.Events[System.Windows.Forms.ListView.EVENT_COLUMNWIDTHCHANGED];
      if (changedEventHandler == null)
        return;
      changedEventHandler((object) this, e);
    }

    protected virtual void OnColumnWidthChanging(ColumnWidthChangingEventArgs e)
    {
      ColumnWidthChangingEventHandler changingEventHandler = (ColumnWidthChangingEventHandler) this.Events[System.Windows.Forms.ListView.EVENT_COLUMNWIDTHCHANGING];
      if (changingEventHandler == null)
        return;
      changingEventHandler((object) this, e);
    }

    protected virtual void OnDrawColumnHeader(DrawListViewColumnHeaderEventArgs e)
    {
      DrawListViewColumnHeaderEventHandler headerEventHandler = (DrawListViewColumnHeaderEventHandler) this.Events[System.Windows.Forms.ListView.EVENT_DRAWCOLUMNHEADER];
      if (headerEventHandler == null)
        return;
      headerEventHandler((object) this, e);
    }

    protected virtual void OnDrawItem(DrawListViewItemEventArgs e)
    {
      DrawListViewItemEventHandler itemEventHandler = (DrawListViewItemEventHandler) this.Events[System.Windows.Forms.ListView.EVENT_DRAWITEM];
      if (itemEventHandler == null)
        return;
      itemEventHandler((object) this, e);
    }

    protected virtual void OnDrawSubItem(DrawListViewSubItemEventArgs e)
    {
      DrawListViewSubItemEventHandler itemEventHandler = (DrawListViewSubItemEventHandler) this.Events[System.Windows.Forms.ListView.EVENT_DRAWSUBITEM];
      if (itemEventHandler == null)
        return;
      itemEventHandler((object) this, e);
    }

    protected override void OnFontChanged(EventArgs e)
    {
      base.OnFontChanged(e);
      if (!this.VirtualMode && this.IsHandleCreated && this.AutoArrange)
      {
        this.BeginUpdate();
        try
        {
          this.SendMessage(4138, -1, 0);
        }
        finally
        {
          this.EndUpdate();
        }
      }
      this.InvalidateColumnHeaders();
    }

    protected override void OnHandleCreated(EventArgs e)
    {
      this.listViewState[4194304] = false;
      this.FlipViewToLargeIconAndSmallIcon = false;
      base.OnHandleCreated(e);
      if ((int) (long) this.SendMessage(8200, 0, 0) < 5)
        this.SendMessage(8199, 5, 0);
      this.UpdateExtendedStyles();
      this.RealizeProperties();
      this.SendMessage(4097, 0, ColorTranslator.ToWin32(this.BackColor));
      this.SendMessage(4132, 0, ColorTranslator.ToWin32(base.ForeColor));
      this.SendMessage(4134, 0, -1);
      if (!this.Scrollable)
        System.Windows.Forms.UnsafeNativeMethods.SetWindowLong(new HandleRef((object) this, this.Handle), -16, new HandleRef((object) null, (IntPtr) ((int) (long) System.Windows.Forms.UnsafeNativeMethods.GetWindowLong(new HandleRef((object) this, this.Handle), -16) | 8192)));
      if (this.VirtualMode)
        System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), 4107, (int) (long) System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), 4106, 0, 0) | 61440, 0);
      if (this.ComctlSupportsVisualStyles)
      {
        this.SendMessage(4238, (int) this.viewStyle, 0);
        this.UpdateGroupView();
        if (this.groups != null)
        {
          for (int index = 0; index < this.groups.Count; ++index)
            this.InsertGroupNative(index, this.groups[index]);
        }
        if (this.viewStyle == View.Tile)
          this.UpdateTileView();
      }
      this.ListViewHandleDestroyed = false;
      ListViewItem[] items = (ListViewItem[]) null;
      if (this.listItemsArray != null)
      {
        items = (ListViewItem[]) this.listItemsArray.ToArray(typeof (ListViewItem));
        this.listItemsArray = (ArrayList) null;
      }
      int num = this.columnHeaders == null ? 0 : this.columnHeaders.Length;
      if (num > 0)
      {
        int[] indices = new int[this.columnHeaders.Length];
        int index = 0;
        foreach (ColumnHeader ch in this.columnHeaders)
        {
          indices[index] = ch.DisplayIndex;
          this.InsertColumnNative(index++, ch);
        }
        this.SetDisplayIndices(indices);
      }
      if (this.itemCount > 0 && items != null)
        this.InsertItemsNative(0, items);
      if (this.VirtualMode && this.VirtualListSize > -1 && !this.DesignMode)
        this.SendMessage(4143, this.VirtualListSize, 0);
      if (num > 0)
        this.UpdateColumnWidths(ColumnHeaderAutoResizeStyle.None);
      this.ArrangeIcons(this.alignStyle);
      this.UpdateListViewItemsLocations();
      if (!this.VirtualMode)
        this.Sort();
      if (this.ComctlSupportsVisualStyles && this.InsertionMark.Index > 0)
        this.InsertionMark.UpdateListView();
      this.savedCheckedItems = (List<ListViewItem>) null;
      if (this.CheckBoxes || this.VirtualMode)
        return;
      for (int index = 0; index < this.Items.Count; ++index)
      {
        if (this.Items[index].Checked)
          this.UpdateSavedCheckedItems(this.Items[index], true);
      }
    }

    protected override void OnHandleDestroyed(EventArgs e)
    {
      if (!this.Disposing && !this.VirtualMode)
      {
        int count = this.Items.Count;
        for (int displayIndex = 0; displayIndex < count; ++displayIndex)
          this.Items[displayIndex].UpdateStateFromListView(displayIndex, true);
        if (this.SelectedItems != null && !this.VirtualMode)
        {
          ListViewItem[] listViewItemArray = new ListViewItem[this.SelectedItems.Count];
          this.SelectedItems.CopyTo((Array) listViewItemArray, 0);
          this.savedSelectedItems = new List<ListViewItem>(listViewItemArray.Length);
          for (int index = 0; index < listViewItemArray.Length; ++index)
            this.savedSelectedItems.Add(listViewItemArray[index]);
        }
        ListViewItem[] listViewItemArray1 = (ListViewItem[]) null;
        System.Windows.Forms.ListView.ListViewItemCollection items = this.Items;
        if (items != null)
        {
          listViewItemArray1 = new ListViewItem[items.Count];
          items.CopyTo((Array) listViewItemArray1, 0);
        }
        if (listViewItemArray1 != null)
        {
          this.listItemsArray = new ArrayList(listViewItemArray1.Length);
          this.listItemsArray.AddRange((ICollection) listViewItemArray1);
        }
        this.ListViewHandleDestroyed = true;
      }
      base.OnHandleDestroyed(e);
    }

    protected virtual void OnItemActivate(EventArgs e)
    {
      if (this.onItemActivate == null)
        return;
      this.onItemActivate((object) this, e);
    }

    protected virtual void OnItemCheck(ItemCheckEventArgs ice)
    {
      if (this.onItemCheck == null)
        return;
      this.onItemCheck((object) this, ice);
    }

    protected virtual void OnItemChecked(ItemCheckedEventArgs e)
    {
      if (this.onItemChecked == null)
        return;
      this.onItemChecked((object) this, e);
    }

    protected virtual void OnItemDrag(ItemDragEventArgs e)
    {
      if (this.onItemDrag == null)
        return;
      this.onItemDrag((object) this, e);
    }

    protected virtual void OnItemMouseHover(ListViewItemMouseHoverEventArgs e)
    {
      if (this.onItemMouseHover == null)
        return;
      this.onItemMouseHover((object) this, e);
    }

    protected virtual void OnItemSelectionChanged(ListViewItemSelectionChangedEventArgs e)
    {
      ListViewItemSelectionChangedEventHandler changedEventHandler = (ListViewItemSelectionChangedEventHandler) this.Events[System.Windows.Forms.ListView.EVENT_ITEMSELECTIONCHANGED];
      if (changedEventHandler == null)
        return;
      changedEventHandler((object) this, e);
    }

    protected override void OnParentChanged(EventArgs e)
    {
      base.OnParentChanged(e);
      if (!this.IsHandleCreated)
        return;
      this.RecreateHandleInternal();
    }

    protected override void OnResize(EventArgs e)
    {
      if (this.View == View.Details && !this.Scrollable && this.IsHandleCreated)
        this.PositionHeader();
      base.OnResize(e);
    }

    protected virtual void OnRetrieveVirtualItem(RetrieveVirtualItemEventArgs e)
    {
      RetrieveVirtualItemEventHandler itemEventHandler = (RetrieveVirtualItemEventHandler) this.Events[System.Windows.Forms.ListView.EVENT_RETRIEVEVIRTUALITEM];
      if (itemEventHandler == null)
        return;
      itemEventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnRightToLeftLayoutChanged(EventArgs e)
    {
      if (this.GetAnyDisposingInHierarchy())
        return;
      if (this.RightToLeft == RightToLeft.Yes)
        this.RecreateHandleInternal();
      EventHandler eventHandler = this.Events[System.Windows.Forms.ListView.EVENT_RIGHTTOLEFTLAYOUTCHANGED] as EventHandler;
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    protected virtual void OnSearchForVirtualItem(SearchForVirtualItemEventArgs e)
    {
      SearchForVirtualItemEventHandler itemEventHandler = (SearchForVirtualItemEventHandler) this.Events[System.Windows.Forms.ListView.EVENT_SEARCHFORVIRTUALITEM];
      if (itemEventHandler == null)
        return;
      itemEventHandler((object) this, e);
    }

    protected virtual void OnSelectedIndexChanged(EventArgs e)
    {
      EventHandler eventHandler = (EventHandler) this.Events[System.Windows.Forms.ListView.EVENT_SELECTEDINDEXCHANGED];
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    protected override void OnSystemColorsChanged(EventArgs e)
    {
      base.OnSystemColorsChanged(e);
      if (!this.IsHandleCreated)
        return;
      this.SendMessage(4097, 0, ColorTranslator.ToWin32(this.BackColor));
      this.SendMessage(4134, 0, -1);
    }

    protected virtual void OnVirtualItemsSelectionRangeChanged(ListViewVirtualItemsSelectionRangeChangedEventArgs e)
    {
      ListViewVirtualItemsSelectionRangeChangedEventHandler changedEventHandler = (ListViewVirtualItemsSelectionRangeChangedEventHandler) this.Events[System.Windows.Forms.ListView.EVENT_VIRTUALITEMSSELECTIONRANGECHANGED];
      if (changedEventHandler == null)
        return;
      changedEventHandler((object) this, e);
    }

    protected void RealizeProperties()
    {
      Color backColor = this.BackColor;
      if (backColor != SystemColors.Window)
        this.SendMessage(4097, 0, ColorTranslator.ToWin32(backColor));
      Color foreColor = this.ForeColor;
      if (foreColor != SystemColors.WindowText)
        this.SendMessage(4132, 0, ColorTranslator.ToWin32(foreColor));
      if (this.imageListLarge != null)
        this.SendMessage(4099, 0, this.imageListLarge.Handle);
      if (this.imageListSmall != null)
        this.SendMessage(4099, 1, this.imageListSmall.Handle);
      if (this.imageListState == null)
        return;
      this.SendMessage(4099, 2, this.imageListState.Handle);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public void RedrawItems(int startIndex, int endIndex, bool invalidateOnly)
    {
      if (this.VirtualMode)
      {
        if (startIndex < 0 || startIndex >= this.VirtualListSize)
          throw new ArgumentOutOfRangeException("startIndex", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "startIndex", (object) startIndex.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
        else if (endIndex < 0 || endIndex >= this.VirtualListSize)
          throw new ArgumentOutOfRangeException("endIndex", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "endIndex", (object) endIndex.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
      }
      else if (startIndex < 0 || startIndex >= this.Items.Count)
        throw new ArgumentOutOfRangeException("startIndex", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "startIndex", (object) startIndex.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
      else if (endIndex < 0 || endIndex >= this.Items.Count)
        throw new ArgumentOutOfRangeException("endIndex", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "endIndex", (object) endIndex.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
      if (startIndex > endIndex)
        throw new ArgumentException(System.Windows.Forms.SR.GetString("ListViewStartIndexCannotBeLargerThanEndIndex"));
      if (!this.IsHandleCreated)
        return;
      int num = (int) System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), 4117, startIndex, endIndex);
      if (this.View == View.LargeIcon || this.View == View.SmallIcon)
      {
        Rectangle rectangle = this.Items[startIndex].Bounds;
        for (int index = startIndex + 1; index <= endIndex; ++index)
          rectangle = Rectangle.Union(rectangle, this.Items[index].Bounds);
        if (startIndex > 0)
        {
          rectangle = Rectangle.Union(rectangle, this.Items[startIndex - 1].Bounds);
        }
        else
        {
          rectangle.Width += rectangle.X;
          rectangle.Height += rectangle.Y;
          rectangle.X = rectangle.Y = 0;
        }
        if (endIndex < this.Items.Count - 1)
        {
          rectangle = Rectangle.Union(rectangle, this.Items[endIndex + 1].Bounds);
        }
        else
        {
          rectangle.Height += this.ClientRectangle.Bottom - rectangle.Bottom;
          rectangle.Width += this.ClientRectangle.Right - rectangle.Right;
        }
        if (this.View == View.LargeIcon)
          rectangle.Inflate(1, this.Font.Height + 1);
        this.Invalidate(rectangle);
      }
      if (invalidateOnly)
        return;
      this.Update();
    }

    public void Sort()
    {
      if (this.VirtualMode)
        throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewSortNotAllowedInVirtualListView"));
      this.ApplyUpdateCachedItems();
      if (!this.IsHandleCreated || this.listItemSorter == null)
        return;
      System.Windows.Forms.NativeMethods.ListViewCompareCallback pfnCompare = new System.Windows.Forms.NativeMethods.ListViewCompareCallback(this.CompareFunc);
      System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), 4144, IntPtr.Zero, pfnCompare);
    }

    public override string ToString()
    {
      string str1 = base.ToString();
      if (this.listItemsArray != null)
      {
        str1 = str1 + ", Items.Count: " + this.listItemsArray.Count.ToString((IFormatProvider) CultureInfo.CurrentCulture);
        if (this.listItemsArray.Count > 0)
        {
          string str2 = this.listItemsArray[0].ToString();
          string str3 = str2.Length > 40 ? str2.Substring(0, 40) : str2;
          str1 = str1 + ", Items[0]: " + str3;
        }
      }
      else if (this.Items != null)
      {
        str1 = str1 + ", Items.Count: " + this.Items.Count.ToString((IFormatProvider) CultureInfo.CurrentCulture);
        if (this.Items.Count > 0 && !this.VirtualMode)
        {
          string str2 = this.Items[0] == null ? "null" : this.Items[0].ToString();
          string str3 = str2.Length > 40 ? str2.Substring(0, 40) : str2;
          str1 = str1 + ", Items[0]: " + str3;
        }
      }
      return str1;
    }

    protected void UpdateExtendedStyles()
    {
      if (!this.IsHandleCreated)
        return;
      int lparam = 0;
      int wparam = 68861;
      switch (this.activation)
      {
        case ItemActivation.OneClick:
          lparam |= 64;
          break;
        case ItemActivation.TwoClick:
          lparam |= 128;
          break;
      }
      if (this.AllowColumnReorder)
        lparam |= 16;
      if (this.CheckBoxes)
        lparam |= 4;
      if (this.DoubleBuffered)
        lparam |= 65536;
      if (this.FullRowSelect)
        lparam |= 32;
      if (this.GridLines)
        lparam |= 1;
      if (this.HoverSelection)
        lparam |= 8;
      if (this.HotTracking)
        lparam |= 2048;
      if (this.ShowItemToolTips)
        lparam |= 1024;
      this.SendMessage(4150, wparam, lparam);
      this.Invalidate();
    }

    [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    protected override void WndProc(ref Message m)
    {
      switch (m.Msg)
      {
        case 791:
          this.WmPrint(ref m);
          return;
        case 8270:
          this.WmReflectNotify(ref m);
          return;
        case 512:
          if (this.listViewState[1048576] && !this.listViewState[524288] && Control.MouseButtons == MouseButtons.None)
          {
            this.OnMouseUp(new MouseEventArgs(this.downButton, 1, System.Windows.Forms.NativeMethods.Util.SignedLOWORD(m.LParam), System.Windows.Forms.NativeMethods.Util.SignedHIWORD(m.LParam), 0));
            this.listViewState[524288] = true;
          }
          this.CaptureInternal = false;
          base.WndProc(ref m);
          return;
        case 513:
          this.ItemCollectionChangedInMouseDown = false;
          this.WmMouseDown(ref m, MouseButtons.Left, 1);
          this.downButton = MouseButtons.Left;
          return;
        case 514:
        case 517:
        case 520:
          if (!this.ValidationCancelled && this.listViewState[262144] && this.GetIndexOfClickedItem(new System.Windows.Forms.NativeMethods.LVHITTESTINFO()) != -1)
          {
            this.listViewState[262144] = false;
            this.OnDoubleClick(EventArgs.Empty);
            this.OnMouseDoubleClick(new MouseEventArgs(this.downButton, 2, System.Windows.Forms.NativeMethods.Util.SignedLOWORD(m.LParam), System.Windows.Forms.NativeMethods.Util.SignedHIWORD(m.LParam), 0));
          }
          if (!this.listViewState[524288])
          {
            this.OnMouseUp(new MouseEventArgs(this.downButton, 1, System.Windows.Forms.NativeMethods.Util.SignedLOWORD(m.LParam), System.Windows.Forms.NativeMethods.Util.SignedHIWORD(m.LParam), 0));
            this.listViewState[1048576] = false;
          }
          this.ItemCollectionChangedInMouseDown = false;
          this.listViewState[524288] = true;
          this.CaptureInternal = false;
          return;
        case 515:
          this.ItemCollectionChangedInMouseDown = false;
          this.CaptureInternal = true;
          this.WmMouseDown(ref m, MouseButtons.Left, 2);
          return;
        case 516:
          this.WmMouseDown(ref m, MouseButtons.Right, 1);
          this.downButton = MouseButtons.Right;
          return;
        case 518:
          this.WmMouseDown(ref m, MouseButtons.Right, 2);
          return;
        case 519:
          this.WmMouseDown(ref m, MouseButtons.Middle, 1);
          this.downButton = MouseButtons.Middle;
          return;
        case 521:
          this.WmMouseDown(ref m, MouseButtons.Middle, 2);
          return;
        case 673:
          if (this.HoverSelection)
          {
            base.WndProc(ref m);
            return;
          }
          else
          {
            this.OnMouseHover(EventArgs.Empty);
            return;
          }
        case 675:
          this.prevHoveredItem = (ListViewItem) null;
          base.WndProc(ref m);
          return;
        case 78:
          if (this.WmNotify(ref m))
            return;
          else
            break;
        case 275:
          if ((int) (long) m.WParam == 48 && this.ComctlSupportsVisualStyles)
            return;
          base.WndProc(ref m);
          return;
        case 7:
          base.WndProc(ref m);
          if (this.RecreatingHandle || this.ListViewHandleDestroyed || (this.FocusedItem != null || this.Items.Count <= 0))
            return;
          this.Items[0].Focused = true;
          return;
        case 15:
          base.WndProc(ref m);
          this.BeginInvoke((Delegate) new MethodInvoker(this.CleanPreviousBackgroundImageFiles));
          return;
      }
      base.WndProc(ref m);
    }

    private bool ShouldSerializeTileSize()
    {
      return !this.tileSize.Equals((object) Size.Empty);
    }

    private void ApplyUpdateCachedItems()
    {
      ArrayList arrayList = (ArrayList) this.Properties.GetObject(System.Windows.Forms.ListView.PropDelayedUpdateItems);
      if (arrayList == null)
        return;
      this.Properties.SetObject(System.Windows.Forms.ListView.PropDelayedUpdateItems, (object) null);
      ListViewItem[] items = (ListViewItem[]) arrayList.ToArray(typeof (ListViewItem));
      if (items.Length <= 0)
        return;
      this.InsertItems(this.itemCount, items, false);
    }

    internal void CacheSelectedStateForItem(ListViewItem lvi, bool selected)
    {
      if (selected)
      {
        if (this.savedSelectedItems == null)
          this.savedSelectedItems = new List<ListViewItem>();
        if (this.savedSelectedItems.Contains(lvi))
          return;
        this.savedSelectedItems.Add(lvi);
      }
      else
      {
        if (this.savedSelectedItems == null || !this.savedSelectedItems.Contains(lvi))
          return;
        this.savedSelectedItems.Remove(lvi);
      }
    }

    private void CleanPreviousBackgroundImageFiles()
    {
      if (this.bkImgFileNames == null)
        return;
      new FileIOPermission(PermissionState.Unrestricted).Assert();
      try
      {
        for (int index = 0; index <= this.bkImgFileNamesCount; ++index)
        {
          FileInfo fileInfo = new FileInfo(this.bkImgFileNames[index]);
          if (fileInfo.Exists)
          {
            try
            {
              fileInfo.Delete();
            }
            catch (IOException ex)
            {
            }
          }
        }
      }
      finally
      {
        PermissionSet.RevertAssert();
      }
      this.bkImgFileNames = (string[]) null;
      this.bkImgFileNamesCount = -1;
    }

    private int CompareFunc(IntPtr lparam1, IntPtr lparam2, IntPtr lparamSort)
    {
      if (this.listItemSorter != null)
        return this.listItemSorter.Compare(this.listItemsTable[(object) (int) lparam1], this.listItemsTable[(object) (int) lparam2]);
      else
        return 0;
    }

    private int CompensateColumnHeaderResize(Message m, bool columnResizeCancelled)
    {
      if (this.ComctlSupportsVisualStyles && this.View == View.Details && (!columnResizeCancelled && this.Items.Count > 0))
        return this.CompensateColumnHeaderResize(((System.Windows.Forms.NativeMethods.NMHEADER) m.GetLParam(typeof (System.Windows.Forms.NativeMethods.NMHEADER))).iItem, columnResizeCancelled);
      else
        return 0;
    }

    private int CompensateColumnHeaderResize(int columnIndex, bool columnResizeCancelled)
    {
      if (this.ComctlSupportsVisualStyles && this.View == View.Details && (!columnResizeCancelled && this.Items.Count > 0) && columnIndex == 0 && (this.columnHeaders == null || this.columnHeaders.Length <= 0 ? (ColumnHeader) null : this.columnHeaders[0]) != null)
      {
        if (this.SmallImageList == null)
          return 2;
        bool flag = true;
        for (int index = 0; index < this.Items.Count; ++index)
        {
          if (this.Items[index].ImageIndexer.ActualIndex > -1)
          {
            flag = false;
            break;
          }
        }
        if (flag)
          return 18;
      }
      return 0;
    }

    private unsafe void CustomDraw(ref Message m)
    {
      bool flag1 = false;
      bool flag2 = false;
      try
      {
        System.Windows.Forms.NativeMethods.NMLVCUSTOMDRAW* nmlvcustomdrawPtr = (System.Windows.Forms.NativeMethods.NMLVCUSTOMDRAW*) (void*) m.LParam;
        switch (nmlvcustomdrawPtr->nmcd.dwDrawStage)
        {
          case 1:
            if (this.OwnerDraw)
            {
              m.Result = (IntPtr) 32;
              break;
            }
            else
            {
              m.Result = (IntPtr) 34;
              this.odCacheBackColor = this.BackColor;
              this.odCacheForeColor = this.ForeColor;
              this.odCacheFont = this.Font;
              this.odCacheFontHandle = this.FontHandle;
              if (nmlvcustomdrawPtr->dwItemType != 1)
                break;
              if (this.odCacheFontHandleWrapper != null)
                this.odCacheFontHandleWrapper.Dispose();
              this.odCacheFont = new Font(this.odCacheFont, FontStyle.Bold);
              this.odCacheFontHandleWrapper = new Control.FontHandleWrapper(this.odCacheFont);
              this.odCacheFontHandle = this.odCacheFontHandleWrapper.Handle;
              System.Windows.Forms.SafeNativeMethods.SelectObject(new HandleRef((object) nmlvcustomdrawPtr->nmcd, nmlvcustomdrawPtr->nmcd.hdc), new HandleRef((object) this.odCacheFontHandleWrapper, this.odCacheFontHandleWrapper.Handle));
              m.Result = (IntPtr) 2;
              break;
            }
          case 65537:
            Rectangle itemRectOrEmpty = this.GetItemRectOrEmpty((int) nmlvcustomdrawPtr->nmcd.dwItemSpec);
            if (!this.ClientRectangle.IntersectsWith(itemRectOrEmpty))
              break;
            if (this.OwnerDraw)
            {
              Graphics graphics = Graphics.FromHdcInternal(nmlvcustomdrawPtr->nmcd.hdc);
              DrawListViewItemEventArgs e = (DrawListViewItemEventArgs) null;
              try
              {
                e = new DrawListViewItemEventArgs(graphics, this.Items[(int) nmlvcustomdrawPtr->nmcd.dwItemSpec], itemRectOrEmpty, (int) nmlvcustomdrawPtr->nmcd.dwItemSpec, (ListViewItemStates) nmlvcustomdrawPtr->nmcd.uItemState);
                this.OnDrawItem(e);
              }
              finally
              {
                graphics.Dispose();
              }
              flag2 = e.DrawDefault;
              if (this.viewStyle == View.Details)
                m.Result = (IntPtr) 32;
              else if (!e.DrawDefault)
                m.Result = (IntPtr) 4;
              if (!e.DrawDefault)
                break;
            }
            if (this.viewStyle == View.Details || this.viewStyle == View.Tile)
            {
              m.Result = (IntPtr) 34;
              flag1 = true;
              goto case 196609;
            }
            else
              goto case 196609;
          case 196609:
            int index1 = (int) nmlvcustomdrawPtr->nmcd.dwItemSpec;
            if (!this.ClientRectangle.IntersectsWith(this.GetItemRectOrEmpty(index1)))
              break;
            if (this.OwnerDraw && !flag2)
            {
              Graphics graphics = Graphics.FromHdcInternal(nmlvcustomdrawPtr->nmcd.hdc);
              bool flag3 = true;
              try
              {
                if (nmlvcustomdrawPtr->iSubItem < this.Items[index1].SubItems.Count)
                {
                  Rectangle subItemRect = this.GetSubItemRect(index1, nmlvcustomdrawPtr->iSubItem);
                  if (nmlvcustomdrawPtr->iSubItem == 0 && this.Items[index1].SubItems.Count > 1)
                    subItemRect.Width = this.columnHeaders[0].Width;
                  if (this.ClientRectangle.IntersectsWith(subItemRect))
                  {
                    DrawListViewSubItemEventArgs e = new DrawListViewSubItemEventArgs(graphics, subItemRect, this.Items[index1], this.Items[index1].SubItems[nmlvcustomdrawPtr->iSubItem], index1, nmlvcustomdrawPtr->iSubItem, this.columnHeaders[nmlvcustomdrawPtr->iSubItem], (ListViewItemStates) nmlvcustomdrawPtr->nmcd.uItemState);
                    this.OnDrawSubItem(e);
                    flag3 = !e.DrawDefault;
                  }
                }
              }
              finally
              {
                graphics.Dispose();
              }
              if (flag3)
              {
                m.Result = (IntPtr) 4;
                break;
              }
            }
            ListViewItem listViewItem = this.Items[(int) nmlvcustomdrawPtr->nmcd.dwItemSpec];
            if (flag1 && listViewItem.UseItemStyleForSubItems)
              m.Result = (IntPtr) 2;
            int num1 = nmlvcustomdrawPtr->nmcd.uItemState;
            if (!this.HideSelection && (this.GetItemState((int) nmlvcustomdrawPtr->nmcd.dwItemSpec) & 2) == 0)
              num1 &= -2;
            int index2 = (nmlvcustomdrawPtr->nmcd.dwDrawStage & 131072) != 0 ? nmlvcustomdrawPtr->iSubItem : 0;
            Font font = (Font) null;
            Color color1 = Color.Empty;
            Color color2 = Color.Empty;
            bool flag4 = false;
            bool flag5 = false;
            if (listViewItem != null && index2 < listViewItem.SubItems.Count)
            {
              flag4 = true;
              if (index2 == 0 && (num1 & 64) != 0 && this.HotTracking)
              {
                flag5 = true;
                font = new Font(listViewItem.SubItems[0].Font, FontStyle.Underline);
              }
              else
                font = listViewItem.SubItems[index2].Font;
              if (index2 > 0 || (num1 & 71) == 0)
              {
                color1 = listViewItem.SubItems[index2].ForeColor;
                color2 = listViewItem.SubItems[index2].BackColor;
              }
            }
            Color c1 = Color.Empty;
            Color c2 = Color.Empty;
            if (flag4)
            {
              c1 = color1;
              c2 = color2;
            }
            bool flag6 = true;
            if (!this.Enabled)
              flag6 = false;
            else if ((this.activation == ItemActivation.OneClick || this.activation == ItemActivation.TwoClick) && (num1 & 71) != 0)
              flag6 = false;
            if (flag6)
            {
              nmlvcustomdrawPtr->clrText = !flag4 || c1.IsEmpty ? ColorTranslator.ToWin32(this.odCacheForeColor) : ColorTranslator.ToWin32(c1);
              if (nmlvcustomdrawPtr->clrText == ColorTranslator.ToWin32(SystemColors.HotTrack))
              {
                int num2 = 0;
                bool flag3 = false;
                int num3 = 16711680;
                do
                {
                  int num4 = nmlvcustomdrawPtr->clrText & num3;
                  if (num4 != 0 || num3 == (int) byte.MaxValue)
                  {
                    int num5 = 16 - num2;
                    int num6 = num4 != num3 ? (num4 >> num5) + 1 << num5 : (num4 >> num5) - 1 << num5;
                    nmlvcustomdrawPtr->clrText = nmlvcustomdrawPtr->clrText & ~num3 | num6;
                    flag3 = true;
                  }
                  else
                  {
                    num3 >>= 8;
                    num2 += 8;
                  }
                }
                while (!flag3);
              }
              nmlvcustomdrawPtr->clrTextBk = !flag4 || c2.IsEmpty ? ColorTranslator.ToWin32(this.odCacheBackColor) : ColorTranslator.ToWin32(c2);
            }
            if (!flag4 || font == null)
            {
              if (this.odCacheFont != null)
                System.Windows.Forms.SafeNativeMethods.SelectObject(new HandleRef((object) nmlvcustomdrawPtr->nmcd, nmlvcustomdrawPtr->nmcd.hdc), new HandleRef((object) null, this.odCacheFontHandle));
            }
            else
            {
              if (this.odCacheFontHandleWrapper != null)
                this.odCacheFontHandleWrapper.Dispose();
              this.odCacheFontHandleWrapper = new Control.FontHandleWrapper(font);
              System.Windows.Forms.SafeNativeMethods.SelectObject(new HandleRef((object) nmlvcustomdrawPtr->nmcd, nmlvcustomdrawPtr->nmcd.hdc), new HandleRef((object) this.odCacheFontHandleWrapper, this.odCacheFontHandleWrapper.Handle));
            }
            if (!flag1)
              m.Result = (IntPtr) 2;
            if (!flag5)
              break;
            font.Dispose();
            break;
          default:
            m.Result = (IntPtr) 0;
            break;
        }
      }
      catch (Exception ex)
      {
        m.Result = (IntPtr) 0;
      }
    }

    private void DeleteFileName(string fileName)
    {
      if (string.IsNullOrEmpty(fileName))
        return;
      new FileIOPermission(PermissionState.Unrestricted).Assert();
      try
      {
        FileInfo fileInfo = new FileInfo(fileName);
        if (!fileInfo.Exists)
          return;
        try
        {
          fileInfo.Delete();
        }
        catch (IOException ex)
        {
        }
      }
      finally
      {
        PermissionSet.RevertAssert();
      }
    }

    private void DestroyLVGROUP(System.Windows.Forms.NativeMethods.LVGROUP lvgroup)
    {
      if (!(lvgroup.pszHeader != IntPtr.Zero))
        return;
      Marshal.FreeHGlobal(lvgroup.pszHeader);
    }

    private void DetachImageList(object sender, EventArgs e)
    {
      this.listViewState1[4] = true;
      try
      {
        if (sender == this.imageListSmall)
          this.SmallImageList = (ImageList) null;
        if (sender == this.imageListLarge)
          this.LargeImageList = (ImageList) null;
        if (sender == this.imageListState)
          this.StateImageList = (ImageList) null;
      }
      finally
      {
        this.listViewState1[4] = false;
      }
      this.UpdateListViewItemsLocations();
    }

    private void EnsureDefaultGroup()
    {
      if (!this.IsHandleCreated || !this.ComctlSupportsVisualStyles || (!this.GroupsEnabled || !(this.SendMessage(4257, this.DefaultGroup.ID, 0) == IntPtr.Zero)))
        return;
      this.UpdateGroupView();
      this.InsertGroupNative(0, this.DefaultGroup);
    }

    private ListViewItem FindItem(bool isTextSearch, string text, bool isPrefixSearch, Point pt, SearchDirectionHint dir, int startIndex, bool includeSubItemsInSearch)
    {
      if (this.Items.Count == 0)
        return (ListViewItem) null;
      if (!this.IsHandleCreated)
        this.CreateHandle();
      if (this.VirtualMode)
      {
        SearchForVirtualItemEventArgs e = new SearchForVirtualItemEventArgs(isTextSearch, isPrefixSearch, includeSubItemsInSearch, text, pt, dir, startIndex);
        this.OnSearchForVirtualItem(e);
        if (e.Index != -1)
          return this.Items[e.Index];
        else
          return (ListViewItem) null;
      }
      else
      {
        System.Windows.Forms.NativeMethods.LVFINDINFO lParam = new System.Windows.Forms.NativeMethods.LVFINDINFO();
        if (isTextSearch)
        {
          lParam.flags = 2;
          lParam.flags |= isPrefixSearch ? 8 : 0;
          lParam.psz = text;
        }
        else
        {
          lParam.flags = 64;
          lParam.ptX = pt.X;
          lParam.ptY = pt.Y;
          lParam.vkDirection = (int) dir;
        }
        lParam.lParam = IntPtr.Zero;
        int index1 = (int) System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), System.Windows.Forms.NativeMethods.LVM_FINDITEM, startIndex - 1, out lParam);
        if (index1 >= 0)
          return this.Items[index1];
        if (!isTextSearch || !includeSubItemsInSearch)
          return (ListViewItem) null;
        for (int index2 = startIndex; index2 < this.Items.Count; ++index2)
        {
          ListViewItem listViewItem = this.Items[index2];
          for (int index3 = 0; index3 < listViewItem.SubItems.Count; ++index3)
          {
            ListViewItem.ListViewSubItem listViewSubItem = listViewItem.SubItems[index3];
            if (string.Equals(text, listViewSubItem.Text, StringComparison.OrdinalIgnoreCase) || isPrefixSearch && CultureInfo.CurrentCulture.CompareInfo.IsPrefix(listViewSubItem.Text, text, CompareOptions.IgnoreCase))
              return listViewItem;
          }
        }
        return (ListViewItem) null;
      }
    }

    private void ForceCheckBoxUpdate()
    {
      if (!this.CheckBoxes || !this.IsHandleCreated)
        return;
      this.SendMessage(4150, 4, 0);
      this.SendMessage(4150, 4, 4);
      if (!this.AutoArrange)
        return;
      this.ArrangeIcons(this.Alignment);
    }

    private string GenerateRandomName()
    {
      Bitmap bitmap = new Bitmap(this.BackgroundImage);
      int Seed = 0;
      try
      {
        Seed = (int) (long) bitmap.GetHicon();
      }
      catch
      {
        bitmap.Dispose();
      }
      return (Seed != 0 ? new Random(Seed) : new Random((int) DateTime.Now.Ticks)).Next().ToString((IFormatProvider) CultureInfo.InvariantCulture);
    }

    private int GenerateUniqueID()
    {
      int num = this.nextID++;
      if (num == -1)
      {
        num = 0;
        this.nextID = 1;
      }
      return num;
    }

    internal int GetDisplayIndex(ListViewItem item, int lastIndex)
    {
      this.ApplyUpdateCachedItems();
      if (this.IsHandleCreated && !this.ListViewHandleDestroyed)
      {
        System.Windows.Forms.NativeMethods.LVFINDINFO lParam = new System.Windows.Forms.NativeMethods.LVFINDINFO();
        lParam.lParam = (IntPtr) item.ID;
        lParam.flags = 1;
        int num = -1;
        if (lastIndex != -1)
          num = (int) System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), System.Windows.Forms.NativeMethods.LVM_FINDITEM, lastIndex - 1, out lParam);
        if (num == -1)
          num = (int) System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), System.Windows.Forms.NativeMethods.LVM_FINDITEM, -1, out lParam);
        return num;
      }
      else
      {
        int num = 0;
        foreach (object obj in this.listItemsArray)
        {
          if (obj == item)
            return num;
          ++num;
        }
        return -1;
      }
    }

    internal int GetColumnIndex(ColumnHeader ch)
    {
      if (this.columnHeaders == null)
        return -1;
      for (int index = 0; index < this.columnHeaders.Length; ++index)
      {
        if (this.columnHeaders[index] == ch)
          return index;
      }
      return -1;
    }

    internal int GetNativeGroupId(ListViewItem item)
    {
      item.UpdateGroupFromName();
      if (item.Group != null && this.Groups.Contains(item.Group))
        return item.Group.ID;
      this.EnsureDefaultGroup();
      return this.DefaultGroup.ID;
    }

    internal void GetSubItemAt(int x, int y, out int iItem, out int iSubItem)
    {
      System.Windows.Forms.NativeMethods.LVHITTESTINFO lParam = new System.Windows.Forms.NativeMethods.LVHITTESTINFO();
      lParam.pt_x = x;
      lParam.pt_y = y;
      if ((int) System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), 4153, 0, lParam) > -1)
      {
        iItem = lParam.iItem;
        iSubItem = lParam.iSubItem;
      }
      else
      {
        iItem = -1;
        iSubItem = -1;
      }
    }

    internal Point GetItemPosition(int index)
    {
      System.Windows.Forms.NativeMethods.POINT lParam = new System.Windows.Forms.NativeMethods.POINT();
      System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), 4112, index, lParam);
      return new Point(lParam.x, lParam.y);
    }

    internal int GetItemState(int index)
    {
      return this.GetItemState(index, 65295);
    }

    internal int GetItemState(int index, int mask)
    {
      if (index >= 0 && (!this.VirtualMode || index < this.VirtualListSize) && (this.VirtualMode || index < this.itemCount))
        return (int) (long) this.SendMessage(4140, index, mask);
      throw new ArgumentOutOfRangeException("index", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "index", (object) index.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
    }

    private Rectangle GetItemRectOrEmpty(int index)
    {
      if (index < 0 || index >= this.Items.Count || this.View == View.Details && this.Columns.Count == 0)
        return Rectangle.Empty;
      System.Windows.Forms.NativeMethods.RECT lparam = new System.Windows.Forms.NativeMethods.RECT();
      lparam.left = 0;
      if ((int) (long) this.SendMessage(4110, index, ref lparam) == 0)
        return Rectangle.Empty;
      else
        return Rectangle.FromLTRB(lparam.left, lparam.top, lparam.right, lparam.bottom);
    }

    private System.Windows.Forms.NativeMethods.LVGROUP GetLVGROUP(ListViewGroup group)
    {
      System.Windows.Forms.NativeMethods.LVGROUP lvgroup = new System.Windows.Forms.NativeMethods.LVGROUP();
      lvgroup.mask = 25U;
      lvgroup.pszHeader = Marshal.StringToHGlobalAuto(group.Header);
      lvgroup.cchHeader = group.Header.Length;
      lvgroup.iGroupId = group.ID;
      switch (group.HeaderAlignment)
      {
        case HorizontalAlignment.Left:
          lvgroup.uAlign = 1U;
          break;
        case HorizontalAlignment.Right:
          lvgroup.uAlign = 4U;
          break;
        case HorizontalAlignment.Center:
          lvgroup.uAlign = 2U;
          break;
      }
      return lvgroup;
    }

    internal Rectangle GetSubItemRect(int itemIndex, int subItemIndex)
    {
      return this.GetSubItemRect(itemIndex, subItemIndex, ItemBoundsPortion.Entire);
    }

    internal Rectangle GetSubItemRect(int itemIndex, int subItemIndex, ItemBoundsPortion portion)
    {
      if (this.View != View.Details)
        return Rectangle.Empty;
      if (itemIndex < 0 || itemIndex >= this.Items.Count)
      {
        throw new ArgumentOutOfRangeException("itemIndex", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "itemIndex", (object) itemIndex.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
      }
      else
      {
        int count = this.Items[itemIndex].SubItems.Count;
        if (subItemIndex < 0 || subItemIndex >= count)
        {
          throw new ArgumentOutOfRangeException("subItemIndex", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "subItemIndex", (object) subItemIndex.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
        }
        else
        {
          if (!System.Windows.Forms.ClientUtils.IsEnumValid((Enum) portion, (int) portion, 0, 3))
            throw new InvalidEnumArgumentException("portion", (int) portion, typeof (ItemBoundsPortion));
          if (this.Columns.Count == 0)
            return Rectangle.Empty;
          System.Windows.Forms.NativeMethods.RECT lparam = new System.Windows.Forms.NativeMethods.RECT();
          lparam.left = (int) portion;
          lparam.top = subItemIndex;
          if ((int) (long) this.SendMessage(4152, itemIndex, ref lparam) != 0)
            return Rectangle.FromLTRB(lparam.left, lparam.top, lparam.right, lparam.bottom);
          throw new ArgumentException(System.Windows.Forms.SR.GetString("InvalidArgument", (object) "itemIndex", (object) itemIndex.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
        }
      }
    }

    private void InvalidateColumnHeaders()
    {
      if (this.viewStyle != View.Details || !this.IsHandleCreated)
        return;
      IntPtr handle = System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), 4127, 0, 0);
      if (!(handle != IntPtr.Zero))
        return;
      System.Windows.Forms.SafeNativeMethods.InvalidateRect(new HandleRef((object) this, handle), (System.Windows.Forms.NativeMethods.COMRECT) null, true);
    }

    internal ColumnHeader InsertColumn(int index, ColumnHeader ch)
    {
      return this.InsertColumn(index, ch, true);
    }

    internal ColumnHeader InsertColumn(int index, ColumnHeader ch, bool refreshSubItems)
    {
      if (ch == null)
        throw new ArgumentNullException("ch");
      if (ch.OwnerListview != null)
      {
        throw new ArgumentException(System.Windows.Forms.SR.GetString("OnlyOneControl", new object[1]
        {
          (object) ch.Text
        }), "ch");
      }
      else
      {
        int sourceIndex = !this.IsHandleCreated || this.View == View.Tile ? index : this.InsertColumnNative(index, ch);
        if (-1 == sourceIndex)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewAddColumnFailed"));
        int length = this.columnHeaders == null ? 0 : this.columnHeaders.Length;
        if (length > 0)
        {
          ColumnHeader[] columnHeaderArray = new ColumnHeader[length + 1];
          if (length > 0)
            Array.Copy((Array) this.columnHeaders, 0, (Array) columnHeaderArray, 0, length);
          this.columnHeaders = columnHeaderArray;
        }
        else
          this.columnHeaders = new ColumnHeader[1];
        if (sourceIndex < length)
          Array.Copy((Array) this.columnHeaders, sourceIndex, (Array) this.columnHeaders, sourceIndex + 1, length - sourceIndex);
        this.columnHeaders[sourceIndex] = ch;
        ch.OwnerListview = this;
        if (ch.ActualImageIndex_Internal != -1 && this.IsHandleCreated && this.View != View.Tile)
          this.SetColumnInfo(16, ch);
        int[] indices = new int[this.Columns.Count];
        for (int index1 = 0; index1 < this.Columns.Count; ++index1)
        {
          ColumnHeader columnHeader = this.Columns[index1];
          if (columnHeader == ch)
            columnHeader.DisplayIndexInternal = index;
          else if (columnHeader.DisplayIndex >= index)
            ++columnHeader.DisplayIndexInternal;
          indices[index1] = columnHeader.DisplayIndexInternal;
        }
        this.SetDisplayIndices(indices);
        if (this.IsHandleCreated && this.View == View.Tile)
          this.RecreateHandleInternal();
        else if (this.IsHandleCreated && refreshSubItems)
          this.RealizeAllSubItems();
        return ch;
      }
    }

    private int InsertColumnNative(int index, ColumnHeader ch)
    {
      System.Windows.Forms.NativeMethods.LVCOLUMN_T lParam = new System.Windows.Forms.NativeMethods.LVCOLUMN_T();
      lParam.mask = 7;
      if (ch.OwnerListview != null && ch.ActualImageIndex_Internal != -1)
      {
        lParam.mask |= 16;
        lParam.iImage = ch.ActualImageIndex_Internal;
      }
      lParam.fmt = (int) ch.TextAlign;
      lParam.cx = ch.Width;
      lParam.pszText = ch.Text;
      return (int) System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), System.Windows.Forms.NativeMethods.LVM_INSERTCOLUMN, index, lParam);
    }

    internal void InsertGroupInListView(int index, ListViewGroup group)
    {
      bool flag = this.groups.Count == 1 && this.GroupsEnabled;
      this.UpdateGroupView();
      this.EnsureDefaultGroup();
      this.InsertGroupNative(index, group);
      if (!flag)
        return;
      for (int index1 = 0; index1 < this.Items.Count; ++index1)
      {
        ListViewItem listViewItem = this.Items[index1];
        if (listViewItem.Group == null)
          listViewItem.UpdateStateToListView(listViewItem.Index);
      }
    }

    private void InsertGroupNative(int index, ListViewGroup group)
    {
      System.Windows.Forms.NativeMethods.LVGROUP lvgroup = new System.Windows.Forms.NativeMethods.LVGROUP();
      try
      {
        lvgroup = this.GetLVGROUP(group);
        int num = (int) System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), 4241, index, lvgroup);
      }
      finally
      {
        this.DestroyLVGROUP(lvgroup);
      }
    }

    private void InsertItems(int displayIndex, ListViewItem[] items, bool checkHosting)
    {
      if (items == null || items.Length == 0)
        return;
      if (this.IsHandleCreated && this.Items.Count == 0 && (this.View == View.SmallIcon && this.ComctlSupportsVisualStyles))
        this.FlipViewToLargeIconAndSmallIcon = true;
      if (this.updateCounter > 0 && this.Properties.GetObject(System.Windows.Forms.ListView.PropDelayedUpdateItems) != null)
      {
        if (checkHosting)
        {
          for (int index = 0; index < items.Length; ++index)
          {
            if (items[index].listView != null)
              throw new ArgumentException(System.Windows.Forms.SR.GetString("OnlyOneControl", new object[1]
              {
                (object) items[index].Text
              }), "item");
          }
        }
        ArrayList arrayList = (ArrayList) this.Properties.GetObject(System.Windows.Forms.ListView.PropDelayedUpdateItems);
        if (arrayList != null)
          arrayList.AddRange((ICollection) items);
        for (int index = 0; index < items.Length; ++index)
          items[index].Host(this, this.GenerateUniqueID(), -1);
        this.FlipViewToLargeIconAndSmallIcon = false;
      }
      else
      {
        for (int index = 0; index < items.Length; ++index)
        {
          ListViewItem listViewItem = items[index];
          if (checkHosting && listViewItem.listView != null)
          {
            throw new ArgumentException(System.Windows.Forms.SR.GetString("OnlyOneControl", new object[1]
            {
              (object) listViewItem.Text
            }), "item");
          }
          else
          {
            int ID = this.GenerateUniqueID();
            this.listItemsTable.Add((object) ID, (object) listViewItem);
            ++this.itemCount;
            listViewItem.Host(this, ID, -1);
            if (!this.IsHandleCreated)
              this.listItemsArray.Insert(displayIndex + index, (object) listViewItem);
          }
        }
        if (this.IsHandleCreated)
          this.InsertItemsNative(displayIndex, items);
        this.Invalidate();
        this.ArrangeIcons(this.alignStyle);
        if (this.VirtualMode)
          return;
        this.Sort();
      }
    }

    private int InsertItemsNative(int index, ListViewItem[] items)
    {
      if (items == null || items.Length == 0)
        return 0;
      if (index == this.itemCount - 1)
        ++index;
      System.Windows.Forms.NativeMethods.LVITEM lParam = new System.Windows.Forms.NativeMethods.LVITEM();
      int num1 = -1;
      IntPtr hglobal = IntPtr.Zero;
      int num2 = 0;
      this.listViewState1[1] = true;
      try
      {
        this.SendMessage(4143, this.itemCount, 0);
        for (int index1 = 0; index1 < items.Length; ++index1)
        {
          ListViewItem listViewItem = items[index1];
          lParam.Reset();
          lParam.mask = 23;
          lParam.iItem = index + index1;
          lParam.pszText = listViewItem.Text;
          lParam.iImage = listViewItem.ImageIndexer.ActualIndex;
          lParam.iIndent = listViewItem.IndentCount;
          lParam.lParam = (IntPtr) listViewItem.ID;
          if (this.GroupsEnabled)
          {
            lParam.mask |= 256;
            lParam.iGroupId = this.GetNativeGroupId(listViewItem);
          }
          lParam.mask |= 512;
          lParam.cColumns = this.columnHeaders != null ? Math.Min(20, this.columnHeaders.Length) : 0;
          if (lParam.cColumns > num2 || hglobal == IntPtr.Zero)
          {
            if (hglobal != IntPtr.Zero)
              Marshal.FreeHGlobal(hglobal);
            hglobal = Marshal.AllocHGlobal(lParam.cColumns * Marshal.SizeOf(typeof (int)));
            num2 = lParam.cColumns;
          }
          lParam.puColumns = hglobal;
          int[] source = new int[lParam.cColumns];
          for (int index2 = 0; index2 < lParam.cColumns; ++index2)
            source[index2] = index2 + 1;
          Marshal.Copy(source, 0, lParam.puColumns, lParam.cColumns);
          ItemCheckEventHandler checkEventHandler = this.onItemCheck;
          this.onItemCheck = (ItemCheckEventHandler) null;
          int num3;
          try
          {
            listViewItem.UpdateStateToListView(lParam.iItem, ref lParam, false);
            num3 = (int) System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), System.Windows.Forms.NativeMethods.LVM_INSERTITEM, 0, out lParam);
            if (num1 == -1)
            {
              num1 = num3;
              index = num1;
            }
          }
          finally
          {
            this.onItemCheck = checkEventHandler;
          }
          if (-1 == num3)
            throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewAddItemFailed"));
          for (int subItemIndex = 1; subItemIndex < listViewItem.SubItems.Count; ++subItemIndex)
            this.SetItemText(num3, subItemIndex, listViewItem.SubItems[subItemIndex].Text, ref lParam);
          if (listViewItem.StateImageSet || listViewItem.StateSelected)
            this.SetItemState(num3, lParam.state, lParam.stateMask);
        }
      }
      finally
      {
        if (hglobal != IntPtr.Zero)
          Marshal.FreeHGlobal(hglobal);
        this.listViewState1[1] = false;
      }
      if (this.listViewState1[16])
      {
        this.listViewState1[16] = false;
        this.OnSelectedIndexChanged(EventArgs.Empty);
      }
      if (this.FlipViewToLargeIconAndSmallIcon)
      {
        this.FlipViewToLargeIconAndSmallIcon = false;
        this.View = View.LargeIcon;
        this.View = View.SmallIcon;
      }
      return num1;
    }

    private void LargeImageListRecreateHandle(object sender, EventArgs e)
    {
      if (!this.IsHandleCreated)
        return;
      this.SendMessage(4099, (IntPtr) 0, this.LargeImageList == null ? IntPtr.Zero : this.LargeImageList.Handle);
      this.ForceCheckBoxUpdate();
    }

    private void LargeImageListChangedHandle(object sender, EventArgs e)
    {
      if (this.VirtualMode || sender == null || (sender != this.imageListLarge || !this.IsHandleCreated))
        return;
      foreach (ListViewItem listViewItem in this.Items)
      {
        if (listViewItem.ImageIndexer.ActualIndex != -1 && listViewItem.ImageIndexer.ActualIndex >= this.imageListLarge.Images.Count)
          this.SetItemImage(listViewItem.Index, this.imageListLarge.Images.Count - 1);
        else
          this.SetItemImage(listViewItem.Index, listViewItem.ImageIndexer.ActualIndex);
      }
    }

    internal void ListViewItemToolTipChanged(ListViewItem item)
    {
      if (!this.IsHandleCreated)
        return;
      this.SetItemText(item.Index, 0, item.Text);
    }

    private void LvnBeginDrag(MouseButtons buttons, System.Windows.Forms.NativeMethods.NMLISTVIEW nmlv)
    {
      ListViewItem listViewItem = this.Items[nmlv.iItem];
      this.OnItemDrag(new ItemDragEventArgs(buttons, (object) listViewItem));
    }

    private void PositionHeader()
    {
      IntPtr window = System.Windows.Forms.UnsafeNativeMethods.GetWindow(new HandleRef((object) this, this.Handle), 5);
      if (!(window != IntPtr.Zero))
        return;
      IntPtr num1 = IntPtr.Zero;
      IntPtr num2 = IntPtr.Zero;
      IntPtr num3 = Marshal.AllocHGlobal(Marshal.SizeOf(typeof (System.Windows.Forms.NativeMethods.RECT)));
      if (num3 == IntPtr.Zero)
        return;
      try
      {
        num2 = Marshal.AllocHGlobal(Marshal.SizeOf(typeof (System.Windows.Forms.NativeMethods.WINDOWPOS)));
        if (num3 == IntPtr.Zero)
          return;
        System.Windows.Forms.UnsafeNativeMethods.GetClientRect(new HandleRef((object) this, this.Handle), num3);
        System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, window), 4613, 0, ref new System.Windows.Forms.NativeMethods.HDLAYOUT()
        {
          prc = num3,
          pwpos = num2
        });
        System.Windows.Forms.NativeMethods.WINDOWPOS windowpos = (System.Windows.Forms.NativeMethods.WINDOWPOS) Marshal.PtrToStructure(num2, typeof (System.Windows.Forms.NativeMethods.WINDOWPOS));
        System.Windows.Forms.SafeNativeMethods.SetWindowPos(new HandleRef((object) this, window), new HandleRef((object) this, windowpos.hwndInsertAfter), windowpos.x, windowpos.y, windowpos.cx, windowpos.cy, windowpos.flags | 64);
      }
      finally
      {
        if (num3 != IntPtr.Zero)
          Marshal.FreeHGlobal(num3);
        if (num2 != IntPtr.Zero)
          Marshal.FreeHGlobal(num2);
      }
    }

    private void RealizeAllSubItems()
    {
      System.Windows.Forms.NativeMethods.LVITEM lvItem = new System.Windows.Forms.NativeMethods.LVITEM();
      for (int itemIndex = 0; itemIndex < this.itemCount; ++itemIndex)
      {
        int count = this.Items[itemIndex].SubItems.Count;
        for (int subItemIndex = 0; subItemIndex < count; ++subItemIndex)
          this.SetItemText(itemIndex, subItemIndex, this.Items[itemIndex].SubItems[subItemIndex].Text, ref lvItem);
      }
    }

    internal void RemoveGroupFromListView(ListViewGroup group)
    {
      this.EnsureDefaultGroup();
      foreach (ListViewItem listViewItem in group.Items)
      {
        if (listViewItem.ListView == this)
          listViewItem.UpdateStateToListView(listViewItem.Index);
      }
      this.RemoveGroupNative(group);
      this.UpdateGroupView();
    }

    private void RemoveGroupNative(ListViewGroup group)
    {
      int num = (int) System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), 4246, group.ID, IntPtr.Zero);
    }

    private void Scroll(int fromLVItem, int toLVItem)
    {
      System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), 4116, 0, this.GetItemPosition(toLVItem).Y - this.GetItemPosition(fromLVItem).Y);
    }

    private void SetBackgroundImage()
    {
      int num1 = (int) Application.OleRequired();
      System.Windows.Forms.NativeMethods.LVBKIMAGE lParam = new System.Windows.Forms.NativeMethods.LVBKIMAGE();
      lParam.xOffset = 0;
      lParam.yOffset = 0;
      string str = this.backgroundImageFileName;
      if (this.BackgroundImage != null)
      {
        EnvironmentPermission environmentPermission = new EnvironmentPermission(EnvironmentPermissionAccess.Read, "TEMP");
        FileIOPermission fileIoPermission = new FileIOPermission(PermissionState.Unrestricted);
        PermissionSet permissionSet = new PermissionSet(PermissionState.Unrestricted);
        permissionSet.AddPermission((IPermission) environmentPermission);
        permissionSet.AddPermission((IPermission) fileIoPermission);
        permissionSet.Assert();
        try
        {
          string tempPath = Path.GetTempPath();
          StringBuilder sb = new StringBuilder(1024);
          System.Windows.Forms.UnsafeNativeMethods.GetTempFileName(tempPath, this.GenerateRandomName(), 0, sb);
          this.backgroundImageFileName = ((object) sb).ToString();
          this.BackgroundImage.Save(this.backgroundImageFileName, ImageFormat.Bmp);
        }
        finally
        {
          PermissionSet.RevertAssert();
        }
        lParam.pszImage = this.backgroundImageFileName;
        lParam.cchImageMax = this.backgroundImageFileName.Length + 1;
        lParam.ulFlags = 2;
        if (this.BackgroundImageTiled)
        {
          lParam.ulFlags |= 16;
        }
        else
        {
          System.Windows.Forms.NativeMethods.LVBKIMAGE lvbkimage = lParam;
          int num2 = lvbkimage.ulFlags;
          lvbkimage.ulFlags = num2;
        }
      }
      else
      {
        lParam.ulFlags = 0;
        this.backgroundImageFileName = string.Empty;
      }
      System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), System.Windows.Forms.NativeMethods.LVM_SETBKIMAGE, 0, lParam);
      if (string.IsNullOrEmpty(str))
        return;
      if (this.bkImgFileNames == null)
      {
        this.bkImgFileNames = new string[8];
        this.bkImgFileNamesCount = -1;
      }
      if (this.bkImgFileNamesCount == 7)
      {
        this.DeleteFileName(this.bkImgFileNames[0]);
        this.bkImgFileNames[0] = this.bkImgFileNames[1];
        this.bkImgFileNames[1] = this.bkImgFileNames[2];
        this.bkImgFileNames[2] = this.bkImgFileNames[3];
        this.bkImgFileNames[3] = this.bkImgFileNames[4];
        this.bkImgFileNames[4] = this.bkImgFileNames[5];
        this.bkImgFileNames[5] = this.bkImgFileNames[6];
        this.bkImgFileNames[6] = this.bkImgFileNames[7];
        this.bkImgFileNames[7] = (string) null;
        --this.bkImgFileNamesCount;
      }
      ++this.bkImgFileNamesCount;
      this.bkImgFileNames[this.bkImgFileNamesCount] = str;
      this.Refresh();
    }

    internal void SetColumnInfo(int mask, ColumnHeader ch)
    {
      if (!this.IsHandleCreated)
        return;
      System.Windows.Forms.NativeMethods.LVCOLUMN lParam = new System.Windows.Forms.NativeMethods.LVCOLUMN();
      lParam.mask = mask;
      if ((mask & 16) != 0 || (mask & 1) != 0)
      {
        lParam.mask |= 1;
        if (ch.ActualImageIndex_Internal > -1)
        {
          lParam.iImage = ch.ActualImageIndex_Internal;
          lParam.fmt |= 2048;
        }
        lParam.fmt |= (int) ch.TextAlign;
      }
      if ((mask & 4) != 0)
        lParam.pszText = Marshal.StringToHGlobalAuto(ch.Text);
      int num = (int) System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), System.Windows.Forms.NativeMethods.LVM_SETCOLUMN, ch.Index, lParam);
      if ((mask & 4) != 0)
        Marshal.FreeHGlobal(lParam.pszText);
      if (num == 0)
        throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewColumnInfoSet"));
      this.InvalidateColumnHeaders();
    }

    internal void SetColumnWidth(int columnIndex, ColumnHeaderAutoResizeStyle headerAutoResize)
    {
      if (columnIndex < 0 || columnIndex >= 0 && this.columnHeaders == null || columnIndex >= this.columnHeaders.Length)
      {
        throw new ArgumentOutOfRangeException("columnIndex", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "columnIndex", (object) columnIndex.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
      }
      else
      {
        if (!System.Windows.Forms.ClientUtils.IsEnumValid((Enum) headerAutoResize, (int) headerAutoResize, 0, 2))
          throw new InvalidEnumArgumentException("headerAutoResize", (int) headerAutoResize, typeof (ColumnHeaderAutoResizeStyle));
        int low1 = 0;
        int num = 0;
        if (headerAutoResize == ColumnHeaderAutoResizeStyle.None)
        {
          low1 = this.columnHeaders[columnIndex].WidthInternal;
          switch (low1)
          {
            case -2:
              headerAutoResize = ColumnHeaderAutoResizeStyle.HeaderSize;
              break;
            case -1:
              headerAutoResize = ColumnHeaderAutoResizeStyle.ColumnContent;
              break;
          }
        }
        if (headerAutoResize == ColumnHeaderAutoResizeStyle.HeaderSize)
        {
          num = this.CompensateColumnHeaderResize(columnIndex, false);
          low1 = -2;
        }
        else if (headerAutoResize == ColumnHeaderAutoResizeStyle.ColumnContent)
        {
          num = this.CompensateColumnHeaderResize(columnIndex, false);
          low1 = -1;
        }
        if (this.IsHandleCreated)
          this.SendMessage(4126, columnIndex, System.Windows.Forms.NativeMethods.Util.MAKELPARAM(low1, 0));
        if (!this.IsHandleCreated || headerAutoResize != ColumnHeaderAutoResizeStyle.ColumnContent && headerAutoResize != ColumnHeaderAutoResizeStyle.HeaderSize || num == 0)
          return;
        int low2 = this.columnHeaders[columnIndex].Width + num;
        this.SendMessage(4126, columnIndex, System.Windows.Forms.NativeMethods.Util.MAKELPARAM(low2, 0));
      }
    }

    private void SetColumnWidth(int index, int width)
    {
      if (!this.IsHandleCreated)
        return;
      this.SendMessage(4126, index, System.Windows.Forms.NativeMethods.Util.MAKELPARAM(width, 0));
    }

    private void SetDisplayIndices(int[] indices)
    {
      int[] lParam = new int[indices.Length];
      for (int index = 0; index < indices.Length; ++index)
      {
        this.Columns[index].DisplayIndexInternal = indices[index];
        lParam[indices[index]] = index;
      }
      if (!this.IsHandleCreated || this.Disposing)
        return;
      System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), 4154, lParam.Length, lParam);
    }

    internal void UpdateSavedCheckedItems(ListViewItem item, bool addItem)
    {
      if (addItem && this.savedCheckedItems == null)
        this.savedCheckedItems = new List<ListViewItem>();
      if (addItem)
      {
        this.savedCheckedItems.Add(item);
      }
      else
      {
        if (this.savedCheckedItems == null)
          return;
        this.savedCheckedItems.Remove(item);
      }
    }

    internal void SetToolTip(System.Windows.Forms.ToolTip toolTip, string toolTipCaption)
    {
      this.toolTipCaption = toolTipCaption;
      System.Windows.Forms.UnsafeNativeMethods.DestroyWindow(new HandleRef((object) null, System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), 4170, new HandleRef((object) toolTip, toolTip.Handle), 0)));
    }

    internal void SetItemImage(int index, int image)
    {
      if (index < 0 || this.VirtualMode && index >= this.VirtualListSize || !this.VirtualMode && index >= this.itemCount)
      {
        throw new ArgumentOutOfRangeException("index", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "index", (object) index.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
      }
      else
      {
        if (!this.IsHandleCreated)
          return;
        System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), System.Windows.Forms.NativeMethods.LVM_SETITEM, 0, out new System.Windows.Forms.NativeMethods.LVITEM()
        {
          mask = 2,
          iItem = index,
          iImage = image
        });
      }
    }

    internal void SetItemIndentCount(int index, int indentCount)
    {
      if (index < 0 || this.VirtualMode && index >= this.VirtualListSize || !this.VirtualMode && index >= this.itemCount)
      {
        throw new ArgumentOutOfRangeException("index", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "index", (object) index.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
      }
      else
      {
        if (!this.IsHandleCreated)
          return;
        System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), System.Windows.Forms.NativeMethods.LVM_SETITEM, 0, out new System.Windows.Forms.NativeMethods.LVITEM()
        {
          mask = 16,
          iItem = index,
          iIndent = indentCount
        });
      }
    }

    internal void SetItemPosition(int index, int x, int y)
    {
      if (this.VirtualMode)
        return;
      if (index < 0 || index >= this.itemCount)
        throw new ArgumentOutOfRangeException("index", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "index", (object) index.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
      else
        System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), 4145, index, new System.Windows.Forms.NativeMethods.POINT()
        {
          x = x,
          y = y
        });
    }

    internal void SetItemState(int index, int state, int mask)
    {
      if (index < -1 || this.VirtualMode && index >= this.VirtualListSize || !this.VirtualMode && index >= this.itemCount)
      {
        throw new ArgumentOutOfRangeException("index", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "index", (object) index.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
      }
      else
      {
        if (!this.IsHandleCreated)
          return;
        System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), 4139, index, out new System.Windows.Forms.NativeMethods.LVITEM()
        {
          mask = 8,
          state = state,
          stateMask = mask
        });
      }
    }

    internal void SetItemText(int itemIndex, int subItemIndex, string text)
    {
      System.Windows.Forms.NativeMethods.LVITEM lvItem = new System.Windows.Forms.NativeMethods.LVITEM();
      this.SetItemText(itemIndex, subItemIndex, text, ref lvItem);
    }

    private void SetItemText(int itemIndex, int subItemIndex, string text, ref System.Windows.Forms.NativeMethods.LVITEM lvItem)
    {
      if (this.View == View.List && subItemIndex == 0)
      {
        int num = (int) (long) System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), 4125, 0, 0);
        Graphics graphicsInternal = this.CreateGraphicsInternal();
        int width = 0;
        try
        {
          width = Size.Ceiling(graphicsInternal.MeasureString(text, this.Font)).Width;
        }
        finally
        {
          graphicsInternal.Dispose();
        }
        if (width > num)
          this.SetColumnWidth(0, width);
      }
      lvItem.mask = 1;
      lvItem.iItem = itemIndex;
      lvItem.iSubItem = subItemIndex;
      lvItem.pszText = text;
      System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), System.Windows.Forms.NativeMethods.LVM_SETITEMTEXT, itemIndex, out lvItem);
    }

    internal void SetSelectionMark(int itemIndex)
    {
      if (itemIndex < 0 || itemIndex >= this.Items.Count)
        return;
      this.SendMessage(4163, 0, itemIndex);
    }

    private void SmallImageListRecreateHandle(object sender, EventArgs e)
    {
      if (!this.IsHandleCreated)
        return;
      this.SendMessage(4099, (IntPtr) 1, this.SmallImageList == null ? IntPtr.Zero : this.SmallImageList.Handle);
      this.ForceCheckBoxUpdate();
    }

    private void StateImageListRecreateHandle(object sender, EventArgs e)
    {
      if (!this.IsHandleCreated)
        return;
      IntPtr lparam = IntPtr.Zero;
      if (this.StateImageList != null)
        lparam = this.imageListState.Handle;
      this.SendMessage(4099, (IntPtr) 2, lparam);
    }

    internal void UpdateListViewItemsLocations()
    {
      if (this.VirtualMode || !this.IsHandleCreated || !this.AutoArrange)
        return;
      if (this.View != View.LargeIcon)
      {
        if (this.View != View.SmallIcon)
          return;
      }
      try
      {
        this.BeginUpdate();
        this.SendMessage(4138, -1, 0);
      }
      finally
      {
        this.EndUpdate();
      }
    }

    private void UpdateColumnWidths(ColumnHeaderAutoResizeStyle headerAutoResize)
    {
      if (this.columnHeaders == null)
        return;
      for (int columnIndex = 0; columnIndex < this.columnHeaders.Length; ++columnIndex)
        this.SetColumnWidth(columnIndex, headerAutoResize);
    }

    internal void UpdateGroupNative(ListViewGroup group)
    {
      System.Windows.Forms.NativeMethods.LVGROUP lvgroup = new System.Windows.Forms.NativeMethods.LVGROUP();
      try
      {
        lvgroup = this.GetLVGROUP(group);
        int num = (int) System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), 4243, group.ID, lvgroup);
      }
      finally
      {
        this.DestroyLVGROUP(lvgroup);
      }
      this.Invalidate();
    }

    internal void UpdateGroupView()
    {
      if (!this.IsHandleCreated || !this.ComctlSupportsVisualStyles || this.VirtualMode)
        return;
      long num = (long) this.SendMessage(4253, this.GroupsEnabled ? 1 : 0, 0);
    }

    private void UpdateTileView()
    {
      System.Windows.Forms.NativeMethods.LVTILEVIEWINFO lParam = new System.Windows.Forms.NativeMethods.LVTILEVIEWINFO();
      lParam.dwMask = 2;
      lParam.cLines = this.columnHeaders != null ? this.columnHeaders.Length : 0;
      lParam.dwMask |= 1;
      lParam.dwFlags = 3;
      lParam.sizeTile = new System.Windows.Forms.NativeMethods.SIZE(this.TileSize.Width, this.TileSize.Height);
      System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), 4258, 0, lParam);
    }

    private void WmNmClick(ref Message m)
    {
      if (!this.CheckBoxes)
        return;
      Point point = this.PointToClientInternal(Cursor.Position);
      System.Windows.Forms.NativeMethods.LVHITTESTINFO lParam = new System.Windows.Forms.NativeMethods.LVHITTESTINFO();
      lParam.pt_x = point.X;
      lParam.pt_y = point.Y;
      int index = (int) System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), 4114, 0, lParam);
      if (index == -1 || (lParam.flags & 8) == 0)
        return;
      ListViewItem listViewItem1 = this.Items[index];
      if (!listViewItem1.Selected)
        return;
      bool flag = !listViewItem1.Checked;
      if (this.VirtualMode)
        return;
      foreach (ListViewItem listViewItem2 in this.SelectedItems)
      {
        if (listViewItem2 != listViewItem1)
          listViewItem2.Checked = flag;
      }
    }

    private void WmNmDblClick(ref Message m)
    {
      if (!this.CheckBoxes)
        return;
      Point point = this.PointToClientInternal(Cursor.Position);
      System.Windows.Forms.NativeMethods.LVHITTESTINFO lParam = new System.Windows.Forms.NativeMethods.LVHITTESTINFO();
      lParam.pt_x = point.X;
      lParam.pt_y = point.Y;
      int index = (int) System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), 4114, 0, lParam);
      if (index == -1 || (lParam.flags & 14) == 0)
        return;
      ListViewItem listViewItem = this.Items[index];
      listViewItem.Checked = !listViewItem.Checked;
    }

    private void WmMouseDown(ref Message m, MouseButtons button, int clicks)
    {
      this.listViewState[524288] = false;
      this.listViewState[1048576] = true;
      this.FocusInternal();
      int x = System.Windows.Forms.NativeMethods.Util.SignedLOWORD(m.LParam);
      int y = System.Windows.Forms.NativeMethods.Util.SignedHIWORD(m.LParam);
      this.OnMouseDown(new MouseEventArgs(button, clicks, x, y, 0));
      if (this.ValidationCancelled)
        return;
      if (this.CheckBoxes && this.imageListState != null && this.imageListState.Images.Count < 2)
      {
        if (this.HitTest(x, y).Location == ListViewHitTestLocations.StateImage)
          return;
        this.DefWndProc(ref m);
      }
      else
        this.DefWndProc(ref m);
    }

    private unsafe bool WmNotify(ref Message m)
    {
      System.Windows.Forms.NativeMethods.NMHDR* nmhdrPtr = (System.Windows.Forms.NativeMethods.NMHDR*) (void*) m.LParam;
      if (nmhdrPtr->code == -12)
      {
        if (this.OwnerDraw)
        {
          try
          {
            System.Windows.Forms.NativeMethods.NMCUSTOMDRAW* nmcustomdrawPtr = (System.Windows.Forms.NativeMethods.NMCUSTOMDRAW*) (void*) m.LParam;
            switch (nmcustomdrawPtr->dwDrawStage)
            {
              case 1:
                m.Result = (IntPtr) 32;
                return true;
              case 65537:
                Graphics graphics = Graphics.FromHdcInternal(nmcustomdrawPtr->hdc);
                Rectangle bounds = Rectangle.FromLTRB(nmcustomdrawPtr->rc.left, nmcustomdrawPtr->rc.top, nmcustomdrawPtr->rc.right, nmcustomdrawPtr->rc.bottom);
                DrawListViewColumnHeaderEventArgs e = (DrawListViewColumnHeaderEventArgs) null;
                try
                {
                  Color foreColor = ColorTranslator.FromWin32(System.Windows.Forms.SafeNativeMethods.GetTextColor(new HandleRef((object) this, nmcustomdrawPtr->hdc)));
                  Color backColor = ColorTranslator.FromWin32(System.Windows.Forms.SafeNativeMethods.GetBkColor(new HandleRef((object) this, nmcustomdrawPtr->hdc)));
                  Font listHeaderFont = this.GetListHeaderFont();
                  e = new DrawListViewColumnHeaderEventArgs(graphics, bounds, (int) nmcustomdrawPtr->dwItemSpec, this.columnHeaders[(int) nmcustomdrawPtr->dwItemSpec], (ListViewItemStates) nmcustomdrawPtr->uItemState, foreColor, backColor, listHeaderFont);
                  this.OnDrawColumnHeader(e);
                }
                finally
                {
                  graphics.Dispose();
                }
                if (e.DrawDefault)
                {
                  m.Result = (IntPtr) 0;
                  return false;
                }
                else
                {
                  m.Result = (IntPtr) 4;
                  return true;
                }
              default:
                return false;
            }
          }
          catch (Exception ex)
          {
            m.Result = (IntPtr) 0;
          }
        }
      }
      if (nmhdrPtr->code == -16 && this.listViewState[131072])
      {
        this.listViewState[131072] = false;
        this.OnColumnClick(new ColumnClickEventArgs(this.columnIndex));
      }
      if (nmhdrPtr->code == -306 || nmhdrPtr->code == -326)
      {
        this.listViewState[67108864] = true;
        this.listViewState1[2] = false;
        this.newWidthForColumnWidthChangingCancelled = -1;
        this.listViewState1[2] = false;
        System.Windows.Forms.NativeMethods.NMHEADER nmheader = (System.Windows.Forms.NativeMethods.NMHEADER) m.GetLParam(typeof (System.Windows.Forms.NativeMethods.NMHEADER));
        if (this.columnHeaders != null && this.columnHeaders.Length > nmheader.iItem)
        {
          this.columnHeaderClicked = this.columnHeaders[nmheader.iItem];
          this.columnHeaderClickedWidth = this.columnHeaderClicked.Width;
        }
        else
        {
          this.columnHeaderClickedWidth = -1;
          this.columnHeaderClicked = (ColumnHeader) null;
        }
      }
      if (nmhdrPtr->code == -300 || nmhdrPtr->code == -320)
      {
        System.Windows.Forms.NativeMethods.NMHEADER nmheader = (System.Windows.Forms.NativeMethods.NMHEADER) m.GetLParam(typeof (System.Windows.Forms.NativeMethods.NMHEADER));
        if (this.columnHeaders != null && nmheader.iItem < this.columnHeaders.Length && (this.listViewState[67108864] || this.listViewState[536870912]))
        {
          System.Windows.Forms.NativeMethods.HDITEM2 hditeM2 = (System.Windows.Forms.NativeMethods.HDITEM2) System.Windows.Forms.UnsafeNativeMethods.PtrToStructure(nmheader.pItem, typeof (System.Windows.Forms.NativeMethods.HDITEM2));
          int newWidth = (hditeM2.mask & 1) != 0 ? hditeM2.cxy : -1;
          ColumnWidthChangingEventArgs e = new ColumnWidthChangingEventArgs(nmheader.iItem, newWidth);
          this.OnColumnWidthChanging(e);
          m.Result = (IntPtr) (e.Cancel ? 1 : 0);
          if (!e.Cancel)
            return false;
          hditeM2.cxy = e.NewWidth;
          if (this.listViewState[536870912])
            this.listViewState[1073741824] = true;
          this.listViewState1[2] = true;
          this.newWidthForColumnWidthChangingCancelled = e.NewWidth;
          return true;
        }
      }
      if ((nmhdrPtr->code == -301 || nmhdrPtr->code == -321) && !this.listViewState[67108864])
      {
        System.Windows.Forms.NativeMethods.NMHEADER nmheader = (System.Windows.Forms.NativeMethods.NMHEADER) m.GetLParam(typeof (System.Windows.Forms.NativeMethods.NMHEADER));
        if (this.columnHeaders != null && nmheader.iItem < this.columnHeaders.Length)
        {
          int width = this.columnHeaders[nmheader.iItem].Width;
          if (this.columnHeaderClicked == null || this.columnHeaderClicked == this.columnHeaders[nmheader.iItem] && this.columnHeaderClickedWidth != -1 && this.columnHeaderClickedWidth != width)
          {
            if (this.listViewState[536870912])
            {
              if (this.CompensateColumnHeaderResize(m, this.listViewState[1073741824]) == 0)
                this.OnColumnWidthChanged(new ColumnWidthChangedEventArgs(nmheader.iItem));
            }
            else
              this.OnColumnWidthChanged(new ColumnWidthChangedEventArgs(nmheader.iItem));
          }
        }
        this.columnHeaderClicked = (ColumnHeader) null;
        this.columnHeaderClickedWidth = -1;
        ISite site = this.Site;
        if (site != null)
        {
          IComponentChangeService componentChangeService = (IComponentChangeService) site.GetService(typeof (IComponentChangeService));
          if (componentChangeService != null)
          {
            try
            {
              componentChangeService.OnComponentChanging((object) this, (MemberDescriptor) null);
            }
            catch (CheckoutException ex)
            {
              if (ex == CheckoutException.Canceled)
                return false;
              else
                throw ex;
            }
          }
        }
      }
      if (nmhdrPtr->code == -307 || nmhdrPtr->code == -327)
      {
        this.listViewState[67108864] = false;
        if (!this.listViewState1[2])
          return false;
        m.Result = (IntPtr) 1;
        if (this.newWidthForColumnWidthChangingCancelled != -1)
        {
          System.Windows.Forms.NativeMethods.NMHEADER nmheader = (System.Windows.Forms.NativeMethods.NMHEADER) m.GetLParam(typeof (System.Windows.Forms.NativeMethods.NMHEADER));
          if (this.columnHeaders != null && this.columnHeaders.Length > nmheader.iItem)
            this.columnHeaders[nmheader.iItem].Width = this.newWidthForColumnWidthChangingCancelled;
        }
        this.listViewState1[2] = false;
        this.newWidthForColumnWidthChangingCancelled = -1;
        return true;
      }
      else
      {
        if (nmhdrPtr->code == -311)
        {
          System.Windows.Forms.NativeMethods.NMHEADER nmheader = (System.Windows.Forms.NativeMethods.NMHEADER) m.GetLParam(typeof (System.Windows.Forms.NativeMethods.NMHEADER));
          if (nmheader.pItem != IntPtr.Zero)
          {
            System.Windows.Forms.NativeMethods.HDITEM2 hditeM2 = (System.Windows.Forms.NativeMethods.HDITEM2) System.Windows.Forms.UnsafeNativeMethods.PtrToStructure(nmheader.pItem, typeof (System.Windows.Forms.NativeMethods.HDITEM2));
            if ((hditeM2.mask & 128) == 128)
            {
              int displayIndex = this.Columns[nmheader.iItem].DisplayIndex;
              int num1 = hditeM2.iOrder;
              if (displayIndex == num1 || num1 < 0)
                return false;
              ColumnReorderedEventArgs e = new ColumnReorderedEventArgs(displayIndex, num1, this.Columns[nmheader.iItem]);
              this.OnColumnReordered(e);
              if (e.Cancel)
              {
                m.Result = new IntPtr(1);
                return true;
              }
              else
              {
                int num2 = Math.Min(displayIndex, num1);
                int num3 = Math.Max(displayIndex, num1);
                bool flag = num1 > displayIndex;
                ColumnHeader columnHeader1 = (ColumnHeader) null;
                int[] indices = new int[this.Columns.Count];
                for (int index = 0; index < this.Columns.Count; ++index)
                {
                  ColumnHeader columnHeader2 = this.Columns[index];
                  if (columnHeader2.DisplayIndex == displayIndex)
                    columnHeader1 = columnHeader2;
                  else if (columnHeader2.DisplayIndex >= num2 && columnHeader2.DisplayIndex <= num3)
                    columnHeader2.DisplayIndexInternal -= flag ? 1 : -1;
                  indices[index] = columnHeader2.DisplayIndexInternal;
                }
                columnHeader1.DisplayIndexInternal = num1;
                indices[columnHeader1.Index] = columnHeader1.DisplayIndexInternal;
                this.SetDisplayIndices(indices);
              }
            }
          }
        }
        if (nmhdrPtr->code != -305 && nmhdrPtr->code != -325)
          return false;
        this.listViewState[536870912] = true;
        this.listViewState[1073741824] = false;
        bool columnResizeCancelled = false;
        try
        {
          this.DefWndProc(ref m);
        }
        finally
        {
          this.listViewState[536870912] = false;
          columnResizeCancelled = this.listViewState[1073741824];
          this.listViewState[1073741824] = false;
        }
        this.columnHeaderClicked = (ColumnHeader) null;
        this.columnHeaderClickedWidth = -1;
        if (columnResizeCancelled)
        {
          if (this.newWidthForColumnWidthChangingCancelled != -1)
          {
            System.Windows.Forms.NativeMethods.NMHEADER nmheader = (System.Windows.Forms.NativeMethods.NMHEADER) m.GetLParam(typeof (System.Windows.Forms.NativeMethods.NMHEADER));
            if (this.columnHeaders != null && this.columnHeaders.Length > nmheader.iItem)
              this.columnHeaders[nmheader.iItem].Width = this.newWidthForColumnWidthChangingCancelled;
          }
          m.Result = (IntPtr) 1;
        }
        else
        {
          int num = this.CompensateColumnHeaderResize(m, columnResizeCancelled);
          if (num != 0)
            this.columnHeaders[0].Width += num;
        }
        return true;
      }
    }

    private Font GetListHeaderFont()
    {
      IntPtr hfont = System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), 4127, 0, 0)), 49, 0, 0);
      System.Windows.Forms.IntSecurity.ObjectFromWin32Handle.Assert();
      return Font.FromHfont(hfont);
    }

    private int GetIndexOfClickedItem(System.Windows.Forms.NativeMethods.LVHITTESTINFO lvhi)
    {
      Point point = this.PointToClientInternal(Cursor.Position);
      lvhi.pt_x = point.X;
      lvhi.pt_y = point.Y;
      return (int) System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), 4114, 0, lvhi);
    }

    internal void RecreateHandleInternal()
    {
      if (this.IsHandleCreated && this.StateImageList != null)
        this.SendMessage(4099, 2, IntPtr.Zero);
      this.RecreateHandle();
    }

    private unsafe void WmReflectNotify(ref Message m)
    {
      System.Windows.Forms.NativeMethods.NMHDR* nmhdrPtr = (System.Windows.Forms.NativeMethods.NMHDR*) (void*) m.LParam;
      switch (nmhdrPtr->code)
      {
        case -114:
          this.OnItemActivate(EventArgs.Empty);
          break;
        case -113:
          System.Windows.Forms.NativeMethods.NMLVCACHEHINT nmlvcachehint = (System.Windows.Forms.NativeMethods.NMLVCACHEHINT) m.GetLParam(typeof (System.Windows.Forms.NativeMethods.NMLVCACHEHINT));
          this.OnCacheVirtualItems(new CacheVirtualItemsEventArgs(nmlvcachehint.iFrom, nmlvcachehint.iTo));
          break;
        case -111:
          if (this.ItemCollectionChangedInMouseDown)
            break;
          this.LvnBeginDrag(MouseButtons.Right, (System.Windows.Forms.NativeMethods.NMLISTVIEW) m.GetLParam(typeof (System.Windows.Forms.NativeMethods.NMLISTVIEW)));
          break;
        case -109:
          if (this.ItemCollectionChangedInMouseDown)
            break;
          this.LvnBeginDrag(MouseButtons.Left, (System.Windows.Forms.NativeMethods.NMLISTVIEW) m.GetLParam(typeof (System.Windows.Forms.NativeMethods.NMLISTVIEW)));
          break;
        case -108:
          System.Windows.Forms.NativeMethods.NMLISTVIEW nmlistview = (System.Windows.Forms.NativeMethods.NMLISTVIEW) m.GetLParam(typeof (System.Windows.Forms.NativeMethods.NMLISTVIEW));
          this.listViewState[131072] = true;
          this.columnIndex = nmlistview.iSubItem;
          break;
        case -106:
        case -176:
          this.listViewState[16384] = false;
          System.Windows.Forms.NativeMethods.NMLVDISPINFO nmlvdispinfo = (System.Windows.Forms.NativeMethods.NMLVDISPINFO) m.GetLParam(typeof (System.Windows.Forms.NativeMethods.NMLVDISPINFO));
          LabelEditEventArgs e1 = new LabelEditEventArgs(nmlvdispinfo.item.iItem, nmlvdispinfo.item.pszText);
          this.OnAfterLabelEdit(e1);
          m.Result = (IntPtr) (e1.CancelEdit ? 0 : 1);
          if (e1.CancelEdit || nmlvdispinfo.item.pszText == null)
            break;
          this.Items[nmlvdispinfo.item.iItem].Text = nmlvdispinfo.item.pszText;
          break;
        case -105:
        case -175:
          LabelEditEventArgs e2 = new LabelEditEventArgs(((System.Windows.Forms.NativeMethods.NMLVDISPINFO_NOTEXT) m.GetLParam(typeof (System.Windows.Forms.NativeMethods.NMLVDISPINFO_NOTEXT))).item.iItem);
          this.OnBeforeLabelEdit(e2);
          m.Result = (IntPtr) (e2.CancelEdit ? 1 : 0);
          this.listViewState[16384] = !e2.CancelEdit;
          break;
        case -101:
          System.Windows.Forms.NativeMethods.NMLISTVIEW* nmlistviewPtr1 = (System.Windows.Forms.NativeMethods.NMLISTVIEW*) (void*) m.LParam;
          if ((nmlistviewPtr1->uChanged & 8) == 0)
            break;
          CheckState checkState = (nmlistviewPtr1->uOldState & 61440) >> 12 == 1 ? CheckState.Unchecked : CheckState.Checked;
          if (((nmlistviewPtr1->uNewState & 61440) >> 12 == 1 ? CheckState.Unchecked : CheckState.Checked) != checkState)
            this.OnItemChecked(new ItemCheckedEventArgs(this.Items[nmlistviewPtr1->iItem]));
          int num1 = nmlistviewPtr1->uOldState & 2;
          int num2 = nmlistviewPtr1->uNewState & 2;
          if (num2 == num1)
            break;
          if (this.VirtualMode && nmlistviewPtr1->iItem == -1)
          {
            if (this.VirtualListSize > 0)
              this.OnVirtualItemsSelectionRangeChanged(new ListViewVirtualItemsSelectionRangeChangedEventArgs(0, this.VirtualListSize - 1, num2 != 0));
          }
          else if (this.Items.Count > 0)
            this.OnItemSelectionChanged(new ListViewItemSelectionChangedEventArgs(this.Items[nmlistviewPtr1->iItem], nmlistviewPtr1->iItem, num2 != 0));
          if (this.Items.Count == 0 || this.Items[this.Items.Count - 1] != null)
          {
            this.listViewState1[16] = false;
            this.OnSelectedIndexChanged(EventArgs.Empty);
            break;
          }
          else
          {
            this.listViewState1[16] = true;
            break;
          }
        case -100:
          System.Windows.Forms.NativeMethods.NMLISTVIEW* nmlistviewPtr2 = (System.Windows.Forms.NativeMethods.NMLISTVIEW*) (void*) m.LParam;
          if ((nmlistviewPtr2->uChanged & 8) == 0)
            break;
          CheckState currentValue = (nmlistviewPtr2->uOldState & 61440) >> 12 == 1 ? CheckState.Unchecked : CheckState.Checked;
          CheckState newCheckValue = (nmlistviewPtr2->uNewState & 61440) >> 12 == 1 ? CheckState.Unchecked : CheckState.Checked;
          if (currentValue == newCheckValue)
            break;
          ItemCheckEventArgs ice = new ItemCheckEventArgs(nmlistviewPtr2->iItem, newCheckValue, currentValue);
          this.OnItemCheck(ice);
          m.Result = (IntPtr) ((ice.NewValue == CheckState.Unchecked ? CheckState.Unchecked : CheckState.Checked) == currentValue ? 1 : 0);
          break;
        case -12:
          this.CustomDraw(ref m);
          break;
        case -6:
          if (this.GetIndexOfClickedItem(new System.Windows.Forms.NativeMethods.LVHITTESTINFO()) != -1)
            this.listViewState[262144] = true;
          this.listViewState[524288] = false;
          this.CaptureInternal = true;
          break;
        case -5:
          int indexOfClickedItem = this.GetIndexOfClickedItem(new System.Windows.Forms.NativeMethods.LVHITTESTINFO());
          MouseButtons button = nmhdrPtr->code == -2 ? MouseButtons.Left : MouseButtons.Right;
          Point point = this.PointToClientInternal(Cursor.Position);
          if (!this.ValidationCancelled && indexOfClickedItem != -1)
          {
            this.OnClick(EventArgs.Empty);
            this.OnMouseClick(new MouseEventArgs(button, 1, point.X, point.Y, 0));
          }
          if (this.listViewState[524288])
            break;
          this.OnMouseUp(new MouseEventArgs(button, 1, point.X, point.Y, 0));
          this.listViewState[524288] = true;
          break;
        case -3:
          this.WmNmDblClick(ref m);
          goto case -6;
        case -2:
          this.WmNmClick(ref m);
          goto case -5;
        case -155:
          if (!this.CheckBoxes || (int) ((System.Windows.Forms.NativeMethods.NMLVKEYDOWN) m.GetLParam(typeof (System.Windows.Forms.NativeMethods.NMLVKEYDOWN))).wVKey != 32)
            break;
          ListViewItem focusedItem = this.FocusedItem;
          if (focusedItem == null)
            break;
          bool flag = !focusedItem.Checked;
          if (this.VirtualMode)
            break;
          IEnumerator enumerator = this.SelectedItems.GetEnumerator();
          try
          {
            while (enumerator.MoveNext())
            {
              ListViewItem listViewItem = (ListViewItem) enumerator.Current;
              if (listViewItem != focusedItem)
                listViewItem.Checked = flag;
            }
            break;
          }
          finally
          {
            IDisposable disposable = enumerator as IDisposable;
            if (disposable != null)
              disposable.Dispose();
          }
        default:
          if (nmhdrPtr->code == System.Windows.Forms.NativeMethods.LVN_GETDISPINFO)
          {
            if (!this.VirtualMode || !(m.LParam != IntPtr.Zero))
              break;
            System.Windows.Forms.NativeMethods.NMLVDISPINFO_NOTEXT nmlvdispinfoNotext = (System.Windows.Forms.NativeMethods.NMLVDISPINFO_NOTEXT) m.GetLParam(typeof (System.Windows.Forms.NativeMethods.NMLVDISPINFO_NOTEXT));
            RetrieveVirtualItemEventArgs e3 = new RetrieveVirtualItemEventArgs(nmlvdispinfoNotext.item.iItem);
            this.OnRetrieveVirtualItem(e3);
            ListViewItem listViewItem = e3.Item;
            if (listViewItem == null)
              throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewVirtualItemRequired"));
            listViewItem.SetItemIndex(this, nmlvdispinfoNotext.item.iItem);
            if ((nmlvdispinfoNotext.item.mask & 1) != 0)
            {
              string str;
              if (nmlvdispinfoNotext.item.iSubItem == 0)
              {
                str = listViewItem.Text;
              }
              else
              {
                if (listViewItem.SubItems.Count <= nmlvdispinfoNotext.item.iSubItem)
                  throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewVirtualModeCantAccessSubItem"));
                str = listViewItem.SubItems[nmlvdispinfoNotext.item.iSubItem].Text;
              }
              if (nmlvdispinfoNotext.item.cchTextMax <= str.Length)
                str = str.Substring(0, nmlvdispinfoNotext.item.cchTextMax - 1);
              if (Marshal.SystemDefaultCharSize == 1)
                Marshal.Copy(Encoding.Default.GetBytes(str + "\0"), 0, nmlvdispinfoNotext.item.pszText, str.Length + 1);
              else
                Marshal.Copy((str + "\0").ToCharArray(), 0, nmlvdispinfoNotext.item.pszText, str.Length + 1);
            }
            if ((nmlvdispinfoNotext.item.mask & 2) != 0 && listViewItem.ImageIndex != -1)
              nmlvdispinfoNotext.item.iImage = listViewItem.ImageIndex;
            if ((nmlvdispinfoNotext.item.mask & 16) != 0)
              nmlvdispinfoNotext.item.iIndent = listViewItem.IndentCount;
            if ((nmlvdispinfoNotext.item.stateMask & 61440) != 0)
              nmlvdispinfoNotext.item.state |= listViewItem.RawStateImageIndex;
            Marshal.StructureToPtr((object) nmlvdispinfoNotext, m.LParam, false);
            break;
          }
          else if (nmhdrPtr->code == -115)
          {
            if (!this.VirtualMode || !(m.LParam != IntPtr.Zero))
              break;
            System.Windows.Forms.NativeMethods.NMLVODSTATECHANGE nmlvodstatechange = (System.Windows.Forms.NativeMethods.NMLVODSTATECHANGE) m.GetLParam(typeof (System.Windows.Forms.NativeMethods.NMLVODSTATECHANGE));
            if ((nmlvodstatechange.uNewState & 2) == (nmlvodstatechange.uOldState & 2))
              break;
            int endIndex = nmlvodstatechange.iTo;
            if (!System.Windows.Forms.UnsafeNativeMethods.IsVista)
              --endIndex;
            this.OnVirtualItemsSelectionRangeChanged(new ListViewVirtualItemsSelectionRangeChangedEventArgs(nmlvodstatechange.iFrom, endIndex, (nmlvodstatechange.uNewState & 2) != 0));
            break;
          }
          else if (nmhdrPtr->code == System.Windows.Forms.NativeMethods.LVN_GETINFOTIP)
          {
            if (!this.ShowItemToolTips || !(m.LParam != IntPtr.Zero))
              break;
            System.Windows.Forms.NativeMethods.NMLVGETINFOTIP nmlvgetinfotip = (System.Windows.Forms.NativeMethods.NMLVGETINFOTIP) m.GetLParam(typeof (System.Windows.Forms.NativeMethods.NMLVGETINFOTIP));
            ListViewItem listViewItem = this.Items[nmlvgetinfotip.item];
            if (listViewItem == null || string.IsNullOrEmpty(listViewItem.ToolTipText))
              break;
            System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, nmhdrPtr->hwndFrom), 1048, 0, SystemInformation.MaxWindowTrackSize.Width);
            if (Marshal.SystemDefaultCharSize == 1)
            {
              byte[] bytes = Encoding.Default.GetBytes(listViewItem.ToolTipText + "\0");
              Marshal.Copy(bytes, 0, nmlvgetinfotip.lpszText, Math.Min(bytes.Length, nmlvgetinfotip.cchTextMax));
            }
            else
            {
              char[] source = (listViewItem.ToolTipText + "\0").ToCharArray();
              Marshal.Copy(source, 0, nmlvgetinfotip.lpszText, Math.Min(source.Length, nmlvgetinfotip.cchTextMax));
            }
            Marshal.StructureToPtr((object) nmlvgetinfotip, m.LParam, false);
            break;
          }
          else
          {
            if (nmhdrPtr->code != System.Windows.Forms.NativeMethods.LVN_ODFINDITEM || !this.VirtualMode)
              break;
            System.Windows.Forms.NativeMethods.NMLVFINDITEM nmlvfinditem = (System.Windows.Forms.NativeMethods.NMLVFINDITEM) m.GetLParam(typeof (System.Windows.Forms.NativeMethods.NMLVFINDITEM));
            if ((nmlvfinditem.lvfi.flags & 1) != 0)
            {
              m.Result = (IntPtr) -1;
              break;
            }
            else
            {
              bool isTextSearch = (nmlvfinditem.lvfi.flags & 2) != 0 || (nmlvfinditem.lvfi.flags & 8) != 0;
              bool isPrefixSearch = (nmlvfinditem.lvfi.flags & 8) != 0;
              string text = string.Empty;
              if (isTextSearch)
                text = nmlvfinditem.lvfi.psz;
              Point startingPoint = Point.Empty;
              if ((nmlvfinditem.lvfi.flags & 64) != 0)
                startingPoint = new Point(nmlvfinditem.lvfi.ptX, nmlvfinditem.lvfi.ptY);
              SearchDirectionHint direction = SearchDirectionHint.Down;
              if ((nmlvfinditem.lvfi.flags & 64) != 0)
                direction = (SearchDirectionHint) nmlvfinditem.lvfi.vkDirection;
              if (nmlvfinditem.iStart >= this.VirtualListSize)
                ;
              SearchForVirtualItemEventArgs e3 = new SearchForVirtualItemEventArgs(isTextSearch, isPrefixSearch, false, text, startingPoint, direction, nmlvfinditem.iStart);
              this.OnSearchForVirtualItem(e3);
              if (e3.Index != -1)
              {
                m.Result = (IntPtr) e3.Index;
                break;
              }
              else
              {
                m.Result = (IntPtr) -1;
                break;
              }
            }
          }
      }
    }

    private void WmPrint(ref Message m)
    {
      base.WndProc(ref m);
      if ((2 & (int) m.LParam) == 0 || !Application.RenderWithVisualStyles || this.BorderStyle != BorderStyle.Fixed3D)
        return;
      System.Windows.Forms.IntSecurity.UnmanagedCode.Assert();
      try
      {
        using (Graphics graphics = Graphics.FromHdc(m.WParam))
        {
          Rectangle rect = new Rectangle(0, 0, this.Size.Width - 1, this.Size.Height - 1);
          graphics.DrawRectangle(new Pen(VisualStyleInformation.TextControlBorder), rect);
          rect.Inflate(-1, -1);
          graphics.DrawRectangle(SystemPens.Window, rect);
        }
      }
      finally
      {
        CodeAccessPermission.RevertAssert();
      }
    }

    [ListBindable(false)]
    public class CheckedIndexCollection : IList, ICollection, IEnumerable
    {
      private System.Windows.Forms.ListView owner;

      [Browsable(false)]
      public int Count
      {
        get
        {
          if (!this.owner.CheckBoxes)
            return 0;
          int num = 0;
          foreach (ListViewItem listViewItem in this.owner.Items)
          {
            if (listViewItem != null && listViewItem.Checked)
              ++num;
          }
          return num;
        }
      }

      int[] IndicesArray
      {
        private get
        {
          int[] numArray = new int[this.Count];
          int num = 0;
          for (int index = 0; index < this.owner.Items.Count && num < numArray.Length; ++index)
          {
            if (this.owner.Items[index].Checked)
              numArray[num++] = index;
          }
          return numArray;
        }
      }

      public int this[int index]
      {
        get
        {
          if (index < 0)
          {
            throw new ArgumentOutOfRangeException("index", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "index", (object) index.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
          }
          else
          {
            int count = this.owner.Items.Count;
            int num = 0;
            for (int index1 = 0; index1 < count; ++index1)
            {
              if (this.owner.Items[index1].Checked)
              {
                if (num == index)
                  return index1;
                ++num;
              }
            }
            throw new ArgumentOutOfRangeException("index", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "index", (object) index.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
          }
        }
      }

      object ICollection.SyncRoot
      {
        get
        {
          return (object) this;
        }
      }

      bool ICollection.IsSynchronized
      {
        get
        {
          return false;
        }
      }

      bool IList.IsFixedSize
      {
        get
        {
          return true;
        }
      }

      public bool IsReadOnly
      {
        get
        {
          return true;
        }
      }

      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
      public CheckedIndexCollection(System.Windows.Forms.ListView owner)
      {
        this.owner = owner;
      }

      object IList.get_Item(int index)
      {
        return (object) this[index];
      }

      void IList.set_Item(int index, object value)
      {
        throw new NotSupportedException();
      }

      public bool Contains(int checkedIndex)
      {
        return this.owner.Items[checkedIndex].Checked;
      }

      bool IList.Contains(object checkedIndex)
      {
        if (checkedIndex is int)
          return this.Contains((int) checkedIndex);
        else
          return false;
      }

      public int IndexOf(int checkedIndex)
      {
        int[] indicesArray = this.IndicesArray;
        for (int index = 0; index < indicesArray.Length; ++index)
        {
          if (indicesArray[index] == checkedIndex)
            return index;
        }
        return -1;
      }

      int IList.IndexOf(object checkedIndex)
      {
        if (checkedIndex is int)
          return this.IndexOf((int) checkedIndex);
        else
          return -1;
      }

      int IList.Add(object value)
      {
        throw new NotSupportedException();
      }

      void IList.Clear()
      {
        throw new NotSupportedException();
      }

      void IList.Insert(int index, object value)
      {
        throw new NotSupportedException();
      }

      void IList.Remove(object value)
      {
        throw new NotSupportedException();
      }

      void IList.RemoveAt(int index)
      {
        throw new NotSupportedException();
      }

      void ICollection.CopyTo(Array dest, int index)
      {
        if (this.Count <= 0)
          return;
        Array.Copy((Array) this.IndicesArray, 0, dest, index, this.Count);
      }

      public IEnumerator GetEnumerator()
      {
        int[] indicesArray = this.IndicesArray;
        if (indicesArray != null)
          return indicesArray.GetEnumerator();
        else
          return new int[0].GetEnumerator();
      }
    }

    [ListBindable(false)]
    public class CheckedListViewItemCollection : IList, ICollection, IEnumerable
    {
      private int lastAccessedIndex = -1;
      private System.Windows.Forms.ListView owner;

      [Browsable(false)]
      public int Count
      {
        get
        {
          if (this.owner.VirtualMode)
            throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantAccessCheckedItemsCollectionWhenInVirtualMode"));
          else
            return this.owner.CheckedIndices.Count;
        }
      }

      ListViewItem[] ItemArray
      {
        private get
        {
          ListViewItem[] listViewItemArray = new ListViewItem[this.Count];
          int num = 0;
          for (int index = 0; index < this.owner.Items.Count && num < listViewItemArray.Length; ++index)
          {
            if (this.owner.Items[index].Checked)
              listViewItemArray[num++] = this.owner.Items[index];
          }
          return listViewItemArray;
        }
      }

      public ListViewItem this[int index]
      {
        get
        {
          if (this.owner.VirtualMode)
            throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantAccessCheckedItemsCollectionWhenInVirtualMode"));
          else
            return this.owner.Items[this.owner.CheckedIndices[index]];
        }
      }

      public virtual ListViewItem this[string key]
      {
        get
        {
          if (this.owner.VirtualMode)
            throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantAccessCheckedItemsCollectionWhenInVirtualMode"));
          if (string.IsNullOrEmpty(key))
            return (ListViewItem) null;
          int index = this.IndexOfKey(key);
          if (this.IsValidIndex(index))
            return this[index];
          else
            return (ListViewItem) null;
        }
      }

      object ICollection.SyncRoot
      {
        get
        {
          return (object) this;
        }
      }

      bool ICollection.IsSynchronized
      {
        get
        {
          return false;
        }
      }

      bool IList.IsFixedSize
      {
        get
        {
          return true;
        }
      }

      public bool IsReadOnly
      {
        get
        {
          return true;
        }
      }

      public CheckedListViewItemCollection(System.Windows.Forms.ListView owner)
      {
        this.owner = owner;
      }

      object IList.get_Item(int index)
      {
        if (this.owner.VirtualMode)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantAccessCheckedItemsCollectionWhenInVirtualMode"));
        else
          return (object) this[index];
      }

      void IList.set_Item(int index, object value)
      {
        throw new NotSupportedException();
      }

      public bool Contains(ListViewItem item)
      {
        if (this.owner.VirtualMode)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantAccessCheckedItemsCollectionWhenInVirtualMode"));
        return item != null && item.ListView == this.owner && item.Checked;
      }

      bool IList.Contains(object item)
      {
        if (this.owner.VirtualMode)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantAccessCheckedItemsCollectionWhenInVirtualMode"));
        if (item is ListViewItem)
          return this.Contains((ListViewItem) item);
        else
          return false;
      }

      public virtual bool ContainsKey(string key)
      {
        if (this.owner.VirtualMode)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantAccessCheckedItemsCollectionWhenInVirtualMode"));
        else
          return this.IsValidIndex(this.IndexOfKey(key));
      }

      public int IndexOf(ListViewItem item)
      {
        if (this.owner.VirtualMode)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantAccessCheckedItemsCollectionWhenInVirtualMode"));
        ListViewItem[] itemArray = this.ItemArray;
        for (int index = 0; index < itemArray.Length; ++index)
        {
          if (itemArray[index] == item)
            return index;
        }
        return -1;
      }

      public virtual int IndexOfKey(string key)
      {
        if (this.owner.VirtualMode)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantAccessCheckedItemsCollectionWhenInVirtualMode"));
        if (string.IsNullOrEmpty(key))
          return -1;
        if (this.IsValidIndex(this.lastAccessedIndex) && WindowsFormsUtils.SafeCompareStrings(this[this.lastAccessedIndex].Name, key, true))
          return this.lastAccessedIndex;
        for (int index = 0; index < this.Count; ++index)
        {
          if (WindowsFormsUtils.SafeCompareStrings(this[index].Name, key, true))
          {
            this.lastAccessedIndex = index;
            return index;
          }
        }
        this.lastAccessedIndex = -1;
        return -1;
      }

      int IList.IndexOf(object item)
      {
        if (this.owner.VirtualMode)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantAccessCheckedItemsCollectionWhenInVirtualMode"));
        if (item is ListViewItem)
          return this.IndexOf((ListViewItem) item);
        else
          return -1;
      }

      int IList.Add(object value)
      {
        throw new NotSupportedException();
      }

      void IList.Clear()
      {
        throw new NotSupportedException();
      }

      void IList.Insert(int index, object value)
      {
        throw new NotSupportedException();
      }

      void IList.Remove(object value)
      {
        throw new NotSupportedException();
      }

      void IList.RemoveAt(int index)
      {
        throw new NotSupportedException();
      }

      public void CopyTo(Array dest, int index)
      {
        if (this.owner.VirtualMode)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantAccessCheckedItemsCollectionWhenInVirtualMode"));
        if (this.Count <= 0)
          return;
        Array.Copy((Array) this.ItemArray, 0, dest, index, this.Count);
      }

      public IEnumerator GetEnumerator()
      {
        if (this.owner.VirtualMode)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantAccessCheckedItemsCollectionWhenInVirtualMode"));
        ListViewItem[] itemArray = this.ItemArray;
        if (itemArray != null)
          return itemArray.GetEnumerator();
        else
          return new ListViewItem[0].GetEnumerator();
      }

      private bool IsValidIndex(int index)
      {
        if (index >= 0)
          return index < this.Count;
        else
          return false;
      }
    }

    [ListBindable(false)]
    public class SelectedIndexCollection : IList, ICollection, IEnumerable
    {
      private System.Windows.Forms.ListView owner;

      [Browsable(false)]
      public int Count
      {
        get
        {
          if (this.owner.IsHandleCreated)
            return (int) (long) this.owner.SendMessage(4146, 0, 0);
          if (this.owner.savedSelectedItems != null)
            return this.owner.savedSelectedItems.Count;
          else
            return 0;
        }
      }

      int[] IndicesArray
      {
        private get
        {
          int count = this.Count;
          int[] numArray = new int[count];
          if (this.owner.IsHandleCreated)
          {
            int wparam = -1;
            for (int index = 0; index < count; ++index)
            {
              int num = (int) (long) this.owner.SendMessage(4108, wparam, 2);
              if (num <= -1)
                throw new InvalidOperationException(System.Windows.Forms.SR.GetString("SelectedNotEqualActual"));
              numArray[index] = num;
              wparam = num;
            }
          }
          else
          {
            for (int index = 0; index < count; ++index)
              numArray[index] = this.owner.savedSelectedItems[index].Index;
          }
          return numArray;
        }
      }

      public int this[int index]
      {
        get
        {
          if (index < 0 || index >= this.Count)
          {
            throw new ArgumentOutOfRangeException("index", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "index", (object) index.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
          }
          else
          {
            if (!this.owner.IsHandleCreated)
              return this.owner.savedSelectedItems[index].Index;
            int wparam = -1;
            for (int index1 = 0; index1 <= index; ++index1)
              wparam = (int) (long) this.owner.SendMessage(4108, wparam, 2);
            return wparam;
          }
        }
      }

      object ICollection.SyncRoot
      {
        get
        {
          return (object) this;
        }
      }

      bool ICollection.IsSynchronized
      {
        get
        {
          return false;
        }
      }

      bool IList.IsFixedSize
      {
        get
        {
          return false;
        }
      }

      public bool IsReadOnly
      {
        get
        {
          return false;
        }
      }

      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
      public SelectedIndexCollection(System.Windows.Forms.ListView owner)
      {
        this.owner = owner;
      }

      object IList.get_Item(int index)
      {
        return (object) this[index];
      }

      void IList.set_Item(int index, object value)
      {
        throw new NotSupportedException();
      }

      public bool Contains(int selectedIndex)
      {
        return this.owner.Items[selectedIndex].Selected;
      }

      bool IList.Contains(object selectedIndex)
      {
        if (selectedIndex is int)
          return this.Contains((int) selectedIndex);
        else
          return false;
      }

      public int IndexOf(int selectedIndex)
      {
        int[] indicesArray = this.IndicesArray;
        for (int index = 0; index < indicesArray.Length; ++index)
        {
          if (indicesArray[index] == selectedIndex)
            return index;
        }
        return -1;
      }

      int IList.IndexOf(object selectedIndex)
      {
        if (selectedIndex is int)
          return this.IndexOf((int) selectedIndex);
        else
          return -1;
      }

      int IList.Add(object value)
      {
        if (value is int)
          return this.Add((int) value);
        throw new ArgumentException(System.Windows.Forms.SR.GetString("InvalidArgument", (object) "value", (object) value.ToString()));
      }

      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
      void IList.Clear()
      {
        this.Clear();
      }

      void IList.Insert(int index, object value)
      {
        throw new NotSupportedException();
      }

      void IList.Remove(object value)
      {
        if (value is int)
          this.Remove((int) value);
        else
          throw new ArgumentException(System.Windows.Forms.SR.GetString("InvalidArgument", (object) "value", (object) value.ToString()));
      }

      void IList.RemoveAt(int index)
      {
        throw new NotSupportedException();
      }

      public int Add(int itemIndex)
      {
        if (this.owner.VirtualMode)
        {
          if (itemIndex < 0 || itemIndex >= this.owner.VirtualListSize)
          {
            throw new ArgumentOutOfRangeException("itemIndex", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "itemIndex", (object) itemIndex.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
          }
          else
          {
            if (!this.owner.IsHandleCreated)
              return -1;
            this.owner.SetItemState(itemIndex, 2, 2);
            return this.Count;
          }
        }
        else if (itemIndex < 0 || itemIndex >= this.owner.Items.Count)
        {
          throw new ArgumentOutOfRangeException("itemIndex", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "itemIndex", (object) itemIndex.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
        }
        else
        {
          this.owner.Items[itemIndex].Selected = true;
          return this.Count;
        }
      }

      public void Clear()
      {
        if (!this.owner.VirtualMode)
          this.owner.savedSelectedItems = (List<ListViewItem>) null;
        if (!this.owner.IsHandleCreated)
          return;
        this.owner.SetItemState(-1, 0, 2);
      }

      public void CopyTo(Array dest, int index)
      {
        if (this.Count <= 0)
          return;
        Array.Copy((Array) this.IndicesArray, 0, dest, index, this.Count);
      }

      public IEnumerator GetEnumerator()
      {
        int[] indicesArray = this.IndicesArray;
        if (indicesArray != null)
          return indicesArray.GetEnumerator();
        else
          return new int[0].GetEnumerator();
      }

      public void Remove(int itemIndex)
      {
        if (this.owner.VirtualMode)
        {
          if (itemIndex < 0 || itemIndex >= this.owner.VirtualListSize)
          {
            throw new ArgumentOutOfRangeException("itemIndex", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "itemIndex", (object) itemIndex.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
          }
          else
          {
            if (!this.owner.IsHandleCreated)
              return;
            this.owner.SetItemState(itemIndex, 0, 2);
          }
        }
        else if (itemIndex < 0 || itemIndex >= this.owner.Items.Count)
          throw new ArgumentOutOfRangeException("itemIndex", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "itemIndex", (object) itemIndex.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
        else
          this.owner.Items[itemIndex].Selected = false;
      }
    }

    [ListBindable(false)]
    public class SelectedListViewItemCollection : IList, ICollection, IEnumerable
    {
      private int lastAccessedIndex = -1;
      private System.Windows.Forms.ListView owner;

      ListViewItem[] SelectedItemArray
      {
        private get
        {
          if (this.owner.IsHandleCreated)
          {
            int length = (int) (long) this.owner.SendMessage(4146, 0, 0);
            ListViewItem[] listViewItemArray = new ListViewItem[length];
            int wparam = -1;
            for (int index1 = 0; index1 < length; ++index1)
            {
              int index2 = (int) (long) this.owner.SendMessage(4108, wparam, 2);
              if (index2 <= -1)
                throw new InvalidOperationException(System.Windows.Forms.SR.GetString("SelectedNotEqualActual"));
              listViewItemArray[index1] = this.owner.Items[index2];
              wparam = index2;
            }
            return listViewItemArray;
          }
          else
          {
            if (this.owner.savedSelectedItems == null)
              return new ListViewItem[0];
            ListViewItem[] listViewItemArray = new ListViewItem[this.owner.savedSelectedItems.Count];
            for (int index = 0; index < this.owner.savedSelectedItems.Count; ++index)
              listViewItemArray[index] = this.owner.savedSelectedItems[index];
            return listViewItemArray;
          }
        }
      }

      [Browsable(false)]
      public int Count
      {
        get
        {
          if (this.owner.VirtualMode)
            throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantAccessSelectedItemsCollectionWhenInVirtualMode"));
          if (this.owner.IsHandleCreated)
            return (int) (long) this.owner.SendMessage(4146, 0, 0);
          if (this.owner.savedSelectedItems != null)
            return this.owner.savedSelectedItems.Count;
          else
            return 0;
        }
      }

      public ListViewItem this[int index]
      {
        get
        {
          if (this.owner.VirtualMode)
            throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantAccessSelectedItemsCollectionWhenInVirtualMode"));
          if (index < 0 || index >= this.Count)
          {
            throw new ArgumentOutOfRangeException("index", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "index", (object) index.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
          }
          else
          {
            if (!this.owner.IsHandleCreated)
              return this.owner.savedSelectedItems[index];
            int wparam = -1;
            for (int index1 = 0; index1 <= index; ++index1)
              wparam = (int) (long) this.owner.SendMessage(4108, wparam, 2);
            return this.owner.Items[wparam];
          }
        }
      }

      public virtual ListViewItem this[string key]
      {
        get
        {
          if (this.owner.VirtualMode)
            throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantAccessSelectedItemsCollectionWhenInVirtualMode"));
          if (string.IsNullOrEmpty(key))
            return (ListViewItem) null;
          int index = this.IndexOfKey(key);
          if (this.IsValidIndex(index))
            return this[index];
          else
            return (ListViewItem) null;
        }
      }

      bool IList.IsFixedSize
      {
        get
        {
          return true;
        }
      }

      public bool IsReadOnly
      {
        get
        {
          return true;
        }
      }

      object ICollection.SyncRoot
      {
        get
        {
          return (object) this;
        }
      }

      bool ICollection.IsSynchronized
      {
        get
        {
          return false;
        }
      }

      public SelectedListViewItemCollection(System.Windows.Forms.ListView owner)
      {
        this.owner = owner;
      }

      object IList.get_Item(int index)
      {
        if (this.owner.VirtualMode)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantAccessSelectedItemsCollectionWhenInVirtualMode"));
        else
          return (object) this[index];
      }

      void IList.set_Item(int index, object value)
      {
        throw new NotSupportedException();
      }

      int IList.Add(object value)
      {
        throw new NotSupportedException();
      }

      void IList.Insert(int index, object value)
      {
        throw new NotSupportedException();
      }

      void IList.Remove(object value)
      {
        throw new NotSupportedException();
      }

      void IList.RemoveAt(int index)
      {
        throw new NotSupportedException();
      }

      public void Clear()
      {
        if (this.owner.VirtualMode)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantAccessSelectedItemsCollectionWhenInVirtualMode"));
        foreach (ListViewItem listViewItem in this.SelectedItemArray)
          listViewItem.Selected = false;
      }

      public virtual bool ContainsKey(string key)
      {
        if (this.owner.VirtualMode)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantAccessSelectedItemsCollectionWhenInVirtualMode"));
        else
          return this.IsValidIndex(this.IndexOfKey(key));
      }

      public bool Contains(ListViewItem item)
      {
        if (this.owner.VirtualMode)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantAccessSelectedItemsCollectionWhenInVirtualMode"));
        else
          return this.IndexOf(item) != -1;
      }

      bool IList.Contains(object item)
      {
        if (this.owner.VirtualMode)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantAccessSelectedItemsCollectionWhenInVirtualMode"));
        if (item is ListViewItem)
          return this.Contains((ListViewItem) item);
        else
          return false;
      }

      public void CopyTo(Array dest, int index)
      {
        if (this.owner.VirtualMode)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantAccessSelectedItemsCollectionWhenInVirtualMode"));
        if (this.Count <= 0)
          return;
        Array.Copy((Array) this.SelectedItemArray, 0, dest, index, this.Count);
      }

      public IEnumerator GetEnumerator()
      {
        if (this.owner.VirtualMode)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantAccessSelectedItemsCollectionWhenInVirtualMode"));
        ListViewItem[] selectedItemArray = this.SelectedItemArray;
        if (selectedItemArray != null)
          return selectedItemArray.GetEnumerator();
        else
          return new ListViewItem[0].GetEnumerator();
      }

      public int IndexOf(ListViewItem item)
      {
        if (this.owner.VirtualMode)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantAccessSelectedItemsCollectionWhenInVirtualMode"));
        ListViewItem[] selectedItemArray = this.SelectedItemArray;
        for (int index = 0; index < selectedItemArray.Length; ++index)
        {
          if (selectedItemArray[index] == item)
            return index;
        }
        return -1;
      }

      int IList.IndexOf(object item)
      {
        if (this.owner.VirtualMode)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantAccessSelectedItemsCollectionWhenInVirtualMode"));
        if (item is ListViewItem)
          return this.IndexOf((ListViewItem) item);
        else
          return -1;
      }

      public virtual int IndexOfKey(string key)
      {
        if (this.owner.VirtualMode)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantAccessSelectedItemsCollectionWhenInVirtualMode"));
        if (string.IsNullOrEmpty(key))
          return -1;
        if (this.IsValidIndex(this.lastAccessedIndex) && WindowsFormsUtils.SafeCompareStrings(this[this.lastAccessedIndex].Name, key, true))
          return this.lastAccessedIndex;
        for (int index = 0; index < this.Count; ++index)
        {
          if (WindowsFormsUtils.SafeCompareStrings(this[index].Name, key, true))
          {
            this.lastAccessedIndex = index;
            return index;
          }
        }
        this.lastAccessedIndex = -1;
        return -1;
      }

      private bool IsValidIndex(int index)
      {
        if (index >= 0)
          return index < this.Count;
        else
          return false;
      }
    }

    [ListBindable(false)]
    public class ColumnHeaderCollection : IList, ICollection, IEnumerable
    {
      private int lastAccessedIndex = -1;
      private System.Windows.Forms.ListView owner;

      public virtual ColumnHeader this[int index]
      {
        get
        {
          if (this.owner.columnHeaders != null && index >= 0 && index < this.owner.columnHeaders.Length)
            return this.owner.columnHeaders[index];
          throw new ArgumentOutOfRangeException("index", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "index", (object) index.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
        }
      }

      public virtual ColumnHeader this[string key]
      {
        get
        {
          if (string.IsNullOrEmpty(key))
            return (ColumnHeader) null;
          int index = this.IndexOfKey(key);
          if (this.IsValidIndex(index))
            return this[index];
          else
            return (ColumnHeader) null;
        }
      }

      [Browsable(false)]
      public int Count
      {
        get
        {
          if (this.owner.columnHeaders != null)
            return this.owner.columnHeaders.Length;
          else
            return 0;
        }
      }

      object ICollection.SyncRoot
      {
        get
        {
          return (object) this;
        }
      }

      bool ICollection.IsSynchronized
      {
        get
        {
          return true;
        }
      }

      bool IList.IsFixedSize
      {
        get
        {
          return false;
        }
      }

      public bool IsReadOnly
      {
        get
        {
          return false;
        }
      }

      public ColumnHeaderCollection(System.Windows.Forms.ListView owner)
      {
        this.owner = owner;
      }

      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
      object IList.get_Item(int index)
      {
        return (object) this[index];
      }

      void IList.set_Item(int index, object value)
      {
        throw new NotSupportedException();
      }

      public virtual void RemoveByKey(string key)
      {
        int index = this.IndexOfKey(key);
        if (!this.IsValidIndex(index))
          return;
        this.RemoveAt(index);
      }

      public virtual int IndexOfKey(string key)
      {
        if (string.IsNullOrEmpty(key))
          return -1;
        if (this.IsValidIndex(this.lastAccessedIndex) && WindowsFormsUtils.SafeCompareStrings(this[this.lastAccessedIndex].Name, key, true))
          return this.lastAccessedIndex;
        for (int index = 0; index < this.Count; ++index)
        {
          if (WindowsFormsUtils.SafeCompareStrings(this[index].Name, key, true))
          {
            this.lastAccessedIndex = index;
            return index;
          }
        }
        this.lastAccessedIndex = -1;
        return -1;
      }

      public virtual ColumnHeader Add(string text, int width, HorizontalAlignment textAlign)
      {
        return this.owner.InsertColumn(this.Count, new ColumnHeader()
        {
          Text = text,
          Width = width,
          TextAlign = textAlign
        });
      }

      public virtual int Add(ColumnHeader value)
      {
        int count = this.Count;
        this.owner.InsertColumn(count, value);
        return count;
      }

      public virtual ColumnHeader Add(string text)
      {
        return this.owner.InsertColumn(this.Count, new ColumnHeader()
        {
          Text = text
        });
      }

      public virtual ColumnHeader Add(string text, int width)
      {
        return this.owner.InsertColumn(this.Count, new ColumnHeader()
        {
          Text = text,
          Width = width
        });
      }

      public virtual ColumnHeader Add(string key, string text)
      {
        return this.owner.InsertColumn(this.Count, new ColumnHeader()
        {
          Name = key,
          Text = text
        });
      }

      public virtual ColumnHeader Add(string key, string text, int width)
      {
        return this.owner.InsertColumn(this.Count, new ColumnHeader()
        {
          Name = key,
          Text = text,
          Width = width
        });
      }

      public virtual ColumnHeader Add(string key, string text, int width, HorizontalAlignment textAlign, string imageKey)
      {
        return this.owner.InsertColumn(this.Count, new ColumnHeader(imageKey)
        {
          Name = key,
          Text = text,
          Width = width,
          TextAlign = textAlign
        });
      }

      public virtual ColumnHeader Add(string key, string text, int width, HorizontalAlignment textAlign, int imageIndex)
      {
        return this.owner.InsertColumn(this.Count, new ColumnHeader(imageIndex)
        {
          Name = key,
          Text = text,
          Width = width,
          TextAlign = textAlign
        });
      }

      public virtual void AddRange(ColumnHeader[] values)
      {
        if (values == null)
          throw new ArgumentNullException("values");
        Hashtable hashtable = new Hashtable();
        int[] indices = new int[values.Length];
        for (int index = 0; index < values.Length; ++index)
        {
          if (values[index].DisplayIndex == -1)
            values[index].DisplayIndexInternal = index;
          if (!hashtable.ContainsKey((object) values[index].DisplayIndex) && values[index].DisplayIndex >= 0 && values[index].DisplayIndex < values.Length)
            hashtable.Add((object) values[index].DisplayIndex, (object) index);
          indices[index] = values[index].DisplayIndex;
          this.Add(values[index]);
        }
        if (hashtable.Count != values.Length)
          return;
        this.owner.SetDisplayIndices(indices);
      }

      int IList.Add(object value)
      {
        if (value is ColumnHeader)
          return this.Add((ColumnHeader) value);
        else
          throw new ArgumentException(System.Windows.Forms.SR.GetString("ColumnHeaderCollectionInvalidArgument"));
      }

      public virtual void Clear()
      {
        if (this.owner.columnHeaders == null)
          return;
        if (this.owner.View == View.Tile)
        {
          for (int index = this.owner.columnHeaders.Length - 1; index >= 0; --index)
          {
            int width = this.owner.columnHeaders[index].Width;
            this.owner.columnHeaders[index].OwnerListview = (System.Windows.Forms.ListView) null;
          }
          this.owner.columnHeaders = (ColumnHeader[]) null;
          if (!this.owner.IsHandleCreated)
            return;
          this.owner.RecreateHandleInternal();
        }
        else
        {
          for (int wparam = this.owner.columnHeaders.Length - 1; wparam >= 0; --wparam)
          {
            int width = this.owner.columnHeaders[wparam].Width;
            if (this.owner.IsHandleCreated)
              this.owner.SendMessage(4124, wparam, 0);
            this.owner.columnHeaders[wparam].OwnerListview = (System.Windows.Forms.ListView) null;
          }
          this.owner.columnHeaders = (ColumnHeader[]) null;
        }
      }

      public bool Contains(ColumnHeader value)
      {
        return this.IndexOf(value) != -1;
      }

      bool IList.Contains(object value)
      {
        if (value is ColumnHeader)
          return this.Contains((ColumnHeader) value);
        else
          return false;
      }

      public virtual bool ContainsKey(string key)
      {
        return this.IsValidIndex(this.IndexOfKey(key));
      }

      void ICollection.CopyTo(Array dest, int index)
      {
        if (this.Count <= 0)
          return;
        Array.Copy((Array) this.owner.columnHeaders, 0, dest, index, this.Count);
      }

      public int IndexOf(ColumnHeader value)
      {
        for (int index = 0; index < this.Count; ++index)
        {
          if (this[index] == value)
            return index;
        }
        return -1;
      }

      int IList.IndexOf(object value)
      {
        if (value is ColumnHeader)
          return this.IndexOf((ColumnHeader) value);
        else
          return -1;
      }

      public void Insert(int index, ColumnHeader value)
      {
        if (index < 0 || index > this.Count)
          throw new ArgumentOutOfRangeException("index", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "index", (object) index.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
        else
          this.owner.InsertColumn(index, value);
      }

      void IList.Insert(int index, object value)
      {
        if (!(value is ColumnHeader))
          return;
        this.Insert(index, (ColumnHeader) value);
      }

      public void Insert(int index, string text, int width, HorizontalAlignment textAlign)
      {
        this.Insert(index, new ColumnHeader()
        {
          Text = text,
          Width = width,
          TextAlign = textAlign
        });
      }

      public void Insert(int index, string text)
      {
        this.Insert(index, new ColumnHeader()
        {
          Text = text
        });
      }

      public void Insert(int index, string text, int width)
      {
        this.Insert(index, new ColumnHeader()
        {
          Text = text,
          Width = width
        });
      }

      public void Insert(int index, string key, string text)
      {
        this.Insert(index, new ColumnHeader()
        {
          Name = key,
          Text = text
        });
      }

      public void Insert(int index, string key, string text, int width)
      {
        this.Insert(index, new ColumnHeader()
        {
          Name = key,
          Text = text,
          Width = width
        });
      }

      public void Insert(int index, string key, string text, int width, HorizontalAlignment textAlign, string imageKey)
      {
        this.Insert(index, new ColumnHeader(imageKey)
        {
          Name = key,
          Text = text,
          Width = width,
          TextAlign = textAlign
        });
      }

      public void Insert(int index, string key, string text, int width, HorizontalAlignment textAlign, int imageIndex)
      {
        this.Insert(index, new ColumnHeader(imageIndex)
        {
          Name = key,
          Text = text,
          Width = width,
          TextAlign = textAlign
        });
      }

      public virtual void RemoveAt(int index)
      {
        if (index < 0 || index >= this.owner.columnHeaders.Length)
        {
          throw new ArgumentOutOfRangeException("index", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "index", (object) index.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
        }
        else
        {
          int width = this.owner.columnHeaders[index].Width;
          if (this.owner.IsHandleCreated && this.owner.View != View.Tile && (int) (long) this.owner.SendMessage(4124, index, 0) == 0)
          {
            throw new ArgumentException(System.Windows.Forms.SR.GetString("InvalidArgument", (object) "index", (object) index.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
          }
          else
          {
            int[] indices = new int[this.Count - 1];
            ColumnHeader columnHeader1 = this[index];
            for (int index1 = 0; index1 < this.Count; ++index1)
            {
              ColumnHeader columnHeader2 = this[index1];
              if (index1 != index)
              {
                if (columnHeader2.DisplayIndex >= columnHeader1.DisplayIndex)
                  --columnHeader2.DisplayIndexInternal;
                indices[index1 > index ? index1 - 1 : index1] = columnHeader2.DisplayIndexInternal;
              }
            }
            columnHeader1.DisplayIndexInternal = -1;
            this.owner.columnHeaders[index].OwnerListview = (System.Windows.Forms.ListView) null;
            int length = this.owner.columnHeaders.Length;
            if (length == 1)
            {
              this.owner.columnHeaders = (ColumnHeader[]) null;
            }
            else
            {
              int num;
              ColumnHeader[] columnHeaderArray = new ColumnHeader[num = length - 1];
              if (index > 0)
                Array.Copy((Array) this.owner.columnHeaders, 0, (Array) columnHeaderArray, 0, index);
              if (index < num)
                Array.Copy((Array) this.owner.columnHeaders, index + 1, (Array) columnHeaderArray, index, num - index);
              this.owner.columnHeaders = columnHeaderArray;
            }
            if (this.owner.IsHandleCreated && this.owner.View == View.Tile)
              this.owner.RecreateHandleInternal();
            this.owner.SetDisplayIndices(indices);
          }
        }
      }

      public virtual void Remove(ColumnHeader column)
      {
        int index = this.IndexOf(column);
        if (index == -1)
          return;
        this.RemoveAt(index);
      }

      void IList.Remove(object value)
      {
        if (!(value is ColumnHeader))
          return;
        this.Remove((ColumnHeader) value);
      }

      public IEnumerator GetEnumerator()
      {
        if (this.owner.columnHeaders != null)
          return this.owner.columnHeaders.GetEnumerator();
        else
          return new ColumnHeader[0].GetEnumerator();
      }

      private bool IsValidIndex(int index)
      {
        if (index >= 0)
          return index < this.Count;
        else
          return false;
      }
    }

    [ListBindable(false)]
    public class ListViewItemCollection : IList, ICollection, IEnumerable
    {
      private int lastAccessedIndex = -1;
      private System.Windows.Forms.ListView.ListViewItemCollection.IInnerList innerList;

      System.Windows.Forms.ListView.ListViewItemCollection.IInnerList InnerList
      {
        private get
        {
          return this.innerList;
        }
      }

      [Browsable(false)]
      public int Count
      {
        get
        {
          return this.InnerList.Count;
        }
      }

      object ICollection.SyncRoot
      {
        get
        {
          return (object) this;
        }
      }

      bool ICollection.IsSynchronized
      {
        get
        {
          return true;
        }
      }

      bool IList.IsFixedSize
      {
        get
        {
          return false;
        }
      }

      public bool IsReadOnly
      {
        get
        {
          return false;
        }
      }

      public virtual ListViewItem this[int index]
      {
        get
        {
          if (index >= 0 && index < this.InnerList.Count)
            return this.InnerList[index];
          throw new ArgumentOutOfRangeException("index", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "index", (object) index.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
        }
        set
        {
          if (index < 0 || index >= this.InnerList.Count)
            throw new ArgumentOutOfRangeException("index", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "index", (object) index.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
          else
            this.InnerList[index] = value;
        }
      }

      public virtual ListViewItem this[string key]
      {
        get
        {
          if (string.IsNullOrEmpty(key))
            return (ListViewItem) null;
          int index = this.IndexOfKey(key);
          if (this.IsValidIndex(index))
            return this[index];
          else
            return (ListViewItem) null;
        }
      }

      public ListViewItemCollection(System.Windows.Forms.ListView owner)
      {
        this.innerList = (System.Windows.Forms.ListView.ListViewItemCollection.IInnerList) new System.Windows.Forms.ListView.ListViewNativeItemCollection(owner);
      }

      internal ListViewItemCollection(System.Windows.Forms.ListView.ListViewItemCollection.IInnerList innerList)
      {
        this.innerList = innerList;
      }

      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
      object IList.get_Item(int index)
      {
        return (object) this[index];
      }

      void IList.set_Item(int index, object value)
      {
        if (value is ListViewItem)
        {
          this[index] = (ListViewItem) value;
        }
        else
        {
          if (value == null)
            return;
          this[index] = new ListViewItem(value.ToString(), -1);
        }
      }

      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
      public virtual ListViewItem Add(string text)
      {
        return this.Add(text, -1);
      }

      int IList.Add(object item)
      {
        if (item is ListViewItem)
          return this.IndexOf(this.Add((ListViewItem) item));
        if (item != null)
          return this.IndexOf(this.Add(item.ToString()));
        else
          return -1;
      }

      public virtual ListViewItem Add(string text, int imageIndex)
      {
        ListViewItem listViewItem = new ListViewItem(text, imageIndex);
        this.Add(listViewItem);
        return listViewItem;
      }

      public virtual ListViewItem Add(ListViewItem value)
      {
        this.InnerList.Add(value);
        return value;
      }

      public virtual ListViewItem Add(string text, string imageKey)
      {
        ListViewItem listViewItem = new ListViewItem(text, imageKey);
        this.Add(listViewItem);
        return listViewItem;
      }

      public virtual ListViewItem Add(string key, string text, string imageKey)
      {
        ListViewItem listViewItem = new ListViewItem(text, imageKey);
        listViewItem.Name = key;
        this.Add(listViewItem);
        return listViewItem;
      }

      public virtual ListViewItem Add(string key, string text, int imageIndex)
      {
        ListViewItem listViewItem = new ListViewItem(text, imageIndex);
        listViewItem.Name = key;
        this.Add(listViewItem);
        return listViewItem;
      }

      public void AddRange(ListViewItem[] items)
      {
        if (items == null)
          throw new ArgumentNullException("items");
        this.InnerList.AddRange(items);
      }

      public void AddRange(System.Windows.Forms.ListView.ListViewItemCollection items)
      {
        if (items == null)
          throw new ArgumentNullException("items");
        ListViewItem[] items1 = new ListViewItem[items.Count];
        items.CopyTo((Array) items1, 0);
        this.InnerList.AddRange(items1);
      }

      public virtual void Clear()
      {
        this.InnerList.Clear();
      }

      public bool Contains(ListViewItem item)
      {
        return this.InnerList.Contains(item);
      }

      bool IList.Contains(object item)
      {
        if (item is ListViewItem)
          return this.Contains((ListViewItem) item);
        else
          return false;
      }

      public virtual bool ContainsKey(string key)
      {
        return this.IsValidIndex(this.IndexOfKey(key));
      }

      public void CopyTo(Array dest, int index)
      {
        this.InnerList.CopyTo(dest, index);
      }

      public ListViewItem[] Find(string key, bool searchAllSubItems)
      {
        ArrayList @internal = this.FindInternal(key, searchAllSubItems, this, new ArrayList());
        ListViewItem[] listViewItemArray = new ListViewItem[@internal.Count];
        @internal.CopyTo((Array) listViewItemArray, 0);
        return listViewItemArray;
      }

      public IEnumerator GetEnumerator()
      {
        if (this.InnerList.OwnerIsVirtualListView && !this.InnerList.OwnerIsDesignMode)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantGetEnumeratorInVirtualMode"));
        else
          return this.InnerList.GetEnumerator();
      }

      public int IndexOf(ListViewItem item)
      {
        for (int index = 0; index < this.Count; ++index)
        {
          if (this[index] == item)
            return index;
        }
        return -1;
      }

      int IList.IndexOf(object item)
      {
        if (item is ListViewItem)
          return this.IndexOf((ListViewItem) item);
        else
          return -1;
      }

      public virtual int IndexOfKey(string key)
      {
        if (string.IsNullOrEmpty(key))
          return -1;
        if (this.IsValidIndex(this.lastAccessedIndex) && WindowsFormsUtils.SafeCompareStrings(this[this.lastAccessedIndex].Name, key, true))
          return this.lastAccessedIndex;
        for (int index = 0; index < this.Count; ++index)
        {
          if (WindowsFormsUtils.SafeCompareStrings(this[index].Name, key, true))
          {
            this.lastAccessedIndex = index;
            return index;
          }
        }
        this.lastAccessedIndex = -1;
        return -1;
      }

      public ListViewItem Insert(int index, ListViewItem item)
      {
        if (index < 0 || index > this.Count)
        {
          throw new ArgumentOutOfRangeException("index", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "index", (object) index.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
        }
        else
        {
          this.InnerList.Insert(index, item);
          return item;
        }
      }

      public ListViewItem Insert(int index, string text)
      {
        return this.Insert(index, new ListViewItem(text));
      }

      public ListViewItem Insert(int index, string text, int imageIndex)
      {
        return this.Insert(index, new ListViewItem(text, imageIndex));
      }

      void IList.Insert(int index, object item)
      {
        if (item is ListViewItem)
        {
          this.Insert(index, (ListViewItem) item);
        }
        else
        {
          if (item == null)
            return;
          this.Insert(index, item.ToString());
        }
      }

      public ListViewItem Insert(int index, string text, string imageKey)
      {
        return this.Insert(index, new ListViewItem(text, imageKey));
      }

      public virtual ListViewItem Insert(int index, string key, string text, string imageKey)
      {
        return this.Insert(index, new ListViewItem(text, imageKey)
        {
          Name = key
        });
      }

      public virtual ListViewItem Insert(int index, string key, string text, int imageIndex)
      {
        return this.Insert(index, new ListViewItem(text, imageIndex)
        {
          Name = key
        });
      }

      public virtual void Remove(ListViewItem item)
      {
        this.InnerList.Remove(item);
      }

      public virtual void RemoveAt(int index)
      {
        if (index < 0 || index >= this.Count)
          throw new ArgumentOutOfRangeException("index", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "index", (object) index.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
        else
          this.InnerList.RemoveAt(index);
      }

      public virtual void RemoveByKey(string key)
      {
        int index = this.IndexOfKey(key);
        if (!this.IsValidIndex(index))
          return;
        this.RemoveAt(index);
      }

      void IList.Remove(object item)
      {
        if (item == null || !(item is ListViewItem))
          return;
        this.Remove((ListViewItem) item);
      }

      private ArrayList FindInternal(string key, bool searchAllSubItems, System.Windows.Forms.ListView.ListViewItemCollection listViewItems, ArrayList foundItems)
      {
        if (listViewItems == null || foundItems == null)
          return (ArrayList) null;
        for (int index1 = 0; index1 < listViewItems.Count; ++index1)
        {
          if (WindowsFormsUtils.SafeCompareStrings(listViewItems[index1].Name, key, true))
            foundItems.Add((object) listViewItems[index1]);
          else if (searchAllSubItems)
          {
            for (int index2 = 1; index2 < listViewItems[index1].SubItems.Count; ++index2)
            {
              if (WindowsFormsUtils.SafeCompareStrings(listViewItems[index1].SubItems[index2].Name, key, true))
              {
                foundItems.Add((object) listViewItems[index1]);
                break;
              }
            }
          }
        }
        return foundItems;
      }

      private bool IsValidIndex(int index)
      {
        if (index >= 0)
          return index < this.Count;
        else
          return false;
      }

      internal interface IInnerList
      {
        int Count { get; }

        bool OwnerIsVirtualListView { get; }

        bool OwnerIsDesignMode { get; }

        ListViewItem this[int index] { get; set; }

        ListViewItem Add(ListViewItem item);

        void AddRange(ListViewItem[] items);

        void Clear();

        bool Contains(ListViewItem item);

        void CopyTo(Array dest, int index);

        IEnumerator GetEnumerator();

        int IndexOf(ListViewItem item);

        ListViewItem Insert(int index, ListViewItem item);

        void Remove(ListViewItem item);

        void RemoveAt(int index);
      }
    }

    internal class IconComparer : IComparer
    {
      private SortOrder sortOrder;

      public SortOrder SortOrder
      {
        set
        {
          this.sortOrder = value;
        }
      }

      public IconComparer(SortOrder currentSortOrder)
      {
        this.sortOrder = currentSortOrder;
      }

      public int Compare(object obj1, object obj2)
      {
        ListViewItem listViewItem1 = (ListViewItem) obj1;
        ListViewItem listViewItem2 = (ListViewItem) obj2;
        if (this.sortOrder == SortOrder.Ascending)
          return string.Compare(listViewItem1.Text, listViewItem2.Text, false, CultureInfo.CurrentCulture);
        else
          return string.Compare(listViewItem2.Text, listViewItem1.Text, false, CultureInfo.CurrentCulture);
      }
    }

    internal class ListViewNativeItemCollection : System.Windows.Forms.ListView.ListViewItemCollection.IInnerList
    {
      private System.Windows.Forms.ListView owner;

      public int Count
      {
        get
        {
          this.owner.ApplyUpdateCachedItems();
          if (this.owner.VirtualMode)
            return this.owner.VirtualListSize;
          else
            return this.owner.itemCount;
        }
      }

      public bool OwnerIsVirtualListView
      {
        get
        {
          return this.owner.VirtualMode;
        }
      }

      public bool OwnerIsDesignMode
      {
        get
        {
          return this.owner.DesignMode;
        }
      }

      public ListViewItem this[int displayIndex]
      {
        get
        {
          this.owner.ApplyUpdateCachedItems();
          if (this.owner.VirtualMode)
          {
            RetrieveVirtualItemEventArgs e = new RetrieveVirtualItemEventArgs(displayIndex);
            this.owner.OnRetrieveVirtualItem(e);
            e.Item.SetItemIndex(this.owner, displayIndex);
            return e.Item;
          }
          else if (displayIndex < 0 || displayIndex >= this.owner.itemCount)
            throw new ArgumentOutOfRangeException("displayIndex", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "displayIndex", (object) displayIndex.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
          else if (this.owner.IsHandleCreated && !this.owner.ListViewHandleDestroyed)
            return (ListViewItem) this.owner.listItemsTable[(object) this.DisplayIndexToID(displayIndex)];
          else
            return (ListViewItem) this.owner.listItemsArray[displayIndex];
        }
        set
        {
          this.owner.ApplyUpdateCachedItems();
          if (this.owner.VirtualMode)
            throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantModifyTheItemCollInAVirtualListView"));
          if (displayIndex < 0 || displayIndex >= this.owner.itemCount)
          {
            throw new ArgumentOutOfRangeException("displayIndex", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "displayIndex", (object) displayIndex.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
          }
          else
          {
            if (this.owner.ExpectingMouseUp)
              this.owner.ItemCollectionChangedInMouseDown = true;
            this.RemoveAt(displayIndex);
            this.Insert(displayIndex, value);
          }
        }
      }

      public ListViewNativeItemCollection(System.Windows.Forms.ListView owner)
      {
        this.owner = owner;
      }

      public ListViewItem Add(ListViewItem value)
      {
        if (this.owner.VirtualMode)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantAddItemsToAVirtualListView"));
        bool @checked = value.Checked;
        this.owner.InsertItems(this.owner.itemCount, new ListViewItem[1]
        {
          value
        }, 1 != 0);
        if (this.owner.IsHandleCreated && !this.owner.CheckBoxes && @checked)
          this.owner.UpdateSavedCheckedItems(value, true);
        if (this.owner.ExpectingMouseUp)
          this.owner.ItemCollectionChangedInMouseDown = true;
        return value;
      }

      public void AddRange(ListViewItem[] values)
      {
        if (values == null)
          throw new ArgumentNullException("values");
        if (this.owner.VirtualMode)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantAddItemsToAVirtualListView"));
        IComparer comparer = this.owner.listItemSorter;
        this.owner.listItemSorter = (IComparer) null;
        bool[] flagArray = (bool[]) null;
        if (this.owner.IsHandleCreated)
        {
          if (!this.owner.CheckBoxes)
          {
            flagArray = new bool[values.Length];
            for (int index = 0; index < values.Length; ++index)
              flagArray[index] = values[index].Checked;
          }
        }
        try
        {
          this.owner.BeginUpdate();
          this.owner.InsertItems(this.owner.itemCount, values, true);
          if (this.owner.IsHandleCreated)
          {
            if (!this.owner.CheckBoxes)
            {
              for (int index = 0; index < values.Length; ++index)
              {
                if (flagArray[index])
                  this.owner.UpdateSavedCheckedItems(values[index], true);
              }
            }
          }
        }
        finally
        {
          this.owner.listItemSorter = comparer;
          this.owner.EndUpdate();
        }
        if (this.owner.ExpectingMouseUp)
          this.owner.ItemCollectionChangedInMouseDown = true;
        if (comparer == null && (this.owner.Sorting == SortOrder.None || this.owner.VirtualMode))
          return;
        this.owner.Sort();
      }

      private int DisplayIndexToID(int displayIndex)
      {
        if (!this.owner.IsHandleCreated || this.owner.ListViewHandleDestroyed)
          return this[displayIndex].ID;
        System.Windows.Forms.NativeMethods.LVITEM lParam = new System.Windows.Forms.NativeMethods.LVITEM();
        lParam.mask = 4;
        lParam.iItem = displayIndex;
        System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this.owner, this.owner.Handle), System.Windows.Forms.NativeMethods.LVM_GETITEM, 0, out lParam);
        return (int) lParam.lParam;
      }

      public void Clear()
      {
        if (this.owner.itemCount <= 0)
          return;
        this.owner.ApplyUpdateCachedItems();
        if (this.owner.IsHandleCreated && !this.owner.ListViewHandleDestroyed)
        {
          int count = this.owner.Items.Count;
          int wParam = (int) System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this.owner, this.owner.Handle), 4108, -1, 2);
          for (int displayIndex = 0; displayIndex < count; ++displayIndex)
          {
            ListViewItem listViewItem = this.owner.Items[displayIndex];
            if (listViewItem != null)
            {
              if (displayIndex == wParam)
              {
                listViewItem.StateSelected = true;
                wParam = (int) System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this.owner, this.owner.Handle), 4108, wParam, 2);
              }
              else
                listViewItem.StateSelected = false;
              listViewItem.UnHost(displayIndex, false);
            }
          }
          System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this.owner, this.owner.Handle), 4105, 0, 0);
          if (this.owner.View == View.SmallIcon)
          {
            if (this.owner.ComctlSupportsVisualStyles)
            {
              this.owner.FlipViewToLargeIconAndSmallIcon = true;
            }
            else
            {
              this.owner.View = View.LargeIcon;
              this.owner.View = View.SmallIcon;
            }
          }
        }
        else
        {
          int count = this.owner.Items.Count;
          for (int displayIndex = 0; displayIndex < count; ++displayIndex)
          {
            ListViewItem listViewItem = this.owner.Items[displayIndex];
            if (listViewItem != null)
              listViewItem.UnHost(displayIndex, true);
          }
          this.owner.listItemsArray.Clear();
        }
        this.owner.listItemsTable.Clear();
        if (this.owner.IsHandleCreated && !this.owner.CheckBoxes)
          this.owner.savedCheckedItems = (List<ListViewItem>) null;
        this.owner.itemCount = 0;
        if (!this.owner.ExpectingMouseUp)
          return;
        this.owner.ItemCollectionChangedInMouseDown = true;
      }

      public bool Contains(ListViewItem item)
      {
        this.owner.ApplyUpdateCachedItems();
        if (this.owner.IsHandleCreated && !this.owner.ListViewHandleDestroyed)
          return this.owner.listItemsTable[(object) item.ID] == item;
        else
          return this.owner.listItemsArray.Contains((object) item);
      }

      public ListViewItem Insert(int index, ListViewItem item)
      {
        int num = !this.owner.VirtualMode ? this.owner.itemCount : this.Count;
        if (index < 0 || index > num)
        {
          throw new ArgumentOutOfRangeException("index", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "index", (object) index.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
        }
        else
        {
          if (this.owner.VirtualMode)
            throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantAddItemsToAVirtualListView"));
          if (index < num)
            this.owner.ApplyUpdateCachedItems();
          this.owner.InsertItems(index, new ListViewItem[1]
          {
            item
          }, 1 != 0);
          if (this.owner.IsHandleCreated && !this.owner.CheckBoxes && item.Checked)
            this.owner.UpdateSavedCheckedItems(item, true);
          if (this.owner.ExpectingMouseUp)
            this.owner.ItemCollectionChangedInMouseDown = true;
          return item;
        }
      }

      public int IndexOf(ListViewItem item)
      {
        for (int index = 0; index < this.Count; ++index)
        {
          if (item == this[index])
            return index;
        }
        return -1;
      }

      public void Remove(ListViewItem item)
      {
        int index = this.owner.VirtualMode ? this.Count - 1 : this.IndexOf(item);
        if (this.owner.VirtualMode)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantRemoveItemsFromAVirtualListView"));
        if (index == -1)
          return;
        this.RemoveAt(index);
      }

      public void RemoveAt(int index)
      {
        if (this.owner.VirtualMode)
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ListViewCantRemoveItemsFromAVirtualListView"));
        if (index < 0 || index >= this.owner.itemCount)
        {
          throw new ArgumentOutOfRangeException("index", System.Windows.Forms.SR.GetString("InvalidArgument", (object) "index", (object) index.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
        }
        else
        {
          if (this.owner.IsHandleCreated && !this.owner.CheckBoxes && this[index].Checked)
            this.owner.UpdateSavedCheckedItems(this[index], false);
          this.owner.ApplyUpdateCachedItems();
          int num = this.DisplayIndexToID(index);
          this[index].UnHost(true);
          if (this.owner.IsHandleCreated)
          {
            if ((int) (long) this.owner.SendMessage(4104, index, 0) == 0)
              throw new ArgumentException(System.Windows.Forms.SR.GetString("InvalidArgument", (object) "index", (object) index.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
          }
          else
            this.owner.listItemsArray.RemoveAt(index);
          --this.owner.itemCount;
          this.owner.listItemsTable.Remove((object) num);
          if (!this.owner.ExpectingMouseUp)
            return;
          this.owner.ItemCollectionChangedInMouseDown = true;
        }
      }

      public void CopyTo(Array dest, int index)
      {
        if (this.owner.itemCount <= 0)
          return;
        for (int index1 = 0; index1 < this.Count; ++index1)
          dest.SetValue((object) this[index1], index++);
      }

      public IEnumerator GetEnumerator()
      {
        ListViewItem[] listViewItemArray = new ListViewItem[this.owner.itemCount];
        this.CopyTo((Array) listViewItemArray, 0);
        return listViewItemArray.GetEnumerator();
      }
    }
  }
}
