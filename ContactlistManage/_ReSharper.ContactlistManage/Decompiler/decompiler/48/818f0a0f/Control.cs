// Type: System.Windows.Forms.Control
// Assembly: System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Windows.Forms.dll

using Accessibility;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Internal;
using System.IO;
using System.Reflection;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Windows.Forms.Internal;
using System.Windows.Forms.Layout;

namespace System.Windows.Forms
{
  [DefaultProperty("Text")]
  [Designer("System.Windows.Forms.Design.ControlDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [DesignerSerializer("System.Windows.Forms.Design.ControlCodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [ToolboxItemFilter("System.Windows.Forms")]
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  [ComVisible(true)]
  [DefaultEvent("Click")]
  public class Control : Component, System.Windows.Forms.UnsafeNativeMethods.IOleControl, System.Windows.Forms.UnsafeNativeMethods.IOleObject, System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceObject, System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceActiveObject, System.Windows.Forms.UnsafeNativeMethods.IOleWindow, System.Windows.Forms.UnsafeNativeMethods.IViewObject, System.Windows.Forms.UnsafeNativeMethods.IViewObject2, System.Windows.Forms.UnsafeNativeMethods.IPersist, System.Windows.Forms.UnsafeNativeMethods.IPersistStreamInit, System.Windows.Forms.UnsafeNativeMethods.IPersistPropertyBag, System.Windows.Forms.UnsafeNativeMethods.IPersistStorage, System.Windows.Forms.UnsafeNativeMethods.IQuickActivate, ISupportOleDropSource, IDropTarget, ISynchronizeInvoke, IWin32Window, IArrangedElement, IBindableComponent, IComponent, IDisposable
  {
    private static readonly object EventAutoSizeChanged = new object();
    private static readonly object EventKeyDown = new object();
    private static readonly object EventKeyPress = new object();
    private static readonly object EventKeyUp = new object();
    private static readonly object EventMouseDown = new object();
    private static readonly object EventMouseEnter = new object();
    private static readonly object EventMouseLeave = new object();
    private static readonly object EventMouseHover = new object();
    private static readonly object EventMouseMove = new object();
    private static readonly object EventMouseUp = new object();
    private static readonly object EventMouseWheel = new object();
    private static readonly object EventClick = new object();
    private static readonly object EventClientSize = new object();
    private static readonly object EventDoubleClick = new object();
    private static readonly object EventMouseClick = new object();
    private static readonly object EventMouseDoubleClick = new object();
    private static readonly object EventMouseCaptureChanged = new object();
    private static readonly object EventMove = new object();
    private static readonly object EventResize = new object();
    private static readonly object EventLayout = new object();
    private static readonly object EventGotFocus = new object();
    private static readonly object EventLostFocus = new object();
    private static readonly object EventEnabledChanged = new object();
    private static readonly object EventEnter = new object();
    private static readonly object EventLeave = new object();
    private static readonly object EventHandleCreated = new object();
    private static readonly object EventHandleDestroyed = new object();
    private static readonly object EventVisibleChanged = new object();
    private static readonly object EventControlAdded = new object();
    private static readonly object EventControlRemoved = new object();
    private static readonly object EventChangeUICues = new object();
    private static readonly object EventSystemColorsChanged = new object();
    private static readonly object EventValidating = new object();
    private static readonly object EventValidated = new object();
    private static readonly object EventStyleChanged = new object();
    private static readonly object EventImeModeChanged = new object();
    private static readonly object EventHelpRequested = new object();
    private static readonly object EventPaint = new object();
    private static readonly object EventInvalidated = new object();
    private static readonly object EventQueryContinueDrag = new object();
    private static readonly object EventGiveFeedback = new object();
    private static readonly object EventDragEnter = new object();
    private static readonly object EventDragLeave = new object();
    private static readonly object EventDragOver = new object();
    private static readonly object EventDragDrop = new object();
    private static readonly object EventQueryAccessibilityHelp = new object();
    private static readonly object EventBackgroundImage = new object();
    private static readonly object EventBackgroundImageLayout = new object();
    private static readonly object EventBindingContext = new object();
    private static readonly object EventBackColor = new object();
    private static readonly object EventParent = new object();
    private static readonly object EventVisible = new object();
    private static readonly object EventText = new object();
    private static readonly object EventTabStop = new object();
    private static readonly object EventTabIndex = new object();
    private static readonly object EventSize = new object();
    private static readonly object EventRightToLeft = new object();
    private static readonly object EventLocation = new object();
    private static readonly object EventForeColor = new object();
    private static readonly object EventFont = new object();
    private static readonly object EventEnabled = new object();
    private static readonly object EventDock = new object();
    private static readonly object EventCursor = new object();
    private static readonly object EventContextMenu = new object();
    private static readonly object EventContextMenuStrip = new object();
    private static readonly object EventCausesValidation = new object();
    private static readonly object EventRegionChanged = new object();
    private static readonly object EventMarginChanged = new object();
    internal static readonly object EventPaddingChanged = new object();
    private static readonly object EventPreviewKeyDown = new object();
    private static int mouseWheelMessage = 522;
    private static bool checkForIllegalCrossThreadCalls = Debugger.IsAttached;
    [ThreadStatic]
    private static bool inCrossThreadSafeCall = false;
    [ThreadStatic]
    internal static HelpInfo currentHelpInfo = (HelpInfo) null;
    private static readonly int PropName = PropertyStore.CreateKey();
    private static readonly int PropBackBrush = PropertyStore.CreateKey();
    private static readonly int PropFontHeight = PropertyStore.CreateKey();
    private static readonly int PropCurrentAmbientFont = PropertyStore.CreateKey();
    private static readonly int PropControlsCollection = PropertyStore.CreateKey();
    private static readonly int PropBackColor = PropertyStore.CreateKey();
    private static readonly int PropForeColor = PropertyStore.CreateKey();
    private static readonly int PropFont = PropertyStore.CreateKey();
    private static readonly int PropBackgroundImage = PropertyStore.CreateKey();
    private static readonly int PropFontHandleWrapper = PropertyStore.CreateKey();
    private static readonly int PropUserData = PropertyStore.CreateKey();
    private static readonly int PropContextMenu = PropertyStore.CreateKey();
    private static readonly int PropCursor = PropertyStore.CreateKey();
    private static readonly int PropRegion = PropertyStore.CreateKey();
    private static readonly int PropRightToLeft = PropertyStore.CreateKey();
    private static readonly int PropBindings = PropertyStore.CreateKey();
    private static readonly int PropBindingManager = PropertyStore.CreateKey();
    private static readonly int PropAccessibleDefaultActionDescription = PropertyStore.CreateKey();
    private static readonly int PropAccessibleDescription = PropertyStore.CreateKey();
    private static readonly int PropAccessibility = PropertyStore.CreateKey();
    private static readonly int PropNcAccessibility = PropertyStore.CreateKey();
    private static readonly int PropAccessibleName = PropertyStore.CreateKey();
    private static readonly int PropAccessibleRole = PropertyStore.CreateKey();
    private static readonly int PropPaintingException = PropertyStore.CreateKey();
    private static readonly int PropActiveXImpl = PropertyStore.CreateKey();
    private static readonly int PropControlVersionInfo = PropertyStore.CreateKey();
    private static readonly int PropBackgroundImageLayout = PropertyStore.CreateKey();
    private static readonly int PropAccessibleHelpProvider = PropertyStore.CreateKey();
    private static readonly int PropContextMenuStrip = PropertyStore.CreateKey();
    private static readonly int PropAutoScrollOffset = PropertyStore.CreateKey();
    private static readonly int PropUseCompatibleTextRendering = PropertyStore.CreateKey();
    private static readonly int PropImeWmCharsToIgnore = PropertyStore.CreateKey();
    private static readonly int PropImeMode = PropertyStore.CreateKey();
    private static readonly int PropDisableImeModeChangedCount = PropertyStore.CreateKey();
    private static readonly int PropLastCanEnableIme = PropertyStore.CreateKey();
    private static readonly int PropCacheTextCount = PropertyStore.CreateKey();
    private static readonly int PropCacheTextField = PropertyStore.CreateKey();
    private static readonly int PropAmbientPropertiesService = PropertyStore.CreateKey();
    internal static bool UseCompatibleTextRenderingDefault = true;
    private static ImeMode propagatingImeMode = ImeMode.Inherit;
    private static bool lastLanguageChinese = false;
    private static int WM_GETCONTROLNAME = System.Windows.Forms.SafeNativeMethods.RegisterWindowMessage("WM_GETCONTROLNAME");
    private static int WM_GETCONTROLTYPE = System.Windows.Forms.SafeNativeMethods.RegisterWindowMessage("WM_GETCONTROLTYPE");
    internal static readonly TraceSwitch ControlKeyboardRouting;
    internal static readonly TraceSwitch PaletteTracing;
    internal static readonly TraceSwitch FocusTracing;
    internal static readonly BooleanSwitch BufferPinkRect;
    private static bool mouseWheelRoutingNeeded;
    private static bool mouseWheelInit;
    private static int threadCallbackMessage;
    private static ContextCallback invokeMarshaledCallbackHelperDelegate;
    private static Control.FontHandleWrapper defaultFontHandleWrapper;
    private static Font defaultFont;
    private Control.ControlNativeWindow window;
    private Control parent;
    private Control reflectParent;
    private CreateParams createParams;
    private int x;
    private int y;
    private int width;
    private int height;
    private int clientWidth;
    private int clientHeight;
    private int state;
    private int state2;
    private ControlStyles controlStyle;
    private int tabIndex;
    private string text;
    private byte layoutSuspendCount;
    private byte requiredScaling;
    private PropertyStore propertyStore;
    private System.Windows.Forms.NativeMethods.TRACKMOUSEEVENT trackMouseEvent;
    private short updateCount;
    private LayoutEventArgs cachedLayoutEventArgs;
    private Queue threadCallbackList;
    private int uiCuesState;
    private static bool ignoreWmImeNotify;
    internal const int STATE_CREATED = 1;
    internal const int STATE_VISIBLE = 2;
    internal const int STATE_ENABLED = 4;
    internal const int STATE_TABSTOP = 8;
    internal const int STATE_RECREATE = 16;
    internal const int STATE_MODAL = 32;
    internal const int STATE_ALLOWDROP = 64;
    internal const int STATE_DROPTARGET = 128;
    internal const int STATE_NOZORDER = 256;
    internal const int STATE_LAYOUTDEFERRED = 512;
    internal const int STATE_USEWAITCURSOR = 1024;
    internal const int STATE_DISPOSED = 2048;
    internal const int STATE_DISPOSING = 4096;
    internal const int STATE_MOUSEENTERPENDING = 8192;
    internal const int STATE_TRACKINGMOUSEEVENT = 16384;
    internal const int STATE_THREADMARSHALLPENDING = 32768;
    internal const int STATE_SIZELOCKEDBYOS = 65536;
    internal const int STATE_CAUSESVALIDATION = 131072;
    internal const int STATE_CREATINGHANDLE = 262144;
    internal const int STATE_TOPLEVEL = 524288;
    internal const int STATE_ISACCESSIBLE = 1048576;
    internal const int STATE_OWNCTLBRUSH = 2097152;
    internal const int STATE_EXCEPTIONWHILEPAINTING = 4194304;
    internal const int STATE_LAYOUTISDIRTY = 8388608;
    internal const int STATE_CHECKEDHOST = 16777216;
    internal const int STATE_HOSTEDINDIALOG = 33554432;
    internal const int STATE_DOUBLECLICKFIRED = 67108864;
    internal const int STATE_MOUSEPRESSED = 134217728;
    internal const int STATE_VALIDATIONCANCELLED = 268435456;
    internal const int STATE_PARENTRECREATING = 536870912;
    internal const int STATE_MIRRORED = 1073741824;
    private const int STATE2_HAVEINVOKED = 1;
    private const int STATE2_SETSCROLLPOS = 2;
    private const int STATE2_LISTENINGTOUSERPREFERENCECHANGED = 4;
    internal const int STATE2_INTERESTEDINUSERPREFERENCECHANGED = 8;
    internal const int STATE2_MAINTAINSOWNCAPTUREMODE = 16;
    private const int STATE2_BECOMINGACTIVECONTROL = 32;
    private const int STATE2_CLEARLAYOUTARGS = 64;
    private const int STATE2_INPUTKEY = 128;
    private const int STATE2_INPUTCHAR = 256;
    private const int STATE2_UICUES = 512;
    private const int STATE2_ISACTIVEX = 1024;
    internal const int STATE2_USEPREFERREDSIZECACHE = 2048;
    private const short PaintLayerBackground = (short) 1;
    private const short PaintLayerForeground = (short) 2;
    private const byte RequiredScalingEnabledMask = (byte) 16;
    private const byte RequiredScalingMask = (byte) 15;
    private const int UISTATE_FOCUS_CUES_MASK = 15;
    private const int UISTATE_FOCUS_CUES_HIDDEN = 1;
    private const int UISTATE_FOCUS_CUES_SHOW = 2;
    private const int UISTATE_KEYBOARD_CUES_MASK = 240;
    private const int UISTATE_KEYBOARD_CUES_HIDDEN = 16;
    private const int UISTATE_KEYBOARD_CUES_SHOW = 32;
    private const int ImeCharsToIgnoreDisabled = -1;
    private const int ImeCharsToIgnoreEnabled = 0;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Browsable(false)]
    [SRDescription("ControlAccessibilityObjectDescr")]
    public AccessibleObject AccessibilityObject
    {
      get
      {
        AccessibleObject accessibleObject = (AccessibleObject) this.Properties.GetObject(Control.PropAccessibility);
        if (accessibleObject == null)
        {
          accessibleObject = this.CreateAccessibilityInstance();
          if (!(accessibleObject is Control.ControlAccessibleObject))
            return (AccessibleObject) null;
          this.Properties.SetObject(Control.PropAccessibility, (object) accessibleObject);
        }
        return accessibleObject;
      }
    }

    AccessibleObject NcAccessibilityObject
    {
      private get
      {
        AccessibleObject accessibleObject = (AccessibleObject) this.Properties.GetObject(Control.PropNcAccessibility);
        if (accessibleObject == null)
        {
          accessibleObject = (AccessibleObject) new Control.ControlAccessibleObject(this, 0);
          this.Properties.SetObject(Control.PropNcAccessibility, (object) accessibleObject);
        }
        return accessibleObject;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [SRDescription("ControlAccessibleDefaultActionDescr")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [SRCategory("CatAccessibility")]
    public string AccessibleDefaultActionDescription
    {
      get
      {
        return (string) this.Properties.GetObject(Control.PropAccessibleDefaultActionDescription);
      }
      set
      {
        this.Properties.SetObject(Control.PropAccessibleDefaultActionDescription, (object) value);
      }
    }

    [Localizable(true)]
    [SRCategory("CatAccessibility")]
    [SRDescription("ControlAccessibleDescriptionDescr")]
    [DefaultValue(null)]
    public string AccessibleDescription
    {
      get
      {
        return (string) this.Properties.GetObject(Control.PropAccessibleDescription);
      }
      set
      {
        this.Properties.SetObject(Control.PropAccessibleDescription, (object) value);
      }
    }

    [SRCategory("CatAccessibility")]
    [Localizable(true)]
    [DefaultValue(null)]
    [SRDescription("ControlAccessibleNameDescr")]
    public string AccessibleName
    {
      get
      {
        return (string) this.Properties.GetObject(Control.PropAccessibleName);
      }
      set
      {
        this.Properties.SetObject(Control.PropAccessibleName, (object) value);
      }
    }

    [SRDescription("ControlAccessibleRoleDescr")]
    [DefaultValue(AccessibleRole.Default)]
    [SRCategory("CatAccessibility")]
    public AccessibleRole AccessibleRole
    {
      get
      {
        bool found;
        int integer = this.Properties.GetInteger(Control.PropAccessibleRole, out found);
        if (found)
          return (AccessibleRole) integer;
        else
          return AccessibleRole.Default;
      }
      set
      {
        if (!System.Windows.Forms.ClientUtils.IsEnumValid((Enum) value, (int) value, -1, 64))
          throw new InvalidEnumArgumentException("value", (int) value, typeof (AccessibleRole));
        this.Properties.SetInteger(Control.PropAccessibleRole, (int) value);
      }
    }

    System.Drawing.Color ActiveXAmbientBackColor
    {
      private get
      {
        return this.ActiveXInstance.AmbientBackColor;
      }
    }

    System.Drawing.Color ActiveXAmbientForeColor
    {
      private get
      {
        return this.ActiveXInstance.AmbientForeColor;
      }
    }

    Font ActiveXAmbientFont
    {
      private get
      {
        return this.ActiveXInstance.AmbientFont;
      }
    }

    bool ActiveXEventsFrozen
    {
      private get
      {
        return this.ActiveXInstance.EventsFrozen;
      }
    }

    IntPtr ActiveXHWNDParent
    {
      private get
      {
        return this.ActiveXInstance.HWNDParent;
      }
    }

    Control.ActiveXImpl ActiveXInstance
    {
      private get
      {
        Control.ActiveXImpl activeXimpl = (Control.ActiveXImpl) this.Properties.GetObject(Control.PropActiveXImpl);
        if (activeXimpl == null)
        {
          if (this.GetState(524288))
            throw new NotSupportedException(System.Windows.Forms.SR.GetString("AXTopLevelSource"));
          activeXimpl = new Control.ActiveXImpl(this);
          this.SetState2(1024, true);
          this.Properties.SetObject(Control.PropActiveXImpl, (object) activeXimpl);
        }
        return activeXimpl;
      }
    }

    [SRCategory("CatBehavior")]
    [DefaultValue(false)]
    [SRDescription("ControlAllowDropDescr")]
    public virtual bool AllowDrop
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.GetState(64);
      }
      set
      {
        if (this.GetState(64) == value)
          return;
        if (value && !this.IsHandleCreated)
          System.Windows.Forms.IntSecurity.ClipboardRead.Demand();
        this.SetState(64, value);
        if (!this.IsHandleCreated)
          return;
        try
        {
          this.SetAcceptDrops(value);
        }
        catch
        {
          this.SetState(64, !value);
          throw;
        }
      }
    }

    AmbientProperties AmbientPropertiesService
    {
      private get
      {
        bool found;
        AmbientProperties ambientProperties = (AmbientProperties) this.Properties.GetObject(Control.PropAmbientPropertiesService, out found);
        if (!found)
        {
          ambientProperties = this.Site == null ? (AmbientProperties) this.GetService(typeof (AmbientProperties)) : (AmbientProperties) this.Site.GetService(typeof (AmbientProperties));
          if (ambientProperties != null)
            this.Properties.SetObject(Control.PropAmbientPropertiesService, (object) ambientProperties);
        }
        return ambientProperties;
      }
    }

    [DefaultValue(AnchorStyles.Top | AnchorStyles.Left)]
    [Localizable(true)]
    [SRDescription("ControlAnchorDescr")]
    [SRCategory("CatLayout")]
    [RefreshProperties(RefreshProperties.Repaint)]
    public virtual AnchorStyles Anchor
    {
      get
      {
        return DefaultLayout.GetAnchor((IArrangedElement) this);
      }
      set
      {
        DefaultLayout.SetAnchor((IArrangedElement) this.ParentInternal, (IArrangedElement) this, value);
      }
    }

    [DefaultValue(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [SRCategory("CatLayout")]
    [RefreshProperties(RefreshProperties.All)]
    [Localizable(true)]
    [SRDescription("ControlAutoSizeDescr")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool AutoSize
    {
      get
      {
        return CommonProperties.GetAutoSize((IArrangedElement) this);
      }
      set
      {
        if (value == this.AutoSize)
          return;
        CommonProperties.SetAutoSize((IArrangedElement) this, value);
        if (this.ParentInternal != null)
        {
          if (value && this.ParentInternal.LayoutEngine == DefaultLayout.Instance)
            this.ParentInternal.LayoutEngine.InitLayout((object) this, BoundsSpecified.Size);
          LayoutTransaction.DoLayout((IArrangedElement) this.ParentInternal, (IArrangedElement) this, PropertyNames.AutoSize);
        }
        this.OnAutoSizeChanged(EventArgs.Empty);
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Browsable(false)]
    [DefaultValue(typeof (Point), "0, 0")]
    public virtual Point AutoScrollOffset
    {
      get
      {
        if (this.Properties.ContainsObject(Control.PropAutoScrollOffset))
          return (Point) this.Properties.GetObject(Control.PropAutoScrollOffset);
        else
          return Point.Empty;
      }
      set
      {
        if (!(this.AutoScrollOffset != value))
          return;
        this.Properties.SetObject(Control.PropAutoScrollOffset, (object) value);
      }
    }

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public virtual LayoutEngine LayoutEngine
    {
      [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")] get
      {
        return (LayoutEngine) DefaultLayout.Instance;
      }
    }

    internal IntPtr BackColorBrush
    {
      get
      {
        object @object = this.Properties.GetObject(Control.PropBackBrush);
        if (@object != null)
          return (IntPtr) @object;
        if (!this.Properties.ContainsObject(Control.PropBackColor) && this.parent != null && this.parent.BackColor == this.BackColor)
          return this.parent.BackColorBrush;
        System.Drawing.Color backColor = this.BackColor;
        IntPtr num;
        if (ColorTranslator.ToOle(backColor) < 0)
        {
          num = System.Windows.Forms.SafeNativeMethods.GetSysColorBrush(ColorTranslator.ToOle(backColor) & (int) byte.MaxValue);
          this.SetState(2097152, false);
        }
        else
        {
          num = System.Windows.Forms.SafeNativeMethods.CreateSolidBrush(ColorTranslator.ToWin32(backColor));
          this.SetState(2097152, true);
        }
        this.Properties.SetObject(Control.PropBackBrush, (object) num);
        return num;
      }
    }

    [SRDescription("ControlBackColorDescr")]
    [DispId(-501)]
    [SRCategory("CatAppearance")]
    public virtual System.Drawing.Color BackColor
    {
      get
      {
        System.Drawing.Color c = this.RawBackColor;
        if (!c.IsEmpty)
          return c;
        Control parentInternal = this.ParentInternal;
        if (parentInternal != null && parentInternal.CanAccessProperties)
        {
          c = parentInternal.BackColor;
          if (this.IsValidBackColor(c))
            return c;
        }
        if (this.IsActiveX)
          c = this.ActiveXAmbientBackColor;
        if (c.IsEmpty)
        {
          AmbientProperties propertiesService = this.AmbientPropertiesService;
          if (propertiesService != null)
            c = propertiesService.BackColor;
        }
        if (!c.IsEmpty && this.IsValidBackColor(c))
          return c;
        else
          return Control.DefaultBackColor;
      }
      set
      {
        if (!value.Equals((object) System.Drawing.Color.Empty) && !this.GetStyle(ControlStyles.SupportsTransparentBackColor) && (int) value.A < (int) byte.MaxValue)
          throw new ArgumentException(System.Windows.Forms.SR.GetString("TransparentBackColorNotAllowed"));
        System.Drawing.Color backColor = this.BackColor;
        if (!value.IsEmpty || this.Properties.ContainsObject(Control.PropBackColor))
          this.Properties.SetColor(Control.PropBackColor, value);
        if (backColor.Equals((object) this.BackColor))
          return;
        this.OnBackColorChanged(EventArgs.Empty);
      }
    }

    [SRDescription("ControlBackgroundImageDescr")]
    [Localizable(true)]
    [SRCategory("CatAppearance")]
    [DefaultValue(null)]
    public virtual Image BackgroundImage
    {
      get
      {
        return (Image) this.Properties.GetObject(Control.PropBackgroundImage);
      }
      set
      {
        if (this.BackgroundImage == value)
          return;
        this.Properties.SetObject(Control.PropBackgroundImage, (object) value);
        this.OnBackgroundImageChanged(EventArgs.Empty);
      }
    }

    [SRCategory("CatAppearance")]
    [SRDescription("ControlBackgroundImageLayoutDescr")]
    [Localizable(true)]
    [DefaultValue(ImageLayout.Tile)]
    public virtual ImageLayout BackgroundImageLayout
    {
      get
      {
        if (!this.Properties.ContainsObject(Control.PropBackgroundImageLayout))
          return ImageLayout.Tile;
        else
          return (ImageLayout) this.Properties.GetObject(Control.PropBackgroundImageLayout);
      }
      set
      {
        if (this.BackgroundImageLayout == value)
          return;
        if (!System.Windows.Forms.ClientUtils.IsEnumValid((Enum) value, (int) value, 0, 4))
          throw new InvalidEnumArgumentException("value", (int) value, typeof (ImageLayout));
        if (value == ImageLayout.Center || value == ImageLayout.Zoom || value == ImageLayout.Stretch)
        {
          this.SetStyle(ControlStyles.ResizeRedraw, true);
          if (ControlPaint.IsImageTransparent(this.BackgroundImage))
            this.DoubleBuffered = true;
        }
        this.Properties.SetObject(Control.PropBackgroundImageLayout, (object) value);
        this.OnBackgroundImageLayoutChanged(EventArgs.Empty);
      }
    }

    internal bool BecomingActiveControl
    {
      get
      {
        return this.GetState2(32);
      }
      set
      {
        if (value == this.BecomingActiveControl)
          return;
        Application.ThreadContext.FromCurrent().ActivatingControl = value ? this : (Control) null;
        this.SetState2(32, value);
      }
    }

    internal BindingContext BindingContextInternal
    {
      get
      {
        BindingContext bindingContext = (BindingContext) this.Properties.GetObject(Control.PropBindingManager);
        if (bindingContext != null)
          return bindingContext;
        Control parentInternal = this.ParentInternal;
        if (parentInternal != null && parentInternal.CanAccessProperties)
          return parentInternal.BindingContext;
        else
          return (BindingContext) null;
      }
      set
      {
        BindingContext bindingContext1 = (BindingContext) this.Properties.GetObject(Control.PropBindingManager);
        BindingContext bindingContext2 = value;
        if (bindingContext1 == bindingContext2)
          return;
        this.Properties.SetObject(Control.PropBindingManager, (object) bindingContext2);
        this.OnBindingContextChanged(EventArgs.Empty);
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [SRDescription("ControlBindingContextDescr")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual BindingContext BindingContext
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.BindingContextInternal;
      }
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] set
      {
        this.BindingContextInternal = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [SRCategory("CatLayout")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [SRDescription("ControlBottomDescr")]
    public int Bottom
    {
      get
      {
        return this.y + this.height;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [SRDescription("ControlBoundsDescr")]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [SRCategory("CatLayout")]
    [Browsable(false)]
    public Rectangle Bounds
    {
      get
      {
        return new Rectangle(this.x, this.y, this.width, this.height);
      }
      set
      {
        this.SetBounds(value.X, value.Y, value.Width, value.Height, BoundsSpecified.All);
      }
    }

    internal virtual bool CanAccessProperties
    {
      get
      {
        return true;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [SRCategory("CatFocus")]
    [SRDescription("ControlCanFocusDescr")]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Browsable(false)]
    public bool CanFocus
    {
      get
      {
        if (!this.IsHandleCreated)
          return false;
        bool flag1 = System.Windows.Forms.SafeNativeMethods.IsWindowVisible(new HandleRef((object) this.window, this.Handle));
        bool flag2 = System.Windows.Forms.SafeNativeMethods.IsWindowEnabled(new HandleRef((object) this.window, this.Handle));
        if (flag1)
          return flag2;
        else
          return false;
      }
    }

    protected override bool CanRaiseEvents
    {
      [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")] get
      {
        if (this.IsActiveX)
          return !this.ActiveXEventsFrozen;
        else
          return true;
      }
    }

    [SRCategory("CatFocus")]
    [SRDescription("ControlCanSelectDescr")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool CanSelect
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.CanSelectCore();
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [SRCategory("CatFocus")]
    [SRDescription("ControlCaptureDescr")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public bool Capture
    {
      [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")] get
      {
        return this.CaptureInternal;
      }
      set
      {
        if (value)
          System.Windows.Forms.IntSecurity.GetCapture.Demand();
        this.CaptureInternal = value;
      }
    }

    internal bool CaptureInternal
    {
      [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")] get
      {
        if (this.IsHandleCreated)
          return System.Windows.Forms.UnsafeNativeMethods.GetCapture() == this.Handle;
        else
          return false;
      }
      set
      {
        if (this.CaptureInternal == value)
          return;
        if (value)
          System.Windows.Forms.UnsafeNativeMethods.SetCapture(new HandleRef((object) this, this.Handle));
        else
          System.Windows.Forms.SafeNativeMethods.ReleaseCapture();
      }
    }

    [DefaultValue(true)]
    [SRCategory("CatFocus")]
    [SRDescription("ControlCausesValidationDescr")]
    public bool CausesValidation
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.GetState(131072);
      }
      set
      {
        if (value == this.CausesValidation)
          return;
        this.SetState(131072, value);
        this.OnCausesValidationChanged(EventArgs.Empty);
      }
    }

    internal bool CacheTextInternal
    {
      get
      {
        bool found;
        if (this.Properties.GetInteger(Control.PropCacheTextCount, out found) <= 0)
          return this.GetStyle(ControlStyles.CacheText);
        else
          return true;
      }
      set
      {
        if (this.GetStyle(ControlStyles.CacheText) || !this.IsHandleCreated)
          return;
        bool found;
        int integer = this.Properties.GetInteger(Control.PropCacheTextCount, out found);
        int num;
        if (value)
        {
          if (integer == 0)
          {
            this.Properties.SetObject(Control.PropCacheTextField, (object) this.text);
            if (this.text == null)
              this.text = this.WindowText;
          }
          num = integer + 1;
        }
        else
        {
          num = integer - 1;
          if (num == 0)
            this.text = (string) this.Properties.GetObject(Control.PropCacheTextField, out found);
        }
        this.Properties.SetInteger(Control.PropCacheTextCount, num);
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [SRDescription("ControlCheckForIllegalCrossThreadCalls")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public static bool CheckForIllegalCrossThreadCalls
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return Control.checkForIllegalCrossThreadCalls;
      }
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] set
      {
        Control.checkForIllegalCrossThreadCalls = value;
      }
    }

    [SRCategory("CatLayout")]
    [SRDescription("ControlClientRectangleDescr")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Rectangle ClientRectangle
    {
      get
      {
        return new Rectangle(0, 0, this.clientWidth, this.clientHeight);
      }
    }

    [SRDescription("ControlClientSizeDescr")]
    [SRCategory("CatLayout")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Browsable(false)]
    public Size ClientSize
    {
      get
      {
        return new Size(this.clientWidth, this.clientHeight);
      }
      set
      {
        this.SetClientSizeCore(value.Width, value.Height);
      }
    }

    [Description("ControlCompanyNameDescr")]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public string CompanyName
    {
      get
      {
        return this.VersionInfo.CompanyName;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    [SRDescription("ControlContainsFocusDescr")]
    public bool ContainsFocus
    {
      get
      {
        if (!this.IsHandleCreated)
          return false;
        IntPtr focus = System.Windows.Forms.UnsafeNativeMethods.GetFocus();
        return !(focus == IntPtr.Zero) && (focus == this.Handle || System.Windows.Forms.UnsafeNativeMethods.IsChild(new HandleRef((object) this, this.Handle), new HandleRef((object) this, focus)));
      }
    }

    [Browsable(false)]
    [SRCategory("CatBehavior")]
    [DefaultValue(null)]
    [SRDescription("ControlContextMenuDescr")]
    public virtual ContextMenu ContextMenu
    {
      get
      {
        return (ContextMenu) this.Properties.GetObject(Control.PropContextMenu);
      }
      set
      {
        ContextMenu contextMenu = (ContextMenu) this.Properties.GetObject(Control.PropContextMenu);
        if (contextMenu == value)
          return;
        EventHandler eventHandler = new EventHandler(this.DetachContextMenu);
        if (contextMenu != null)
          contextMenu.Disposed -= eventHandler;
        this.Properties.SetObject(Control.PropContextMenu, (object) value);
        if (value != null)
          value.Disposed += eventHandler;
        this.OnContextMenuChanged(EventArgs.Empty);
      }
    }

    [SRDescription("ControlContextMenuDescr")]
    [SRCategory("CatBehavior")]
    [DefaultValue(null)]
    public virtual ContextMenuStrip ContextMenuStrip
    {
      get
      {
        return (ContextMenuStrip) this.Properties.GetObject(Control.PropContextMenuStrip);
      }
      set
      {
        ContextMenuStrip contextMenuStrip = this.Properties.GetObject(Control.PropContextMenuStrip) as ContextMenuStrip;
        if (contextMenuStrip == value)
          return;
        EventHandler eventHandler = new EventHandler(this.DetachContextMenuStrip);
        if (contextMenuStrip != null)
          contextMenuStrip.Disposed -= eventHandler;
        this.Properties.SetObject(Control.PropContextMenuStrip, (object) value);
        if (value != null)
          value.Disposed += eventHandler;
        this.OnContextMenuStripChanged(EventArgs.Empty);
      }
    }

    [SRDescription("ControlControlsDescr")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Browsable(false)]
    public Control.ControlCollection Controls
    {
      get
      {
        Control.ControlCollection controlCollection = (Control.ControlCollection) this.Properties.GetObject(Control.PropControlsCollection);
        if (controlCollection == null)
        {
          controlCollection = this.CreateControlsInstance();
          this.Properties.SetObject(Control.PropControlsCollection, (object) controlCollection);
        }
        return controlCollection;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [SRDescription("ControlCreatedDescr")]
    [Browsable(false)]
    public bool Created
    {
      get
      {
        return (this.state & 1) != 0;
      }
    }

    protected virtual CreateParams CreateParams
    {
      [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode), SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)] get
      {
        if (System.Windows.Forms.UnsafeNativeMethods.GetModuleHandle("comctl32.dll") == IntPtr.Zero && System.Windows.Forms.UnsafeNativeMethods.LoadLibrary("comctl32.dll") == IntPtr.Zero)
        {
          throw new Win32Exception(Marshal.GetLastWin32Error(), System.Windows.Forms.SR.GetString("LoadDLLError", new object[1]
          {
            (object) "comctl32.dll"
          }));
        }
        else
        {
          if (this.createParams == null)
            this.createParams = new CreateParams();
          CreateParams createParams = this.createParams;
          createParams.Style = 0;
          createParams.ExStyle = 0;
          createParams.ClassStyle = 0;
          createParams.Caption = this.text;
          createParams.X = this.x;
          createParams.Y = this.y;
          createParams.Width = this.width;
          createParams.Height = this.height;
          createParams.Style = 33554432;
          if (this.GetStyle(ControlStyles.ContainerControl))
            createParams.ExStyle |= 65536;
          createParams.ClassStyle = 8;
          if ((this.state & 524288) == 0)
          {
            createParams.Parent = this.parent == null ? IntPtr.Zero : this.parent.InternalHandle;
            createParams.Style |= 1140850688;
          }
          else
            createParams.Parent = IntPtr.Zero;
          if ((this.state & 8) != 0)
            createParams.Style |= 65536;
          if ((this.state & 2) != 0)
            createParams.Style |= 268435456;
          if (!this.Enabled)
            createParams.Style |= 134217728;
          if (createParams.Parent == IntPtr.Zero && this.IsActiveX)
            createParams.Parent = this.ActiveXHWNDParent;
          if (this.RightToLeft == RightToLeft.Yes)
          {
            createParams.ExStyle |= 8192;
            createParams.ExStyle |= 4096;
            createParams.ExStyle |= 16384;
          }
          return createParams;
        }
      }
    }

    internal bool ValidationCancelled
    {
      get
      {
        if (this.GetState(268435456))
          return true;
        Control parentInternal = this.ParentInternal;
        if (parentInternal != null)
          return parentInternal.ValidationCancelled;
        else
          return false;
      }
      set
      {
        this.SetState(268435456, value);
      }
    }

    internal int CreateThreadId
    {
      get
      {
        if (this.IsHandleCreated)
        {
          int lpdwProcessId;
          return System.Windows.Forms.SafeNativeMethods.GetWindowThreadProcessId(new HandleRef((object) this, this.Handle), out lpdwProcessId);
        }
        else
          return System.Windows.Forms.SafeNativeMethods.GetCurrentThreadId();
      }
    }

    [SRDescription("ControlCursorDescr")]
    [SRCategory("CatAppearance")]
    [AmbientValue(null)]
    public virtual Cursor Cursor
    {
      get
      {
        if (this.GetState(1024))
          return Cursors.WaitCursor;
        Cursor cursor = (Cursor) this.Properties.GetObject(Control.PropCursor);
        if (cursor != (Cursor) null)
          return cursor;
        Cursor defaultCursor = this.DefaultCursor;
        if (defaultCursor != Cursors.Default)
          return defaultCursor;
        Control parentInternal = this.ParentInternal;
        if (parentInternal != null)
          return parentInternal.Cursor;
        AmbientProperties propertiesService = this.AmbientPropertiesService;
        if (propertiesService != null && propertiesService.Cursor != (Cursor) null)
          return propertiesService.Cursor;
        else
          return defaultCursor;
      }
      set
      {
        Cursor cursor1 = (Cursor) this.Properties.GetObject(Control.PropCursor);
        Cursor cursor2 = this.Cursor;
        if (cursor1 != value)
        {
          System.Windows.Forms.IntSecurity.ModifyCursor.Demand();
          this.Properties.SetObject(Control.PropCursor, (object) value);
        }
        if (this.IsHandleCreated)
        {
          System.Windows.Forms.NativeMethods.POINT pt = new System.Windows.Forms.NativeMethods.POINT();
          System.Windows.Forms.NativeMethods.RECT rect = new System.Windows.Forms.NativeMethods.RECT();
          System.Windows.Forms.UnsafeNativeMethods.GetCursorPos(pt);
          System.Windows.Forms.UnsafeNativeMethods.GetWindowRect(new HandleRef((object) this, this.Handle), out rect);
          if (rect.left <= pt.x && pt.x < rect.right && (rect.top <= pt.y && pt.y < rect.bottom) || System.Windows.Forms.UnsafeNativeMethods.GetCapture() == this.Handle)
            this.SendMessage(32, this.Handle, (IntPtr) 1);
        }
        if (cursor2.Equals((object) value))
          return;
        this.OnCursorChanged(EventArgs.Empty);
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [SRDescription("ControlBindingsDescr")]
    [RefreshProperties(RefreshProperties.All)]
    [ParenthesizePropertyName(true)]
    [SRCategory("CatData")]
    public ControlBindingsCollection DataBindings
    {
      get
      {
        ControlBindingsCollection bindingsCollection = (ControlBindingsCollection) this.Properties.GetObject(Control.PropBindings);
        if (bindingsCollection == null)
        {
          bindingsCollection = new ControlBindingsCollection((IBindableComponent) this);
          this.Properties.SetObject(Control.PropBindings, (object) bindingsCollection);
        }
        return bindingsCollection;
      }
    }

    public static System.Drawing.Color DefaultBackColor
    {
      get
      {
        return SystemColors.Control;
      }
    }

    protected virtual Cursor DefaultCursor
    {
      get
      {
        return Cursors.Default;
      }
    }

    public static Font DefaultFont
    {
      get
      {
        if (Control.defaultFont == null)
          Control.defaultFont = SystemFonts.DefaultFont;
        return Control.defaultFont;
      }
    }

    public static System.Drawing.Color DefaultForeColor
    {
      get
      {
        return SystemColors.ControlText;
      }
    }

    protected virtual Padding DefaultMargin
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return CommonProperties.DefaultMargin;
      }
    }

    protected virtual Size DefaultMaximumSize
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return CommonProperties.DefaultMaximumSize;
      }
    }

    protected virtual Size DefaultMinimumSize
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return CommonProperties.DefaultMinimumSize;
      }
    }

    protected virtual Padding DefaultPadding
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return Padding.Empty;
      }
    }

    RightToLeft DefaultRightToLeft
    {
      private get
      {
        return RightToLeft.No;
      }
    }

    protected virtual Size DefaultSize
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return Size.Empty;
      }
    }

    internal System.Drawing.Color DisabledColor
    {
      get
      {
        System.Drawing.Color color = this.BackColor;
        if ((int) color.A == 0)
        {
          Control parentInternal = this.ParentInternal;
          while ((int) color.A == 0)
          {
            if (parentInternal == null)
            {
              color = SystemColors.Control;
              break;
            }
            else
            {
              color = parentInternal.BackColor;
              parentInternal = parentInternal.ParentInternal;
            }
          }
        }
        return color;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [SRDescription("ControlDisplayRectangleDescr")]
    [Browsable(false)]
    public virtual Rectangle DisplayRectangle
    {
      get
      {
        return new Rectangle(0, 0, this.clientWidth, this.clientHeight);
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [SRDescription("ControlDisposedDescr")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public bool IsDisposed
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.GetState(2048);
      }
    }

    [SRDescription("ControlDisposingDescr")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Browsable(false)]
    public bool Disposing
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.GetState(4096);
      }
    }

    [SRDescription("ControlDockDescr")]
    [RefreshProperties(RefreshProperties.Repaint)]
    [Localizable(true)]
    [SRCategory("CatLayout")]
    [DefaultValue(DockStyle.None)]
    public virtual DockStyle Dock
    {
      get
      {
        return DefaultLayout.GetDock((IArrangedElement) this);
      }
      set
      {
        if (value == this.Dock)
          return;
        this.SuspendLayout();
        try
        {
          DefaultLayout.SetDock((IArrangedElement) this, value);
          this.OnDockChanged(EventArgs.Empty);
        }
        finally
        {
          this.ResumeLayout();
        }
      }
    }

    [SRCategory("CatBehavior")]
    [SRDescription("ControlDoubleBufferedDescr")]
    protected virtual bool DoubleBuffered
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.GetStyle(ControlStyles.OptimizedDoubleBuffer);
      }
      set
      {
        if (value == this.DoubleBuffered)
          return;
        if (value)
          this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value);
        else
          this.SetStyle(ControlStyles.OptimizedDoubleBuffer, value);
      }
    }

    bool DoubleBufferingEnabled
    {
      private get
      {
        return this.GetStyle(ControlStyles.UserPaint | ControlStyles.DoubleBuffer);
      }
    }

    [SRDescription("ControlEnabledDescr")]
    [Localizable(true)]
    [SRCategory("CatBehavior")]
    [DispId(-514)]
    public bool Enabled
    {
      get
      {
        if (!this.GetState(4))
          return false;
        if (this.ParentInternal == null)
          return true;
        else
          return this.ParentInternal.Enabled;
      }
      set
      {
        bool enabled = this.Enabled;
        this.SetState(4, value);
        if (enabled == value)
          return;
        if (!value)
          this.SelectNextIfFocused();
        this.OnEnabledChanged(EventArgs.Empty);
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [SRDescription("ControlFocusedDescr")]
    [Browsable(false)]
    public virtual bool Focused
    {
      get
      {
        if (this.IsHandleCreated)
          return System.Windows.Forms.UnsafeNativeMethods.GetFocus() == this.Handle;
        else
          return false;
      }
    }

    [DispId(-512)]
    [SRCategory("CatAppearance")]
    [Localizable(true)]
    [AmbientValue(null)]
    [SRDescription("ControlFontDescr")]
    public virtual Font Font
    {
      get
      {
        Font font = (Font) this.Properties.GetObject(Control.PropFont);
        if (font != null)
          return font;
        Font parentFont = this.GetParentFont();
        if (parentFont != null)
          return parentFont;
        if (this.IsActiveX)
        {
          Font activeXambientFont = this.ActiveXAmbientFont;
          if (activeXambientFont != null)
            return activeXambientFont;
        }
        AmbientProperties propertiesService = this.AmbientPropertiesService;
        if (propertiesService != null && propertiesService.Font != null)
          return propertiesService.Font;
        else
          return Control.DefaultFont;
      }
      set
      {
        Font font1 = (Font) this.Properties.GetObject(Control.PropFont);
        Font font2 = this.Font;
        bool flag = false;
        if (value == null)
        {
          if (font1 != null)
            flag = true;
        }
        else
          flag = font1 == null || !value.Equals((object) font1);
        if (!flag)
          return;
        this.Properties.SetObject(Control.PropFont, (object) value);
        if (!font2.Equals((object) value))
        {
          this.DisposeFontHandle();
          if (this.Properties.ContainsInteger(Control.PropFontHeight))
            this.Properties.SetInteger(Control.PropFontHeight, value == null ? -1 : value.Height);
          using (new LayoutTransaction(this.ParentInternal, (IArrangedElement) this, PropertyNames.Font))
            this.OnFontChanged(EventArgs.Empty);
        }
        else
        {
          if (!this.IsHandleCreated || this.GetStyle(ControlStyles.UserPaint))
            return;
          this.DisposeFontHandle();
          this.SetWindowFont();
        }
      }
    }

    internal IntPtr FontHandle
    {
      get
      {
        Font font1 = (Font) this.Properties.GetObject(Control.PropFont);
        if (font1 != null)
        {
          Control.FontHandleWrapper fontHandleWrapper = (Control.FontHandleWrapper) this.Properties.GetObject(Control.PropFontHandleWrapper);
          if (fontHandleWrapper == null)
          {
            fontHandleWrapper = new Control.FontHandleWrapper(font1);
            this.Properties.SetObject(Control.PropFontHandleWrapper, (object) fontHandleWrapper);
          }
          return fontHandleWrapper.Handle;
        }
        else
        {
          if (this.parent != null)
            return this.parent.FontHandle;
          AmbientProperties propertiesService = this.AmbientPropertiesService;
          if (propertiesService == null || propertiesService.Font == null)
            return Control.GetDefaultFontHandleWrapper().Handle;
          Control.FontHandleWrapper fontHandleWrapper = (Control.FontHandleWrapper) null;
          Font font2 = (Font) this.Properties.GetObject(Control.PropCurrentAmbientFont);
          if (font2 != null && font2 == propertiesService.Font)
            fontHandleWrapper = (Control.FontHandleWrapper) this.Properties.GetObject(Control.PropFontHandleWrapper);
          else
            this.Properties.SetObject(Control.PropCurrentAmbientFont, (object) propertiesService.Font);
          if (fontHandleWrapper == null)
          {
            fontHandleWrapper = new Control.FontHandleWrapper(propertiesService.Font);
            this.Properties.SetObject(Control.PropFontHandleWrapper, (object) fontHandleWrapper);
          }
          return fontHandleWrapper.Handle;
        }
      }
    }

    protected int FontHeight
    {
      get
      {
        bool found;
        int integer = this.Properties.GetInteger(Control.PropFontHeight, out found);
        if (found && integer != -1)
          return integer;
        Font font = (Font) this.Properties.GetObject(Control.PropFont);
        if (font != null)
        {
          int height = font.Height;
          this.Properties.SetInteger(Control.PropFontHeight, height);
          return height;
        }
        else
        {
          int num = -1;
          if (this.ParentInternal != null && this.ParentInternal.CanAccessProperties)
            num = this.ParentInternal.FontHeight;
          if (num == -1)
          {
            num = this.Font.Height;
            this.Properties.SetInteger(Control.PropFontHeight, num);
          }
          return num;
        }
      }
      set
      {
        this.Properties.SetInteger(Control.PropFontHeight, value);
      }
    }

    [SRDescription("ControlForeColorDescr")]
    [DispId(-513)]
    [SRCategory("CatAppearance")]
    public virtual System.Drawing.Color ForeColor
    {
      get
      {
        System.Drawing.Color color1 = this.Properties.GetColor(Control.PropForeColor);
        if (!color1.IsEmpty)
          return color1;
        Control parentInternal = this.ParentInternal;
        if (parentInternal != null && parentInternal.CanAccessProperties)
          return parentInternal.ForeColor;
        System.Drawing.Color color2 = System.Drawing.Color.Empty;
        if (this.IsActiveX)
          color2 = this.ActiveXAmbientForeColor;
        if (color2.IsEmpty)
        {
          AmbientProperties propertiesService = this.AmbientPropertiesService;
          if (propertiesService != null)
            color2 = propertiesService.ForeColor;
        }
        if (!color2.IsEmpty)
          return color2;
        else
          return Control.DefaultForeColor;
      }
      set
      {
        System.Drawing.Color foreColor = this.ForeColor;
        if (!value.IsEmpty || this.Properties.ContainsObject(Control.PropForeColor))
          this.Properties.SetColor(Control.PropForeColor, value);
        if (foreColor.Equals((object) this.ForeColor))
          return;
        this.OnForeColorChanged(EventArgs.Empty);
      }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(-515)]
    [SRDescription("ControlHandleDescr")]
    public IntPtr Handle
    {
      get
      {
        if (Control.checkForIllegalCrossThreadCalls && !Control.inCrossThreadSafeCall && this.InvokeRequired)
        {
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("IllegalCrossThreadCall", new object[1]
          {
            (object) this.Name
          }));
        }
        else
        {
          if (!this.IsHandleCreated)
            this.CreateHandle();
          return this.HandleInternal;
        }
      }
    }

    internal IntPtr HandleInternal
    {
      get
      {
        return this.window.Handle;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [SRDescription("ControlHasChildrenDescr")]
    public bool HasChildren
    {
      get
      {
        Control.ControlCollection controlCollection = (Control.ControlCollection) this.Properties.GetObject(Control.PropControlsCollection);
        if (controlCollection != null)
          return controlCollection.Count > 0;
        else
          return false;
      }
    }

    internal virtual bool HasMenu
    {
      get
      {
        return false;
      }
    }

    [SRCategory("CatLayout")]
    [SRDescription("ControlHeightDescr")]
    [EditorBrowsable(EditorBrowsableState.Always)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public int Height
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.height;
      }
      set
      {
        this.SetBounds(this.x, this.y, this.width, value, BoundsSpecified.Height);
      }
    }

    internal bool HostedInWin32DialogManager
    {
      get
      {
        if (!this.GetState(16777216))
        {
          Control topMostParent = this.TopMostParent;
          if (this != topMostParent)
          {
            this.SetState(33554432, topMostParent.HostedInWin32DialogManager);
          }
          else
          {
            IntPtr parent = System.Windows.Forms.UnsafeNativeMethods.GetParent(new HandleRef((object) this, this.Handle));
            IntPtr handle = parent;
            StringBuilder lpClassName = new StringBuilder(32);
            this.SetState(33554432, false);
            for (; parent != IntPtr.Zero; parent = System.Windows.Forms.UnsafeNativeMethods.GetParent(new HandleRef((object) null, parent)))
            {
              int className = System.Windows.Forms.UnsafeNativeMethods.GetClassName(new HandleRef((object) null, handle), (StringBuilder) null, 0);
              if (className > lpClassName.Capacity)
                lpClassName.Capacity = className + 5;
              System.Windows.Forms.UnsafeNativeMethods.GetClassName(new HandleRef((object) null, handle), lpClassName, lpClassName.Capacity);
              if (((object) lpClassName).ToString() == "#32770")
              {
                this.SetState(33554432, true);
                break;
              }
              else
                handle = parent;
            }
          }
          this.SetState(16777216, true);
        }
        return this.GetState(33554432);
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [SRDescription("ControlHandleCreatedDescr")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IsHandleCreated
    {
      get
      {
        return this.window.Handle != IntPtr.Zero;
      }
    }

    internal bool IsLayoutSuspended
    {
      get
      {
        return (int) this.layoutSuspendCount > 0;
      }
    }

    internal bool IsWindowObscured
    {
      get
      {
        if (!this.IsHandleCreated || !this.Visible)
          return false;
        System.Windows.Forms.NativeMethods.RECT rect1 = new System.Windows.Forms.NativeMethods.RECT();
        Control parentInternal = this.ParentInternal;
        if (parentInternal != null)
        {
          while (parentInternal.ParentInternal != null)
            parentInternal = parentInternal.ParentInternal;
        }
        System.Windows.Forms.UnsafeNativeMethods.GetWindowRect(new HandleRef((object) this, this.Handle), out rect1);
        using (Region region = new Region(Rectangle.FromLTRB(rect1.left, rect1.top, rect1.right, rect1.bottom)))
        {
          IntPtr window;
          for (IntPtr handle = parentInternal == null ? this.Handle : parentInternal.Handle; (window = System.Windows.Forms.UnsafeNativeMethods.GetWindow(new HandleRef((object) null, handle), 3)) != IntPtr.Zero; handle = window)
          {
            System.Windows.Forms.UnsafeNativeMethods.GetWindowRect(new HandleRef((object) null, window), out rect1);
            Rectangle rect2 = Rectangle.FromLTRB(rect1.left, rect1.top, rect1.right, rect1.bottom);
            if (System.Windows.Forms.SafeNativeMethods.IsWindowVisible(new HandleRef((object) null, window)))
              region.Exclude(rect2);
          }
          using (Graphics graphics = this.CreateGraphics())
            return region.IsEmpty(graphics);
        }
      }
    }

    internal IntPtr InternalHandle
    {
      get
      {
        if (!this.IsHandleCreated)
          return IntPtr.Zero;
        else
          return this.Handle;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [SRDescription("ControlInvokeRequiredDescr")]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Browsable(false)]
    public bool InvokeRequired
    {
      get
      {
        using (new Control.MultithreadSafeCallScope())
        {
          HandleRef hWnd;
          if (this.IsHandleCreated)
          {
            hWnd = new HandleRef((object) this, this.Handle);
          }
          else
          {
            Control marshalingControl = this.FindMarshalingControl();
            if (!marshalingControl.IsHandleCreated)
              return false;
            hWnd = new HandleRef((object) marshalingControl, marshalingControl.Handle);
          }
          int lpdwProcessId;
          return System.Windows.Forms.SafeNativeMethods.GetWindowThreadProcessId(hWnd, out lpdwProcessId) != System.Windows.Forms.SafeNativeMethods.GetCurrentThreadId();
        }
      }
    }

    [SRDescription("ControlIsAccessibleDescr")]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [SRCategory("CatBehavior")]
    public bool IsAccessible
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.GetState(1048576);
      }
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] set
      {
        this.SetState(1048576, value);
      }
    }

    internal bool IsActiveX
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.GetState2(1024);
      }
    }

    internal virtual bool IsContainerControl
    {
      get
      {
        return false;
      }
    }

    internal bool IsIEParent
    {
      get
      {
        if (!this.IsActiveX)
          return false;
        else
          return this.ActiveXInstance.IsIE;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [SRDescription("IsMirroredDescr")]
    [Browsable(false)]
    [SRCategory("CatLayout")]
    public bool IsMirrored
    {
      get
      {
        if (!this.IsHandleCreated)
          this.SetState(1073741824, (this.CreateParams.ExStyle & 4194304) != 0);
        return this.GetState(1073741824);
      }
    }

    internal virtual bool IsMnemonicsListenerAxSourced
    {
      get
      {
        return false;
      }
    }

    [SRDescription("ControlLeftDescr")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    [SRCategory("CatLayout")]
    [EditorBrowsable(EditorBrowsableState.Always)]
    public int Left
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.x;
      }
      set
      {
        this.SetBounds(value, this.y, this.width, this.height, BoundsSpecified.X);
      }
    }

    [SRDescription("ControlLocationDescr")]
    [SRCategory("CatLayout")]
    [Localizable(true)]
    public Point Location
    {
      get
      {
        return new Point(this.x, this.y);
      }
      set
      {
        this.SetBounds(value.X, value.Y, this.width, this.height, BoundsSpecified.Location);
      }
    }

    [SRDescription("ControlMarginDescr")]
    [Localizable(true)]
    [SRCategory("CatLayout")]
    public Padding Margin
    {
      get
      {
        return CommonProperties.GetMargin((IArrangedElement) this);
      }
      set
      {
        value = LayoutUtils.ClampNegativePaddingToZero(value);
        if (!(value != this.Margin))
          return;
        CommonProperties.SetMargin((IArrangedElement) this, value);
        this.OnMarginChanged(EventArgs.Empty);
      }
    }

    [SRCategory("CatLayout")]
    [Localizable(true)]
    [SRDescription("ControlMaximumSizeDescr")]
    [AmbientValue(typeof (Size), "0, 0")]
    public virtual Size MaximumSize
    {
      get
      {
        return CommonProperties.GetMaximumSize((IArrangedElement) this, this.DefaultMaximumSize);
      }
      set
      {
        if (value == Size.Empty)
        {
          CommonProperties.ClearMaximumSize((IArrangedElement) this);
        }
        else
        {
          if (!(value != this.MaximumSize))
            return;
          CommonProperties.SetMaximumSize((IArrangedElement) this, value);
        }
      }
    }

    [SRDescription("ControlMinimumSizeDescr")]
    [Localizable(true)]
    [SRCategory("CatLayout")]
    public virtual Size MinimumSize
    {
      get
      {
        return CommonProperties.GetMinimumSize((IArrangedElement) this, this.DefaultMinimumSize);
      }
      set
      {
        if (!(value != this.MinimumSize))
          return;
        CommonProperties.SetMinimumSize((IArrangedElement) this, value);
      }
    }

    public static Keys ModifierKeys
    {
      get
      {
        Keys keys = Keys.None;
        if ((int) System.Windows.Forms.UnsafeNativeMethods.GetKeyState(16) < 0)
          keys |= Keys.Shift;
        if ((int) System.Windows.Forms.UnsafeNativeMethods.GetKeyState(17) < 0)
          keys |= Keys.Control;
        if ((int) System.Windows.Forms.UnsafeNativeMethods.GetKeyState(18) < 0)
          keys |= Keys.Alt;
        return keys;
      }
    }

    public static MouseButtons MouseButtons
    {
      get
      {
        MouseButtons mouseButtons = MouseButtons.None;
        if ((int) System.Windows.Forms.UnsafeNativeMethods.GetKeyState(1) < 0)
          mouseButtons |= MouseButtons.Left;
        if ((int) System.Windows.Forms.UnsafeNativeMethods.GetKeyState(2) < 0)
          mouseButtons |= MouseButtons.Right;
        if ((int) System.Windows.Forms.UnsafeNativeMethods.GetKeyState(4) < 0)
          mouseButtons |= MouseButtons.Middle;
        if ((int) System.Windows.Forms.UnsafeNativeMethods.GetKeyState(5) < 0)
          mouseButtons |= MouseButtons.XButton1;
        if ((int) System.Windows.Forms.UnsafeNativeMethods.GetKeyState(6) < 0)
          mouseButtons |= MouseButtons.XButton2;
        return mouseButtons;
      }
    }

    public static Point MousePosition
    {
      get
      {
        System.Windows.Forms.NativeMethods.POINT pt = new System.Windows.Forms.NativeMethods.POINT();
        System.Windows.Forms.UnsafeNativeMethods.GetCursorPos(pt);
        return new Point(pt.x, pt.y);
      }
    }

    [Browsable(false)]
    public string Name
    {
      get
      {
        string str = (string) this.Properties.GetObject(Control.PropName);
        if (string.IsNullOrEmpty(str))
        {
          if (this.Site != null)
            str = this.Site.Name;
          if (str == null)
            str = "";
        }
        return str;
      }
      set
      {
        if (string.IsNullOrEmpty(value))
          this.Properties.SetObject(Control.PropName, (object) null);
        else
          this.Properties.SetObject(Control.PropName, (object) value);
      }
    }

    [Browsable(false)]
    [SRDescription("ControlParentDescr")]
    [SRCategory("CatBehavior")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Control Parent
    {
      get
      {
        System.Windows.Forms.IntSecurity.GetParent.Demand();
        return this.ParentInternal;
      }
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] set
      {
        this.ParentInternal = value;
      }
    }

    internal virtual Control ParentInternal
    {
      [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")] get
      {
        return this.parent;
      }
      set
      {
        if (this.parent == value)
          return;
        if (value != null)
          value.Controls.Add(this);
        else
          this.parent.Controls.Remove(this);
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Browsable(false)]
    [SRDescription("ControlProductNameDescr")]
    public string ProductName
    {
      get
      {
        return this.VersionInfo.ProductName;
      }
    }

    [SRDescription("ControlProductVersionDescr")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Browsable(false)]
    public string ProductVersion
    {
      get
      {
        return this.VersionInfo.ProductVersion;
      }
    }

    internal PropertyStore Properties
    {
      [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")] get
      {
        return this.propertyStore;
      }
    }

    internal System.Drawing.Color RawBackColor
    {
      get
      {
        return this.Properties.GetColor(Control.PropBackColor);
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [SRCategory("CatBehavior")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [SRDescription("ControlRecreatingHandleDescr")]
    public bool RecreatingHandle
    {
      get
      {
        return (this.state & 16) != 0;
      }
    }

    private Control ReflectParent
    {
      get
      {
        return this.reflectParent;
      }
      set
      {
        if (value != null)
          value.AddReflectChild();
        Control reflectParent = this.ReflectParent;
        this.reflectParent = value;
        if (reflectParent == null)
          return;
        reflectParent.RemoveReflectChild();
      }
    }

    [SRCategory("CatLayout")]
    [SRDescription("ControlRegionDescr")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public Region Region
    {
      get
      {
        return (Region) this.Properties.GetObject(Control.PropRegion);
      }
      set
      {
        if (this.GetState(524288))
          System.Windows.Forms.IntSecurity.ChangeWindowRegionForTopLevel.Demand();
        Region region = this.Region;
        if (region == value)
          return;
        this.Properties.SetObject(Control.PropRegion, (object) value);
        if (region != null)
          region.Dispose();
        if (this.IsHandleCreated)
        {
          IntPtr num = IntPtr.Zero;
          try
          {
            if (value != null)
              num = this.GetHRgn(value);
            if (this.IsActiveX)
              num = this.ActiveXMergeRegion(num);
            if (System.Windows.Forms.UnsafeNativeMethods.SetWindowRgn(new HandleRef((object) this, this.Handle), new HandleRef((object) this, num), System.Windows.Forms.SafeNativeMethods.IsWindowVisible(new HandleRef((object) this, this.Handle))) != 0)
              num = IntPtr.Zero;
          }
          finally
          {
            if (num != IntPtr.Zero)
              System.Windows.Forms.SafeNativeMethods.DeleteObject(new HandleRef((object) null, num));
          }
        }
        this.OnRegionChanged(EventArgs.Empty);
      }
    }

    [Obsolete("This property has been deprecated. Please use RightToLeft instead. http://go.microsoft.com/fwlink/?linkid=14202")]
    protected internal bool RenderRightToLeft
    {
      get
      {
        return true;
      }
    }

    internal bool RenderTransparent
    {
      get
      {
        if (this.GetStyle(ControlStyles.SupportsTransparentBackColor))
          return (int) this.BackColor.A < (int) byte.MaxValue;
        else
          return false;
      }
    }

    internal virtual bool RenderTransparencyWithVisualStyles
    {
      get
      {
        return false;
      }
    }

    internal BoundsSpecified RequiredScaling
    {
      get
      {
        if (((int) this.requiredScaling & 16) != 0)
          return (BoundsSpecified) ((int) this.requiredScaling & 15);
        else
          return BoundsSpecified.None;
      }
      set
      {
        byte num = (byte) ((uint) this.requiredScaling & 16U);
        this.requiredScaling = (byte) (value & BoundsSpecified.All | (BoundsSpecified) num);
      }
    }

    internal bool RequiredScalingEnabled
    {
      get
      {
        return ((int) this.requiredScaling & 16) != 0;
      }
      set
      {
        this.requiredScaling = (byte) ((uint) this.requiredScaling & 15U);
        if (!value)
          return;
        this.requiredScaling |= (byte) 16;
      }
    }

    [SRDescription("ControlResizeRedrawDescr")]
    protected bool ResizeRedraw
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.GetStyle(ControlStyles.ResizeRedraw);
      }
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] set
      {
        this.SetStyle(ControlStyles.ResizeRedraw, value);
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [SRDescription("ControlRightDescr")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [SRCategory("CatLayout")]
    public int Right
    {
      get
      {
        return this.x + this.width;
      }
    }

    [Localizable(true)]
    [AmbientValue(RightToLeft.Inherit)]
    [SRCategory("CatAppearance")]
    [SRDescription("ControlRightToLeftDescr")]
    public virtual RightToLeft RightToLeft
    {
      get
      {
        bool found;
        int num = this.Properties.GetInteger(Control.PropRightToLeft, out found);
        if (!found)
          num = 2;
        if (num == 2)
        {
          Control parentInternal = this.ParentInternal;
          num = parentInternal == null ? (int) this.DefaultRightToLeft : (int) parentInternal.RightToLeft;
        }
        return (RightToLeft) num;
      }
      set
      {
        if (!System.Windows.Forms.ClientUtils.IsEnumValid((Enum) value, (int) value, 0, 2))
          throw new InvalidEnumArgumentException("RightToLeft", (int) value, typeof (RightToLeft));
        RightToLeft rightToLeft = this.RightToLeft;
        if (this.Properties.ContainsInteger(Control.PropRightToLeft) || value != RightToLeft.Inherit)
          this.Properties.SetInteger(Control.PropRightToLeft, (int) value);
        if (rightToLeft == this.RightToLeft)
          return;
        using (new LayoutTransaction(this, (IArrangedElement) this, PropertyNames.RightToLeft))
          this.OnRightToLeftChanged(EventArgs.Empty);
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual bool ScaleChildren
    {
      get
      {
        return true;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public override ISite Site
    {
      get
      {
        return base.Site;
      }
      set
      {
        AmbientProperties propertiesService = this.AmbientPropertiesService;
        AmbientProperties ambientProperties = (AmbientProperties) null;
        if (value != null)
          ambientProperties = (AmbientProperties) value.GetService(typeof (AmbientProperties));
        if (propertiesService != ambientProperties)
        {
          bool flag1 = !this.Properties.ContainsObject(Control.PropFont);
          bool flag2 = !this.Properties.ContainsObject(Control.PropBackColor);
          bool flag3 = !this.Properties.ContainsObject(Control.PropForeColor);
          bool flag4 = !this.Properties.ContainsObject(Control.PropCursor);
          Font font = (Font) null;
          System.Drawing.Color color1 = System.Drawing.Color.Empty;
          System.Drawing.Color color2 = System.Drawing.Color.Empty;
          Cursor cursor = (Cursor) null;
          if (flag1)
            font = this.Font;
          if (flag2)
            color1 = this.BackColor;
          if (flag3)
            color2 = this.ForeColor;
          if (flag4)
            cursor = this.Cursor;
          this.Properties.SetObject(Control.PropAmbientPropertiesService, (object) ambientProperties);
          base.Site = value;
          if (flag1 && !font.Equals((object) this.Font))
            this.OnFontChanged(EventArgs.Empty);
          if (flag3 && !color2.Equals((object) this.ForeColor))
            this.OnForeColorChanged(EventArgs.Empty);
          if (flag2 && !color1.Equals((object) this.BackColor))
            this.OnBackColorChanged(EventArgs.Empty);
          if (!flag4 || !cursor.Equals((object) this.Cursor))
            return;
          this.OnCursorChanged(EventArgs.Empty);
        }
        else
          base.Site = value;
      }
    }

    [Localizable(true)]
    [SRCategory("CatLayout")]
    [SRDescription("ControlSizeDescr")]
    public Size Size
    {
      get
      {
        return new Size(this.width, this.height);
      }
      set
      {
        this.SetBounds(this.x, this.y, value.Width, value.Height, BoundsSpecified.Size);
      }
    }

    [SRDescription("ControlTabIndexDescr")]
    [SRCategory("CatBehavior")]
    [Localizable(true)]
    [MergableProperty(false)]
    public int TabIndex
    {
      get
      {
        if (this.tabIndex != -1)
          return this.tabIndex;
        else
          return 0;
      }
      set
      {
        if (value < 0)
        {
          throw new ArgumentOutOfRangeException("TabIndex", System.Windows.Forms.SR.GetString("InvalidLowBoundArgumentEx", (object) "TabIndex", (object) value.ToString((IFormatProvider) CultureInfo.CurrentCulture), (object) 0.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
        }
        else
        {
          if (this.tabIndex == value)
            return;
          this.tabIndex = value;
          this.OnTabIndexChanged(EventArgs.Empty);
        }
      }
    }

    [DefaultValue(true)]
    [SRDescription("ControlTabStopDescr")]
    [DispId(-516)]
    [SRCategory("CatBehavior")]
    public bool TabStop
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.TabStopInternal;
      }
      set
      {
        if (this.TabStop == value)
          return;
        this.TabStopInternal = value;
        if (this.IsHandleCreated)
          this.SetWindowStyle(65536, value);
        this.OnTabStopChanged(EventArgs.Empty);
      }
    }

    internal bool TabStopInternal
    {
      get
      {
        return (this.state & 8) != 0;
      }
      set
      {
        if (this.TabStopInternal == value)
          return;
        this.SetState(8, value);
      }
    }

    [SRCategory("CatData")]
    [TypeConverter(typeof (StringConverter))]
    [Localizable(false)]
    [SRDescription("ControlTagDescr")]
    [DefaultValue(null)]
    [Bindable(true)]
    public object Tag
    {
      get
      {
        return this.Properties.GetObject(Control.PropUserData);
      }
      set
      {
        this.Properties.SetObject(Control.PropUserData, value);
      }
    }

    [SRDescription("ControlTextDescr")]
    [DispId(-517)]
    [Bindable(true)]
    [Localizable(true)]
    [SRCategory("CatAppearance")]
    public virtual string Text
    {
      get
      {
        if (!this.CacheTextInternal)
          return this.WindowText;
        if (this.text != null)
          return this.text;
        else
          return "";
      }
      set
      {
        if (value == null)
          value = "";
        if (value == this.Text)
          return;
        if (this.CacheTextInternal)
          this.text = value;
        this.WindowText = value;
        this.OnTextChanged(EventArgs.Empty);
        if (!this.IsMnemonicsListenerAxSourced)
          return;
        for (Control control = this; control != null; control = control.ParentInternal)
        {
          Control.ActiveXImpl activeXimpl = (Control.ActiveXImpl) control.Properties.GetObject(Control.PropActiveXImpl);
          if (activeXimpl != null)
          {
            activeXimpl.UpdateAccelTable();
            break;
          }
        }
      }
    }

    [EditorBrowsable(EditorBrowsableState.Always)]
    [SRCategory("CatLayout")]
    [SRDescription("ControlTopDescr")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int Top
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.y;
      }
      set
      {
        this.SetBounds(this.x, value, this.width, this.height, BoundsSpecified.Y);
      }
    }

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [SRCategory("CatBehavior")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [SRDescription("ControlTopLevelControlDescr")]
    public Control TopLevelControl
    {
      get
      {
        System.Windows.Forms.IntSecurity.GetParent.Demand();
        return this.TopLevelControlInternal;
      }
    }

    internal Control TopLevelControlInternal
    {
      get
      {
        Control control = this;
        while (control != null && !control.GetTopLevel())
          control = control.ParentInternal;
        return control;
      }
    }

    internal Control TopMostParent
    {
      get
      {
        Control control = this;
        while (control.ParentInternal != null)
          control = control.ParentInternal;
        return control;
      }
    }

    BufferedGraphicsContext BufferContext
    {
      private get
      {
        return BufferedGraphicsManager.Current;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    protected internal virtual bool ShowKeyboardCues
    {
      get
      {
        if (!this.IsHandleCreated || this.DesignMode)
          return true;
        if ((this.uiCuesState & 240) == 0)
        {
          if (SystemInformation.MenuAccessKeysUnderlined)
          {
            this.uiCuesState |= 32;
          }
          else
          {
            int num = 196608;
            this.uiCuesState |= 16;
            System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this.TopMostParent, this.TopMostParent.Handle), 295, (IntPtr) (num | 1), IntPtr.Zero);
          }
        }
        return (this.uiCuesState & 240) == 32;
      }
    }

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    protected internal virtual bool ShowFocusCues
    {
      get
      {
        if (!this.IsHandleCreated)
          return true;
        if ((this.uiCuesState & 15) == 0)
        {
          if (SystemInformation.MenuAccessKeysUnderlined)
          {
            this.uiCuesState |= 2;
          }
          else
          {
            this.uiCuesState |= 1;
            System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this.TopMostParent, this.TopMostParent.Handle), 295, (IntPtr) (196608 | 1), IntPtr.Zero);
          }
        }
        return (this.uiCuesState & 15) == 2;
      }
    }

    internal virtual int ShowParams
    {
      get
      {
        return 5;
      }
    }

    [SRCategory("CatAppearance")]
    [Browsable(true)]
    [DefaultValue(false)]
    [EditorBrowsable(EditorBrowsableState.Always)]
    [SRDescription("ControlUseWaitCursorDescr")]
    public bool UseWaitCursor
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.GetState(1024);
      }
      set
      {
        if (this.GetState(1024) == value)
          return;
        this.SetState(1024, value);
        Control.ControlCollection controlCollection = (Control.ControlCollection) this.Properties.GetObject(Control.PropControlsCollection);
        if (controlCollection == null)
          return;
        for (int index = 0; index < controlCollection.Count; ++index)
          controlCollection[index].UseWaitCursor = value;
      }
    }

    internal bool UseCompatibleTextRenderingInt
    {
      get
      {
        if (this.Properties.ContainsInteger(Control.PropUseCompatibleTextRendering))
        {
          bool found;
          int integer = this.Properties.GetInteger(Control.PropUseCompatibleTextRendering, out found);
          if (found)
            return integer == 1;
        }
        return Control.UseCompatibleTextRenderingDefault;
      }
      set
      {
        if (!this.SupportsUseCompatibleTextRendering || this.UseCompatibleTextRenderingInt == value)
          return;
        this.Properties.SetInteger(Control.PropUseCompatibleTextRendering, value ? 1 : 0);
        LayoutTransaction.DoLayoutIf(this.AutoSize, (IArrangedElement) this.ParentInternal, (IArrangedElement) this, PropertyNames.UseCompatibleTextRendering);
        this.Invalidate();
      }
    }

    internal virtual bool SupportsUseCompatibleTextRendering
    {
      get
      {
        return false;
      }
    }

    Control.ControlVersionInfo VersionInfo
    {
      private get
      {
        Control.ControlVersionInfo controlVersionInfo = (Control.ControlVersionInfo) this.Properties.GetObject(Control.PropControlVersionInfo);
        if (controlVersionInfo == null)
        {
          controlVersionInfo = new Control.ControlVersionInfo(this);
          this.Properties.SetObject(Control.PropControlVersionInfo, (object) controlVersionInfo);
        }
        return controlVersionInfo;
      }
    }

    [SRCategory("CatBehavior")]
    [Localizable(true)]
    [SRDescription("ControlVisibleDescr")]
    public bool Visible
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.GetVisibleCore();
      }
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] set
      {
        this.SetVisibleCore(value);
      }
    }

    [SRDescription("ControlWidthDescr")]
    [EditorBrowsable(EditorBrowsableState.Always)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    [SRCategory("CatLayout")]
    public int Width
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.width;
      }
      set
      {
        this.SetBounds(this.x, this.y, value, this.height, BoundsSpecified.Width);
      }
    }

    private int WindowExStyle
    {
      get
      {
        return (int) (long) System.Windows.Forms.UnsafeNativeMethods.GetWindowLong(new HandleRef((object) this, this.Handle), -20);
      }
      set
      {
        System.Windows.Forms.UnsafeNativeMethods.SetWindowLong(new HandleRef((object) this, this.Handle), -20, new HandleRef((object) null, (IntPtr) value));
      }
    }

    internal int WindowStyle
    {
      get
      {
        return (int) (long) System.Windows.Forms.UnsafeNativeMethods.GetWindowLong(new HandleRef((object) this, this.Handle), -16);
      }
      set
      {
        System.Windows.Forms.UnsafeNativeMethods.SetWindowLong(new HandleRef((object) this, this.Handle), -16, new HandleRef((object) null, (IntPtr) value));
      }
    }

    [SRDescription("ControlWindowTargetDescr")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [SRCategory("CatBehavior")]
    [Browsable(false)]
    public IWindowTarget WindowTarget
    {
      [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)] get
      {
        return this.window.WindowTarget;
      }
      [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)] set
      {
        this.window.WindowTarget = value;
      }
    }

    internal virtual string WindowText
    {
      get
      {
        if (!this.IsHandleCreated)
        {
          if (this.text == null)
            return "";
          else
            return this.text;
        }
        else
        {
          using (new Control.MultithreadSafeCallScope())
          {
            int num = System.Windows.Forms.SafeNativeMethods.GetWindowTextLength(new HandleRef((object) this.window, this.Handle));
            if (SystemInformation.DbcsEnabled)
              num = num * 2 + 1;
            StringBuilder lpString = new StringBuilder(num + 1);
            System.Windows.Forms.UnsafeNativeMethods.GetWindowText(new HandleRef((object) this.window, this.Handle), lpString, lpString.Capacity);
            return ((object) lpString).ToString();
          }
        }
      }
      set
      {
        if (value == null)
          value = "";
        if (this.WindowText.Equals(value))
          return;
        if (this.IsHandleCreated)
          System.Windows.Forms.UnsafeNativeMethods.SetWindowText(new HandleRef((object) this.window, this.Handle), value);
        else if (value.Length == 0)
          this.text = (string) null;
        else
          this.text = value;
      }
    }

    [Browsable(false)]
    public Size PreferredSize
    {
      get
      {
        return this.GetPreferredSize(Size.Empty);
      }
    }

    [SRDescription("ControlPaddingDescr")]
    [Localizable(true)]
    [SRCategory("CatLayout")]
    public Padding Padding
    {
      get
      {
        return CommonProperties.GetPadding((IArrangedElement) this, this.DefaultPadding);
      }
      set
      {
        if (!(value != this.Padding))
          return;
        CommonProperties.SetPadding((IArrangedElement) this, value);
        this.SetState(8388608, true);
        using (new LayoutTransaction(this.ParentInternal, (IArrangedElement) this, PropertyNames.Padding))
          this.OnPaddingChanged(EventArgs.Empty);
        if (!this.GetState(8388608))
          return;
        LayoutTransaction.DoLayout((IArrangedElement) this, (IArrangedElement) this, PropertyNames.Padding);
      }
    }

    internal ContainerControl ParentContainerControl
    {
      get
      {
        for (Control parentInternal = this.ParentInternal; parentInternal != null; parentInternal = parentInternal.ParentInternal)
        {
          if (parentInternal is ContainerControl)
            return parentInternal as ContainerControl;
        }
        return (ContainerControl) null;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal bool ShouldAutoValidate
    {
      get
      {
        return Control.GetAutoValidateForControl(this) != AutoValidate.Disable;
      }
    }

    ArrangedElementCollection IArrangedElement.Children
    {
      get
      {
        return (ArrangedElementCollection) this.Properties.GetObject(Control.PropControlsCollection) ?? ArrangedElementCollection.Empty;
      }
    }

    IArrangedElement IArrangedElement.Container
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return (IArrangedElement) this.ParentInternal;
      }
    }

    bool IArrangedElement.ParticipatesInLayout
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.GetState(2);
      }
    }

    PropertyStore IArrangedElement.Properties
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.Properties;
      }
    }

    internal ImeMode CachedImeMode
    {
      get
      {
        bool found;
        ImeMode imeMode = (ImeMode) this.Properties.GetInteger(Control.PropImeMode, out found);
        if (!found)
          imeMode = this.DefaultImeMode;
        if (imeMode == ImeMode.Inherit)
        {
          Control parentInternal = this.ParentInternal;
          imeMode = parentInternal == null ? ImeMode.NoControl : parentInternal.CachedImeMode;
        }
        return imeMode;
      }
      set
      {
        this.Properties.SetInteger(Control.PropImeMode, (int) value);
      }
    }

    protected virtual bool CanEnableIme
    {
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
      {
        return this.ImeSupported;
      }
    }

    internal ImeMode CurrentImeContextMode
    {
      get
      {
        if (this.IsHandleCreated)
          return ImeContext.GetImeMode(this.Handle);
        else
          return ImeMode.Inherit;
      }
    }

    protected virtual ImeMode DefaultImeMode
    {
      get
      {
        return ImeMode.Inherit;
      }
    }

    internal int DisableImeModeChangedCount
    {
      get
      {
        bool found;
        return this.Properties.GetInteger(Control.PropDisableImeModeChangedCount, out found);
      }
      set
      {
        this.Properties.SetInteger(Control.PropDisableImeModeChangedCount, value);
      }
    }

    private static bool IgnoreWmImeNotify
    {
      get
      {
        return Control.ignoreWmImeNotify;
      }
      set
      {
        Control.ignoreWmImeNotify = value;
      }
    }

    [AmbientValue(ImeMode.Inherit)]
    [SRDescription("ControlIMEModeDescr")]
    [SRCategory("CatBehavior")]
    [Localizable(true)]
    public ImeMode ImeMode
    {
      get
      {
        ImeMode imeMode = this.ImeModeBase;
        if (imeMode == ImeMode.OnHalf)
          imeMode = ImeMode.On;
        return imeMode;
      }
      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] set
      {
        this.ImeModeBase = value;
      }
    }

    protected virtual ImeMode ImeModeBase
    {
      get
      {
        return this.CachedImeMode;
      }
      set
      {
        if (!System.Windows.Forms.ClientUtils.IsEnumValid((Enum) value, (int) value, -1, 12))
          throw new InvalidEnumArgumentException("ImeMode", (int) value, typeof (ImeMode));
        ImeMode cachedImeMode = this.CachedImeMode;
        this.CachedImeMode = value;
        if (cachedImeMode == value)
          return;
        Control control = (Control) null;
        if (!this.DesignMode && ImeModeConversion.InputLanguageTable != ImeModeConversion.UnsupportedTable)
        {
          if (this.Focused)
            control = this;
          else if (this.ContainsFocus)
            control = Control.FromChildHandleInternal(System.Windows.Forms.UnsafeNativeMethods.GetFocus());
          if (control != null && control.CanEnableIme)
          {
            ++this.DisableImeModeChangedCount;
            try
            {
              control.UpdateImeContextMode();
            }
            finally
            {
              --this.DisableImeModeChangedCount;
            }
          }
        }
        this.VerifyImeModeChanged(cachedImeMode, this.CachedImeMode);
      }
    }

    bool ImeSupported
    {
      private get
      {
        return this.DefaultImeMode != ImeMode.Disable;
      }
    }

    internal int ImeWmCharsToIgnore
    {
      get
      {
        return this.Properties.GetInteger(Control.PropImeWmCharsToIgnore);
      }
      set
      {
        if (this.ImeWmCharsToIgnore == -1)
          return;
        this.Properties.SetInteger(Control.PropImeWmCharsToIgnore, value);
      }
    }

    private bool LastCanEnableIme
    {
      get
      {
        bool found;
        int integer = this.Properties.GetInteger(Control.PropLastCanEnableIme, out found);
        return !found || integer == 1;
      }
      set
      {
        this.Properties.SetInteger(Control.PropLastCanEnableIme, value ? 1 : 0);
      }
    }

    protected static ImeMode PropagatingImeMode
    {
      get
      {
        if (Control.propagatingImeMode == ImeMode.Inherit)
        {
          ImeMode imeMode = ImeMode.Inherit;
          IntPtr focus = System.Windows.Forms.UnsafeNativeMethods.GetFocus();
          if (focus != IntPtr.Zero)
          {
            imeMode = ImeContext.GetImeMode(focus);
            if (imeMode == ImeMode.Disable)
            {
              IntPtr ancestor = System.Windows.Forms.UnsafeNativeMethods.GetAncestor(new HandleRef((object) null, focus), 2);
              if (ancestor != IntPtr.Zero)
                imeMode = ImeContext.GetImeMode(ancestor);
            }
          }
          Control.PropagatingImeMode = imeMode;
        }
        return Control.propagatingImeMode;
      }
      private set
      {
        if (Control.propagatingImeMode == value)
          return;
        switch (value)
        {
          case ImeMode.NoControl:
            break;
          case ImeMode.Disable:
            break;
          default:
            Control.propagatingImeMode = value;
            break;
        }
      }
    }

    [Browsable(false)]
    [SRDescription("ControlOnAutoSizeChangedDescr")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [SRCategory("CatPropertyChanged")]
    public event EventHandler AutoSizeChanged
    {
      add
      {
        this.Events.AddHandler(Control.EventAutoSizeChanged, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventAutoSizeChanged, (Delegate) value);
      }
    }

    [SRCategory("CatPropertyChanged")]
    [SRDescription("ControlOnBackColorChangedDescr")]
    public event EventHandler BackColorChanged
    {
      add
      {
        this.Events.AddHandler(Control.EventBackColor, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventBackColor, (Delegate) value);
      }
    }

    [SRCategory("CatPropertyChanged")]
    [SRDescription("ControlOnBackgroundImageChangedDescr")]
    public event EventHandler BackgroundImageChanged
    {
      add
      {
        this.Events.AddHandler(Control.EventBackgroundImage, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventBackgroundImage, (Delegate) value);
      }
    }

    [SRDescription("ControlOnBackgroundImageLayoutChangedDescr")]
    [SRCategory("CatPropertyChanged")]
    public event EventHandler BackgroundImageLayoutChanged
    {
      add
      {
        this.Events.AddHandler(Control.EventBackgroundImageLayout, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventBackgroundImageLayout, (Delegate) value);
      }
    }

    [SRDescription("ControlOnBindingContextChangedDescr")]
    [SRCategory("CatPropertyChanged")]
    public event EventHandler BindingContextChanged
    {
      add
      {
        this.Events.AddHandler(Control.EventBindingContext, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventBindingContext, (Delegate) value);
      }
    }

    [SRCategory("CatPropertyChanged")]
    [SRDescription("ControlOnCausesValidationChangedDescr")]
    public event EventHandler CausesValidationChanged
    {
      add
      {
        this.Events.AddHandler(Control.EventCausesValidation, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventCausesValidation, (Delegate) value);
      }
    }

    [SRCategory("CatPropertyChanged")]
    [SRDescription("ControlOnClientSizeChangedDescr")]
    public event EventHandler ClientSizeChanged
    {
      add
      {
        this.Events.AddHandler(Control.EventClientSize, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventClientSize, (Delegate) value);
      }
    }

    [SRDescription("ControlOnContextMenuChangedDescr")]
    [Browsable(false)]
    [SRCategory("CatPropertyChanged")]
    public event EventHandler ContextMenuChanged
    {
      add
      {
        this.Events.AddHandler(Control.EventContextMenu, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventContextMenu, (Delegate) value);
      }
    }

    [SRDescription("ControlContextMenuStripChangedDescr")]
    [SRCategory("CatPropertyChanged")]
    public event EventHandler ContextMenuStripChanged
    {
      add
      {
        this.Events.AddHandler(Control.EventContextMenuStrip, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventContextMenuStrip, (Delegate) value);
      }
    }

    [SRDescription("ControlOnCursorChangedDescr")]
    [SRCategory("CatPropertyChanged")]
    public event EventHandler CursorChanged
    {
      add
      {
        this.Events.AddHandler(Control.EventCursor, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventCursor, (Delegate) value);
      }
    }

    [SRDescription("ControlOnDockChangedDescr")]
    [SRCategory("CatPropertyChanged")]
    public event EventHandler DockChanged
    {
      add
      {
        this.Events.AddHandler(Control.EventDock, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventDock, (Delegate) value);
      }
    }

    [SRCategory("CatPropertyChanged")]
    [SRDescription("ControlOnEnabledChangedDescr")]
    public event EventHandler EnabledChanged
    {
      add
      {
        this.Events.AddHandler(Control.EventEnabled, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventEnabled, (Delegate) value);
      }
    }

    [SRDescription("ControlOnFontChangedDescr")]
    [SRCategory("CatPropertyChanged")]
    public event EventHandler FontChanged
    {
      add
      {
        this.Events.AddHandler(Control.EventFont, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventFont, (Delegate) value);
      }
    }

    [SRCategory("CatPropertyChanged")]
    [SRDescription("ControlOnForeColorChangedDescr")]
    public event EventHandler ForeColorChanged
    {
      add
      {
        this.Events.AddHandler(Control.EventForeColor, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventForeColor, (Delegate) value);
      }
    }

    [SRDescription("ControlOnLocationChangedDescr")]
    [SRCategory("CatPropertyChanged")]
    public event EventHandler LocationChanged
    {
      add
      {
        this.Events.AddHandler(Control.EventLocation, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventLocation, (Delegate) value);
      }
    }

    [SRDescription("ControlOnMarginChangedDescr")]
    [SRCategory("CatLayout")]
    public event EventHandler MarginChanged
    {
      add
      {
        this.Events.AddHandler(Control.EventMarginChanged, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventMarginChanged, (Delegate) value);
      }
    }

    [SRDescription("ControlRegionChangedDescr")]
    [SRCategory("CatPropertyChanged")]
    public event EventHandler RegionChanged
    {
      add
      {
        this.Events.AddHandler(Control.EventRegionChanged, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventRegionChanged, (Delegate) value);
      }
    }

    [SRDescription("ControlOnRightToLeftChangedDescr")]
    [SRCategory("CatPropertyChanged")]
    public event EventHandler RightToLeftChanged
    {
      add
      {
        this.Events.AddHandler(Control.EventRightToLeft, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventRightToLeft, (Delegate) value);
      }
    }

    [SRDescription("ControlOnSizeChangedDescr")]
    [SRCategory("CatPropertyChanged")]
    public event EventHandler SizeChanged
    {
      add
      {
        this.Events.AddHandler(Control.EventSize, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventSize, (Delegate) value);
      }
    }

    [SRCategory("CatPropertyChanged")]
    [SRDescription("ControlOnTabIndexChangedDescr")]
    public event EventHandler TabIndexChanged
    {
      add
      {
        this.Events.AddHandler(Control.EventTabIndex, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventTabIndex, (Delegate) value);
      }
    }

    [SRDescription("ControlOnTabStopChangedDescr")]
    [SRCategory("CatPropertyChanged")]
    public event EventHandler TabStopChanged
    {
      add
      {
        this.Events.AddHandler(Control.EventTabStop, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventTabStop, (Delegate) value);
      }
    }

    [SRCategory("CatPropertyChanged")]
    [SRDescription("ControlOnTextChangedDescr")]
    public event EventHandler TextChanged
    {
      add
      {
        this.Events.AddHandler(Control.EventText, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventText, (Delegate) value);
      }
    }

    [SRCategory("CatPropertyChanged")]
    [SRDescription("ControlOnVisibleChangedDescr")]
    public event EventHandler VisibleChanged
    {
      add
      {
        this.Events.AddHandler(Control.EventVisible, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventVisible, (Delegate) value);
      }
    }

    [SRCategory("CatAction")]
    [SRDescription("ControlOnClickDescr")]
    public event EventHandler Click
    {
      add
      {
        this.Events.AddHandler(Control.EventClick, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventClick, (Delegate) value);
      }
    }

    [SRDescription("ControlOnControlAddedDescr")]
    [SRCategory("CatBehavior")]
    [Browsable(true)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public event ControlEventHandler ControlAdded
    {
      add
      {
        this.Events.AddHandler(Control.EventControlAdded, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventControlAdded, (Delegate) value);
      }
    }

    [SRCategory("CatBehavior")]
    [SRDescription("ControlOnControlRemovedDescr")]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Browsable(true)]
    public event ControlEventHandler ControlRemoved
    {
      add
      {
        this.Events.AddHandler(Control.EventControlRemoved, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventControlRemoved, (Delegate) value);
      }
    }

    [SRDescription("ControlOnDragDropDescr")]
    [SRCategory("CatDragDrop")]
    public event DragEventHandler DragDrop
    {
      add
      {
        this.Events.AddHandler(Control.EventDragDrop, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventDragDrop, (Delegate) value);
      }
    }

    [SRDescription("ControlOnDragEnterDescr")]
    [SRCategory("CatDragDrop")]
    public event DragEventHandler DragEnter
    {
      add
      {
        this.Events.AddHandler(Control.EventDragEnter, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventDragEnter, (Delegate) value);
      }
    }

    [SRCategory("CatDragDrop")]
    [SRDescription("ControlOnDragOverDescr")]
    public event DragEventHandler DragOver
    {
      add
      {
        this.Events.AddHandler(Control.EventDragOver, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventDragOver, (Delegate) value);
      }
    }

    [SRCategory("CatDragDrop")]
    [SRDescription("ControlOnDragLeaveDescr")]
    public event EventHandler DragLeave
    {
      add
      {
        this.Events.AddHandler(Control.EventDragLeave, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventDragLeave, (Delegate) value);
      }
    }

    [SRCategory("CatDragDrop")]
    [SRDescription("ControlOnGiveFeedbackDescr")]
    public event GiveFeedbackEventHandler GiveFeedback
    {
      add
      {
        this.Events.AddHandler(Control.EventGiveFeedback, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventGiveFeedback, (Delegate) value);
      }
    }

    [Browsable(false)]
    [SRDescription("ControlOnCreateHandleDescr")]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [SRCategory("CatPrivate")]
    public event EventHandler HandleCreated
    {
      add
      {
        this.Events.AddHandler(Control.EventHandleCreated, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventHandleCreated, (Delegate) value);
      }
    }

    [SRDescription("ControlOnDestroyHandleDescr")]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [SRCategory("CatPrivate")]
    [Browsable(false)]
    public event EventHandler HandleDestroyed
    {
      add
      {
        this.Events.AddHandler(Control.EventHandleDestroyed, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventHandleDestroyed, (Delegate) value);
      }
    }

    [SRDescription("ControlOnHelpDescr")]
    [SRCategory("CatBehavior")]
    public event HelpEventHandler HelpRequested
    {
      add
      {
        this.Events.AddHandler(Control.EventHelpRequested, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventHelpRequested, (Delegate) value);
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Browsable(false)]
    [SRDescription("ControlOnInvalidateDescr")]
    [SRCategory("CatAppearance")]
    public event InvalidateEventHandler Invalidated
    {
      add
      {
        this.Events.AddHandler(Control.EventInvalidated, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventInvalidated, (Delegate) value);
      }
    }

    [SRCategory("CatLayout")]
    [SRDescription("ControlOnPaddingChangedDescr")]
    public event EventHandler PaddingChanged
    {
      add
      {
        this.Events.AddHandler(Control.EventPaddingChanged, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventPaddingChanged, (Delegate) value);
      }
    }

    [SRDescription("ControlOnPaintDescr")]
    [SRCategory("CatAppearance")]
    public event PaintEventHandler Paint
    {
      add
      {
        this.Events.AddHandler(Control.EventPaint, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventPaint, (Delegate) value);
      }
    }

    [SRCategory("CatDragDrop")]
    [SRDescription("ControlOnQueryContinueDragDescr")]
    public event QueryContinueDragEventHandler QueryContinueDrag
    {
      add
      {
        this.Events.AddHandler(Control.EventQueryContinueDrag, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventQueryContinueDrag, (Delegate) value);
      }
    }

    [SRDescription("ControlOnQueryAccessibilityHelpDescr")]
    [SRCategory("CatBehavior")]
    public event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp
    {
      add
      {
        this.Events.AddHandler(Control.EventQueryAccessibilityHelp, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventQueryAccessibilityHelp, (Delegate) value);
      }
    }

    [SRCategory("CatAction")]
    [SRDescription("ControlOnDoubleClickDescr")]
    public event EventHandler DoubleClick
    {
      add
      {
        this.Events.AddHandler(Control.EventDoubleClick, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventDoubleClick, (Delegate) value);
      }
    }

    [SRDescription("ControlOnEnterDescr")]
    [SRCategory("CatFocus")]
    public event EventHandler Enter
    {
      add
      {
        this.Events.AddHandler(Control.EventEnter, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventEnter, (Delegate) value);
      }
    }

    [SRCategory("CatFocus")]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Browsable(false)]
    [SRDescription("ControlOnGotFocusDescr")]
    public event EventHandler GotFocus
    {
      add
      {
        this.Events.AddHandler(Control.EventGotFocus, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventGotFocus, (Delegate) value);
      }
    }

    [SRDescription("ControlOnKeyDownDescr")]
    [SRCategory("CatKey")]
    public event KeyEventHandler KeyDown
    {
      add
      {
        this.Events.AddHandler(Control.EventKeyDown, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventKeyDown, (Delegate) value);
      }
    }

    [SRCategory("CatKey")]
    [SRDescription("ControlOnKeyPressDescr")]
    public event KeyPressEventHandler KeyPress
    {
      add
      {
        this.Events.AddHandler(Control.EventKeyPress, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventKeyPress, (Delegate) value);
      }
    }

    [SRDescription("ControlOnKeyUpDescr")]
    [SRCategory("CatKey")]
    public event KeyEventHandler KeyUp
    {
      add
      {
        this.Events.AddHandler(Control.EventKeyUp, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventKeyUp, (Delegate) value);
      }
    }

    [SRCategory("CatLayout")]
    [SRDescription("ControlOnLayoutDescr")]
    public event LayoutEventHandler Layout
    {
      add
      {
        this.Events.AddHandler(Control.EventLayout, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventLayout, (Delegate) value);
      }
    }

    [SRCategory("CatFocus")]
    [SRDescription("ControlOnLeaveDescr")]
    public event EventHandler Leave
    {
      add
      {
        this.Events.AddHandler(Control.EventLeave, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventLeave, (Delegate) value);
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [SRCategory("CatFocus")]
    [SRDescription("ControlOnLostFocusDescr")]
    [Browsable(false)]
    public event EventHandler LostFocus
    {
      add
      {
        this.Events.AddHandler(Control.EventLostFocus, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventLostFocus, (Delegate) value);
      }
    }

    [SRDescription("ControlOnMouseClickDescr")]
    [SRCategory("CatAction")]
    public event MouseEventHandler MouseClick
    {
      add
      {
        this.Events.AddHandler(Control.EventMouseClick, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventMouseClick, (Delegate) value);
      }
    }

    [SRDescription("ControlOnMouseDoubleClickDescr")]
    [SRCategory("CatAction")]
    public event MouseEventHandler MouseDoubleClick
    {
      add
      {
        this.Events.AddHandler(Control.EventMouseDoubleClick, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventMouseDoubleClick, (Delegate) value);
      }
    }

    [SRDescription("ControlOnMouseCaptureChangedDescr")]
    [SRCategory("CatAction")]
    public event EventHandler MouseCaptureChanged
    {
      add
      {
        this.Events.AddHandler(Control.EventMouseCaptureChanged, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventMouseCaptureChanged, (Delegate) value);
      }
    }

    [SRCategory("CatMouse")]
    [SRDescription("ControlOnMouseDownDescr")]
    public event MouseEventHandler MouseDown
    {
      add
      {
        this.Events.AddHandler(Control.EventMouseDown, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventMouseDown, (Delegate) value);
      }
    }

    [SRCategory("CatMouse")]
    [SRDescription("ControlOnMouseEnterDescr")]
    public event EventHandler MouseEnter
    {
      add
      {
        this.Events.AddHandler(Control.EventMouseEnter, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventMouseEnter, (Delegate) value);
      }
    }

    [SRCategory("CatMouse")]
    [SRDescription("ControlOnMouseLeaveDescr")]
    public event EventHandler MouseLeave
    {
      add
      {
        this.Events.AddHandler(Control.EventMouseLeave, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventMouseLeave, (Delegate) value);
      }
    }

    [SRDescription("ControlOnMouseHoverDescr")]
    [SRCategory("CatMouse")]
    public event EventHandler MouseHover
    {
      add
      {
        this.Events.AddHandler(Control.EventMouseHover, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventMouseHover, (Delegate) value);
      }
    }

    [SRDescription("ControlOnMouseMoveDescr")]
    [SRCategory("CatMouse")]
    public event MouseEventHandler MouseMove
    {
      add
      {
        this.Events.AddHandler(Control.EventMouseMove, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventMouseMove, (Delegate) value);
      }
    }

    [SRCategory("CatMouse")]
    [SRDescription("ControlOnMouseUpDescr")]
    public event MouseEventHandler MouseUp
    {
      add
      {
        this.Events.AddHandler(Control.EventMouseUp, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventMouseUp, (Delegate) value);
      }
    }

    [SRDescription("ControlOnMouseWheelDescr")]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [SRCategory("CatMouse")]
    [Browsable(false)]
    public event MouseEventHandler MouseWheel
    {
      add
      {
        this.Events.AddHandler(Control.EventMouseWheel, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventMouseWheel, (Delegate) value);
      }
    }

    [SRDescription("ControlOnMoveDescr")]
    [SRCategory("CatLayout")]
    public event EventHandler Move
    {
      add
      {
        this.Events.AddHandler(Control.EventMove, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventMove, (Delegate) value);
      }
    }

    [SRCategory("CatKey")]
    [SRDescription("PreviewKeyDownDescr")]
    public event PreviewKeyDownEventHandler PreviewKeyDown
    {
      [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)] add
      {
        this.Events.AddHandler(Control.EventPreviewKeyDown, (Delegate) value);
      }
      [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)] remove
      {
        this.Events.RemoveHandler(Control.EventPreviewKeyDown, (Delegate) value);
      }
    }

    [SRCategory("CatLayout")]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [SRDescription("ControlOnResizeDescr")]
    public event EventHandler Resize
    {
      add
      {
        this.Events.AddHandler(Control.EventResize, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventResize, (Delegate) value);
      }
    }

    [SRCategory("CatBehavior")]
    [SRDescription("ControlOnChangeUICuesDescr")]
    public event UICuesEventHandler ChangeUICues
    {
      add
      {
        this.Events.AddHandler(Control.EventChangeUICues, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventChangeUICues, (Delegate) value);
      }
    }

    [SRDescription("ControlOnStyleChangedDescr")]
    [SRCategory("CatBehavior")]
    public event EventHandler StyleChanged
    {
      add
      {
        this.Events.AddHandler(Control.EventStyleChanged, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventStyleChanged, (Delegate) value);
      }
    }

    [SRCategory("CatBehavior")]
    [SRDescription("ControlOnSystemColorsChangedDescr")]
    public event EventHandler SystemColorsChanged
    {
      add
      {
        this.Events.AddHandler(Control.EventSystemColorsChanged, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventSystemColorsChanged, (Delegate) value);
      }
    }

    [SRCategory("CatFocus")]
    [SRDescription("ControlOnValidatingDescr")]
    public event CancelEventHandler Validating
    {
      add
      {
        this.Events.AddHandler(Control.EventValidating, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventValidating, (Delegate) value);
      }
    }

    [SRDescription("ControlOnValidatedDescr")]
    [SRCategory("CatFocus")]
    public event EventHandler Validated
    {
      add
      {
        this.Events.AddHandler(Control.EventValidated, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventValidated, (Delegate) value);
      }
    }

    [SRDescription("ControlOnParentChangedDescr")]
    [SRCategory("CatPropertyChanged")]
    public event EventHandler ParentChanged
    {
      add
      {
        this.Events.AddHandler(Control.EventParent, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventParent, (Delegate) value);
      }
    }

    [SRDescription("ControlOnImeModeChangedDescr")]
    [WinCategory("Behavior")]
    public event EventHandler ImeModeChanged
    {
      add
      {
        this.Events.AddHandler(Control.EventImeModeChanged, (Delegate) value);
      }
      remove
      {
        this.Events.RemoveHandler(Control.EventImeModeChanged, (Delegate) value);
      }
    }

    static Control()
    {
    }

    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public Control()
      : this(true)
    {
    }

    internal Control(bool autoInstallSyncContext)
    {
      this.propertyStore = new PropertyStore();
      this.window = new Control.ControlNativeWindow(this);
      this.RequiredScalingEnabled = true;
      this.RequiredScaling = BoundsSpecified.All;
      this.tabIndex = -1;
      this.state = 131086;
      this.state2 = 8;
      this.SetStyle(ControlStyles.UserPaint | ControlStyles.StandardClick | ControlStyles.Selectable | ControlStyles.StandardDoubleClick | ControlStyles.AllPaintingInWmPaint | ControlStyles.UseTextForAccessibility, true);
      this.InitMouseWheelSupport();
      if (this.DefaultMargin != CommonProperties.DefaultMargin)
        this.Margin = this.DefaultMargin;
      if (this.DefaultMinimumSize != CommonProperties.DefaultMinimumSize)
        this.MinimumSize = this.DefaultMinimumSize;
      if (this.DefaultMaximumSize != CommonProperties.DefaultMaximumSize)
        this.MaximumSize = this.DefaultMaximumSize;
      Size defaultSize = this.DefaultSize;
      this.width = defaultSize.Width;
      this.height = defaultSize.Height;
      CommonProperties.xClearPreferredSizeCache((IArrangedElement) this);
      if (this.width != 0 && this.height != 0)
      {
        System.Windows.Forms.NativeMethods.RECT lpRect = new System.Windows.Forms.NativeMethods.RECT();
        lpRect.left = lpRect.right = lpRect.top = lpRect.bottom = 0;
        CreateParams createParams = this.CreateParams;
        System.Windows.Forms.SafeNativeMethods.AdjustWindowRectEx(ref lpRect, createParams.Style, false, createParams.ExStyle);
        this.clientWidth = this.width - (lpRect.right - lpRect.left);
        this.clientHeight = this.height - (lpRect.bottom - lpRect.top);
      }
      if (!autoInstallSyncContext)
        return;
      WindowsFormsSynchronizationContext.InstallIfNeeded();
    }

    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public Control(string text)
      : this((Control) null, text)
    {
    }

    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public Control(string text, int left, int top, int width, int height)
      : this((Control) null, text, left, top, width, height)
    {
    }

    public Control(Control parent, string text)
      : this()
    {
      this.Parent = parent;
      this.Text = text;
    }

    public Control(Control parent, string text, int left, int top, int width, int height)
      : this(parent, text)
    {
      this.Location = new Point(left, top);
      this.Size = new Size(width, height);
    }

    protected virtual AccessibleObject GetAccessibilityObjectById(int objectId)
    {
      return (AccessibleObject) null;
    }

    protected void SetAutoSizeMode(AutoSizeMode mode)
    {
      CommonProperties.SetAutoSizeMode((IArrangedElement) this, mode);
    }

    protected AutoSizeMode GetAutoSizeMode()
    {
      return CommonProperties.GetAutoSizeMode((IArrangedElement) this);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void ResetBindings()
    {
      ControlBindingsCollection bindingsCollection = (ControlBindingsCollection) this.Properties.GetObject(Control.PropBindings);
      if (bindingsCollection == null)
        return;
      bindingsCollection.Clear();
    }

    internal virtual void NotifyValidationResult(object sender, CancelEventArgs ev)
    {
      this.ValidationCancelled = ev.Cancel;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public virtual Size GetPreferredSize(Size proposedSize)
    {
      Size size;
      if (this.GetState(6144))
      {
        size = CommonProperties.xGetPreferredSizeCache((IArrangedElement) this);
      }
      else
      {
        proposedSize = LayoutUtils.ConvertZeroToUnbounded(proposedSize);
        proposedSize = this.ApplySizeConstraints(proposedSize);
        if (this.GetState2(2048))
        {
          Size preferredSizeCache = CommonProperties.xGetPreferredSizeCache((IArrangedElement) this);
          if (!preferredSizeCache.IsEmpty && proposedSize == LayoutUtils.MaxSize)
            return preferredSizeCache;
        }
        this.CacheTextInternal = true;
        Size preferredSizeCore;
        try
        {
          preferredSizeCore = this.GetPreferredSizeCore(proposedSize);
        }
        finally
        {
          this.CacheTextInternal = false;
        }
        size = this.ApplySizeConstraints(preferredSizeCore);
        if (this.GetState2(2048) && proposedSize == LayoutUtils.MaxSize)
          CommonProperties.xSetPreferredSizeCache((IArrangedElement) this, size);
      }
      return size;
    }

    internal virtual Size GetPreferredSizeCore(Size proposedSize)
    {
      return CommonProperties.GetSpecifiedBounds((IArrangedElement) this).Size;
    }

    internal virtual void AddReflectChild()
    {
    }

    internal virtual void RemoveReflectChild()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    protected internal void AccessibilityNotifyClients(AccessibleEvents accEvent, int childID)
    {
      this.AccessibilityNotifyClients(accEvent, -4, childID);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected void AccessibilityNotifyClients(AccessibleEvents accEvent, int objectID, int childID)
    {
      if (!this.IsHandleCreated)
        return;
      System.Windows.Forms.UnsafeNativeMethods.NotifyWinEvent((int) accEvent, new HandleRef((object) this, this.Handle), objectID, childID + 1);
    }

    internal virtual void AssignParent(Control value)
    {
      if (value != null)
        this.RequiredScalingEnabled = value.RequiredScalingEnabled;
      if (this.CanAccessProperties)
      {
        Font font = this.Font;
        System.Drawing.Color foreColor = this.ForeColor;
        System.Drawing.Color backColor = this.BackColor;
        RightToLeft rightToLeft = this.RightToLeft;
        bool enabled = this.Enabled;
        bool visible1 = this.Visible;
        this.parent = value;
        this.OnParentChanged(EventArgs.Empty);
        if (this.GetAnyDisposingInHierarchy())
          return;
        if (enabled != this.Enabled)
          this.OnEnabledChanged(EventArgs.Empty);
        bool visible2 = this.Visible;
        if (visible1 != visible2 && (visible1 || !visible2 || (this.parent != null || this.GetTopLevel())))
          this.OnVisibleChanged(EventArgs.Empty);
        if (!font.Equals((object) this.Font))
          this.OnFontChanged(EventArgs.Empty);
        if (!foreColor.Equals((object) this.ForeColor))
          this.OnForeColorChanged(EventArgs.Empty);
        if (!backColor.Equals((object) this.BackColor))
          this.OnBackColorChanged(EventArgs.Empty);
        if (rightToLeft != this.RightToLeft)
          this.OnRightToLeftChanged(EventArgs.Empty);
        if (this.Properties.GetObject(Control.PropBindingManager) == null && this.Created)
          this.OnBindingContextChanged(EventArgs.Empty);
      }
      else
      {
        this.parent = value;
        this.OnParentChanged(EventArgs.Empty);
      }
      this.SetState(16777216, false);
      if (this.ParentInternal == null)
        return;
      this.ParentInternal.LayoutEngine.InitLayout((object) this, BoundsSpecified.All);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public IAsyncResult BeginInvoke(Delegate method)
    {
      return this.BeginInvoke(method, (object[]) null);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public IAsyncResult BeginInvoke(Delegate method, params object[] args)
    {
      using (new Control.MultithreadSafeCallScope())
        return (IAsyncResult) this.FindMarshalingControl().MarshaledInvoke(this, method, args, false);
    }

    public void BringToFront()
    {
      if (this.parent != null)
      {
        this.parent.Controls.SetChildIndex(this, 0);
      }
      else
      {
        if (!this.IsHandleCreated || !this.GetTopLevel() || !System.Windows.Forms.SafeNativeMethods.IsWindowEnabled(new HandleRef((object) this.window, this.Handle)))
          return;
        System.Windows.Forms.SafeNativeMethods.SetWindowPos(new HandleRef((object) this.window, this.Handle), System.Windows.Forms.NativeMethods.HWND_TOP, 0, 0, 0, 0, 3);
      }
    }

    internal virtual bool CanProcessMnemonic()
    {
      if (!this.Enabled || !this.Visible)
        return false;
      if (this.parent != null)
        return this.parent.CanProcessMnemonic();
      else
        return true;
    }

    internal virtual bool CanSelectCore()
    {
      if ((this.controlStyle & ControlStyles.Selectable) != ControlStyles.Selectable)
        return false;
      for (Control control = this; control != null; control = control.parent)
      {
        if (!control.Enabled || !control.Visible)
          return false;
      }
      return true;
    }

    public bool Contains(Control ctl)
    {
      while (ctl != null)
      {
        ctl = ctl.ParentInternal;
        if (ctl == null)
          return false;
        if (ctl == this)
          return true;
      }
      return false;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual AccessibleObject CreateAccessibilityInstance()
    {
      return (AccessibleObject) new Control.ControlAccessibleObject(this);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual Control.ControlCollection CreateControlsInstance()
    {
      return new Control.ControlCollection(this);
    }

    public Graphics CreateGraphics()
    {
      using (new Control.MultithreadSafeCallScope())
      {
        System.Windows.Forms.IntSecurity.CreateGraphicsForControl.Demand();
        return this.CreateGraphicsInternal();
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [UIPermission(SecurityAction.InheritanceDemand, Window = UIPermissionWindow.AllWindows)]
    protected virtual void CreateHandle()
    {
      IntPtr userCookie = IntPtr.Zero;
      if (this.GetState(2048))
        throw new ObjectDisposedException(this.GetType().Name);
      if (this.GetState(262144))
        return;
      Rectangle bounds;
      try
      {
        this.SetState(262144, true);
        bounds = this.Bounds;
        if (Application.UseVisualStyles)
          userCookie = System.Windows.Forms.UnsafeNativeMethods.ThemingScope.Activate();
        CreateParams createParams = this.CreateParams;
        this.SetState(1073741824, (createParams.ExStyle & 4194304) != 0);
        if (this.parent != null)
        {
          Rectangle clientRectangle = this.parent.ClientRectangle;
          if (!clientRectangle.IsEmpty)
          {
            if (createParams.X != int.MinValue)
              createParams.X -= clientRectangle.X;
            if (createParams.Y != int.MinValue)
              createParams.Y -= clientRectangle.Y;
          }
        }
        if (createParams.Parent == IntPtr.Zero && (createParams.Style & 1073741824) != 0)
          Application.ParkHandle(createParams);
        this.window.CreateHandle(createParams);
        this.UpdateReflectParent(true);
      }
      finally
      {
        this.SetState(262144, false);
        System.Windows.Forms.UnsafeNativeMethods.ThemingScope.Deactivate(userCookie);
      }
      if (!(this.Bounds != bounds))
        return;
      LayoutTransaction.DoLayout((IArrangedElement) this.ParentInternal, (IArrangedElement) this, PropertyNames.Bounds);
    }

    public void CreateControl()
    {
      bool created = this.Created;
      this.CreateControl(false);
      if (this.Properties.GetObject(Control.PropBindingManager) != null || this.ParentInternal == null || created)
        return;
      this.OnBindingContextChanged(EventArgs.Empty);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    [SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    protected virtual void DefWndProc(ref Message m)
    {
      this.window.DefWndProc(ref m);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    [UIPermission(SecurityAction.LinkDemand, Window = UIPermissionWindow.AllWindows)]
    protected virtual void DestroyHandle()
    {
      if (this.RecreatingHandle && this.threadCallbackList != null)
      {
        lock (this.threadCallbackList)
        {
          if (Control.threadCallbackMessage != 0)
          {
            System.Windows.Forms.NativeMethods.MSG local_0 = new System.Windows.Forms.NativeMethods.MSG();
            if (System.Windows.Forms.UnsafeNativeMethods.PeekMessage(out local_0, new HandleRef((object) this, this.Handle), Control.threadCallbackMessage, Control.threadCallbackMessage, 0))
              this.SetState(32768, true);
          }
        }
      }
      if (!this.RecreatingHandle && this.threadCallbackList != null)
      {
        lock (this.threadCallbackList)
        {
          Exception local_2 = (Exception) new ObjectDisposedException(this.GetType().Name);
          while (this.threadCallbackList.Count > 0)
          {
            Control.ThreadMethodEntry local_3 = (Control.ThreadMethodEntry) this.threadCallbackList.Dequeue();
            local_3.exception = local_2;
            local_3.Complete();
          }
        }
      }
      if ((64 & (int) (long) System.Windows.Forms.UnsafeNativeMethods.GetWindowLong(new HandleRef((object) this.window, this.InternalHandle), -20)) != 0)
        System.Windows.Forms.UnsafeNativeMethods.DefMDIChildProc(this.InternalHandle, 16, IntPtr.Zero, IntPtr.Zero);
      else
        this.window.DestroyHandle();
      this.trackMouseEvent = (System.Windows.Forms.NativeMethods.TRACKMOUSEEVENT) null;
    }

    protected override void Dispose(bool disposing)
    {
      if (this.GetState(2097152))
      {
        object @object = this.Properties.GetObject(Control.PropBackBrush);
        if (@object != null)
        {
          IntPtr handle = (IntPtr) @object;
          if (handle != IntPtr.Zero)
            System.Windows.Forms.SafeNativeMethods.DeleteObject(new HandleRef((object) this, handle));
          this.Properties.SetObject(Control.PropBackBrush, (object) null);
        }
      }
      this.UpdateReflectParent(false);
      if (disposing)
      {
        if (this.GetState(4096))
          return;
        if (this.GetState(262144))
        {
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ClosingWhileCreatingHandle", new object[1]
          {
            (object) "Dispose"
          }));
        }
        else
        {
          this.SetState(4096, true);
          this.SuspendLayout();
          try
          {
            this.DisposeAxControls();
            ContextMenu contextMenu = (ContextMenu) this.Properties.GetObject(Control.PropContextMenu);
            if (contextMenu != null)
              contextMenu.Disposed -= new EventHandler(this.DetachContextMenu);
            this.ResetBindings();
            if (this.IsHandleCreated)
              this.DestroyHandle();
            if (this.parent != null)
              this.parent.Controls.Remove(this);
            Control.ControlCollection controlCollection = (Control.ControlCollection) this.Properties.GetObject(Control.PropControlsCollection);
            if (controlCollection != null)
            {
              for (int index = 0; index < controlCollection.Count; ++index)
              {
                Control control = controlCollection[index];
                control.parent = (Control) null;
                control.Dispose();
              }
              this.Properties.SetObject(Control.PropControlsCollection, (object) null);
            }
            base.Dispose(disposing);
          }
          finally
          {
            this.ResumeLayout(false);
            this.SetState(4096, false);
            this.SetState(2048, true);
          }
        }
      }
      else
      {
        if (this.window != null)
          this.window.ForceExitMessageLoop();
        base.Dispose(disposing);
      }
    }

    internal virtual void DisposeAxControls()
    {
      Control.ControlCollection controlCollection = (Control.ControlCollection) this.Properties.GetObject(Control.PropControlsCollection);
      if (controlCollection == null)
        return;
      for (int index = 0; index < controlCollection.Count; ++index)
        controlCollection[index].DisposeAxControls();
    }

    [UIPermission(SecurityAction.Demand, Clipboard = UIPermissionClipboard.OwnClipboard)]
    public DragDropEffects DoDragDrop(object data, DragDropEffects allowedEffects)
    {
      int[] finalEffect = new int[1];
      System.Windows.Forms.UnsafeNativeMethods.IOleDropSource dropSource = (System.Windows.Forms.UnsafeNativeMethods.IOleDropSource) new DropSource((ISupportOleDropSource) this);
      System.Runtime.InteropServices.ComTypes.IDataObject dataObject1;
      if (data is System.Runtime.InteropServices.ComTypes.IDataObject)
      {
        dataObject1 = (System.Runtime.InteropServices.ComTypes.IDataObject) data;
      }
      else
      {
        DataObject dataObject2;
        if (data is System.Windows.Forms.IDataObject)
        {
          dataObject2 = new DataObject((System.Windows.Forms.IDataObject) data);
        }
        else
        {
          dataObject2 = new DataObject();
          dataObject2.SetData(data);
        }
        dataObject1 = (System.Runtime.InteropServices.ComTypes.IDataObject) dataObject2;
      }
      try
      {
        System.Windows.Forms.SafeNativeMethods.DoDragDrop(dataObject1, dropSource, (int) allowedEffects, finalEffect);
      }
      catch (Exception ex)
      {
        if (System.Windows.Forms.ClientUtils.IsSecurityOrCriticalException(ex))
          throw;
      }
      return (DragDropEffects) finalEffect[0];
    }

    [UIPermission(SecurityAction.Demand, Window = UIPermissionWindow.AllWindows)]
    public void DrawToBitmap(Bitmap bitmap, Rectangle targetBounds)
    {
      if (bitmap == null)
        throw new ArgumentNullException("bitmap");
      if (targetBounds.Width <= 0 || targetBounds.Height <= 0 || (targetBounds.X < 0 || targetBounds.Y < 0))
        throw new ArgumentException("targetBounds");
      if (!this.IsHandleCreated)
        this.CreateHandle();
      int num1 = Math.Min(this.Width, targetBounds.Width);
      int num2 = Math.Min(this.Height, targetBounds.Height);
      using (Graphics graphics1 = Graphics.FromImage((Image) new Bitmap(num1, num2, bitmap.PixelFormat)))
      {
        IntPtr hdc1 = graphics1.GetHdc();
        System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), 791, hdc1, (IntPtr) 30);
        using (Graphics graphics2 = Graphics.FromImage((Image) bitmap))
        {
          IntPtr hdc2 = graphics2.GetHdc();
          System.Windows.Forms.SafeNativeMethods.BitBlt(new HandleRef((object) graphics2, hdc2), targetBounds.X, targetBounds.Y, num1, num2, new HandleRef((object) graphics1, hdc1), 0, 0, 13369376);
          graphics2.ReleaseHdcInternal(hdc2);
        }
        graphics1.ReleaseHdcInternal(hdc1);
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public object EndInvoke(IAsyncResult asyncResult)
    {
      using (new Control.MultithreadSafeCallScope())
      {
        if (asyncResult == null)
          throw new ArgumentNullException("asyncResult");
        Control.ThreadMethodEntry threadMethodEntry = asyncResult as Control.ThreadMethodEntry;
        if (threadMethodEntry == null)
          throw new ArgumentException(System.Windows.Forms.SR.GetString("ControlBadAsyncResult"), "asyncResult");
        if (!asyncResult.IsCompleted)
        {
          Control marshalingControl = this.FindMarshalingControl();
          int lpdwProcessId;
          if (System.Windows.Forms.SafeNativeMethods.GetWindowThreadProcessId(new HandleRef((object) marshalingControl, marshalingControl.Handle), out lpdwProcessId) == System.Windows.Forms.SafeNativeMethods.GetCurrentThreadId())
            marshalingControl.InvokeMarshaledCallbacks();
          else
            threadMethodEntry.marshaler.WaitForWaitHandle(asyncResult.AsyncWaitHandle);
        }
        if (threadMethodEntry.exception != null)
          throw threadMethodEntry.exception;
        else
          return threadMethodEntry.retVal;
      }
    }

    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    [UIPermission(SecurityAction.Demand, Window = UIPermissionWindow.AllWindows)]
    public Form FindForm()
    {
      return this.FindFormInternal();
    }

    internal Form FindFormInternal()
    {
      Control control = this;
      while (control != null && !(control is Form))
        control = control.ParentInternal;
      return (Form) control;
    }

    protected bool GetTopLevel()
    {
      return (this.state & 524288) != 0;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected void RaiseKeyEvent(object key, KeyEventArgs e)
    {
      KeyEventHandler keyEventHandler = (KeyEventHandler) this.Events[key];
      if (keyEventHandler == null)
        return;
      keyEventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected void RaiseMouseEvent(object key, MouseEventArgs e)
    {
      MouseEventHandler mouseEventHandler = (MouseEventHandler) this.Events[key];
      if (mouseEventHandler == null)
        return;
      mouseEventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public bool Focus()
    {
      System.Windows.Forms.IntSecurity.ModifyFocus.Demand();
      return this.FocusInternal();
    }

    internal virtual bool FocusInternal()
    {
      if (this.CanFocus)
        System.Windows.Forms.UnsafeNativeMethods.SetFocus(new HandleRef((object) this, this.Handle));
      if (this.Focused && this.ParentInternal != null)
      {
        IContainerControl containerControlInternal = this.ParentInternal.GetContainerControlInternal();
        if (containerControlInternal != null)
        {
          if (containerControlInternal is ContainerControl)
            ((ContainerControl) containerControlInternal).SetActiveControlInternal(this);
          else
            containerControlInternal.ActiveControl = this;
        }
      }
      return this.Focused;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public static Control FromChildHandle(IntPtr handle)
    {
      System.Windows.Forms.IntSecurity.ControlFromHandleOrLocation.Demand();
      return Control.FromChildHandleInternal(handle);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public static Control FromHandle(IntPtr handle)
    {
      System.Windows.Forms.IntSecurity.ControlFromHandleOrLocation.Demand();
      return Control.FromHandleInternal(handle);
    }

    internal virtual Rectangle ApplyBoundsConstraints(int suggestedX, int suggestedY, int proposedWidth, int proposedHeight)
    {
      if (!(this.MaximumSize != Size.Empty) && !(this.MinimumSize != Size.Empty))
        return new Rectangle(suggestedX, suggestedY, proposedWidth, proposedHeight);
      Size b = LayoutUtils.ConvertZeroToUnbounded(this.MaximumSize);
      Rectangle rectangle = new Rectangle(suggestedX, suggestedY, 0, 0);
      rectangle.Size = LayoutUtils.IntersectSizes(new Size(proposedWidth, proposedHeight), b);
      rectangle.Size = LayoutUtils.UnionSizes(rectangle.Size, this.MinimumSize);
      return rectangle;
    }

    public Control GetChildAtPoint(Point pt, GetChildAtPointSkip skipValue)
    {
      int num = (int) skipValue;
      if (num < 0 || num > 7)
        throw new InvalidEnumArgumentException("skipValue", num, typeof (GetChildAtPointSkip));
      Control descendant = Control.FromChildHandleInternal(System.Windows.Forms.UnsafeNativeMethods.ChildWindowFromPointEx(new HandleRef((object) null, this.Handle), pt.X, pt.Y, num));
      if (descendant != null && !this.IsDescendant(descendant))
        System.Windows.Forms.IntSecurity.ControlFromHandleOrLocation.Demand();
      if (descendant != this)
        return descendant;
      else
        return (Control) null;
    }

    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public Control GetChildAtPoint(Point pt)
    {
      return this.GetChildAtPoint(pt, GetChildAtPointSkip.None);
    }

    public IContainerControl GetContainerControl()
    {
      System.Windows.Forms.IntSecurity.GetParent.Demand();
      return this.GetContainerControlInternal();
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual Rectangle GetScaledBounds(Rectangle bounds, SizeF factor, BoundsSpecified specified)
    {
      System.Windows.Forms.NativeMethods.RECT lpRect = new System.Windows.Forms.NativeMethods.RECT(0, 0, 0, 0);
      CreateParams createParams = this.CreateParams;
      System.Windows.Forms.SafeNativeMethods.AdjustWindowRectEx(ref lpRect, createParams.Style, this.HasMenu, createParams.ExStyle);
      float width1 = factor.Width;
      float height1 = factor.Height;
      int x = bounds.X;
      int y = bounds.Y;
      bool flag = !this.GetState(524288);
      if (flag)
      {
        ISite site = this.Site;
        if (site != null && site.DesignMode)
        {
          IDesignerHost designerHost = site.GetService(typeof (IDesignerHost)) as IDesignerHost;
          if (designerHost != null && designerHost.RootComponent == this)
            flag = false;
        }
      }
      if (flag)
      {
        if ((specified & BoundsSpecified.X) != BoundsSpecified.None)
          x = (int) Math.Round((double) bounds.X * (double) width1);
        if ((specified & BoundsSpecified.Y) != BoundsSpecified.None)
          y = (int) Math.Round((double) bounds.Y * (double) height1);
      }
      int width2 = bounds.Width;
      int height2 = bounds.Height;
      if ((this.controlStyle & ControlStyles.FixedWidth) != ControlStyles.FixedWidth && (specified & BoundsSpecified.Width) != BoundsSpecified.None)
      {
        int num = lpRect.right - lpRect.left;
        width2 = (int) Math.Round((double) (bounds.Width - num) * (double) width1) + num;
      }
      if ((this.controlStyle & ControlStyles.FixedHeight) != ControlStyles.FixedHeight && (specified & BoundsSpecified.Height) != BoundsSpecified.None)
      {
        int num = lpRect.bottom - lpRect.top;
        height2 = (int) Math.Round((double) (bounds.Height - num) * (double) height1) + num;
      }
      return new Rectangle(x, y, width2, height2);
    }

    internal virtual bool GetVisibleCore()
    {
      if (!this.GetState(2))
        return false;
      if (this.ParentInternal == null)
        return true;
      else
        return this.ParentInternal.GetVisibleCore();
    }

    internal virtual Control GetFirstChildControlInTabOrder(bool forward)
    {
      Control.ControlCollection controlCollection = (Control.ControlCollection) this.Properties.GetObject(Control.PropControlsCollection);
      Control control = (Control) null;
      if (controlCollection != null)
      {
        if (forward)
        {
          for (int index = 0; index < controlCollection.Count; ++index)
          {
            if (control == null || control.tabIndex > controlCollection[index].tabIndex)
              control = controlCollection[index];
          }
        }
        else
        {
          for (int index = controlCollection.Count - 1; index >= 0; --index)
          {
            if (control == null || control.tabIndex < controlCollection[index].tabIndex)
              control = controlCollection[index];
          }
        }
      }
      return control;
    }

    public Control GetNextControl(Control ctl, bool forward)
    {
      if (!this.Contains(ctl))
        ctl = this;
      if (forward)
      {
        Control.ControlCollection controlCollection1 = (Control.ControlCollection) ctl.Properties.GetObject(Control.PropControlsCollection);
        if (controlCollection1 != null && controlCollection1.Count > 0 && (ctl == this || !Control.IsFocusManagingContainerControl(ctl)))
        {
          Control controlInTabOrder = ctl.GetFirstChildControlInTabOrder(true);
          if (controlInTabOrder != null)
            return controlInTabOrder;
        }
        for (; ctl != this; ctl = ctl.parent)
        {
          int num1 = ctl.tabIndex;
          bool flag = false;
          Control control1 = (Control) null;
          Control control2 = ctl.parent;
          int num2 = 0;
          Control.ControlCollection controlCollection2 = (Control.ControlCollection) control2.Properties.GetObject(Control.PropControlsCollection);
          if (controlCollection2 != null)
            num2 = controlCollection2.Count;
          for (int index = 0; index < num2; ++index)
          {
            if (controlCollection2[index] != ctl)
            {
              if (controlCollection2[index].tabIndex >= num1 && (control1 == null || control1.tabIndex > controlCollection2[index].tabIndex) && (controlCollection2[index].tabIndex != num1 || flag))
                control1 = controlCollection2[index];
            }
            else
              flag = true;
          }
          if (control1 != null)
            return control1;
        }
      }
      else
      {
        if (ctl != this)
        {
          int num1 = ctl.tabIndex;
          bool flag = false;
          Control control1 = (Control) null;
          Control control2 = ctl.parent;
          int num2 = 0;
          Control.ControlCollection controlCollection = (Control.ControlCollection) control2.Properties.GetObject(Control.PropControlsCollection);
          if (controlCollection != null)
            num2 = controlCollection.Count;
          for (int index = num2 - 1; index >= 0; --index)
          {
            if (controlCollection[index] != ctl)
            {
              if (controlCollection[index].tabIndex <= num1 && (control1 == null || control1.tabIndex < controlCollection[index].tabIndex) && (controlCollection[index].tabIndex != num1 || flag))
                control1 = controlCollection[index];
            }
            else
              flag = true;
          }
          if (control1 != null)
            ctl = control1;
          else if (control2 == this)
            return (Control) null;
          else
            return control2;
        }
        for (Control.ControlCollection controlCollection = (Control.ControlCollection) ctl.Properties.GetObject(Control.PropControlsCollection); controlCollection != null && controlCollection.Count > 0 && (ctl == this || !Control.IsFocusManagingContainerControl(ctl)); controlCollection = (Control.ControlCollection) ctl.Properties.GetObject(Control.PropControlsCollection))
        {
          Control controlInTabOrder = ctl.GetFirstChildControlInTabOrder(false);
          if (controlInTabOrder != null)
            ctl = controlInTabOrder;
          else
            break;
        }
      }
      if (ctl != this)
        return ctl;
      else
        return (Control) null;
    }

    internal bool GetState(int flag)
    {
      return (this.state & flag) != 0;
    }

    private bool GetState2(int flag)
    {
      return (this.state2 & flag) != 0;
    }

    protected bool GetStyle(ControlStyles flag)
    {
      return (this.controlStyle & flag) == flag;
    }

    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public void Hide()
    {
      this.Visible = false;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void InitLayout()
    {
      this.LayoutEngine.InitLayout((object) this, BoundsSpecified.All);
    }

    internal virtual IntPtr InitializeDCForWmCtlColor(IntPtr dc, int msg)
    {
      if (this.GetStyle(ControlStyles.UserPaint))
        return System.Windows.Forms.UnsafeNativeMethods.GetStockObject(5);
      System.Windows.Forms.SafeNativeMethods.SetTextColor(new HandleRef((object) null, dc), ColorTranslator.ToWin32(this.ForeColor));
      System.Windows.Forms.SafeNativeMethods.SetBkColor(new HandleRef((object) null, dc), ColorTranslator.ToWin32(this.BackColor));
      return this.BackColorBrush;
    }

    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public void Invalidate(Region region)
    {
      this.Invalidate(region, false);
    }

    public void Invalidate(Region region, bool invalidateChildren)
    {
      if (region == null)
      {
        this.Invalidate(invalidateChildren);
      }
      else
      {
        if (!this.IsHandleCreated)
          return;
        IntPtr hrgn = this.GetHRgn(region);
        try
        {
          if (invalidateChildren)
          {
            System.Windows.Forms.SafeNativeMethods.RedrawWindow(new HandleRef((object) this, this.Handle), (System.Windows.Forms.NativeMethods.COMRECT) null, new HandleRef((object) region, hrgn), 133);
          }
          else
          {
            using (new Control.MultithreadSafeCallScope())
              System.Windows.Forms.SafeNativeMethods.InvalidateRgn(new HandleRef((object) this, this.Handle), new HandleRef((object) region, hrgn), !this.GetStyle(ControlStyles.Opaque));
          }
        }
        finally
        {
          System.Windows.Forms.SafeNativeMethods.DeleteObject(new HandleRef((object) region, hrgn));
        }
        Rectangle invalidRect = Rectangle.Empty;
        using (Graphics graphicsInternal = this.CreateGraphicsInternal())
          invalidRect = Rectangle.Ceiling(region.GetBounds(graphicsInternal));
        this.OnInvalidated(new InvalidateEventArgs(invalidRect));
      }
    }

    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public void Invalidate()
    {
      this.Invalidate(false);
    }

    public void Invalidate(bool invalidateChildren)
    {
      if (!this.IsHandleCreated)
        return;
      if (invalidateChildren)
      {
        System.Windows.Forms.SafeNativeMethods.RedrawWindow(new HandleRef((object) this.window, this.Handle), (System.Windows.Forms.NativeMethods.COMRECT) null, System.Windows.Forms.NativeMethods.NullHandleRef, 133);
      }
      else
      {
        using (new Control.MultithreadSafeCallScope())
          System.Windows.Forms.SafeNativeMethods.InvalidateRect(new HandleRef((object) this.window, this.Handle), (System.Windows.Forms.NativeMethods.COMRECT) null, (this.controlStyle & ControlStyles.Opaque) != ControlStyles.Opaque);
      }
      this.NotifyInvalidate(this.ClientRectangle);
    }

    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public void Invalidate(Rectangle rc)
    {
      this.Invalidate(rc, false);
    }

    public void Invalidate(Rectangle rc, bool invalidateChildren)
    {
      if (rc.IsEmpty)
      {
        this.Invalidate(invalidateChildren);
      }
      else
      {
        if (!this.IsHandleCreated)
          return;
        if (invalidateChildren)
        {
          System.Windows.Forms.NativeMethods.RECT rcUpdate = System.Windows.Forms.NativeMethods.RECT.FromXYWH(rc.X, rc.Y, rc.Width, rc.Height);
          System.Windows.Forms.SafeNativeMethods.RedrawWindow(new HandleRef((object) this.window, this.Handle), ref rcUpdate, System.Windows.Forms.NativeMethods.NullHandleRef, 133);
        }
        else
        {
          System.Windows.Forms.NativeMethods.RECT rect = System.Windows.Forms.NativeMethods.RECT.FromXYWH(rc.X, rc.Y, rc.Width, rc.Height);
          using (new Control.MultithreadSafeCallScope())
            System.Windows.Forms.SafeNativeMethods.InvalidateRect(new HandleRef((object) this.window, this.Handle), ref rect, (this.controlStyle & ControlStyles.Opaque) != ControlStyles.Opaque);
        }
        this.NotifyInvalidate(rc);
      }
    }

    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public object Invoke(Delegate method)
    {
      return this.Invoke(method, (object[]) null);
    }

    public object Invoke(Delegate method, params object[] args)
    {
      using (new Control.MultithreadSafeCallScope())
        return this.FindMarshalingControl().MarshaledInvoke(this, method, args, true);
    }

    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    protected void InvokePaint(Control c, PaintEventArgs e)
    {
      c.OnPaint(e);
    }

    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    protected void InvokePaintBackground(Control c, PaintEventArgs e)
    {
      c.OnPaintBackground(e);
    }

    public static bool IsKeyLocked(Keys keyVal)
    {
      if (keyVal != Keys.Insert && keyVal != Keys.NumLock && (keyVal != Keys.Capital && keyVal != Keys.Scroll))
        throw new NotSupportedException(System.Windows.Forms.SR.GetString("ControlIsKeyLockedNumCapsScrollLockKeysSupportedOnly"));
      int num = (int) System.Windows.Forms.UnsafeNativeMethods.GetKeyState((int) keyVal);
      if (keyVal == Keys.Insert || keyVal == Keys.Capital)
        return (num & 1) != 0;
      else
        return (num & 32769) != 0;
    }

    [UIPermission(SecurityAction.InheritanceDemand, Window = UIPermissionWindow.AllWindows)]
    protected virtual bool IsInputChar(char charCode)
    {
      return ((int) (long) this.SendMessage(135, 0, 0) & ((int) charCode != 9 ? 132 : 134)) != 0;
    }

    [UIPermission(SecurityAction.InheritanceDemand, Window = UIPermissionWindow.AllWindows)]
    protected virtual bool IsInputKey(Keys keyData)
    {
      if ((keyData & Keys.Alt) == Keys.Alt)
        return false;
      int num = 4;
      switch (keyData & Keys.KeyCode)
      {
        case Keys.Tab:
          num = 6;
          break;
        case Keys.Left:
        case Keys.Up:
        case Keys.Right:
        case Keys.Down:
          num = 5;
          break;
      }
      if (this.IsHandleCreated)
        return ((int) (long) this.SendMessage(135, 0, 0) & num) != 0;
      else
        return false;
    }

    public static bool IsMnemonic(char charCode, string text)
    {
      if ((int) charCode == 38 || text == null)
        return false;
      int index = -1;
      char c1 = char.ToUpper(charCode, CultureInfo.CurrentCulture);
      while (index + 1 < text.Length)
      {
        index = text.IndexOf('&', index + 1) + 1;
        if (index > 0 && index < text.Length)
        {
          char c2 = char.ToUpper(text[index], CultureInfo.CurrentCulture);
          if ((int) c2 == (int) c1 || (int) char.ToLower(c2, CultureInfo.CurrentCulture) == (int) char.ToLower(c1, CultureInfo.CurrentCulture))
            return true;
        }
        else
          break;
      }
      return false;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void NotifyInvalidate(Rectangle invalidatedArea)
    {
      this.OnInvalidated(new InvalidateEventArgs(invalidatedArea));
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected void InvokeOnClick(Control toInvoke, EventArgs e)
    {
      if (toInvoke == null)
        return;
      toInvoke.OnClick(e);
    }

    protected virtual void OnAutoSizeChanged(EventArgs e)
    {
      EventHandler eventHandler = this.Events[Control.EventAutoSizeChanged] as EventHandler;
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnBackColorChanged(EventArgs e)
    {
      if (this.GetAnyDisposingInHierarchy())
        return;
      object @object = this.Properties.GetObject(Control.PropBackBrush);
      if (@object != null)
      {
        if (this.GetState(2097152))
        {
          IntPtr handle = (IntPtr) @object;
          if (handle != IntPtr.Zero)
            System.Windows.Forms.SafeNativeMethods.DeleteObject(new HandleRef((object) this, handle));
        }
        this.Properties.SetObject(Control.PropBackBrush, (object) null);
      }
      this.Invalidate();
      EventHandler eventHandler = this.Events[Control.EventBackColor] as EventHandler;
      if (eventHandler != null)
        eventHandler((object) this, e);
      Control.ControlCollection controlCollection = (Control.ControlCollection) this.Properties.GetObject(Control.PropControlsCollection);
      if (controlCollection == null)
        return;
      for (int index = 0; index < controlCollection.Count; ++index)
        controlCollection[index].OnParentBackColorChanged(e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnBackgroundImageChanged(EventArgs e)
    {
      if (this.GetAnyDisposingInHierarchy())
        return;
      this.Invalidate();
      EventHandler eventHandler = this.Events[Control.EventBackgroundImage] as EventHandler;
      if (eventHandler != null)
        eventHandler((object) this, e);
      Control.ControlCollection controlCollection = (Control.ControlCollection) this.Properties.GetObject(Control.PropControlsCollection);
      if (controlCollection == null)
        return;
      for (int index = 0; index < controlCollection.Count; ++index)
        controlCollection[index].OnParentBackgroundImageChanged(e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnBackgroundImageLayoutChanged(EventArgs e)
    {
      if (this.GetAnyDisposingInHierarchy())
        return;
      this.Invalidate();
      EventHandler eventHandler = this.Events[Control.EventBackgroundImageLayout] as EventHandler;
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnBindingContextChanged(EventArgs e)
    {
      if (this.Properties.GetObject(Control.PropBindings) != null)
        this.UpdateBindings();
      EventHandler eventHandler = this.Events[Control.EventBindingContext] as EventHandler;
      if (eventHandler != null)
        eventHandler((object) this, e);
      Control.ControlCollection controlCollection = (Control.ControlCollection) this.Properties.GetObject(Control.PropControlsCollection);
      if (controlCollection == null)
        return;
      for (int index = 0; index < controlCollection.Count; ++index)
        controlCollection[index].OnParentBindingContextChanged(e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnCausesValidationChanged(EventArgs e)
    {
      EventHandler eventHandler = this.Events[Control.EventCausesValidation] as EventHandler;
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    internal virtual void OnChildLayoutResuming(Control child, bool performLayout)
    {
      if (this.ParentInternal == null)
        return;
      this.ParentInternal.OnChildLayoutResuming(child, performLayout);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnContextMenuChanged(EventArgs e)
    {
      EventHandler eventHandler = this.Events[Control.EventContextMenu] as EventHandler;
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnContextMenuStripChanged(EventArgs e)
    {
      EventHandler eventHandler = this.Events[Control.EventContextMenuStrip] as EventHandler;
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnCursorChanged(EventArgs e)
    {
      EventHandler eventHandler = this.Events[Control.EventCursor] as EventHandler;
      if (eventHandler != null)
        eventHandler((object) this, e);
      Control.ControlCollection controlCollection = (Control.ControlCollection) this.Properties.GetObject(Control.PropControlsCollection);
      if (controlCollection == null)
        return;
      for (int index = 0; index < controlCollection.Count; ++index)
        controlCollection[index].OnParentCursorChanged(e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnDockChanged(EventArgs e)
    {
      EventHandler eventHandler = this.Events[Control.EventDock] as EventHandler;
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnEnabledChanged(EventArgs e)
    {
      if (this.GetAnyDisposingInHierarchy())
        return;
      if (this.IsHandleCreated)
      {
        System.Windows.Forms.SafeNativeMethods.EnableWindow(new HandleRef((object) this, this.Handle), this.Enabled);
        if (this.GetStyle(ControlStyles.UserPaint))
        {
          this.Invalidate();
          this.Update();
        }
      }
      EventHandler eventHandler = this.Events[Control.EventEnabled] as EventHandler;
      if (eventHandler != null)
        eventHandler((object) this, e);
      Control.ControlCollection controlCollection = (Control.ControlCollection) this.Properties.GetObject(Control.PropControlsCollection);
      if (controlCollection == null)
        return;
      for (int index = 0; index < controlCollection.Count; ++index)
        controlCollection[index].OnParentEnabledChanged(e);
    }

    internal virtual void OnFrameWindowActivate(bool fActivate)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnFontChanged(EventArgs e)
    {
      if (this.GetAnyDisposingInHierarchy())
        return;
      this.Invalidate();
      if (this.Properties.ContainsInteger(Control.PropFontHeight))
        this.Properties.SetInteger(Control.PropFontHeight, -1);
      this.DisposeFontHandle();
      if (this.IsHandleCreated && !this.GetStyle(ControlStyles.UserPaint))
        this.SetWindowFont();
      EventHandler eventHandler = this.Events[Control.EventFont] as EventHandler;
      if (eventHandler != null)
        eventHandler((object) this, e);
      Control.ControlCollection controlCollection = (Control.ControlCollection) this.Properties.GetObject(Control.PropControlsCollection);
      using (new LayoutTransaction(this, (IArrangedElement) this, PropertyNames.Font, false))
      {
        if (controlCollection != null)
        {
          for (int index = 0; index < controlCollection.Count; ++index)
            controlCollection[index].OnParentFontChanged(e);
        }
      }
      LayoutTransaction.DoLayout((IArrangedElement) this, (IArrangedElement) this, PropertyNames.Font);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnForeColorChanged(EventArgs e)
    {
      if (this.GetAnyDisposingInHierarchy())
        return;
      this.Invalidate();
      EventHandler eventHandler = this.Events[Control.EventForeColor] as EventHandler;
      if (eventHandler != null)
        eventHandler((object) this, e);
      Control.ControlCollection controlCollection = (Control.ControlCollection) this.Properties.GetObject(Control.PropControlsCollection);
      if (controlCollection == null)
        return;
      for (int index = 0; index < controlCollection.Count; ++index)
        controlCollection[index].OnParentForeColorChanged(e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnRightToLeftChanged(EventArgs e)
    {
      if (this.GetAnyDisposingInHierarchy())
        return;
      this.SetState2(2, true);
      this.RecreateHandle();
      EventHandler eventHandler = this.Events[Control.EventRightToLeft] as EventHandler;
      if (eventHandler != null)
        eventHandler((object) this, e);
      Control.ControlCollection controlCollection = (Control.ControlCollection) this.Properties.GetObject(Control.PropControlsCollection);
      if (controlCollection == null)
        return;
      for (int index = 0; index < controlCollection.Count; ++index)
        controlCollection[index].OnParentRightToLeftChanged(e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnNotifyMessage(Message m)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnParentBackColorChanged(EventArgs e)
    {
      if (!this.Properties.GetColor(Control.PropBackColor).IsEmpty)
        return;
      this.OnBackColorChanged(e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    protected virtual void OnParentBackgroundImageChanged(EventArgs e)
    {
      this.OnBackgroundImageChanged(e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnParentBindingContextChanged(EventArgs e)
    {
      if (this.Properties.GetObject(Control.PropBindingManager) != null)
        return;
      this.OnBindingContextChanged(e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnParentCursorChanged(EventArgs e)
    {
      if (this.Properties.GetObject(Control.PropCursor) != null)
        return;
      this.OnCursorChanged(e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnParentEnabledChanged(EventArgs e)
    {
      if (!this.GetState(4))
        return;
      this.OnEnabledChanged(e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnParentFontChanged(EventArgs e)
    {
      if (this.Properties.GetObject(Control.PropFont) != null)
        return;
      this.OnFontChanged(e);
    }

    internal virtual void OnParentHandleRecreated()
    {
      Control parentInternal = this.ParentInternal;
      if (parentInternal != null && this.IsHandleCreated)
      {
        System.Windows.Forms.UnsafeNativeMethods.SetParent(new HandleRef((object) this, this.Handle), new HandleRef((object) parentInternal, parentInternal.Handle));
        this.UpdateZOrder();
      }
      this.SetState(536870912, false);
      if (this.ReflectParent != this.ParentInternal)
        return;
      this.RecreateHandle();
    }

    internal virtual void OnParentHandleRecreating()
    {
      this.SetState(536870912, true);
      if (!this.IsHandleCreated)
        return;
      Application.ParkHandle(new HandleRef((object) this, this.Handle));
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnParentForeColorChanged(EventArgs e)
    {
      if (!this.Properties.GetColor(Control.PropForeColor).IsEmpty)
        return;
      this.OnForeColorChanged(e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnParentRightToLeftChanged(EventArgs e)
    {
      if (this.Properties.ContainsInteger(Control.PropRightToLeft) && this.Properties.GetInteger(Control.PropRightToLeft) != 2)
        return;
      this.OnRightToLeftChanged(e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnParentVisibleChanged(EventArgs e)
    {
      if (!this.GetState(2))
        return;
      this.OnVisibleChanged(e);
    }

    internal virtual void OnParentBecameInvisible()
    {
      if (!this.GetState(2))
        return;
      Control.ControlCollection controlCollection = (Control.ControlCollection) this.Properties.GetObject(Control.PropControlsCollection);
      if (controlCollection == null)
        return;
      for (int index = 0; index < controlCollection.Count; ++index)
        controlCollection[index].OnParentBecameInvisible();
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnPrint(PaintEventArgs e)
    {
      if (e == null)
        throw new ArgumentNullException("e");
      if (this.GetStyle(ControlStyles.UserPaint))
      {
        this.PaintWithErrorHandling(e, (short) 1);
        e.ResetGraphics();
        this.PaintWithErrorHandling(e, (short) 2);
      }
      else
      {
        Control.PrintPaintEventArgs printPaintEventArgs = e as Control.PrintPaintEventArgs;
        bool flag = false;
        IntPtr num = IntPtr.Zero;
        Message message;
        if (printPaintEventArgs == null)
        {
          IntPtr lparam = (IntPtr) 30;
          num = e.HDC;
          if (num == IntPtr.Zero)
          {
            num = e.Graphics.GetHdc();
            flag = true;
          }
          message = Message.Create(this.Handle, 792, num, lparam);
        }
        else
          message = printPaintEventArgs.Message;
        try
        {
          this.DefWndProc(ref message);
        }
        finally
        {
          if (flag)
            e.Graphics.ReleaseHdcInternal(num);
        }
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnTabIndexChanged(EventArgs e)
    {
      EventHandler eventHandler = this.Events[Control.EventTabIndex] as EventHandler;
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnTabStopChanged(EventArgs e)
    {
      EventHandler eventHandler = this.Events[Control.EventTabStop] as EventHandler;
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnTextChanged(EventArgs e)
    {
      EventHandler eventHandler = this.Events[Control.EventText] as EventHandler;
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnVisibleChanged(EventArgs e)
    {
      bool visible = this.Visible;
      if (visible)
      {
        this.UnhookMouseEvent();
        this.trackMouseEvent = (System.Windows.Forms.NativeMethods.TRACKMOUSEEVENT) null;
      }
      if (this.parent != null && visible && (!this.Created && !this.GetAnyDisposingInHierarchy()))
        this.CreateControl();
      EventHandler eventHandler = this.Events[Control.EventVisible] as EventHandler;
      if (eventHandler != null)
        eventHandler((object) this, e);
      Control.ControlCollection controlCollection = (Control.ControlCollection) this.Properties.GetObject(Control.PropControlsCollection);
      if (controlCollection == null)
        return;
      for (int index = 0; index < controlCollection.Count; ++index)
      {
        Control control = controlCollection[index];
        if (control.Visible)
          control.OnParentVisibleChanged(e);
        if (!visible)
          control.OnParentBecameInvisible();
      }
    }

    internal virtual void OnTopMostActiveXParentChanged(EventArgs e)
    {
      Control.ControlCollection controlCollection = (Control.ControlCollection) this.Properties.GetObject(Control.PropControlsCollection);
      if (controlCollection == null)
        return;
      for (int index = 0; index < controlCollection.Count; ++index)
        controlCollection[index].OnTopMostActiveXParentChanged(e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnParentChanged(EventArgs e)
    {
      EventHandler eventHandler = this.Events[Control.EventParent] as EventHandler;
      if (eventHandler != null)
        eventHandler((object) this, e);
      if (!this.TopMostParent.IsActiveX)
        return;
      this.OnTopMostActiveXParentChanged(EventArgs.Empty);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnClick(EventArgs e)
    {
      EventHandler eventHandler = (EventHandler) this.Events[Control.EventClick];
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnClientSizeChanged(EventArgs e)
    {
      EventHandler eventHandler = this.Events[Control.EventClientSize] as EventHandler;
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnControlAdded(ControlEventArgs e)
    {
      ControlEventHandler controlEventHandler = (ControlEventHandler) this.Events[Control.EventControlAdded];
      if (controlEventHandler == null)
        return;
      controlEventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnControlRemoved(ControlEventArgs e)
    {
      ControlEventHandler controlEventHandler = (ControlEventHandler) this.Events[Control.EventControlRemoved];
      if (controlEventHandler == null)
        return;
      controlEventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnCreateControl()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnHandleCreated(EventArgs e)
    {
      if (this.IsHandleCreated)
      {
        if (!this.GetStyle(ControlStyles.UserPaint))
          this.SetWindowFont();
        this.SetAcceptDrops(this.AllowDrop);
        Region region = (Region) this.Properties.GetObject(Control.PropRegion);
        if (region != null)
        {
          IntPtr num = this.GetHRgn(region);
          try
          {
            if (this.IsActiveX)
              num = this.ActiveXMergeRegion(num);
            if (System.Windows.Forms.UnsafeNativeMethods.SetWindowRgn(new HandleRef((object) this, this.Handle), new HandleRef((object) this, num), System.Windows.Forms.SafeNativeMethods.IsWindowVisible(new HandleRef((object) this, this.Handle))) != 0)
              num = IntPtr.Zero;
          }
          finally
          {
            if (num != IntPtr.Zero)
              System.Windows.Forms.SafeNativeMethods.DeleteObject(new HandleRef((object) null, num));
          }
        }
        Control.ControlAccessibleObject accessibleObject1 = this.Properties.GetObject(Control.PropAccessibility) as Control.ControlAccessibleObject;
        Control.ControlAccessibleObject accessibleObject2 = this.Properties.GetObject(Control.PropNcAccessibility) as Control.ControlAccessibleObject;
        IntPtr handle = this.Handle;
        System.Windows.Forms.IntSecurity.UnmanagedCode.Assert();
        try
        {
          if (accessibleObject1 != null)
            accessibleObject1.Handle = handle;
          if (accessibleObject2 != null)
            accessibleObject2.Handle = handle;
        }
        finally
        {
          CodeAccessPermission.RevertAssert();
        }
        if (this.text != null && this.text.Length != 0)
          System.Windows.Forms.UnsafeNativeMethods.SetWindowText(new HandleRef((object) this, this.Handle), this.text);
        if (!(this is ScrollableControl) && !this.IsMirrored && (this.GetState2(2) && !this.GetState2(1)))
        {
          this.BeginInvoke((Delegate) new EventHandler(this.OnSetScrollPosition));
          this.SetState2(1, true);
          this.SetState2(2, false);
        }
        if (this.GetState2(8))
          this.ListenToUserPreferenceChanged(this.GetTopLevel());
      }
      EventHandler eventHandler = (EventHandler) this.Events[Control.EventHandleCreated];
      if (eventHandler != null)
        eventHandler((object) this, e);
      if (!this.IsHandleCreated || !this.GetState(32768))
        return;
      System.Windows.Forms.UnsafeNativeMethods.PostMessage(new HandleRef((object) this, this.Handle), Control.threadCallbackMessage, IntPtr.Zero, IntPtr.Zero);
      this.SetState(32768, false);
    }

    internal virtual void OnInvokedSetScrollPosition(object sender, EventArgs e)
    {
      if (this is ScrollableControl || this.IsMirrored)
        return;
      System.Windows.Forms.NativeMethods.SCROLLINFO si = new System.Windows.Forms.NativeMethods.SCROLLINFO();
      si.cbSize = Marshal.SizeOf(typeof (System.Windows.Forms.NativeMethods.SCROLLINFO));
      si.fMask = 1;
      if (!System.Windows.Forms.UnsafeNativeMethods.GetScrollInfo(new HandleRef((object) this, this.Handle), 0, si))
        return;
      si.nPos = this.RightToLeft == RightToLeft.Yes ? si.nMax : si.nMin;
      this.SendMessage(276, System.Windows.Forms.NativeMethods.Util.MAKELPARAM(4, si.nPos), 0);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnLocationChanged(EventArgs e)
    {
      this.OnMove(EventArgs.Empty);
      EventHandler eventHandler = this.Events[Control.EventLocation] as EventHandler;
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnHandleDestroyed(EventArgs e)
    {
      EventHandler eventHandler = (EventHandler) this.Events[Control.EventHandleDestroyed];
      if (eventHandler != null)
        eventHandler((object) this, e);
      this.UpdateReflectParent(false);
      if (!this.RecreatingHandle)
      {
        if (this.GetState(2097152))
        {
          object @object = this.Properties.GetObject(Control.PropBackBrush);
          if (@object != null)
          {
            IntPtr handle = (IntPtr) @object;
            if (handle != IntPtr.Zero)
              System.Windows.Forms.SafeNativeMethods.DeleteObject(new HandleRef((object) this, handle));
            this.Properties.SetObject(Control.PropBackBrush, (object) null);
          }
        }
        this.ListenToUserPreferenceChanged(false);
      }
      try
      {
        if (!this.GetAnyDisposingInHierarchy())
        {
          this.text = this.Text;
          if (this.text != null && this.text.Length == 0)
            this.text = (string) null;
        }
        this.SetAcceptDrops(false);
      }
      catch (Exception ex)
      {
        if (!System.Windows.Forms.ClientUtils.IsSecurityOrCriticalException(ex))
          return;
        throw;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnDoubleClick(EventArgs e)
    {
      EventHandler eventHandler = (EventHandler) this.Events[Control.EventDoubleClick];
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnDragEnter(DragEventArgs drgevent)
    {
      DragEventHandler dragEventHandler = (DragEventHandler) this.Events[Control.EventDragEnter];
      if (dragEventHandler == null)
        return;
      dragEventHandler((object) this, drgevent);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnDragOver(DragEventArgs drgevent)
    {
      DragEventHandler dragEventHandler = (DragEventHandler) this.Events[Control.EventDragOver];
      if (dragEventHandler == null)
        return;
      dragEventHandler((object) this, drgevent);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnDragLeave(EventArgs e)
    {
      EventHandler eventHandler = (EventHandler) this.Events[Control.EventDragLeave];
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnDragDrop(DragEventArgs drgevent)
    {
      DragEventHandler dragEventHandler = (DragEventHandler) this.Events[Control.EventDragDrop];
      if (dragEventHandler == null)
        return;
      dragEventHandler((object) this, drgevent);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnGiveFeedback(GiveFeedbackEventArgs gfbevent)
    {
      GiveFeedbackEventHandler feedbackEventHandler = (GiveFeedbackEventHandler) this.Events[Control.EventGiveFeedback];
      if (feedbackEventHandler == null)
        return;
      feedbackEventHandler((object) this, gfbevent);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnEnter(EventArgs e)
    {
      EventHandler eventHandler = (EventHandler) this.Events[Control.EventEnter];
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected void InvokeGotFocus(Control toInvoke, EventArgs e)
    {
      if (toInvoke == null)
        return;
      toInvoke.OnGotFocus(e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnGotFocus(EventArgs e)
    {
      if (this.IsActiveX)
        this.ActiveXOnFocus(true);
      if (this.parent != null)
        this.parent.ChildGotFocus(this);
      EventHandler eventHandler = (EventHandler) this.Events[Control.EventGotFocus];
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnHelpRequested(HelpEventArgs hevent)
    {
      HelpEventHandler helpEventHandler = (HelpEventHandler) this.Events[Control.EventHelpRequested];
      if (helpEventHandler != null)
      {
        helpEventHandler((object) this, hevent);
        hevent.Handled = true;
      }
      if (hevent.Handled || this.ParentInternal == null)
        return;
      this.ParentInternal.OnHelpRequested(hevent);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnInvalidated(InvalidateEventArgs e)
    {
      if (this.IsActiveX)
        this.ActiveXViewChanged();
      Control.ControlCollection controlCollection = (Control.ControlCollection) this.Properties.GetObject(Control.PropControlsCollection);
      if (controlCollection != null)
      {
        for (int index = 0; index < controlCollection.Count; ++index)
          controlCollection[index].OnParentInvalidated(e);
      }
      InvalidateEventHandler invalidateEventHandler = (InvalidateEventHandler) this.Events[Control.EventInvalidated];
      if (invalidateEventHandler == null)
        return;
      invalidateEventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnKeyDown(KeyEventArgs e)
    {
      KeyEventHandler keyEventHandler = (KeyEventHandler) this.Events[Control.EventKeyDown];
      if (keyEventHandler == null)
        return;
      keyEventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnKeyPress(KeyPressEventArgs e)
    {
      KeyPressEventHandler pressEventHandler = (KeyPressEventHandler) this.Events[Control.EventKeyPress];
      if (pressEventHandler == null)
        return;
      pressEventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnKeyUp(KeyEventArgs e)
    {
      KeyEventHandler keyEventHandler = (KeyEventHandler) this.Events[Control.EventKeyUp];
      if (keyEventHandler == null)
        return;
      keyEventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnLayout(LayoutEventArgs levent)
    {
      if (this.IsActiveX)
        this.ActiveXViewChanged();
      LayoutEventHandler layoutEventHandler = (LayoutEventHandler) this.Events[Control.EventLayout];
      if (layoutEventHandler != null)
        layoutEventHandler((object) this, levent);
      if (!this.LayoutEngine.Layout((object) this, levent) || this.ParentInternal == null)
        return;
      this.ParentInternal.SetState(8388608, true);
    }

    internal virtual void OnLayoutResuming(bool performLayout)
    {
      if (this.ParentInternal == null)
        return;
      this.ParentInternal.OnChildLayoutResuming(this, performLayout);
    }

    internal virtual void OnLayoutSuspended()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnLeave(EventArgs e)
    {
      EventHandler eventHandler = (EventHandler) this.Events[Control.EventLeave];
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected void InvokeLostFocus(Control toInvoke, EventArgs e)
    {
      if (toInvoke == null)
        return;
      toInvoke.OnLostFocus(e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnLostFocus(EventArgs e)
    {
      if (this.IsActiveX)
        this.ActiveXOnFocus(false);
      EventHandler eventHandler = (EventHandler) this.Events[Control.EventLostFocus];
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    protected virtual void OnMarginChanged(EventArgs e)
    {
      EventHandler eventHandler = (EventHandler) this.Events[Control.EventMarginChanged];
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnMouseDoubleClick(MouseEventArgs e)
    {
      MouseEventHandler mouseEventHandler = (MouseEventHandler) this.Events[Control.EventMouseDoubleClick];
      if (mouseEventHandler == null)
        return;
      mouseEventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnMouseClick(MouseEventArgs e)
    {
      MouseEventHandler mouseEventHandler = (MouseEventHandler) this.Events[Control.EventMouseClick];
      if (mouseEventHandler == null)
        return;
      mouseEventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnMouseCaptureChanged(EventArgs e)
    {
      EventHandler eventHandler = (EventHandler) this.Events[Control.EventMouseCaptureChanged];
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnMouseDown(MouseEventArgs e)
    {
      MouseEventHandler mouseEventHandler = (MouseEventHandler) this.Events[Control.EventMouseDown];
      if (mouseEventHandler == null)
        return;
      mouseEventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnMouseEnter(EventArgs e)
    {
      EventHandler eventHandler = (EventHandler) this.Events[Control.EventMouseEnter];
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnMouseLeave(EventArgs e)
    {
      EventHandler eventHandler = (EventHandler) this.Events[Control.EventMouseLeave];
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnMouseHover(EventArgs e)
    {
      EventHandler eventHandler = (EventHandler) this.Events[Control.EventMouseHover];
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnMouseMove(MouseEventArgs e)
    {
      MouseEventHandler mouseEventHandler = (MouseEventHandler) this.Events[Control.EventMouseMove];
      if (mouseEventHandler == null)
        return;
      mouseEventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnMouseUp(MouseEventArgs e)
    {
      MouseEventHandler mouseEventHandler = (MouseEventHandler) this.Events[Control.EventMouseUp];
      if (mouseEventHandler == null)
        return;
      mouseEventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnMouseWheel(MouseEventArgs e)
    {
      MouseEventHandler mouseEventHandler = (MouseEventHandler) this.Events[Control.EventMouseWheel];
      if (mouseEventHandler == null)
        return;
      mouseEventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnMove(EventArgs e)
    {
      EventHandler eventHandler = (EventHandler) this.Events[Control.EventMove];
      if (eventHandler != null)
        eventHandler((object) this, e);
      if (!this.RenderTransparent)
        return;
      this.Invalidate();
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnPaint(PaintEventArgs e)
    {
      PaintEventHandler paintEventHandler = (PaintEventHandler) this.Events[Control.EventPaint];
      if (paintEventHandler == null)
        return;
      paintEventHandler((object) this, e);
    }

    protected virtual void OnPaddingChanged(EventArgs e)
    {
      if (this.GetStyle(ControlStyles.ResizeRedraw))
        this.Invalidate();
      EventHandler eventHandler = (EventHandler) this.Events[Control.EventPaddingChanged];
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnPaintBackground(PaintEventArgs pevent)
    {
      System.Windows.Forms.NativeMethods.RECT rect = new System.Windows.Forms.NativeMethods.RECT();
      System.Windows.Forms.UnsafeNativeMethods.GetClientRect(new HandleRef((object) this.window, this.InternalHandle), out rect);
      this.PaintBackground(pevent, new Rectangle(rect.left, rect.top, rect.right, rect.bottom));
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnQueryContinueDrag(QueryContinueDragEventArgs qcdevent)
    {
      QueryContinueDragEventHandler dragEventHandler = (QueryContinueDragEventHandler) this.Events[Control.EventQueryContinueDrag];
      if (dragEventHandler == null)
        return;
      dragEventHandler((object) this, qcdevent);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnRegionChanged(EventArgs e)
    {
      EventHandler eventHandler = this.Events[Control.EventRegionChanged] as EventHandler;
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnResize(EventArgs e)
    {
      if ((this.controlStyle & ControlStyles.ResizeRedraw) == ControlStyles.ResizeRedraw || this.GetState(4194304))
        this.Invalidate();
      LayoutTransaction.DoLayout((IArrangedElement) this, (IArrangedElement) this, PropertyNames.Bounds);
      EventHandler eventHandler = (EventHandler) this.Events[Control.EventResize];
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    protected virtual void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
    {
      PreviewKeyDownEventHandler downEventHandler = (PreviewKeyDownEventHandler) this.Events[Control.EventPreviewKeyDown];
      if (downEventHandler == null)
        return;
      downEventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnSizeChanged(EventArgs e)
    {
      this.OnResize(EventArgs.Empty);
      EventHandler eventHandler = this.Events[Control.EventSize] as EventHandler;
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnChangeUICues(UICuesEventArgs e)
    {
      UICuesEventHandler cuesEventHandler = (UICuesEventHandler) this.Events[Control.EventChangeUICues];
      if (cuesEventHandler == null)
        return;
      cuesEventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnStyleChanged(EventArgs e)
    {
      EventHandler eventHandler = (EventHandler) this.Events[Control.EventStyleChanged];
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnSystemColorsChanged(EventArgs e)
    {
      Control.ControlCollection controlCollection = (Control.ControlCollection) this.Properties.GetObject(Control.PropControlsCollection);
      if (controlCollection != null)
      {
        for (int index = 0; index < controlCollection.Count; ++index)
          controlCollection[index].OnSystemColorsChanged(EventArgs.Empty);
      }
      this.Invalidate();
      EventHandler eventHandler = (EventHandler) this.Events[Control.EventSystemColorsChanged];
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnValidating(CancelEventArgs e)
    {
      CancelEventHandler cancelEventHandler = (CancelEventHandler) this.Events[Control.EventValidating];
      if (cancelEventHandler == null)
        return;
      cancelEventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void OnValidated(EventArgs e)
    {
      EventHandler eventHandler = (EventHandler) this.Events[Control.EventValidated];
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public void PerformLayout()
    {
      if (this.cachedLayoutEventArgs != null)
      {
        this.PerformLayout(this.cachedLayoutEventArgs);
        this.cachedLayoutEventArgs = (LayoutEventArgs) null;
        this.SetState2(64, false);
      }
      else
        this.PerformLayout((Control) null, (string) null);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public void PerformLayout(Control affectedControl, string affectedProperty)
    {
      this.PerformLayout(new LayoutEventArgs(affectedControl, affectedProperty));
    }

    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public Point PointToClient(Point p)
    {
      return this.PointToClientInternal(p);
    }

    internal Point PointToClientInternal(Point p)
    {
      System.Windows.Forms.NativeMethods.POINT pt = new System.Windows.Forms.NativeMethods.POINT(p.X, p.Y);
      System.Windows.Forms.UnsafeNativeMethods.MapWindowPoints(System.Windows.Forms.NativeMethods.NullHandleRef, new HandleRef((object) this, this.Handle), pt, 1);
      return new Point(pt.x, pt.y);
    }

    public Point PointToScreen(Point p)
    {
      System.Windows.Forms.NativeMethods.POINT pt = new System.Windows.Forms.NativeMethods.POINT(p.X, p.Y);
      System.Windows.Forms.UnsafeNativeMethods.MapWindowPoints(new HandleRef((object) this, this.Handle), System.Windows.Forms.NativeMethods.NullHandleRef, pt, 1);
      return new Point(pt.x, pt.y);
    }

    [SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    public virtual bool PreProcessMessage(ref Message msg)
    {
      bool flag;
      if (msg.Msg == 256 || msg.Msg == 260)
      {
        if (!this.GetState2(512))
          this.ProcessUICues(ref msg);
        Keys keyData = (Keys) (long) msg.WParam | Control.ModifierKeys;
        if (this.ProcessCmdKey(ref msg, keyData))
          flag = true;
        else if (this.IsInputKey(keyData))
        {
          this.SetState2(128, true);
          flag = false;
        }
        else
        {
          System.Windows.Forms.IntSecurity.ModifyFocus.Assert();
          try
          {
            flag = this.ProcessDialogKey(keyData);
          }
          finally
          {
            CodeAccessPermission.RevertAssert();
          }
        }
      }
      else if (msg.Msg == 258 || msg.Msg == 262)
      {
        if (msg.Msg == 258 && this.IsInputChar((char) (int) msg.WParam))
        {
          this.SetState2(256, true);
          flag = false;
        }
        else
          flag = this.ProcessDialogChar((char) (int) msg.WParam);
      }
      else
        flag = false;
      return flag;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    public PreProcessControlState PreProcessControlMessage(ref Message msg)
    {
      return Control.PreProcessControlMessageInternal((Control) null, ref msg);
    }

    internal static PreProcessControlState PreProcessControlMessageInternal(Control target, ref Message msg)
    {
      if (target == null)
        target = Control.FromChildHandleInternal(msg.HWnd);
      if (target == null)
        return PreProcessControlState.MessageNotNeeded;
      target.SetState2(128, false);
      target.SetState2(256, false);
      target.SetState2(512, true);
      try
      {
        Keys keyData = (Keys) (long) msg.WParam | Control.ModifierKeys;
        if (msg.Msg == 256 || msg.Msg == 260)
        {
          target.ProcessUICues(ref msg);
          PreviewKeyDownEventArgs e = new PreviewKeyDownEventArgs(keyData);
          target.OnPreviewKeyDown(e);
          if (e.IsInputKey)
            return PreProcessControlState.MessageNeeded;
        }
        PreProcessControlState processControlState = PreProcessControlState.MessageNotNeeded;
        if (!target.PreProcessMessage(ref msg))
        {
          if (msg.Msg == 256 || msg.Msg == 260)
          {
            if (target.GetState2(128) || target.IsInputKey(keyData))
              processControlState = PreProcessControlState.MessageNeeded;
          }
          else if ((msg.Msg == 258 || msg.Msg == 262) && (target.GetState2(256) || target.IsInputChar((char) (int) msg.WParam)))
            processControlState = PreProcessControlState.MessageNeeded;
        }
        else
          processControlState = PreProcessControlState.MessageProcessed;
        return processControlState;
      }
      finally
      {
        target.SetState2(512, false);
      }
    }

    [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    [SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    protected virtual bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
      ContextMenu contextMenu = (ContextMenu) this.Properties.GetObject(Control.PropContextMenu);
      if (contextMenu != null && contextMenu.ProcessCmdKey(ref msg, keyData, this))
        return true;
      if (this.parent != null)
        return this.parent.ProcessCmdKey(ref msg, keyData);
      else
        return false;
    }

    internal virtual void PrintToMetaFileRecursive(HandleRef hDC, IntPtr lParam, Rectangle bounds)
    {
      using (new WindowsFormsUtils.DCMapping(hDC, bounds))
      {
        this.PrintToMetaFile_SendPrintMessage(hDC, (IntPtr) ((long) lParam & -5L));
        System.Windows.Forms.NativeMethods.RECT rect = new System.Windows.Forms.NativeMethods.RECT();
        System.Windows.Forms.UnsafeNativeMethods.GetWindowRect(new HandleRef((object) null, this.Handle), out rect);
        Point location = this.PointToScreen(Point.Empty);
        location = new Point(location.X - rect.left, location.Y - rect.top);
        Rectangle bounds1 = new Rectangle(location, this.ClientSize);
        using (new WindowsFormsUtils.DCMapping(hDC, bounds1))
        {
          this.PrintToMetaFile_SendPrintMessage(hDC, (IntPtr) ((long) lParam & -3L));
          for (int index = this.Controls.Count - 1; index >= 0; --index)
          {
            Control control = this.Controls[index];
            if (control.Visible)
              control.PrintToMetaFileRecursive(hDC, lParam, control.Bounds);
          }
        }
      }
    }

    [UIPermission(SecurityAction.LinkDemand, Window = UIPermissionWindow.AllWindows)]
    [UIPermission(SecurityAction.InheritanceDemand, Window = UIPermissionWindow.AllWindows)]
    protected virtual bool ProcessDialogChar(char charCode)
    {
      if (this.parent != null)
        return this.parent.ProcessDialogChar(charCode);
      else
        return false;
    }

    [UIPermission(SecurityAction.InheritanceDemand, Window = UIPermissionWindow.AllWindows)]
    [UIPermission(SecurityAction.LinkDemand, Window = UIPermissionWindow.AllWindows)]
    protected virtual bool ProcessDialogKey(Keys keyData)
    {
      if (this.parent != null)
        return this.parent.ProcessDialogKey(keyData);
      else
        return false;
    }

    [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    [SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    protected virtual bool ProcessKeyEventArgs(ref Message m)
    {
      KeyEventArgs e1 = (KeyEventArgs) null;
      KeyPressEventArgs e2 = (KeyPressEventArgs) null;
      IntPtr num1 = IntPtr.Zero;
      if (m.Msg == 258 || m.Msg == 262)
      {
        int imeWmCharsToIgnore = this.ImeWmCharsToIgnore;
        if (imeWmCharsToIgnore > 0)
        {
          this.ImeWmCharsToIgnore = imeWmCharsToIgnore - 1;
          return false;
        }
        else
        {
          e2 = new KeyPressEventArgs((char) (long) m.WParam);
          this.OnKeyPress(e2);
          num1 = (IntPtr) ((int) e2.KeyChar);
        }
      }
      else if (m.Msg == 646)
      {
        int imeWmCharsToIgnore = this.ImeWmCharsToIgnore;
        if (Marshal.SystemDefaultCharSize == 1)
        {
          char keyChar = char.MinValue;
          byte[] lpMultiByteStr = new byte[2]
          {
            (byte) ((uint) (int) (long) m.WParam >> 8),
            (byte) (long) m.WParam
          };
          char[] lpWideCharStr1 = new char[1];
          int length = System.Windows.Forms.UnsafeNativeMethods.MultiByteToWideChar(0, 1, lpMultiByteStr, lpMultiByteStr.Length, lpWideCharStr1, 0);
          if (length <= 0)
            throw new Win32Exception();
          char[] lpWideCharStr2 = new char[length];
          System.Windows.Forms.UnsafeNativeMethods.MultiByteToWideChar(0, 1, lpMultiByteStr, lpMultiByteStr.Length, lpWideCharStr2, lpWideCharStr2.Length);
          if ((int) lpWideCharStr2[0] != 0)
          {
            keyChar = lpWideCharStr2[0];
            imeWmCharsToIgnore += 2;
          }
          else if ((int) lpWideCharStr2[0] == 0 && lpWideCharStr2.Length >= 2)
          {
            keyChar = lpWideCharStr2[1];
            ++imeWmCharsToIgnore;
          }
          this.ImeWmCharsToIgnore = imeWmCharsToIgnore;
          e2 = new KeyPressEventArgs(keyChar);
        }
        else
        {
          this.ImeWmCharsToIgnore = imeWmCharsToIgnore + (3 - Marshal.SystemDefaultCharSize);
          e2 = new KeyPressEventArgs((char) (long) m.WParam);
        }
        char keyChar1 = e2.KeyChar;
        this.OnKeyPress(e2);
        if ((int) e2.KeyChar == (int) keyChar1)
          num1 = m.WParam;
        else if (Marshal.SystemDefaultCharSize == 1)
        {
          string wideStr = new string(new char[1]
          {
            e2.KeyChar
          });
          int length = System.Windows.Forms.UnsafeNativeMethods.WideCharToMultiByte(0, 0, wideStr, wideStr.Length, (byte[]) null, 0, IntPtr.Zero, IntPtr.Zero);
          if (length >= 2)
          {
            byte[] pOutBytes = new byte[length];
            System.Windows.Forms.UnsafeNativeMethods.WideCharToMultiByte(0, 0, wideStr, wideStr.Length, pOutBytes, pOutBytes.Length, IntPtr.Zero, IntPtr.Zero);
            int num2 = Marshal.SizeOf(typeof (IntPtr));
            if (length > num2)
              length = num2;
            long num3 = 0L;
            for (int index = 0; index < length; ++index)
              num3 = num3 << 8 | (long) pOutBytes[index];
            num1 = (IntPtr) num3;
          }
          else if (length == 1)
          {
            byte[] pOutBytes = new byte[length];
            System.Windows.Forms.UnsafeNativeMethods.WideCharToMultiByte(0, 0, wideStr, wideStr.Length, pOutBytes, pOutBytes.Length, IntPtr.Zero, IntPtr.Zero);
            num1 = (IntPtr) ((int) pOutBytes[0]);
          }
          else
            num1 = m.WParam;
        }
        else
          num1 = (IntPtr) ((int) e2.KeyChar);
      }
      else
      {
        e1 = new KeyEventArgs((Keys) (long) m.WParam | Control.ModifierKeys);
        if (m.Msg == 256 || m.Msg == 260)
          this.OnKeyDown(e1);
        else
          this.OnKeyUp(e1);
      }
      if (e2 != null)
      {
        m.WParam = num1;
        return e2.Handled;
      }
      else
      {
        if (e1.SuppressKeyPress)
        {
          this.RemovePendingMessages(258, 258);
          this.RemovePendingMessages(262, 262);
          this.RemovePendingMessages(646, 646);
        }
        return e1.Handled;
      }
    }

    [SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    protected internal virtual bool ProcessKeyMessage(ref Message m)
    {
      if (this.parent != null && this.parent.ProcessKeyPreview(ref m))
        return true;
      else
        return this.ProcessKeyEventArgs(ref m);
    }

    [SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    protected virtual bool ProcessKeyPreview(ref Message m)
    {
      if (this.parent != null)
        return this.parent.ProcessKeyPreview(ref m);
      else
        return false;
    }

    [UIPermission(SecurityAction.InheritanceDemand, Window = UIPermissionWindow.AllWindows)]
    [UIPermission(SecurityAction.LinkDemand, Window = UIPermissionWindow.AllWindows)]
    protected internal virtual bool ProcessMnemonic(char charCode)
    {
      return false;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected void RaiseDragEvent(object key, DragEventArgs e)
    {
      DragEventHandler dragEventHandler = (DragEventHandler) this.Events[key];
      if (dragEventHandler == null)
        return;
      dragEventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected void RaisePaintEvent(object key, PaintEventArgs e)
    {
      PaintEventHandler paintEventHandler = (PaintEventHandler) this.Events[Control.EventPaint];
      if (paintEventHandler == null)
        return;
      paintEventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual void ResetBackColor()
    {
      this.BackColor = System.Drawing.Color.Empty;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public virtual void ResetCursor()
    {
      this.Cursor = (Cursor) null;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public virtual void ResetFont()
    {
      this.Font = (Font) null;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual void ResetForeColor()
    {
      this.ForeColor = System.Drawing.Color.Empty;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public virtual void ResetRightToLeft()
    {
      this.RightToLeft = RightToLeft.Inherit;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    protected void RecreateHandle()
    {
      this.RecreateHandleCore();
    }

    internal virtual void RecreateHandleCore()
    {
      lock (this)
      {
        if (!this.IsHandleCreated)
          return;
        bool local_0 = this.ContainsFocus;
        bool local_1 = (this.state & 1) != 0;
        if (this.GetState(16384))
        {
          this.SetState(8192, true);
          this.UnhookMouseEvent();
        }
        HandleRef local_2 = new HandleRef((object) this, System.Windows.Forms.UnsafeNativeMethods.GetParent(new HandleRef((object) this, this.Handle)));
        try
        {
          Control[] local_3 = (Control[]) null;
          this.state |= 16;
          try
          {
            Control.ControlCollection local_4 = (Control.ControlCollection) this.Properties.GetObject(Control.PropControlsCollection);
            if (local_4 != null && local_4.Count > 0)
            {
              local_3 = new Control[local_4.Count];
              for (int local_5 = 0; local_5 < local_4.Count; ++local_5)
              {
                Control local_6 = local_4[local_5];
                if (local_6 != null && local_6.IsHandleCreated)
                {
                  local_6.OnParentHandleRecreating();
                  local_3[local_5] = local_6;
                }
                else
                  local_3[local_5] = (Control) null;
              }
            }
            this.DestroyHandle();
            this.CreateHandle();
          }
          finally
          {
            this.state &= -17;
            if (local_3 != null)
            {
              for (int local_7 = 0; local_7 < local_3.Length; ++local_7)
              {
                Control local_8 = local_3[local_7];
                if (local_8 != null && local_8.IsHandleCreated)
                  local_8.OnParentHandleRecreated();
              }
            }
          }
          if (local_1)
            this.CreateControl();
        }
        finally
        {
          if (local_2.Handle != IntPtr.Zero && (Control.FromHandleInternal(local_2.Handle) == null || this.parent == null) && System.Windows.Forms.UnsafeNativeMethods.IsWindow(local_2))
            System.Windows.Forms.UnsafeNativeMethods.SetParent(new HandleRef((object) this, this.Handle), local_2);
        }
        if (!local_0)
          return;
        this.FocusInternal();
      }
    }

    public Rectangle RectangleToClient(Rectangle r)
    {
      System.Windows.Forms.NativeMethods.RECT rect = System.Windows.Forms.NativeMethods.RECT.FromXYWH(r.X, r.Y, r.Width, r.Height);
      System.Windows.Forms.UnsafeNativeMethods.MapWindowPoints(System.Windows.Forms.NativeMethods.NullHandleRef, new HandleRef((object) this, this.Handle), out rect, 2);
      return Rectangle.FromLTRB(rect.left, rect.top, rect.right, rect.bottom);
    }

    public Rectangle RectangleToScreen(Rectangle r)
    {
      System.Windows.Forms.NativeMethods.RECT rect = System.Windows.Forms.NativeMethods.RECT.FromXYWH(r.X, r.Y, r.Width, r.Height);
      System.Windows.Forms.UnsafeNativeMethods.MapWindowPoints(new HandleRef((object) this, this.Handle), System.Windows.Forms.NativeMethods.NullHandleRef, out rect, 2);
      return Rectangle.FromLTRB(rect.left, rect.top, rect.right, rect.bottom);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected static bool ReflectMessage(IntPtr hWnd, ref Message m)
    {
      System.Windows.Forms.IntSecurity.SendMessages.Demand();
      return Control.ReflectMessageInternal(hWnd, ref m);
    }

    public virtual void Refresh()
    {
      this.Invalidate(true);
      this.Update();
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected void ResetMouseEventArgs()
    {
      if (!this.GetState(16384))
        return;
      this.UnhookMouseEvent();
      this.HookMouseEvent();
    }

    public virtual void ResetText()
    {
      this.Text = string.Empty;
    }

    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public void ResumeLayout()
    {
      this.ResumeLayout(true);
    }

    public void ResumeLayout(bool performLayout)
    {
      bool flag = false;
      if ((int) this.layoutSuspendCount > 0)
      {
        if ((int) this.layoutSuspendCount == 1)
        {
          ++this.layoutSuspendCount;
          try
          {
            this.OnLayoutResuming(performLayout);
          }
          finally
          {
            --this.layoutSuspendCount;
          }
        }
        --this.layoutSuspendCount;
        if ((int) this.layoutSuspendCount == 0 && this.GetState(512) && performLayout)
        {
          this.PerformLayout();
          flag = true;
        }
      }
      if (!flag)
        this.SetState2(64, true);
      if (performLayout)
        return;
      CommonProperties.xClearPreferredSizeCache((IArrangedElement) this);
      Control.ControlCollection controlCollection = (Control.ControlCollection) this.Properties.GetObject(Control.PropControlsCollection);
      if (controlCollection == null)
        return;
      for (int index = 0; index < controlCollection.Count; ++index)
      {
        this.LayoutEngine.InitLayout((object) controlCollection[index], BoundsSpecified.All);
        CommonProperties.xClearPreferredSizeCache((IArrangedElement) controlCollection[index]);
      }
    }

    [Obsolete("This method has been deprecated. Use the Scale(SizeF ratio) method instead. http://go.microsoft.com/fwlink/?linkid=14202")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public void Scale(float ratio)
    {
      this.ScaleCore(ratio, ratio);
    }

    [Obsolete("This method has been deprecated. Use the Scale(SizeF ratio) method instead. http://go.microsoft.com/fwlink/?linkid=14202")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public void Scale(float dx, float dy)
    {
      this.SuspendLayout();
      try
      {
        this.ScaleCore(dx, dy);
      }
      finally
      {
        this.ResumeLayout();
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public void Scale(SizeF factor)
    {
      using (new LayoutTransaction(this, (IArrangedElement) this, PropertyNames.Bounds, false))
      {
        this.ScaleControl(factor, factor, this);
        if (this.ScaleChildren)
        {
          Control.ControlCollection controlCollection = (Control.ControlCollection) this.Properties.GetObject(Control.PropControlsCollection);
          if (controlCollection != null)
          {
            for (int index = 0; index < controlCollection.Count; ++index)
              controlCollection[index].Scale(factor);
          }
        }
      }
      LayoutTransaction.DoLayout((IArrangedElement) this, (IArrangedElement) this, PropertyNames.Bounds);
    }

    internal virtual void Scale(SizeF includedFactor, SizeF excludedFactor, Control requestingControl)
    {
      using (new LayoutTransaction(this, (IArrangedElement) this, PropertyNames.Bounds, false))
      {
        this.ScaleControl(includedFactor, excludedFactor, requestingControl);
        this.ScaleChildControls(includedFactor, excludedFactor, requestingControl);
      }
      LayoutTransaction.DoLayout((IArrangedElement) this, (IArrangedElement) this, PropertyNames.Bounds);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void ScaleControl(SizeF factor, BoundsSpecified specified)
    {
      CreateParams createParams = this.CreateParams;
      System.Windows.Forms.NativeMethods.RECT lpRect = new System.Windows.Forms.NativeMethods.RECT(0, 0, 0, 0);
      System.Windows.Forms.SafeNativeMethods.AdjustWindowRectEx(ref lpRect, createParams.Style, this.HasMenu, createParams.ExStyle);
      Size b1 = this.MinimumSize;
      Size size1 = this.MaximumSize;
      this.MinimumSize = Size.Empty;
      this.MaximumSize = Size.Empty;
      Rectangle scaledBounds = this.GetScaledBounds(this.Bounds, factor, specified);
      float width = factor.Width;
      float height = factor.Height;
      Padding padding = this.Padding;
      Padding margin = this.Margin;
      if ((double) width == 1.0)
        specified &= ~(BoundsSpecified.X | BoundsSpecified.Width);
      if ((double) height == 1.0)
        specified &= ~(BoundsSpecified.Y | BoundsSpecified.Height);
      if ((double) width != 1.0)
      {
        padding.Left = (int) Math.Round((double) padding.Left * (double) width);
        padding.Right = (int) Math.Round((double) padding.Right * (double) width);
        margin.Left = (int) Math.Round((double) margin.Left * (double) width);
        margin.Right = (int) Math.Round((double) margin.Right * (double) width);
      }
      if ((double) height != 1.0)
      {
        padding.Top = (int) Math.Round((double) padding.Top * (double) height);
        padding.Bottom = (int) Math.Round((double) padding.Bottom * (double) height);
        margin.Top = (int) Math.Round((double) margin.Top * (double) height);
        margin.Bottom = (int) Math.Round((double) margin.Bottom * (double) height);
      }
      this.Padding = padding;
      this.Margin = margin;
      Size size2 = lpRect.Size;
      if (!b1.IsEmpty)
      {
        b1 -= size2;
        b1 = this.ScaleSize(LayoutUtils.UnionSizes(Size.Empty, b1), factor.Width, factor.Height) + size2;
      }
      if (!size1.IsEmpty)
      {
        Size b2 = size1 - size2;
        size1 = this.ScaleSize(LayoutUtils.UnionSizes(Size.Empty, b2), factor.Width, factor.Height) + size2;
      }
      Size b3 = LayoutUtils.ConvertZeroToUnbounded(size1);
      Size size3 = LayoutUtils.UnionSizes(LayoutUtils.IntersectSizes(scaledBounds.Size, b3), b1);
      this.SetBoundsCore(scaledBounds.X, scaledBounds.Y, size3.Width, size3.Height, BoundsSpecified.All);
      this.MaximumSize = size1;
      this.MinimumSize = b1;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    protected virtual void ScaleCore(float dx, float dy)
    {
      this.SuspendLayout();
      try
      {
        int x = (int) Math.Round((double) this.x * (double) dx);
        int y = (int) Math.Round((double) this.y * (double) dy);
        int width = this.width;
        if ((this.controlStyle & ControlStyles.FixedWidth) != ControlStyles.FixedWidth)
          width = (int) Math.Round((double) (this.x + this.width) * (double) dx) - x;
        int height = this.height;
        if ((this.controlStyle & ControlStyles.FixedHeight) != ControlStyles.FixedHeight)
          height = (int) Math.Round((double) (this.y + this.height) * (double) dy) - y;
        this.SetBounds(x, y, width, height, BoundsSpecified.All);
        Control.ControlCollection controlCollection = (Control.ControlCollection) this.Properties.GetObject(Control.PropControlsCollection);
        if (controlCollection == null)
          return;
        for (int index = 0; index < controlCollection.Count; ++index)
          controlCollection[index].Scale(dx, dy);
      }
      finally
      {
        this.ResumeLayout();
      }
    }

    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public void Select()
    {
      this.Select(false, false);
    }

    protected virtual void Select(bool directed, bool forward)
    {
      IContainerControl containerControlInternal = this.GetContainerControlInternal();
      if (containerControlInternal == null)
        return;
      containerControlInternal.ActiveControl = this;
    }

    public bool SelectNextControl(Control ctl, bool forward, bool tabStopOnly, bool nested, bool wrap)
    {
      if (!this.Contains(ctl) || !nested && ctl.parent != this)
        ctl = (Control) null;
      bool flag = false;
      Control control = ctl;
      do
      {
        ctl = this.GetNextControl(ctl, forward);
        if (ctl == null)
        {
          if (wrap && !flag)
            flag = true;
          else
            break;
        }
        else if (ctl.CanSelect && (!tabStopOnly || ctl.TabStop) && (nested || ctl.parent == this))
        {
          ctl.Select(true, forward);
          return true;
        }
      }
      while (ctl != control);
      return false;
    }

    public void SendToBack()
    {
      if (this.parent != null)
      {
        this.parent.Controls.SetChildIndex(this, -1);
      }
      else
      {
        if (!this.IsHandleCreated || !this.GetTopLevel())
          return;
        System.Windows.Forms.SafeNativeMethods.SetWindowPos(new HandleRef((object) this.window, this.Handle), System.Windows.Forms.NativeMethods.HWND_BOTTOM, 0, 0, 0, 0, 3);
      }
    }

    public void SetBounds(int x, int y, int width, int height)
    {
      if (this.x != x || this.y != y || (this.width != width || this.height != height))
      {
        this.SetBoundsCore(x, y, width, height, BoundsSpecified.All);
        LayoutTransaction.DoLayout((IArrangedElement) this.ParentInternal, (IArrangedElement) this, PropertyNames.Bounds);
      }
      else
        this.InitScaling(BoundsSpecified.All);
    }

    public void SetBounds(int x, int y, int width, int height, BoundsSpecified specified)
    {
      if ((specified & BoundsSpecified.X) == BoundsSpecified.None)
        x = this.x;
      if ((specified & BoundsSpecified.Y) == BoundsSpecified.None)
        y = this.y;
      if ((specified & BoundsSpecified.Width) == BoundsSpecified.None)
        width = this.width;
      if ((specified & BoundsSpecified.Height) == BoundsSpecified.None)
        height = this.height;
      if (this.x != x || this.y != y || (this.width != width || this.height != height))
      {
        this.SetBoundsCore(x, y, width, height, specified);
        LayoutTransaction.DoLayout((IArrangedElement) this.ParentInternal, (IArrangedElement) this, PropertyNames.Bounds);
      }
      else
        this.InitScaling(specified);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
    {
      if (this.ParentInternal != null)
        this.ParentInternal.SuspendLayout();
      try
      {
        if (this.x == x && this.y == y && (this.width == width && this.height == height))
          return;
        CommonProperties.UpdateSpecifiedBounds((IArrangedElement) this, x, y, width, height, specified);
        Rectangle rectangle = this.ApplyBoundsConstraints(x, y, width, height);
        width = rectangle.Width;
        height = rectangle.Height;
        x = rectangle.X;
        y = rectangle.Y;
        if (!this.IsHandleCreated)
        {
          this.UpdateBounds(x, y, width, height);
        }
        else
        {
          if (this.GetState(65536))
            return;
          int flags = 20;
          if (this.x == x && this.y == y)
            flags |= 2;
          if (this.width == width && this.height == height)
            flags |= 1;
          this.OnBoundsUpdate(x, y, width, height);
          System.Windows.Forms.SafeNativeMethods.SetWindowPos(new HandleRef((object) this.window, this.Handle), System.Windows.Forms.NativeMethods.NullHandleRef, x, y, width, height, flags);
        }
      }
      finally
      {
        this.InitScaling(specified);
        if (this.ParentInternal != null)
        {
          CommonProperties.xClearPreferredSizeCache((IArrangedElement) this.ParentInternal);
          this.ParentInternal.LayoutEngine.InitLayout((object) this, specified);
          this.ParentInternal.ResumeLayout(true);
        }
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual void SetClientSizeCore(int x, int y)
    {
      this.Size = this.SizeFromClientSize(x, y);
      this.clientWidth = x;
      this.clientHeight = y;
      this.OnClientSizeChanged(EventArgs.Empty);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected virtual Size SizeFromClientSize(Size clientSize)
    {
      return this.SizeFromClientSize(clientSize.Width, clientSize.Height);
    }

    internal void SetState(int flag, bool value)
    {
      this.state = value ? this.state | flag : this.state & ~flag;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected void SetStyle(ControlStyles flag, bool value)
    {
      if ((flag & ControlStyles.EnableNotifyMessage) != (ControlStyles) 0 && value)
        System.Windows.Forms.IntSecurity.UnmanagedCode.Demand();
      this.controlStyle = value ? this.controlStyle | flag : this.controlStyle & ~flag;
    }

    protected void SetTopLevel(bool value)
    {
      if (value && this.IsActiveX)
        throw new InvalidOperationException(System.Windows.Forms.SR.GetString("TopLevelNotAllowedIfActiveX"));
      if (value)
      {
        if (this is Form)
          System.Windows.Forms.IntSecurity.TopLevelWindow.Demand();
        else
          System.Windows.Forms.IntSecurity.UnrestrictedWindows.Demand();
      }
      this.SetTopLevelInternal(value);
    }

    protected virtual void SetVisibleCore(bool value)
    {
      try
      {
        System.Internal.HandleCollector.SuspendCollect();
        if (this.GetVisibleCore() != value)
        {
          if (!value)
            this.SelectNextIfFocused();
          bool flag = false;
          if (this.GetTopLevel())
          {
            if (this.IsHandleCreated || value)
              System.Windows.Forms.SafeNativeMethods.ShowWindow(new HandleRef((object) this, this.Handle), value ? this.ShowParams : 0);
          }
          else if (this.IsHandleCreated || value && this.parent != null && this.parent.Created)
          {
            this.SetState(2, value);
            flag = true;
            try
            {
              if (value)
                this.CreateControl();
              System.Windows.Forms.SafeNativeMethods.SetWindowPos(new HandleRef((object) this.window, this.Handle), System.Windows.Forms.NativeMethods.NullHandleRef, 0, 0, 0, 0, 23 | (value ? 64 : 128));
            }
            catch
            {
              this.SetState(2, !value);
              throw;
            }
          }
          if (this.GetVisibleCore() != value)
          {
            this.SetState(2, value);
            flag = true;
          }
          if (flag)
          {
            using (new LayoutTransaction(this.parent, (IArrangedElement) this, PropertyNames.Visible))
              this.OnVisibleChanged(EventArgs.Empty);
          }
          this.UpdateRoot();
        }
        else
        {
          if (!this.GetState(2) && !value && (this.IsHandleCreated && !System.Windows.Forms.SafeNativeMethods.IsWindowVisible(new HandleRef((object) this, this.Handle))))
            return;
          this.SetState(2, value);
          if (!this.IsHandleCreated)
            return;
          System.Windows.Forms.SafeNativeMethods.SetWindowPos(new HandleRef((object) this.window, this.Handle), System.Windows.Forms.NativeMethods.NullHandleRef, 0, 0, 0, 0, 23 | (value ? 64 : 128));
        }
      }
      finally
      {
        System.Internal.HandleCollector.ResumeCollect();
      }
    }

    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    internal virtual bool ShouldPerformContainerValidation()
    {
      return this.GetStyle(ControlStyles.ContainerControl);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal virtual bool ShouldSerializeBackColor()
    {
      return !this.Properties.GetColor(Control.PropBackColor).IsEmpty;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal virtual bool ShouldSerializeCursor()
    {
      bool found;
      object @object = this.Properties.GetObject(Control.PropCursor, out found);
      if (found)
        return @object != null;
      else
        return false;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal virtual bool ShouldSerializeForeColor()
    {
      return !this.Properties.GetColor(Control.PropForeColor).IsEmpty;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal virtual bool ShouldSerializeFont()
    {
      bool found;
      object @object = this.Properties.GetObject(Control.PropFont, out found);
      if (found)
        return @object != null;
      else
        return false;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal virtual bool ShouldSerializeRightToLeft()
    {
      bool found;
      int integer = this.Properties.GetInteger(Control.PropRightToLeft, out found);
      if (found)
        return integer != 2;
      else
        return false;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    protected HorizontalAlignment RtlTranslateAlignment(HorizontalAlignment align)
    {
      return this.RtlTranslateHorizontal(align);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    protected LeftRightAlignment RtlTranslateAlignment(LeftRightAlignment align)
    {
      return this.RtlTranslateLeftRight(align);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    protected ContentAlignment RtlTranslateAlignment(ContentAlignment align)
    {
      return this.RtlTranslateContent(align);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected HorizontalAlignment RtlTranslateHorizontal(HorizontalAlignment align)
    {
      if (RightToLeft.Yes == this.RightToLeft)
      {
        if (align == HorizontalAlignment.Left)
          return HorizontalAlignment.Right;
        if (HorizontalAlignment.Right == align)
          return HorizontalAlignment.Left;
      }
      return align;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected LeftRightAlignment RtlTranslateLeftRight(LeftRightAlignment align)
    {
      if (RightToLeft.Yes == this.RightToLeft)
      {
        if (align == LeftRightAlignment.Left)
          return LeftRightAlignment.Right;
        if (LeftRightAlignment.Right == align)
          return LeftRightAlignment.Left;
      }
      return align;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal ContentAlignment RtlTranslateContent(ContentAlignment align)
    {
      if (RightToLeft.Yes == this.RightToLeft)
      {
        if ((align & WindowsFormsUtils.AnyTopAlign) != (ContentAlignment) 0)
        {
          switch (align)
          {
            case ContentAlignment.TopLeft:
              return ContentAlignment.TopRight;
            case ContentAlignment.TopRight:
              return ContentAlignment.TopLeft;
          }
        }
        if ((align & WindowsFormsUtils.AnyMiddleAlign) != (ContentAlignment) 0)
        {
          switch (align)
          {
            case ContentAlignment.MiddleLeft:
              return ContentAlignment.MiddleRight;
            case ContentAlignment.MiddleRight:
              return ContentAlignment.MiddleLeft;
          }
        }
        if ((align & WindowsFormsUtils.AnyBottomAlign) != (ContentAlignment) 0)
        {
          switch (align)
          {
            case ContentAlignment.BottomLeft:
              return ContentAlignment.BottomRight;
            case ContentAlignment.BottomRight:
              return ContentAlignment.BottomLeft;
          }
        }
      }
      return align;
    }

    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public void Show()
    {
      this.Visible = true;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal virtual bool ShouldSerializeMaximumSize()
    {
      return this.MaximumSize != this.DefaultMaximumSize;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal virtual bool ShouldSerializeMinimumSize()
    {
      return this.MinimumSize != this.DefaultMinimumSize;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal virtual bool ShouldSerializeSize()
    {
      Size defaultSize = this.DefaultSize;
      if (this.width == defaultSize.Width)
        return this.height != defaultSize.Height;
      else
        return true;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal virtual bool ShouldSerializeText()
    {
      return this.Text.Length != 0;
    }

    public void SuspendLayout()
    {
      ++this.layoutSuspendCount;
      if ((int) this.layoutSuspendCount != 1)
        return;
      this.OnLayoutSuspended();
    }

    public void Update()
    {
      System.Windows.Forms.SafeNativeMethods.UpdateWindow(new HandleRef((object) this.window, this.InternalHandle));
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal void UpdateBounds()
    {
      System.Windows.Forms.NativeMethods.RECT rect = new System.Windows.Forms.NativeMethods.RECT();
      System.Windows.Forms.UnsafeNativeMethods.GetClientRect(new HandleRef((object) this.window, this.InternalHandle), out rect);
      int clientWidth = rect.right;
      int clientHeight = rect.bottom;
      System.Windows.Forms.UnsafeNativeMethods.GetWindowRect(new HandleRef((object) this.window, this.InternalHandle), out rect);
      if (!this.GetTopLevel())
        System.Windows.Forms.UnsafeNativeMethods.MapWindowPoints(System.Windows.Forms.NativeMethods.NullHandleRef, new HandleRef((object) null, System.Windows.Forms.UnsafeNativeMethods.GetParent(new HandleRef((object) this.window, this.InternalHandle))), out rect, 2);
      this.UpdateBounds(rect.left, rect.top, rect.right - rect.left, rect.bottom - rect.top, clientWidth, clientHeight);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected void UpdateBounds(int x, int y, int width, int height)
    {
      System.Windows.Forms.NativeMethods.RECT lpRect = new System.Windows.Forms.NativeMethods.RECT();
      lpRect.left = lpRect.right = lpRect.top = lpRect.bottom = 0;
      CreateParams createParams = this.CreateParams;
      System.Windows.Forms.SafeNativeMethods.AdjustWindowRectEx(ref lpRect, createParams.Style, false, createParams.ExStyle);
      int clientWidth = width - (lpRect.right - lpRect.left);
      int clientHeight = height - (lpRect.bottom - lpRect.top);
      this.UpdateBounds(x, y, width, height, clientWidth, clientHeight);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected void UpdateBounds(int x, int y, int width, int height, int clientWidth, int clientHeight)
    {
      bool flag1 = this.x != x || this.y != y;
      bool flag2 = this.Width != width || this.Height != height || this.clientWidth != clientWidth || this.clientHeight != clientHeight;
      this.x = x;
      this.y = y;
      this.width = width;
      this.height = height;
      this.clientWidth = clientWidth;
      this.clientHeight = clientHeight;
      if (flag1)
        this.OnLocationChanged(EventArgs.Empty);
      if (!flag2)
        return;
      this.OnSizeChanged(EventArgs.Empty);
      this.OnClientSizeChanged(EventArgs.Empty);
      CommonProperties.xClearPreferredSizeCache((IArrangedElement) this);
      LayoutTransaction.DoLayout((IArrangedElement) this.ParentInternal, (IArrangedElement) this, PropertyNames.Bounds);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected void UpdateZOrder()
    {
      if (this.parent == null)
        return;
      this.parent.UpdateChildZOrder(this);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected void UpdateStyles()
    {
      this.UpdateStylesCore();
      this.OnStyleChanged(EventArgs.Empty);
    }

    internal virtual void UpdateStylesCore()
    {
      if (!this.IsHandleCreated)
        return;
      CreateParams createParams = this.CreateParams;
      int windowStyle = this.WindowStyle;
      int windowExStyle = this.WindowExStyle;
      if ((this.state & 2) != 0)
        createParams.Style |= 268435456;
      if (windowStyle != createParams.Style)
        this.WindowStyle = createParams.Style;
      if (windowExStyle != createParams.ExStyle)
      {
        this.WindowExStyle = createParams.ExStyle;
        this.SetState(1073741824, (createParams.ExStyle & 4194304) != 0);
      }
      System.Windows.Forms.SafeNativeMethods.SetWindowPos(new HandleRef((object) this, this.Handle), System.Windows.Forms.NativeMethods.NullHandleRef, 0, 0, 0, 0, 55);
      this.Invalidate(true);
    }

    internal virtual void OnBoundsUpdate(int x, int y, int width, int height)
    {
    }

    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    internal virtual void WmContextMenu(ref Message m)
    {
      this.WmContextMenu(ref m, this);
    }

    internal void WmContextMenu(ref Message m, Control sourceControl)
    {
      ContextMenu contextMenu = this.Properties.GetObject(Control.PropContextMenu) as ContextMenu;
      ContextMenuStrip contextMenuStrip = contextMenu != null ? (ContextMenuStrip) null : this.Properties.GetObject(Control.PropContextMenuStrip) as ContextMenuStrip;
      if (contextMenu != null || contextMenuStrip != null)
      {
        int x = System.Windows.Forms.NativeMethods.Util.SignedLOWORD(m.LParam);
        int y = System.Windows.Forms.NativeMethods.Util.SignedHIWORD(m.LParam);
        bool isKeyboardActivated = false;
        Point point;
        if ((int) (long) m.LParam == -1)
        {
          isKeyboardActivated = true;
          point = new Point(this.Width / 2, this.Height / 2);
        }
        else
          point = this.PointToClientInternal(new Point(x, y));
        if (this.ClientRectangle.Contains(point))
        {
          if (contextMenu != null)
            contextMenu.Show(sourceControl, point);
          else if (contextMenuStrip != null)
            contextMenuStrip.ShowInternal(sourceControl, point, isKeyboardActivated);
          else
            this.DefWndProc(ref m);
        }
        else
          this.DefWndProc(ref m);
      }
      else
        this.DefWndProc(ref m);
    }

    [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    [SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    protected virtual void WndProc(ref Message m)
    {
      if ((this.controlStyle & ControlStyles.EnableNotifyMessage) == ControlStyles.EnableNotifyMessage)
        this.OnNotifyMessage(m);
      switch (m.Msg)
      {
        case 8277:
          m.Result = (IntPtr) (Marshal.SystemDefaultCharSize == 1 ? 1 : 2);
          break;
        case 8498:
        case 8499:
        case 8500:
        case 8501:
        case 8502:
        case 8503:
        case 8504:
        case 8217:
        case 306:
        case 307:
        case 308:
        case 309:
        case 310:
        case 311:
        case 312:
        case 25:
          this.WmCtlColorControl(ref m);
          break;
        case 792:
          if (this.GetStyle(ControlStyles.UserPaint))
          {
            this.WmPrintClient(ref m);
            break;
          }
          else
          {
            this.DefWndProc(ref m);
            break;
          }
        case 646:
          this.WmImeChar(ref m);
          break;
        case 673:
          this.WmMouseHover(ref m);
          break;
        case 675:
          this.WmMouseLeave(ref m);
          break;
        case 783:
          this.WmQueryNewPalette(ref m);
          break;
        case 512:
          this.WmMouseMove(ref m);
          break;
        case 513:
          this.WmMouseDown(ref m, MouseButtons.Left, 1);
          break;
        case 514:
          this.WmMouseUp(ref m, MouseButtons.Left, 1);
          break;
        case 515:
          this.WmMouseDown(ref m, MouseButtons.Left, 2);
          if (!this.GetStyle(ControlStyles.StandardDoubleClick))
            break;
          this.SetState(67108864, true);
          break;
        case 516:
          this.WmMouseDown(ref m, MouseButtons.Right, 1);
          break;
        case 517:
          this.WmMouseUp(ref m, MouseButtons.Right, 1);
          break;
        case 518:
          this.WmMouseDown(ref m, MouseButtons.Right, 2);
          if (!this.GetStyle(ControlStyles.StandardDoubleClick))
            break;
          this.SetState(67108864, true);
          break;
        case 519:
          this.WmMouseDown(ref m, MouseButtons.Middle, 1);
          break;
        case 520:
          this.WmMouseUp(ref m, MouseButtons.Middle, 1);
          break;
        case 521:
          this.WmMouseDown(ref m, MouseButtons.Middle, 2);
          if (!this.GetStyle(ControlStyles.StandardDoubleClick))
            break;
          this.SetState(67108864, true);
          break;
        case 522:
          this.WmMouseWheel(ref m);
          break;
        case 523:
          this.WmMouseDown(ref m, this.GetXButton(System.Windows.Forms.NativeMethods.Util.HIWORD(m.WParam)), 1);
          break;
        case 524:
          this.WmMouseUp(ref m, this.GetXButton(System.Windows.Forms.NativeMethods.Util.HIWORD(m.WParam)), 1);
          break;
        case 525:
          this.WmMouseDown(ref m, this.GetXButton(System.Windows.Forms.NativeMethods.Util.HIWORD(m.WParam)), 2);
          if (!this.GetStyle(ControlStyles.StandardDoubleClick))
            break;
          this.SetState(67108864, true);
          break;
        case 528:
          this.WmParentNotify(ref m);
          break;
        case 530:
          this.WmExitMenuLoop(ref m);
          break;
        case 533:
          this.WmCaptureChanged(ref m);
          break;
        case 642:
          this.WmImeNotify(ref m);
          break;
        case 269:
          this.WmImeStartComposition(ref m);
          break;
        case 270:
          this.WmImeEndComposition(ref m);
          break;
        case 273:
          this.WmCommand(ref m);
          break;
        case 274:
          if (((int) (long) m.WParam & 65520) == 61696 && ToolStripManager.ProcessMenuKey(ref m))
          {
            m.Result = IntPtr.Zero;
            break;
          }
          else
          {
            this.DefWndProc(ref m);
            break;
          }
        case 276:
        case 277:
        case 57:
        case 45:
        case 46:
        case 47:
          if (Control.ReflectMessageInternal(m.LParam, ref m))
            break;
          this.DefWndProc(ref m);
          break;
        case 279:
          this.WmInitMenuPopup(ref m);
          break;
        case 287:
          this.WmMenuSelect(ref m);
          break;
        case 288:
          this.WmMenuChar(ref m);
          break;
        case 296:
          this.WmUpdateUIState(ref m);
          break;
        case 126:
          this.WmDisplayChange(ref m);
          break;
        case 256:
        case 257:
        case 258:
        case 260:
        case 261:
          this.WmKeyChar(ref m);
          break;
        case 78:
          this.WmNotify(ref m);
          break;
        case 80:
          this.WmInputLangChangeRequest(ref m);
          break;
        case 81:
          this.WmInputLangChange(ref m);
          break;
        case 83:
          this.WmHelp(ref m);
          break;
        case 85:
          this.WmNotifyFormat(ref m);
          break;
        case 123:
          this.WmContextMenu(ref m);
          break;
        case 61:
          this.WmGetObject(ref m);
          break;
        case 70:
          this.WmWindowPosChanging(ref m);
          break;
        case 71:
          this.WmWindowPosChanged(ref m);
          break;
        case 24:
          this.WmShowWindow(ref m);
          break;
        case 32:
          this.WmSetCursor(ref m);
          break;
        case 43:
          this.WmDrawItem(ref m);
          break;
        case 44:
          this.WmMeasureItem(ref m);
          break;
        case 1:
          this.WmCreate(ref m);
          break;
        case 2:
          this.WmDestroy(ref m);
          break;
        case 3:
          this.WmMove(ref m);
          break;
        case 7:
          this.WmSetFocus(ref m);
          break;
        case 8:
          this.WmKillFocus(ref m);
          break;
        case 15:
          if (this.GetStyle(ControlStyles.UserPaint))
          {
            this.WmPaint(ref m);
            break;
          }
          else
          {
            this.DefWndProc(ref m);
            break;
          }
        case 16:
          this.WmClose(ref m);
          break;
        case 20:
          this.WmEraseBkgnd(ref m);
          break;
        default:
          if (m.Msg == Control.threadCallbackMessage && m.Msg != 0)
          {
            this.InvokeMarshaledCallbacks();
            break;
          }
          else if (m.Msg == Control.WM_GETCONTROLNAME)
          {
            this.WmGetControlName(ref m);
            break;
          }
          else if (m.Msg == Control.WM_GETCONTROLTYPE)
          {
            this.WmGetControlType(ref m);
            break;
          }
          else
          {
            if (Control.mouseWheelRoutingNeeded && m.Msg == Control.mouseWheelMessage)
            {
              Keys keys = (Keys) (0 | ((int) System.Windows.Forms.UnsafeNativeMethods.GetKeyState(17) < 0 ? 8 : 0) | ((int) System.Windows.Forms.UnsafeNativeMethods.GetKeyState(16) < 0 ? 4 : 0));
              IntPtr handle = System.Windows.Forms.UnsafeNativeMethods.GetFocus();
              if (handle == IntPtr.Zero)
              {
                this.SendMessage(m.Msg, (IntPtr) ((int) ((Keys) ((int) (long) m.WParam << 16) | keys)), m.LParam);
              }
              else
              {
                IntPtr num = IntPtr.Zero;
                for (IntPtr desktopWindow = System.Windows.Forms.UnsafeNativeMethods.GetDesktopWindow(); num == IntPtr.Zero && handle != IntPtr.Zero && handle != desktopWindow; handle = System.Windows.Forms.UnsafeNativeMethods.GetParent(new HandleRef((object) null, handle)))
                  num = System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) null, handle), 522, (int) ((Keys) ((int) (long) m.WParam << 16) | keys), m.LParam);
              }
            }
            if (m.Msg == System.Windows.Forms.NativeMethods.WM_MOUSEENTER)
            {
              this.WmMouseEnter(ref m);
              break;
            }
            else
            {
              this.DefWndProc(ref m);
              break;
            }
          }
      }
    }

    void IArrangedElement.PerformLayout(IArrangedElement affectedElement, string affectedProperty)
    {
      this.PerformLayout(new LayoutEventArgs((IComponent) affectedElement, affectedProperty));
    }

    void IArrangedElement.SetBounds(Rectangle bounds, BoundsSpecified specified)
    {
      ISite site = this.Site;
      IComponentChangeService componentChangeService = (IComponentChangeService) null;
      PropertyDescriptor propertyDescriptor1 = (PropertyDescriptor) null;
      PropertyDescriptor propertyDescriptor2 = (PropertyDescriptor) null;
      bool flag1 = false;
      bool flag2 = false;
      if (site != null && site.DesignMode)
      {
        componentChangeService = (IComponentChangeService) site.GetService(typeof (IComponentChangeService));
        if (componentChangeService != null)
        {
          propertyDescriptor1 = TypeDescriptor.GetProperties((object) this)[PropertyNames.Size];
          propertyDescriptor2 = TypeDescriptor.GetProperties((object) this)[PropertyNames.Location];
          try
          {
            if (propertyDescriptor1 != null && !propertyDescriptor1.IsReadOnly && (bounds.Width != this.Width || bounds.Height != this.Height))
            {
              if (!(site is INestedSite))
                componentChangeService.OnComponentChanging((object) this, (MemberDescriptor) propertyDescriptor1);
              flag1 = true;
            }
            if (propertyDescriptor2 != null)
            {
              if (!propertyDescriptor2.IsReadOnly)
              {
                if (bounds.X == this.x)
                {
                  if (bounds.Y == this.y)
                    goto label_16;
                }
                if (!(site is INestedSite))
                  componentChangeService.OnComponentChanging((object) this, (MemberDescriptor) propertyDescriptor2);
                flag2 = true;
              }
            }
          }
          catch (InvalidOperationException ex)
          {
          }
        }
      }
label_16:
      this.SetBoundsCore(bounds.X, bounds.Y, bounds.Width, bounds.Height, specified);
      if (site == null)
        return;
      if (componentChangeService == null)
        return;
      try
      {
        if (flag1)
          componentChangeService.OnComponentChanged((object) this, (MemberDescriptor) propertyDescriptor1, (object) null, (object) null);
        if (!flag2)
          return;
        componentChangeService.OnComponentChanged((object) this, (MemberDescriptor) propertyDescriptor2, (object) null, (object) null);
      }
      catch (InvalidOperationException ex)
      {
      }
    }

    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    void IDropTarget.OnDragEnter(DragEventArgs drgEvent)
    {
      this.OnDragEnter(drgEvent);
    }

    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    void IDropTarget.OnDragOver(DragEventArgs drgEvent)
    {
      this.OnDragOver(drgEvent);
    }

    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    void IDropTarget.OnDragLeave(EventArgs e)
    {
      this.OnDragLeave(e);
    }

    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    void IDropTarget.OnDragDrop(DragEventArgs drgEvent)
    {
      this.OnDragDrop(drgEvent);
    }

    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    void ISupportOleDropSource.OnGiveFeedback(GiveFeedbackEventArgs giveFeedbackEventArgs)
    {
      this.OnGiveFeedback(giveFeedbackEventArgs);
    }

    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    void ISupportOleDropSource.OnQueryContinueDrag(QueryContinueDragEventArgs queryContinueDragEventArgs)
    {
      this.OnQueryContinueDrag(queryContinueDragEventArgs);
    }

    int System.Windows.Forms.UnsafeNativeMethods.IOleControl.GetControlInfo(System.Windows.Forms.NativeMethods.tagCONTROLINFO pCI)
    {
      pCI.cb = Marshal.SizeOf(typeof (System.Windows.Forms.NativeMethods.tagCONTROLINFO));
      pCI.hAccel = IntPtr.Zero;
      pCI.cAccel = (short) 0;
      pCI.dwFlags = 0;
      if (this.IsInputKey(Keys.Return))
        pCI.dwFlags |= 1;
      if (this.IsInputKey(Keys.Escape))
        pCI.dwFlags |= 2;
      this.ActiveXInstance.GetControlInfo(pCI);
      return 0;
    }

    int System.Windows.Forms.UnsafeNativeMethods.IOleControl.OnMnemonic(ref System.Windows.Forms.NativeMethods.MSG pMsg)
    {
      this.ProcessMnemonic((char) (int) pMsg.wParam);
      return 0;
    }

    int System.Windows.Forms.UnsafeNativeMethods.IOleControl.OnAmbientPropertyChange(int dispID)
    {
      this.ActiveXInstance.OnAmbientPropertyChange(dispID);
      return 0;
    }

    int System.Windows.Forms.UnsafeNativeMethods.IOleControl.FreezeEvents(int bFreeze)
    {
      this.ActiveXInstance.EventsFrozen = bFreeze != 0;
      return 0;
    }

    int System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceActiveObject.GetWindow(out IntPtr hwnd)
    {
      return this.GetWindow(out hwnd);
    }

    void System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceActiveObject.ContextSensitiveHelp(int fEnterMode)
    {
      this.ContextSensitiveHelp(fEnterMode);
    }

    int System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceActiveObject.TranslateAccelerator(ref System.Windows.Forms.NativeMethods.MSG lpmsg)
    {
      return this.ActiveXInstance.TranslateAccelerator(ref lpmsg);
    }

    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    void System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceActiveObject.OnFrameWindowActivate(bool fActivate)
    {
      this.OnFrameWindowActivate(fActivate);
    }

    void System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceActiveObject.OnDocWindowActivate(int fActivate)
    {
      this.ActiveXInstance.OnDocWindowActivate(fActivate);
    }

    void System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceActiveObject.ResizeBorder(System.Windows.Forms.NativeMethods.COMRECT prcBorder, System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceUIWindow pUIWindow, bool fFrameWindow)
    {
    }

    void System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceActiveObject.EnableModeless(int fEnable)
    {
    }

    int System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceObject.GetWindow(out IntPtr hwnd)
    {
      return this.ActiveXInstance.GetWindow(out hwnd);
    }

    void System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceObject.ContextSensitiveHelp(int fEnterMode)
    {
      if (fEnterMode == 0)
        return;
      this.OnHelpRequested(new HelpEventArgs(Control.MousePosition));
    }

    void System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceObject.InPlaceDeactivate()
    {
      this.ActiveXInstance.InPlaceDeactivate();
    }

    int System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceObject.UIDeactivate()
    {
      return this.ActiveXInstance.UIDeactivate();
    }

    void System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceObject.SetObjectRects(System.Windows.Forms.NativeMethods.COMRECT lprcPosRect, System.Windows.Forms.NativeMethods.COMRECT lprcClipRect)
    {
      this.ActiveXInstance.SetObjectRects(lprcPosRect, lprcClipRect);
    }

    void System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceObject.ReactivateAndUndo()
    {
    }

    int System.Windows.Forms.UnsafeNativeMethods.IOleObject.SetClientSite(System.Windows.Forms.UnsafeNativeMethods.IOleClientSite pClientSite)
    {
      this.ActiveXInstance.SetClientSite(pClientSite);
      return 0;
    }

    System.Windows.Forms.UnsafeNativeMethods.IOleClientSite System.Windows.Forms.UnsafeNativeMethods.IOleObject.GetClientSite()
    {
      return this.ActiveXInstance.GetClientSite();
    }

    int System.Windows.Forms.UnsafeNativeMethods.IOleObject.SetHostNames(string szContainerApp, string szContainerObj)
    {
      return 0;
    }

    int System.Windows.Forms.UnsafeNativeMethods.IOleObject.Close(int dwSaveOption)
    {
      this.ActiveXInstance.Close(dwSaveOption);
      return 0;
    }

    int System.Windows.Forms.UnsafeNativeMethods.IOleObject.SetMoniker(int dwWhichMoniker, object pmk)
    {
      return -2147467263;
    }

    int System.Windows.Forms.UnsafeNativeMethods.IOleObject.GetMoniker(int dwAssign, int dwWhichMoniker, out object moniker)
    {
      moniker = (object) null;
      return -2147467263;
    }

    int System.Windows.Forms.UnsafeNativeMethods.IOleObject.InitFromData(System.Runtime.InteropServices.ComTypes.IDataObject pDataObject, int fCreation, int dwReserved)
    {
      return -2147467263;
    }

    int System.Windows.Forms.UnsafeNativeMethods.IOleObject.GetClipboardData(int dwReserved, out System.Runtime.InteropServices.ComTypes.IDataObject data)
    {
      data = (System.Runtime.InteropServices.ComTypes.IDataObject) null;
      return -2147467263;
    }

    int System.Windows.Forms.UnsafeNativeMethods.IOleObject.DoVerb(int iVerb, IntPtr lpmsg, System.Windows.Forms.UnsafeNativeMethods.IOleClientSite pActiveSite, int lindex, IntPtr hwndParent, System.Windows.Forms.NativeMethods.COMRECT lprcPosRect)
    {
      iVerb = (int) (short) iVerb;
      try
      {
        this.ActiveXInstance.DoVerb(iVerb, lpmsg, pActiveSite, lindex, hwndParent, lprcPosRect);
      }
      catch (Exception ex)
      {
        throw;
      }
      return 0;
    }

    int System.Windows.Forms.UnsafeNativeMethods.IOleObject.EnumVerbs(out System.Windows.Forms.UnsafeNativeMethods.IEnumOLEVERB e)
    {
      return Control.ActiveXImpl.EnumVerbs(out e);
    }

    int System.Windows.Forms.UnsafeNativeMethods.IOleObject.OleUpdate()
    {
      return 0;
    }

    int System.Windows.Forms.UnsafeNativeMethods.IOleObject.IsUpToDate()
    {
      return 0;
    }

    int System.Windows.Forms.UnsafeNativeMethods.IOleObject.GetUserClassID(ref Guid pClsid)
    {
      pClsid = this.GetType().GUID;
      return 0;
    }

    int System.Windows.Forms.UnsafeNativeMethods.IOleObject.GetUserType(int dwFormOfType, out string userType)
    {
      userType = dwFormOfType != 1 ? this.GetType().Name : this.GetType().FullName;
      return 0;
    }

    int System.Windows.Forms.UnsafeNativeMethods.IOleObject.SetExtent(int dwDrawAspect, System.Windows.Forms.NativeMethods.tagSIZEL pSizel)
    {
      this.ActiveXInstance.SetExtent(dwDrawAspect, pSizel);
      return 0;
    }

    int System.Windows.Forms.UnsafeNativeMethods.IOleObject.GetExtent(int dwDrawAspect, System.Windows.Forms.NativeMethods.tagSIZEL pSizel)
    {
      this.ActiveXInstance.GetExtent(dwDrawAspect, pSizel);
      return 0;
    }

    int System.Windows.Forms.UnsafeNativeMethods.IOleObject.Advise(IAdviseSink pAdvSink, out int cookie)
    {
      cookie = this.ActiveXInstance.Advise(pAdvSink);
      return 0;
    }

    int System.Windows.Forms.UnsafeNativeMethods.IOleObject.Unadvise(int dwConnection)
    {
      this.ActiveXInstance.Unadvise(dwConnection);
      return 0;
    }

    int System.Windows.Forms.UnsafeNativeMethods.IOleObject.EnumAdvise(out IEnumSTATDATA e)
    {
      e = (IEnumSTATDATA) null;
      return -2147467263;
    }

    int System.Windows.Forms.UnsafeNativeMethods.IOleObject.GetMiscStatus(int dwAspect, out int cookie)
    {
      if ((dwAspect & 1) != 0)
      {
        int num = 131456;
        if (this.GetStyle(ControlStyles.ResizeRedraw))
          num |= 1;
        if (this is IButtonControl)
          num |= 4096;
        cookie = num;
        return 0;
      }
      else
      {
        cookie = 0;
        return -2147221397;
      }
    }

    int System.Windows.Forms.UnsafeNativeMethods.IOleObject.SetColorScheme(System.Windows.Forms.NativeMethods.tagLOGPALETTE pLogpal)
    {
      return 0;
    }

    int System.Windows.Forms.UnsafeNativeMethods.IOleWindow.GetWindow(out IntPtr hwnd)
    {
      return this.GetWindow(out hwnd);
    }

    void System.Windows.Forms.UnsafeNativeMethods.IOleWindow.ContextSensitiveHelp(int fEnterMode)
    {
      this.ContextSensitiveHelp(fEnterMode);
    }

    void System.Windows.Forms.UnsafeNativeMethods.IPersist.GetClassID(out Guid pClassID)
    {
      pClassID = this.GetType().GUID;
    }

    void System.Windows.Forms.UnsafeNativeMethods.IPersistPropertyBag.InitNew()
    {
    }

    void System.Windows.Forms.UnsafeNativeMethods.IPersistPropertyBag.GetClassID(out Guid pClassID)
    {
      pClassID = this.GetType().GUID;
    }

    void System.Windows.Forms.UnsafeNativeMethods.IPersistPropertyBag.Load(System.Windows.Forms.UnsafeNativeMethods.IPropertyBag pPropBag, System.Windows.Forms.UnsafeNativeMethods.IErrorLog pErrorLog)
    {
      this.ActiveXInstance.Load(pPropBag, pErrorLog);
    }

    void System.Windows.Forms.UnsafeNativeMethods.IPersistPropertyBag.Save(System.Windows.Forms.UnsafeNativeMethods.IPropertyBag pPropBag, bool fClearDirty, bool fSaveAllProperties)
    {
      this.ActiveXInstance.Save(pPropBag, fClearDirty, fSaveAllProperties);
    }

    void System.Windows.Forms.UnsafeNativeMethods.IPersistStorage.GetClassID(out Guid pClassID)
    {
      pClassID = this.GetType().GUID;
    }

    int System.Windows.Forms.UnsafeNativeMethods.IPersistStorage.IsDirty()
    {
      return this.ActiveXInstance.IsDirty();
    }

    void System.Windows.Forms.UnsafeNativeMethods.IPersistStorage.InitNew(System.Windows.Forms.UnsafeNativeMethods.IStorage pstg)
    {
    }

    int System.Windows.Forms.UnsafeNativeMethods.IPersistStorage.Load(System.Windows.Forms.UnsafeNativeMethods.IStorage pstg)
    {
      this.ActiveXInstance.Load(pstg);
      return 0;
    }

    void System.Windows.Forms.UnsafeNativeMethods.IPersistStorage.Save(System.Windows.Forms.UnsafeNativeMethods.IStorage pstg, bool fSameAsLoad)
    {
      this.ActiveXInstance.Save(pstg, fSameAsLoad);
    }

    void System.Windows.Forms.UnsafeNativeMethods.IPersistStorage.SaveCompleted(System.Windows.Forms.UnsafeNativeMethods.IStorage pStgNew)
    {
    }

    void System.Windows.Forms.UnsafeNativeMethods.IPersistStorage.HandsOffStorage()
    {
    }

    void System.Windows.Forms.UnsafeNativeMethods.IPersistStreamInit.GetClassID(out Guid pClassID)
    {
      pClassID = this.GetType().GUID;
    }

    int System.Windows.Forms.UnsafeNativeMethods.IPersistStreamInit.IsDirty()
    {
      return this.ActiveXInstance.IsDirty();
    }

    void System.Windows.Forms.UnsafeNativeMethods.IPersistStreamInit.Load(System.Windows.Forms.UnsafeNativeMethods.IStream pstm)
    {
      this.ActiveXInstance.Load(pstm);
    }

    void System.Windows.Forms.UnsafeNativeMethods.IPersistStreamInit.Save(System.Windows.Forms.UnsafeNativeMethods.IStream pstm, bool fClearDirty)
    {
      this.ActiveXInstance.Save(pstm, fClearDirty);
    }

    void System.Windows.Forms.UnsafeNativeMethods.IPersistStreamInit.GetSizeMax(long pcbSize)
    {
    }

    void System.Windows.Forms.UnsafeNativeMethods.IPersistStreamInit.InitNew()
    {
    }

    void System.Windows.Forms.UnsafeNativeMethods.IQuickActivate.QuickActivate(System.Windows.Forms.UnsafeNativeMethods.tagQACONTAINER pQaContainer, System.Windows.Forms.UnsafeNativeMethods.tagQACONTROL pQaControl)
    {
      this.ActiveXInstance.QuickActivate(pQaContainer, pQaControl);
    }

    void System.Windows.Forms.UnsafeNativeMethods.IQuickActivate.SetContentExtent(System.Windows.Forms.NativeMethods.tagSIZEL pSizel)
    {
      this.ActiveXInstance.SetExtent(1, pSizel);
    }

    void System.Windows.Forms.UnsafeNativeMethods.IQuickActivate.GetContentExtent(System.Windows.Forms.NativeMethods.tagSIZEL pSizel)
    {
      this.ActiveXInstance.GetExtent(1, pSizel);
    }

    int System.Windows.Forms.UnsafeNativeMethods.IViewObject.Draw(int dwDrawAspect, int lindex, IntPtr pvAspect, System.Windows.Forms.NativeMethods.tagDVTARGETDEVICE ptd, IntPtr hdcTargetDev, IntPtr hdcDraw, System.Windows.Forms.NativeMethods.COMRECT lprcBounds, System.Windows.Forms.NativeMethods.COMRECT lprcWBounds, IntPtr pfnContinue, int dwContinue)
    {
      try
      {
        this.ActiveXInstance.Draw(dwDrawAspect, lindex, pvAspect, ptd, hdcTargetDev, hdcDraw, lprcBounds, lprcWBounds, pfnContinue, dwContinue);
      }
      catch (ExternalException ex)
      {
        return ex.ErrorCode;
      }
      return 0;
    }

    int System.Windows.Forms.UnsafeNativeMethods.IViewObject.GetColorSet(int dwDrawAspect, int lindex, IntPtr pvAspect, System.Windows.Forms.NativeMethods.tagDVTARGETDEVICE ptd, IntPtr hicTargetDev, System.Windows.Forms.NativeMethods.tagLOGPALETTE ppColorSet)
    {
      return -2147467263;
    }

    int System.Windows.Forms.UnsafeNativeMethods.IViewObject.Freeze(int dwDrawAspect, int lindex, IntPtr pvAspect, IntPtr pdwFreeze)
    {
      return -2147467263;
    }

    int System.Windows.Forms.UnsafeNativeMethods.IViewObject.Unfreeze(int dwFreeze)
    {
      return -2147467263;
    }

    void System.Windows.Forms.UnsafeNativeMethods.IViewObject.SetAdvise(int aspects, int advf, IAdviseSink pAdvSink)
    {
      this.ActiveXInstance.SetAdvise(aspects, advf, pAdvSink);
    }

    void System.Windows.Forms.UnsafeNativeMethods.IViewObject.GetAdvise(int[] paspects, int[] padvf, IAdviseSink[] pAdvSink)
    {
      this.ActiveXInstance.GetAdvise(paspects, padvf, pAdvSink);
    }

    void System.Windows.Forms.UnsafeNativeMethods.IViewObject2.Draw(int dwDrawAspect, int lindex, IntPtr pvAspect, System.Windows.Forms.NativeMethods.tagDVTARGETDEVICE ptd, IntPtr hdcTargetDev, IntPtr hdcDraw, System.Windows.Forms.NativeMethods.COMRECT lprcBounds, System.Windows.Forms.NativeMethods.COMRECT lprcWBounds, IntPtr pfnContinue, int dwContinue)
    {
      this.ActiveXInstance.Draw(dwDrawAspect, lindex, pvAspect, ptd, hdcTargetDev, hdcDraw, lprcBounds, lprcWBounds, pfnContinue, dwContinue);
    }

    int System.Windows.Forms.UnsafeNativeMethods.IViewObject2.GetColorSet(int dwDrawAspect, int lindex, IntPtr pvAspect, System.Windows.Forms.NativeMethods.tagDVTARGETDEVICE ptd, IntPtr hicTargetDev, System.Windows.Forms.NativeMethods.tagLOGPALETTE ppColorSet)
    {
      return -2147467263;
    }

    int System.Windows.Forms.UnsafeNativeMethods.IViewObject2.Freeze(int dwDrawAspect, int lindex, IntPtr pvAspect, IntPtr pdwFreeze)
    {
      return -2147467263;
    }

    int System.Windows.Forms.UnsafeNativeMethods.IViewObject2.Unfreeze(int dwFreeze)
    {
      return -2147467263;
    }

    void System.Windows.Forms.UnsafeNativeMethods.IViewObject2.SetAdvise(int aspects, int advf, IAdviseSink pAdvSink)
    {
      this.ActiveXInstance.SetAdvise(aspects, advf, pAdvSink);
    }

    void System.Windows.Forms.UnsafeNativeMethods.IViewObject2.GetAdvise(int[] paspects, int[] padvf, IAdviseSink[] pAdvSink)
    {
      this.ActiveXInstance.GetAdvise(paspects, padvf, pAdvSink);
    }

    void System.Windows.Forms.UnsafeNativeMethods.IViewObject2.GetExtent(int dwDrawAspect, int lindex, System.Windows.Forms.NativeMethods.tagDVTARGETDEVICE ptd, System.Windows.Forms.NativeMethods.tagSIZEL lpsizel)
    {
      this.GetExtent(dwDrawAspect, lpsizel);
    }

    protected virtual void OnImeModeChanged(EventArgs e)
    {
      EventHandler eventHandler = (EventHandler) this.Events[Control.EventImeModeChanged];
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void ResetImeMode()
    {
      this.ImeMode = this.DefaultImeMode;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal virtual bool ShouldSerializeImeMode()
    {
      bool found;
      int integer = this.Properties.GetInteger(Control.PropImeMode, out found);
      if (found)
        return (ImeMode) integer != this.DefaultImeMode;
      else
        return false;
    }

    private AccessibleObject GetAccessibilityObject(int accObjId)
    {
      AccessibleObject accessibleObject;
      switch (accObjId)
      {
        case -4:
          accessibleObject = this.AccessibilityObject;
          break;
        case 0:
          accessibleObject = this.NcAccessibilityObject;
          break;
        default:
          accessibleObject = accObjId <= 0 ? (AccessibleObject) null : this.GetAccessibilityObjectById(accObjId);
          break;
      }
      return accessibleObject;
    }

    private bool ShouldSerializeAccessibleName()
    {
      string accessibleName = this.AccessibleName;
      if (accessibleName != null)
        return accessibleName.Length > 0;
      else
        return false;
    }

    internal bool ValidateActiveControl(out bool validatedControlAllowsFocusChange)
    {
      bool flag = true;
      validatedControlAllowsFocusChange = false;
      IContainerControl containerControlInternal = this.GetContainerControlInternal();
      if (containerControlInternal != null)
      {
        ContainerControl containerControl1 = containerControlInternal as ContainerControl;
        if (containerControl1 != null)
        {
          for (; containerControl1.ActiveControl == null; {
            ContainerControl containerControl2;
            containerControl1 = containerControl2;
          }
          )
          {
            Control parentInternal = containerControl1.ParentInternal;
            if (parentInternal != null)
            {
              containerControl2 = parentInternal.GetContainerControlInternal() as ContainerControl;
              if (containerControl2 == null)
                break;
            }
            else
              break;
          }
          flag = containerControl1.ValidateInternal(true, out validatedControlAllowsFocusChange);
        }
      }
      return flag;
    }

    private void DetachContextMenu(object sender, EventArgs e)
    {
      this.ContextMenu = (ContextMenu) null;
    }

    private void DetachContextMenuStrip(object sender, EventArgs e)
    {
      this.ContextMenuStrip = (ContextMenuStrip) null;
    }

    private void DisposeFontHandle()
    {
      if (!this.Properties.ContainsObject(Control.PropFontHandleWrapper))
        return;
      Control.FontHandleWrapper fontHandleWrapper = this.Properties.GetObject(Control.PropFontHandleWrapper) as Control.FontHandleWrapper;
      if (fontHandleWrapper != null)
        fontHandleWrapper.Dispose();
      this.Properties.SetObject(Control.PropFontHandleWrapper, (object) null);
    }

    private Font GetParentFont()
    {
      if (this.ParentInternal != null && this.ParentInternal.CanAccessProperties)
        return this.ParentInternal.Font;
      else
        return (Font) null;
    }

    private bool IsValidBackColor(System.Drawing.Color c)
    {
      return c.IsEmpty || this.GetStyle(ControlStyles.SupportsTransparentBackColor) || (int) c.A >= (int) byte.MaxValue;
    }

    private bool RenderColorTransparent(System.Drawing.Color c)
    {
      if (this.GetStyle(ControlStyles.SupportsTransparentBackColor))
        return (int) c.A < (int) byte.MaxValue;
      else
        return false;
    }

    private void WaitForWaitHandle(WaitHandle waitHandle)
    {
      Application.ThreadContext threadContext = Application.ThreadContext.FromId(this.CreateThreadId);
      if (threadContext == null)
        return;
      IntPtr handle = threadContext.GetHandle();
      bool flag = false;
      uint lpExitCode = 0U;
      for (; !flag; flag = waitHandle.WaitOne(1000, false))
      {
        if (System.Windows.Forms.UnsafeNativeMethods.GetExitCodeThread(handle, out lpExitCode) && (int) lpExitCode != 259 || AppDomain.CurrentDomain.IsFinalizingForUnload())
        {
          if (waitHandle.WaitOne(1, false))
            break;
          else
            throw new InvalidAsynchronousStateException(System.Windows.Forms.SR.GetString("ThreadNoLongerValid"));
        }
        else if (this.IsDisposed && this.threadCallbackList != null && this.threadCallbackList.Count > 0)
        {
          lock (this.threadCallbackList)
          {
            Exception local_6 = (Exception) new ObjectDisposedException(this.GetType().Name);
            while (this.threadCallbackList.Count > 0)
            {
              Control.ThreadMethodEntry local_7 = (Control.ThreadMethodEntry) this.threadCallbackList.Dequeue();
              local_7.exception = local_6;
              local_7.Complete();
            }
          }
        }
      }
    }

    private IntPtr ActiveXMergeRegion(IntPtr region)
    {
      return this.ActiveXInstance.MergeRegion(region);
    }

    private void ActiveXOnFocus(bool focus)
    {
      this.ActiveXInstance.OnFocus(focus);
    }

    private void ActiveXViewChanged()
    {
      this.ActiveXInstance.ViewChangedInternal();
    }

    private void ActiveXUpdateBounds(ref int x, ref int y, ref int width, ref int height, int flags)
    {
      this.ActiveXInstance.UpdateBounds(ref x, ref y, ref width, ref height, flags);
    }

    internal void BeginUpdateInternal()
    {
      if (!this.IsHandleCreated)
        return;
      if ((int) this.updateCount == 0)
        this.SendMessage(11, 0, 0);
      ++this.updateCount;
    }

    internal static void CheckParentingCycle(Control bottom, Control toFind)
    {
      Form form1 = (Form) null;
      Control control1 = (Control) null;
      for (Control control2 = bottom; control2 != null; control2 = control2.ParentInternal)
      {
        control1 = control2;
        if (control2 == toFind)
          throw new ArgumentException(System.Windows.Forms.SR.GetString("CircularOwner"));
      }
      if (control1 != null && control1 is Form)
      {
        for (Form form2 = (Form) control1; form2 != null; form2 = form2.OwnerInternal)
        {
          form1 = form2;
          if (form2 == toFind)
            throw new ArgumentException(System.Windows.Forms.SR.GetString("CircularOwner"));
        }
      }
      if (form1 == null || form1.ParentInternal == null)
        return;
      Control.CheckParentingCycle(form1.ParentInternal, toFind);
    }

    private void ChildGotFocus(Control child)
    {
      if (this.IsActiveX)
        this.ActiveXOnFocus(true);
      if (this.parent == null)
        return;
      this.parent.ChildGotFocus(child);
    }

    internal Graphics CreateGraphicsInternal()
    {
      return Graphics.FromHwndInternal(this.Handle);
    }

    internal void CreateControl(bool fIgnoreVisible)
    {
      if (((this.state & 1) != 0 || !this.Visible) && !fIgnoreVisible)
        return;
      this.state |= 1;
      bool flag = false;
      try
      {
        if (!this.IsHandleCreated)
          this.CreateHandle();
        Control.ControlCollection controlCollection = (Control.ControlCollection) this.Properties.GetObject(Control.PropControlsCollection);
        if (controlCollection != null)
        {
          Control[] controlArray = new Control[controlCollection.Count];
          controlCollection.CopyTo((Array) controlArray, 0);
          foreach (Control control in controlArray)
          {
            if (control.IsHandleCreated)
              control.SetParentHandle(this.Handle);
            control.CreateControl(fIgnoreVisible);
          }
        }
        flag = true;
      }
      finally
      {
        if (!flag)
          this.state &= -2;
      }
      this.OnCreateControl();
    }

    internal bool EndUpdateInternal()
    {
      return this.EndUpdateInternal(true);
    }

    internal bool EndUpdateInternal(bool invalidate)
    {
      if ((int) this.updateCount <= 0)
        return false;
      --this.updateCount;
      if ((int) this.updateCount == 0)
      {
        this.SendMessage(11, -1, 0);
        if (invalidate)
          this.Invalidate();
      }
      return true;
    }

    private Control FindMarshalingControl()
    {
      lock (this)
      {
        Control local_0 = this;
        while (local_0 != null && !local_0.IsHandleCreated)
          local_0 = local_0.ParentInternal;
        if (local_0 == null)
          local_0 = this;
        return local_0;
      }
    }

    internal void RaiseCreateHandleEvent(EventArgs e)
    {
      EventHandler eventHandler = (EventHandler) this.Events[Control.EventHandleCreated];
      if (eventHandler == null)
        return;
      eventHandler((object) this, e);
    }

    internal static Control FromChildHandleInternal(IntPtr handle)
    {
      for (; handle != IntPtr.Zero; handle = System.Windows.Forms.UnsafeNativeMethods.GetAncestor(new HandleRef((object) null, handle), 1))
      {
        Control control = Control.FromHandleInternal(handle);
        if (control != null)
          return control;
      }
      return (Control) null;
    }

    internal static Control FromHandleInternal(IntPtr handle)
    {
      NativeWindow nativeWindow = NativeWindow.FromHandle(handle);
      while (nativeWindow != null && !(nativeWindow is Control.ControlNativeWindow))
        nativeWindow = nativeWindow.PreviousWindow;
      if (nativeWindow is Control.ControlNativeWindow)
        return ((Control.ControlNativeWindow) nativeWindow).GetControl();
      else
        return (Control) null;
    }

    internal Size ApplySizeConstraints(int width, int height)
    {
      return this.ApplyBoundsConstraints(0, 0, width, height).Size;
    }

    internal Size ApplySizeConstraints(Size proposedSize)
    {
      return this.ApplyBoundsConstraints(0, 0, proposedSize.Width, proposedSize.Height).Size;
    }

    private static bool IsFocusManagingContainerControl(Control ctl)
    {
      if ((ctl.controlStyle & ControlStyles.ContainerControl) == ControlStyles.ContainerControl)
        return ctl is IContainerControl;
      else
        return false;
    }

    internal bool IsUpdating()
    {
      return (int) this.updateCount > 0;
    }

    internal IContainerControl GetContainerControlInternal()
    {
      Control ctl = this;
      if (ctl != null && this.IsContainerControl)
        ctl = ctl.ParentInternal;
      while (ctl != null && !Control.IsFocusManagingContainerControl(ctl))
        ctl = ctl.ParentInternal;
      return (IContainerControl) ctl;
    }

    private static Control.FontHandleWrapper GetDefaultFontHandleWrapper()
    {
      if (Control.defaultFontHandleWrapper == null)
        Control.defaultFontHandleWrapper = new Control.FontHandleWrapper(Control.DefaultFont);
      return Control.defaultFontHandleWrapper;
    }

    internal IntPtr GetHRgn(Region region)
    {
      Graphics graphicsInternal = this.CreateGraphicsInternal();
      IntPtr hrgn = region.GetHrgn(graphicsInternal);
      System.Internal.HandleCollector.Add(hrgn, System.Windows.Forms.NativeMethods.CommonHandles.GDI);
      graphicsInternal.Dispose();
      return hrgn;
    }

    private MouseButtons GetXButton(int wparam)
    {
      switch (wparam)
      {
        case 1:
          return MouseButtons.XButton1;
        case 2:
          return MouseButtons.XButton2;
        default:
          return MouseButtons.None;
      }
    }

    internal bool GetAnyDisposingInHierarchy()
    {
      Control control = this;
      bool flag = false;
      for (; control != null; control = control.parent)
      {
        if (control.Disposing)
        {
          flag = true;
          break;
        }
      }
      return flag;
    }

    private MenuItem GetMenuItemFromHandleId(IntPtr hmenu, int item)
    {
      MenuItem menuItem1 = (MenuItem) null;
      int menuItemId = System.Windows.Forms.UnsafeNativeMethods.GetMenuItemID(new HandleRef((object) null, hmenu), item);
      if (menuItemId == -1)
      {
        IntPtr num = IntPtr.Zero;
        IntPtr subMenu = System.Windows.Forms.UnsafeNativeMethods.GetSubMenu(new HandleRef((object) null, hmenu), item);
        int menuItemCount = System.Windows.Forms.UnsafeNativeMethods.GetMenuItemCount(new HandleRef((object) null, subMenu));
        MenuItem menuItem2 = (MenuItem) null;
        for (int index = 0; index < menuItemCount; ++index)
        {
          menuItem2 = this.GetMenuItemFromHandleId(subMenu, index);
          if (menuItem2 != null)
          {
            Menu parent = menuItem2.Parent;
            if (parent != null && parent is MenuItem)
            {
              menuItem2 = (MenuItem) parent;
              break;
            }
            else
              menuItem2 = (MenuItem) null;
          }
        }
        menuItem1 = menuItem2;
      }
      else
      {
        Command commandFromId = Command.GetCommandFromID(menuItemId);
        if (commandFromId != null)
        {
          object target = commandFromId.Target;
          if (target != null && target is MenuItem.MenuItemData)
            menuItem1 = ((MenuItem.MenuItemData) target).baseItem;
        }
      }
      return menuItem1;
    }

    private ArrayList GetChildControlsTabOrderList(bool handleCreatedOnly)
    {
      ArrayList arrayList = new ArrayList();
      foreach (Control control in (ArrangedElementCollection) this.Controls)
      {
        if (!handleCreatedOnly || control.IsHandleCreated)
          arrayList.Add((object) new Control.ControlTabOrderHolder(arrayList.Count, control.TabIndex, control));
      }
      arrayList.Sort((IComparer) new Control.ControlTabOrderComparer());
      return arrayList;
    }

    private int[] GetChildWindowsInTabOrder()
    {
      ArrayList windowsTabOrderList = this.GetChildWindowsTabOrderList();
      int[] numArray = new int[windowsTabOrderList.Count];
      for (int index = 0; index < windowsTabOrderList.Count; ++index)
        numArray[index] = ((Control.ControlTabOrderHolder) windowsTabOrderList[index]).oldOrder;
      return numArray;
    }

    internal Control[] GetChildControlsInTabOrder(bool handleCreatedOnly)
    {
      ArrayList controlsTabOrderList = this.GetChildControlsTabOrderList(handleCreatedOnly);
      Control[] controlArray = new Control[controlsTabOrderList.Count];
      for (int index = 0; index < controlsTabOrderList.Count; ++index)
        controlArray[index] = ((Control.ControlTabOrderHolder) controlsTabOrderList[index]).control;
      return controlArray;
    }

    private static ArrayList GetChildWindows(IntPtr hWndParent)
    {
      ArrayList arrayList = new ArrayList();
      for (IntPtr window = System.Windows.Forms.UnsafeNativeMethods.GetWindow(new HandleRef((object) null, hWndParent), 5); window != IntPtr.Zero; window = System.Windows.Forms.UnsafeNativeMethods.GetWindow(new HandleRef((object) null, window), 2))
        arrayList.Add((object) window);
      return arrayList;
    }

    private ArrayList GetChildWindowsTabOrderList()
    {
      ArrayList arrayList = new ArrayList();
      foreach (IntPtr handle in Control.GetChildWindows(this.Handle))
      {
        Control control = Control.FromHandleInternal(handle);
        int newOrder = control == null ? -1 : control.TabIndex;
        arrayList.Add((object) new Control.ControlTabOrderHolder(arrayList.Count, newOrder, control));
      }
      arrayList.Sort((IComparer) new Control.ControlTabOrderComparer());
      return arrayList;
    }

    internal static IntPtr GetSafeHandle(IWin32Window window)
    {
      IntPtr num = IntPtr.Zero;
      Control control = window as Control;
      if (control != null)
        return control.Handle;
      System.Windows.Forms.IntSecurity.AllWindows.Demand();
      IntPtr handle = window.Handle;
      if (handle == IntPtr.Zero || System.Windows.Forms.UnsafeNativeMethods.IsWindow(new HandleRef((object) null, handle)))
        return handle;
      else
        throw new Win32Exception(6);
    }

    private void HookMouseEvent()
    {
      if (this.GetState(16384))
        return;
      this.SetState(16384, true);
      if (this.trackMouseEvent == null)
      {
        this.trackMouseEvent = new System.Windows.Forms.NativeMethods.TRACKMOUSEEVENT();
        this.trackMouseEvent.dwFlags = 3;
        this.trackMouseEvent.hwndTrack = this.Handle;
      }
      System.Windows.Forms.SafeNativeMethods.TrackMouseEvent(this.trackMouseEvent);
    }

    private void InitScaling(BoundsSpecified specified)
    {
      this.requiredScaling |= (byte) (specified & BoundsSpecified.All);
    }

    private void InitMouseWheelSupport()
    {
      if (Control.mouseWheelInit)
        return;
      Control.mouseWheelRoutingNeeded = !SystemInformation.NativeMouseWheelSupport;
      if (Control.mouseWheelRoutingNeeded)
      {
        IntPtr num1 = IntPtr.Zero;
        if (System.Windows.Forms.UnsafeNativeMethods.FindWindow("MouseZ", "Magellan MSWHEEL") != IntPtr.Zero)
        {
          int num2 = System.Windows.Forms.SafeNativeMethods.RegisterWindowMessage("MSWHEEL_ROLLMSG");
          if (num2 != 0)
            Control.mouseWheelMessage = num2;
        }
      }
      Control.mouseWheelInit = true;
    }

    private void InvokeMarshaledCallback(Control.ThreadMethodEntry tme)
    {
      if (tme.executionContext != null)
      {
        if (Control.invokeMarshaledCallbackHelperDelegate == null)
          Control.invokeMarshaledCallbackHelperDelegate = new ContextCallback(Control.InvokeMarshaledCallbackHelper);
        if (SynchronizationContext.Current == null)
          WindowsFormsSynchronizationContext.InstallIfNeeded();
        tme.syncContext = SynchronizationContext.Current;
        ExecutionContext.Run(tme.executionContext, Control.invokeMarshaledCallbackHelperDelegate, (object) tme);
      }
      else
        Control.InvokeMarshaledCallbackHelper((object) tme);
    }

    private static void InvokeMarshaledCallbackHelper(object obj)
    {
      Control.ThreadMethodEntry tme = (Control.ThreadMethodEntry) obj;
      if (tme.syncContext != null)
      {
        SynchronizationContext current = SynchronizationContext.Current;
        try
        {
          SynchronizationContext.SetSynchronizationContext(tme.syncContext);
          Control.InvokeMarshaledCallbackDo(tme);
        }
        finally
        {
          SynchronizationContext.SetSynchronizationContext(current);
        }
      }
      else
        Control.InvokeMarshaledCallbackDo(tme);
    }

    private static void InvokeMarshaledCallbackDo(Control.ThreadMethodEntry tme)
    {
      if (tme.method is EventHandler)
      {
        if (tme.args == null || tme.args.Length < 1)
          ((EventHandler) tme.method)((object) tme.caller, EventArgs.Empty);
        else if (tme.args.Length < 2)
          ((EventHandler) tme.method)(tme.args[0], EventArgs.Empty);
        else
          ((EventHandler) tme.method)(tme.args[0], (EventArgs) tme.args[1]);
      }
      else if (tme.method is MethodInvoker)
        ((MethodInvoker) tme.method)();
      else if (tme.method is WaitCallback)
        ((WaitCallback) tme.method)(tme.args[0]);
      else
        tme.retVal = tme.method.DynamicInvoke(tme.args);
    }

    private void InvokeMarshaledCallbacks()
    {
      Control.ThreadMethodEntry tme = (Control.ThreadMethodEntry) null;
      lock (this.threadCallbackList)
      {
        if (this.threadCallbackList.Count > 0)
          tme = (Control.ThreadMethodEntry) this.threadCallbackList.Dequeue();
      }
      while (tme != null)
      {
        if (tme.method != null)
        {
          try
          {
            if (NativeWindow.WndProcShouldBeDebuggable)
            {
              if (!tme.synchronous)
              {
                this.InvokeMarshaledCallback(tme);
                goto label_15;
              }
            }
            try
            {
              this.InvokeMarshaledCallback(tme);
            }
            catch (Exception ex)
            {
              tme.exception = ex.GetBaseException();
            }
          }
          finally
          {
            tme.Complete();
            if (!NativeWindow.WndProcShouldBeDebuggable && tme.exception != null && !tme.synchronous)
              Application.OnThreadException(tme.exception);
          }
        }
label_15:
        lock (this.threadCallbackList)
          tme = this.threadCallbackList.Count <= 0 ? (Control.ThreadMethodEntry) null : (Control.ThreadMethodEntry) this.threadCallbackList.Dequeue();
      }
    }

    internal bool IsFontSet()
    {
      return (Font) this.Properties.GetObject(Control.PropFont) != null;
    }

    internal bool IsDescendant(Control descendant)
    {
      for (Control control = descendant; control != null; control = control.ParentInternal)
      {
        if (control == this)
          return true;
      }
      return false;
    }

    private void ListenToUserPreferenceChanged(bool listen)
    {
      if (this.GetState2(4))
      {
        if (listen)
          return;
        this.SetState2(4, false);
        SystemEvents.UserPreferenceChanged -= new UserPreferenceChangedEventHandler(this.UserPreferenceChanged);
      }
      else
      {
        if (!listen)
          return;
        this.SetState2(4, true);
        SystemEvents.UserPreferenceChanged += new UserPreferenceChangedEventHandler(this.UserPreferenceChanged);
      }
    }

    private object MarshaledInvoke(Control caller, Delegate method, object[] args, bool synchronous)
    {
      if (!this.IsHandleCreated)
        throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ErrorNoMarshalingThread"));
      if ((Control.ActiveXImpl) this.Properties.GetObject(Control.PropActiveXImpl) != null)
        System.Windows.Forms.IntSecurity.UnmanagedCode.Demand();
      bool flag = false;
      int lpdwProcessId;
      if (System.Windows.Forms.SafeNativeMethods.GetWindowThreadProcessId(new HandleRef((object) this, this.Handle), out lpdwProcessId) == System.Windows.Forms.SafeNativeMethods.GetCurrentThreadId() && synchronous)
        flag = true;
      ExecutionContext executionContext = (ExecutionContext) null;
      if (!flag)
        executionContext = ExecutionContext.Capture();
      Control.ThreadMethodEntry threadMethodEntry = new Control.ThreadMethodEntry(caller, this, method, args, synchronous, executionContext);
      lock (this)
      {
        if (this.threadCallbackList == null)
          this.threadCallbackList = new Queue();
      }
      lock (this.threadCallbackList)
      {
        if (Control.threadCallbackMessage == 0)
          Control.threadCallbackMessage = System.Windows.Forms.SafeNativeMethods.RegisterWindowMessage(Application.WindowMessagesVersion + "_ThreadCallbackMessage");
        this.threadCallbackList.Enqueue((object) threadMethodEntry);
      }
      if (flag)
        this.InvokeMarshaledCallbacks();
      else
        System.Windows.Forms.UnsafeNativeMethods.PostMessage(new HandleRef((object) this, this.Handle), Control.threadCallbackMessage, IntPtr.Zero, IntPtr.Zero);
      if (!synchronous)
        return (object) threadMethodEntry;
      if (!threadMethodEntry.IsCompleted)
        this.WaitForWaitHandle(threadMethodEntry.AsyncWaitHandle);
      if (threadMethodEntry.exception != null)
        throw threadMethodEntry.exception;
      else
        return threadMethodEntry.retVal;
    }

    private void MarshalStringToMessage(string value, ref Message m)
    {
      if (m.LParam == IntPtr.Zero)
        m.Result = (IntPtr) ((value.Length + 1) * Marshal.SystemDefaultCharSize);
      else if ((int) (long) m.WParam < value.Length + 1)
      {
        m.Result = (IntPtr) -1;
      }
      else
      {
        char[] chars = new char[1];
        byte[] bytes1;
        byte[] bytes2;
        if (Marshal.SystemDefaultCharSize == 1)
        {
          bytes1 = Encoding.Default.GetBytes(value);
          bytes2 = Encoding.Default.GetBytes(chars);
        }
        else
        {
          bytes1 = Encoding.Unicode.GetBytes(value);
          bytes2 = Encoding.Unicode.GetBytes(chars);
        }
        Marshal.Copy(bytes1, 0, m.LParam, bytes1.Length);
        Marshal.Copy(bytes2, 0, (IntPtr) ((long) m.LParam + (long) bytes1.Length), bytes2.Length);
        m.Result = (IntPtr) ((bytes1.Length + bytes2.Length) / Marshal.SystemDefaultCharSize);
      }
    }

    internal void NotifyEnter()
    {
      this.OnEnter(EventArgs.Empty);
    }

    internal void NotifyLeave()
    {
      this.OnLeave(EventArgs.Empty);
    }

    private bool NotifyValidating()
    {
      CancelEventArgs e = new CancelEventArgs();
      this.OnValidating(e);
      return e.Cancel;
    }

    private void NotifyValidated()
    {
      this.OnValidated(EventArgs.Empty);
    }

    private void OnSetScrollPosition(object sender, EventArgs e)
    {
      this.SetState2(1, false);
      this.OnInvokedSetScrollPosition(sender, e);
    }

    private void OnParentInvalidated(InvalidateEventArgs e)
    {
      if (!this.RenderTransparent || !this.IsHandleCreated)
        return;
      Rectangle rectangle = e.InvalidRect;
      Point location = this.Location;
      rectangle.Offset(-location.X, -location.Y);
      rectangle = Rectangle.Intersect(this.ClientRectangle, rectangle);
      if (rectangle.IsEmpty)
        return;
      this.Invalidate(rectangle);
    }

    internal void PaintBackground(PaintEventArgs e, Rectangle rectangle)
    {
      this.PaintBackground(e, rectangle, this.BackColor, Point.Empty);
    }

    internal void PaintBackground(PaintEventArgs e, Rectangle rectangle, System.Drawing.Color backColor)
    {
      this.PaintBackground(e, rectangle, backColor, Point.Empty);
    }

    internal void PaintBackground(PaintEventArgs e, Rectangle rectangle, System.Drawing.Color backColor, Point scrollOffset)
    {
      if (this.RenderColorTransparent(backColor))
        this.PaintTransparentBackground(e, rectangle);
      if (this.BackgroundImage != null && !DisplayInformation.HighContrast && (!(this is Form) && !(this is MdiClient) || !this.IsMirrored))
      {
        if (this.BackgroundImageLayout == ImageLayout.Tile && ControlPaint.IsImageTransparent(this.BackgroundImage))
          this.PaintTransparentBackground(e, rectangle);
        Point scrollOffset1 = scrollOffset;
        if (this is ScrollableControl && scrollOffset1 != Point.Empty)
          scrollOffset1 = ((ScrollableControl) this).AutoScrollPosition;
        if (ControlPaint.IsImageTransparent(this.BackgroundImage))
          Control.PaintBackColor(e, rectangle, backColor);
        ControlPaint.DrawBackgroundImage(e.Graphics, this.BackgroundImage, backColor, this.BackgroundImageLayout, this.ClientRectangle, rectangle, scrollOffset1, this.RightToLeft);
      }
      else
        Control.PaintBackColor(e, rectangle, backColor);
    }

    private static void PaintBackColor(PaintEventArgs e, Rectangle rectangle, System.Drawing.Color backColor)
    {
      System.Drawing.Color color = backColor;
      if ((int) color.A == (int) byte.MaxValue)
      {
        using (WindowsGraphics windowsGraphics = !(e.HDC != IntPtr.Zero) || (int) DisplayInformation.BitsPerPixel <= 8 ? WindowsGraphics.FromGraphics(e.Graphics) : WindowsGraphics.FromHdc(e.HDC))
        {
          System.Drawing.Color nearestColor = windowsGraphics.GetNearestColor(color);
          using (WindowsBrush brush = (WindowsBrush) new WindowsSolidBrush(windowsGraphics.DeviceContext, nearestColor))
            windowsGraphics.FillRectangle(brush, rectangle);
        }
      }
      else
      {
        if ((int) color.A <= 0)
          return;
        using (Brush brush = (Brush) new SolidBrush(color))
          e.Graphics.FillRectangle(brush, rectangle);
      }
    }

    private void PaintException(PaintEventArgs e)
    {
      using (Pen pen = new Pen(System.Drawing.Color.Red, 2f))
      {
        Rectangle clientRectangle = this.ClientRectangle;
        Rectangle rect = clientRectangle;
        ++rect.X;
        ++rect.Y;
        --rect.Width;
        --rect.Height;
        e.Graphics.DrawRectangle(pen, rect.X, rect.Y, rect.Width - 1, rect.Height - 1);
        rect.Inflate(-1, -1);
        e.Graphics.FillRectangle(Brushes.White, rect);
        e.Graphics.DrawLine(pen, clientRectangle.Left, clientRectangle.Top, clientRectangle.Right, clientRectangle.Bottom);
        e.Graphics.DrawLine(pen, clientRectangle.Left, clientRectangle.Bottom, clientRectangle.Right, clientRectangle.Top);
      }
    }

    internal void PaintTransparentBackground(PaintEventArgs e, Rectangle rectangle)
    {
      this.PaintTransparentBackground(e, rectangle, (Region) null);
    }

    internal void PaintTransparentBackground(PaintEventArgs e, Rectangle rectangle, Region transparentRegion)
    {
      Graphics graphics = e.Graphics;
      Control parentInternal = this.ParentInternal;
      if (parentInternal != null)
      {
        if (Application.RenderWithVisualStyles && parentInternal.RenderTransparencyWithVisualStyles)
        {
          System.Drawing.Drawing2D.GraphicsState gstate = (System.Drawing.Drawing2D.GraphicsState) null;
          if (transparentRegion != null)
            gstate = graphics.Save();
          try
          {
            if (transparentRegion != null)
              graphics.Clip = transparentRegion;
            ButtonRenderer.DrawParentBackground(graphics, rectangle, this);
          }
          finally
          {
            if (gstate != null)
              graphics.Restore(gstate);
          }
        }
        else
        {
          Rectangle rectangle1 = new Rectangle(-this.Left, -this.Top, parentInternal.Width, parentInternal.Height);
          Rectangle clipRect = new Rectangle(rectangle.Left + this.Left, rectangle.Top + this.Top, rectangle.Width, rectangle.Height);
          using (WindowsGraphics windowsGraphics = WindowsGraphics.FromGraphics(graphics))
          {
            windowsGraphics.DeviceContext.TranslateTransform(-this.Left, -this.Top);
            using (PaintEventArgs e1 = new PaintEventArgs(windowsGraphics.GetHdc(), clipRect))
            {
              if (transparentRegion != null)
              {
                e1.Graphics.Clip = transparentRegion;
                e1.Graphics.TranslateClip(-rectangle1.X, -rectangle1.Y);
              }
              try
              {
                this.InvokePaintBackground(parentInternal, e1);
                this.InvokePaint(parentInternal, e1);
              }
              finally
              {
                if (transparentRegion != null)
                  e1.Graphics.TranslateClip(rectangle1.X, rectangle1.Y);
              }
            }
          }
        }
      }
      else
        graphics.FillRectangle(SystemBrushes.Control, rectangle);
    }

    private void PaintWithErrorHandling(PaintEventArgs e, short layer)
    {
      try
      {
        this.CacheTextInternal = true;
        if (this.GetState(4194304))
        {
          if ((int) layer != 1)
            return;
          this.PaintException(e);
        }
        else
        {
          bool flag = true;
          try
          {
            switch (layer)
            {
              case (short) 1:
                if (!this.GetStyle(ControlStyles.Opaque))
                {
                  this.OnPaintBackground(e);
                  break;
                }
                else
                  break;
              case (short) 2:
                this.OnPaint(e);
                break;
            }
            flag = false;
          }
          finally
          {
            if (flag)
            {
              this.SetState(4194304, true);
              this.Invalidate();
            }
          }
        }
      }
      finally
      {
        this.CacheTextInternal = false;
      }
    }

    internal void PerformLayout(LayoutEventArgs args)
    {
      if (this.GetAnyDisposingInHierarchy())
        return;
      if ((int) this.layoutSuspendCount > 0)
      {
        this.SetState(512, true);
        if (this.cachedLayoutEventArgs == null || this.GetState2(64) && args != null)
        {
          this.cachedLayoutEventArgs = args;
          if (this.GetState2(64))
            this.SetState2(64, false);
        }
        this.LayoutEngine.ProcessSuspendedLayoutEventArgs((IArrangedElement) this, args);
      }
      else
      {
        this.layoutSuspendCount = (byte) 1;
        try
        {
          this.CacheTextInternal = true;
          this.OnLayout(args);
        }
        finally
        {
          this.CacheTextInternal = false;
          this.SetState(8389120, false);
          this.layoutSuspendCount = (byte) 0;
          if (this.ParentInternal != null && this.ParentInternal.GetState(8388608))
            LayoutTransaction.DoLayout((IArrangedElement) this.ParentInternal, (IArrangedElement) this, PropertyNames.PreferredSize);
        }
      }
    }

    internal bool PerformControlValidation(bool bulkValidation)
    {
      if (!this.CausesValidation)
        return false;
      if (this.NotifyValidating())
        return true;
      if (!bulkValidation)
      {
        if (!NativeWindow.WndProcShouldBeDebuggable)
        {
          try
          {
            this.NotifyValidated();
            goto label_9;
          }
          catch (Exception ex)
          {
            Application.OnThreadException(ex);
            goto label_9;
          }
        }
      }
      this.NotifyValidated();
label_9:
      return false;
    }

    internal bool PerformContainerValidation(ValidationConstraints validationConstraints)
    {
      bool flag = false;
      foreach (Control control in (ArrangedElementCollection) this.Controls)
      {
        if ((validationConstraints & ValidationConstraints.ImmediateChildren) != ValidationConstraints.ImmediateChildren && control.ShouldPerformContainerValidation() && control.PerformContainerValidation(validationConstraints))
          flag = true;
        if (((validationConstraints & ValidationConstraints.Selectable) != ValidationConstraints.Selectable || control.GetStyle(ControlStyles.Selectable)) && ((validationConstraints & ValidationConstraints.Enabled) != ValidationConstraints.Enabled || control.Enabled) && (((validationConstraints & ValidationConstraints.Visible) != ValidationConstraints.Visible || control.Visible) && ((validationConstraints & ValidationConstraints.TabStop) != ValidationConstraints.TabStop || control.TabStop)) && control.PerformControlValidation(true))
          flag = true;
      }
      return flag;
    }

    private void PrintToMetaFile(HandleRef hDC, IntPtr lParam)
    {
      lParam = (IntPtr) ((long) lParam & -17L);
      System.Windows.Forms.NativeMethods.POINT point = new System.Windows.Forms.NativeMethods.POINT();
      System.Windows.Forms.SafeNativeMethods.GetViewportOrgEx(hDC, point);
      HandleRef handleRef = new HandleRef((object) null, System.Windows.Forms.SafeNativeMethods.CreateRectRgn(point.x, point.y, point.x + this.Width, point.y + this.Height));
      try
      {
        System.Windows.Forms.SafeNativeMethods.SelectClipRgn(hDC, handleRef);
        this.PrintToMetaFileRecursive(hDC, lParam, new Rectangle(Point.Empty, this.Size));
      }
      finally
      {
        System.Windows.Forms.SafeNativeMethods.DeleteObject(handleRef);
      }
    }

    private void PrintToMetaFile_SendPrintMessage(HandleRef hDC, IntPtr lParam)
    {
      if (this.GetStyle(ControlStyles.UserPaint))
      {
        this.SendMessage(791, hDC.Handle, lParam);
      }
      else
      {
        if (this.Controls.Count == 0)
          lParam = (IntPtr) ((long) lParam | 16L);
        using (Control.MetafileDCWrapper metafileDcWrapper = new Control.MetafileDCWrapper(hDC, this.Size))
          this.SendMessage(791, metafileDcWrapper.HDC, lParam);
      }
    }

    internal void ProcessUICues(ref Message msg)
    {
      Keys keys = (Keys) ((int) msg.WParam & (int) ushort.MaxValue);
      switch (keys)
      {
        case Keys.F10:
        case Keys.Menu:
        case Keys.Tab:
          Control control = (Control) null;
          int num1 = (int) (long) this.SendMessage(297, 0, 0);
          if (num1 == 0)
          {
            control = this.TopMostParent;
            num1 = (int) control.SendMessage(297, 0, 0);
          }
          int num2 = 0;
          if ((keys == Keys.F10 || keys == Keys.Menu) && (num1 & 2) != 0)
            num2 |= 2;
          if (keys == Keys.Tab && (num1 & 1) != 0)
            num2 |= 1;
          if (num2 == 0)
            break;
          if (control == null)
            control = this.TopMostParent;
          System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) control, control.Handle), System.Windows.Forms.UnsafeNativeMethods.GetParent(new HandleRef((object) null, control.Handle)) == IntPtr.Zero ? 295 : 296, (IntPtr) (2 | num2 << 16), IntPtr.Zero);
          break;
      }
    }

    private void RemovePendingMessages(int msgMin, int msgMax)
    {
      if (this.IsDisposed)
        return;
      System.Windows.Forms.NativeMethods.MSG msg = new System.Windows.Forms.NativeMethods.MSG();
      IntPtr handle = this.Handle;
      do
        ;
      while (System.Windows.Forms.UnsafeNativeMethods.PeekMessage(out msg, new HandleRef((object) this, handle), msgMin, msgMax, 1));
    }

    private void ResetEnabled()
    {
      this.Enabled = true;
    }

    private void ResetLocation()
    {
      this.Location = new Point(0, 0);
    }

    private void ResetMargin()
    {
      this.Margin = this.DefaultMargin;
    }

    private void ResetMinimumSize()
    {
      this.MinimumSize = this.DefaultMinimumSize;
    }

    private void ResetPadding()
    {
      CommonProperties.ResetPadding((IArrangedElement) this);
    }

    private void ResetSize()
    {
      this.Size = this.DefaultSize;
    }

    internal static bool ReflectMessageInternal(IntPtr hWnd, ref Message m)
    {
      Control control = Control.FromHandleInternal(hWnd);
      if (control == null)
        return false;
      m.Result = control.SendMessage(8192 + m.Msg, m.WParam, m.LParam);
      return true;
    }

    private void ResetVisible()
    {
      this.Visible = true;
    }

    internal void SetAcceptDrops(bool accept)
    {
      if (accept == this.GetState(128))
        return;
      if (!this.IsHandleCreated)
        return;
      try
      {
        if (Application.OleRequired() != ApartmentState.STA)
          throw new ThreadStateException(System.Windows.Forms.SR.GetString("ThreadMustBeSTA"));
        if (accept)
        {
          System.Windows.Forms.IntSecurity.ClipboardRead.Demand();
          int error = System.Windows.Forms.UnsafeNativeMethods.RegisterDragDrop(new HandleRef((object) this, this.Handle), (System.Windows.Forms.UnsafeNativeMethods.IOleDropTarget) new DropTarget((IDropTarget) this));
          switch (error)
          {
            case 0:
            case -2147221247:
              break;
            default:
              throw new Win32Exception(error);
          }
        }
        else
        {
          int error = System.Windows.Forms.UnsafeNativeMethods.RevokeDragDrop(new HandleRef((object) this, this.Handle));
          switch (error)
          {
            case 0:
            case -2147221248:
              break;
            default:
              throw new Win32Exception(error);
          }
        }
        this.SetState(128, accept);
      }
      catch (Exception ex)
      {
        throw new InvalidOperationException(System.Windows.Forms.SR.GetString("DragDropRegFailed"), ex);
      }
    }

    internal void ScaleChildControls(SizeF includedFactor, SizeF excludedFactor, Control requestingControl)
    {
      if (!this.ScaleChildren)
        return;
      Control.ControlCollection controlCollection = (Control.ControlCollection) this.Properties.GetObject(Control.PropControlsCollection);
      if (controlCollection == null)
        return;
      for (int index = 0; index < controlCollection.Count; ++index)
        controlCollection[index].Scale(includedFactor, excludedFactor, requestingControl);
    }

    internal void ScaleControl(SizeF includedFactor, SizeF excludedFactor, Control requestingControl)
    {
      BoundsSpecified specified1 = BoundsSpecified.None;
      BoundsSpecified specified2 = BoundsSpecified.None;
      if (!includedFactor.IsEmpty)
        specified1 = this.RequiredScaling;
      if (!excludedFactor.IsEmpty)
        specified2 |= ~this.RequiredScaling & BoundsSpecified.All;
      if (specified1 != BoundsSpecified.None)
        this.ScaleControl(includedFactor, specified1);
      if (specified2 != BoundsSpecified.None)
        this.ScaleControl(excludedFactor, specified2);
      if (includedFactor.IsEmpty)
        return;
      this.RequiredScaling = BoundsSpecified.None;
    }

    internal Size ScaleSize(Size startSize, float x, float y)
    {
      Size size = startSize;
      if (!this.GetStyle(ControlStyles.FixedWidth))
        size.Width = (int) Math.Round((double) size.Width * (double) x);
      if (!this.GetStyle(ControlStyles.FixedHeight))
        size.Height = (int) Math.Round((double) size.Height * (double) y);
      return size;
    }

    internal bool SelectNextControlInternal(Control ctl, bool forward, bool tabStopOnly, bool nested, bool wrap)
    {
      System.Windows.Forms.IntSecurity.ModifyFocus.Assert();
      return this.SelectNextControl(ctl, forward, tabStopOnly, nested, wrap);
    }

    private void SelectNextIfFocused()
    {
      if (!this.ContainsFocus || this.ParentInternal == null)
        return;
      IContainerControl containerControlInternal = this.ParentInternal.GetContainerControlInternal();
      if (containerControlInternal == null)
        return;
      ((Control) containerControlInternal).SelectNextControlInternal(this, true, true, true, true);
    }

    internal IntPtr SendMessage(int msg, int wparam, int lparam)
    {
      return System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), msg, wparam, lparam);
    }

    internal IntPtr SendMessage(int msg, ref int wparam, ref int lparam)
    {
      return System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), msg, ref wparam, ref lparam);
    }

    internal IntPtr SendMessage(int msg, int wparam, IntPtr lparam)
    {
      return System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), msg, (IntPtr) wparam, lparam);
    }

    internal IntPtr SendMessage(int msg, IntPtr wparam, IntPtr lparam)
    {
      return System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), msg, wparam, lparam);
    }

    internal IntPtr SendMessage(int msg, IntPtr wparam, int lparam)
    {
      return System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), msg, wparam, (IntPtr) lparam);
    }

    internal IntPtr SendMessage(int msg, int wparam, ref System.Windows.Forms.NativeMethods.RECT lparam)
    {
      return System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), msg, wparam, out lparam);
    }

    internal IntPtr SendMessage(int msg, bool wparam, int lparam)
    {
      return System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), msg, wparam, lparam);
    }

    internal IntPtr SendMessage(int msg, int wparam, string lparam)
    {
      return System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) this, this.Handle), msg, wparam, lparam);
    }

    internal Size SizeFromClientSize(int width, int height)
    {
      System.Windows.Forms.NativeMethods.RECT lpRect = new System.Windows.Forms.NativeMethods.RECT(0, 0, width, height);
      CreateParams createParams = this.CreateParams;
      System.Windows.Forms.SafeNativeMethods.AdjustWindowRectEx(ref lpRect, createParams.Style, this.HasMenu, createParams.ExStyle);
      return lpRect.Size;
    }

    private void SetHandle(IntPtr value)
    {
      if (value == IntPtr.Zero)
        this.SetState(1, false);
      this.UpdateRoot();
    }

    private void SetParentHandle(IntPtr value)
    {
      if (!this.IsHandleCreated)
        return;
      IntPtr parent = System.Windows.Forms.UnsafeNativeMethods.GetParent(new HandleRef((object) this.window, this.Handle));
      bool topLevel = this.GetTopLevel();
      if (parent != value || parent == IntPtr.Zero && !topLevel)
      {
        bool flag = parent == IntPtr.Zero && !topLevel || value == IntPtr.Zero && topLevel;
        if (flag)
        {
          Form form = this as Form;
          if (form != null && !form.CanRecreateHandle())
          {
            flag = false;
            this.UpdateStyles();
          }
        }
        if (flag)
          this.RecreateHandle();
        if (this.GetTopLevel())
          return;
        if (value == IntPtr.Zero)
        {
          Application.ParkHandle(new HandleRef((object) this.window, this.Handle));
          this.UpdateRoot();
        }
        else
        {
          System.Windows.Forms.UnsafeNativeMethods.SetParent(new HandleRef((object) this.window, this.Handle), new HandleRef((object) null, value));
          if (this.parent != null)
            this.parent.UpdateChildZOrder(this);
          Application.UnparkHandle(new HandleRef((object) this.window, this.Handle));
        }
      }
      else
      {
        if (!(value == IntPtr.Zero) || !(parent == IntPtr.Zero) || !topLevel)
          return;
        System.Windows.Forms.UnsafeNativeMethods.SetParent(new HandleRef((object) this.window, this.Handle), new HandleRef((object) null, IntPtr.Zero));
        Application.UnparkHandle(new HandleRef((object) this.window, this.Handle));
      }
    }

    internal void SetState2(int flag, bool value)
    {
      this.state2 = value ? this.state2 | flag : this.state2 & ~flag;
    }

    internal static IntPtr SetUpPalette(IntPtr dc, bool force, bool realizePalette)
    {
      IntPtr halftonePalette = Graphics.GetHalftonePalette();
      IntPtr num = System.Windows.Forms.SafeNativeMethods.SelectPalette(new HandleRef((object) null, dc), new HandleRef((object) null, halftonePalette), force ? 0 : 1);
      if (num != IntPtr.Zero && realizePalette)
        System.Windows.Forms.SafeNativeMethods.RealizePalette(new HandleRef((object) null, dc));
      return num;
    }

    internal void SetTopLevelInternal(bool value)
    {
      if (this.GetTopLevel() == value)
        return;
      if (this.parent != null)
        throw new ArgumentException(System.Windows.Forms.SR.GetString("TopLevelParentedControl"), "value");
      this.SetState(524288, value);
      if (this.IsHandleCreated && this.GetState2(8))
        this.ListenToUserPreferenceChanged(value);
      this.UpdateStyles();
      this.SetParentHandle(IntPtr.Zero);
      if (value && this.Visible)
        this.CreateControl();
      this.UpdateRoot();
    }

    internal static AutoValidate GetAutoValidateForControl(Control control)
    {
      ContainerControl containerControl = control.ParentContainerControl;
      if (containerControl == null)
        return AutoValidate.EnablePreventFocusChange;
      else
        return containerControl.AutoValidate;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    private bool ShouldSerializeEnabled()
    {
      return !this.GetState(4);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    private bool ShouldSerializeVisible()
    {
      return !this.GetState(2);
    }

    private void SetWindowFont()
    {
      this.SendMessage(48, this.FontHandle, 0);
    }

    private void SetWindowStyle(int flag, bool value)
    {
      int num = (int) (long) System.Windows.Forms.UnsafeNativeMethods.GetWindowLong(new HandleRef((object) this, this.Handle), -16);
      System.Windows.Forms.UnsafeNativeMethods.SetWindowLong(new HandleRef((object) this, this.Handle), -16, new HandleRef((object) null, (IntPtr) (value ? num | flag : num & ~flag)));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal bool ShouldSerializeMargin()
    {
      return !this.Margin.Equals((object) this.DefaultMargin);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal bool ShouldSerializePadding()
    {
      return !this.Padding.Equals((object) this.DefaultPadding);
    }

    private void UnhookMouseEvent()
    {
      this.SetState(16384, false);
    }

    private void UpdateBindings()
    {
      for (int index = 0; index < this.DataBindings.Count; ++index)
        BindingContext.UpdateBinding(this.BindingContext, ((BindingsCollection) this.DataBindings)[index]);
    }

    private void UpdateChildControlIndex(Control ctl)
    {
      int newIndex = 0;
      int childIndex = this.Controls.GetChildIndex(ctl);
      IntPtr handle = ctl.InternalHandle;
      while ((handle = System.Windows.Forms.UnsafeNativeMethods.GetWindow(new HandleRef((object) null, handle), 3)) != IntPtr.Zero)
      {
        Control child = Control.FromHandleInternal(handle);
        if (child != null)
        {
          newIndex = this.Controls.GetChildIndex(child, false) + 1;
          break;
        }
      }
      if (newIndex > childIndex)
        --newIndex;
      if (newIndex == childIndex)
        return;
      this.Controls.SetChildIndex(ctl, newIndex);
    }

    private void UpdateReflectParent(bool findNewParent)
    {
      if (!this.Disposing && findNewParent && this.IsHandleCreated)
      {
        IntPtr parent = System.Windows.Forms.UnsafeNativeMethods.GetParent(new HandleRef((object) this, this.Handle));
        if (parent != IntPtr.Zero)
        {
          this.ReflectParent = Control.FromHandleInternal(parent);
          return;
        }
      }
      this.ReflectParent = (Control) null;
    }

    private void UpdateChildZOrder(Control ctl)
    {
      if (!this.IsHandleCreated || !ctl.IsHandleCreated || ctl.parent != this)
        return;
      IntPtr handle = (IntPtr) System.Windows.Forms.NativeMethods.HWND_TOP;
      int childIndex = this.Controls.GetChildIndex(ctl);
      while (--childIndex >= 0)
      {
        Control control = this.Controls[childIndex];
        if (control.IsHandleCreated && control.parent == this)
        {
          handle = control.Handle;
          break;
        }
      }
      if (!(System.Windows.Forms.UnsafeNativeMethods.GetWindow(new HandleRef((object) ctl.window, ctl.Handle), 3) != handle))
        return;
      this.state |= 256;
      try
      {
        System.Windows.Forms.SafeNativeMethods.SetWindowPos(new HandleRef((object) ctl.window, ctl.Handle), new HandleRef((object) null, handle), 0, 0, 0, 0, 3);
      }
      finally
      {
        this.state &= -257;
      }
    }

    private void UpdateRoot()
    {
      this.window.LockReference(this.GetTopLevel() && this.Visible);
    }

    private void UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs pref)
    {
      if (pref.Category != UserPreferenceCategory.Color)
        return;
      Control.defaultFont = (Font) null;
      this.OnSystemColorsChanged(EventArgs.Empty);
    }

    internal void WindowAssignHandle(IntPtr handle, bool value)
    {
      this.window.AssignHandle(handle, value);
    }

    internal void WindowReleaseHandle()
    {
      this.window.ReleaseHandle();
    }

    private void WmClose(ref Message m)
    {
      if (this.ParentInternal != null)
      {
        IntPtr handle1 = this.Handle;
        IntPtr handle2 = handle1;
        while (handle1 != IntPtr.Zero)
        {
          handle2 = handle1;
          handle1 = System.Windows.Forms.UnsafeNativeMethods.GetParent(new HandleRef((object) null, handle1));
          if (((int) (long) System.Windows.Forms.UnsafeNativeMethods.GetWindowLong(new HandleRef((object) null, handle2), -16) & 1073741824) == 0)
            break;
        }
        if (handle2 != IntPtr.Zero)
          System.Windows.Forms.UnsafeNativeMethods.PostMessage(new HandleRef((object) null, handle2), 16, IntPtr.Zero, IntPtr.Zero);
      }
      this.DefWndProc(ref m);
    }

    private void WmCaptureChanged(ref Message m)
    {
      this.OnMouseCaptureChanged(EventArgs.Empty);
      this.DefWndProc(ref m);
    }

    private void WmCommand(ref Message m)
    {
      if (IntPtr.Zero == m.LParam)
      {
        if (Command.DispatchID(System.Windows.Forms.NativeMethods.Util.LOWORD(m.WParam)))
          return;
      }
      else if (Control.ReflectMessageInternal(m.LParam, ref m))
        return;
      this.DefWndProc(ref m);
    }

    private void WmCtlColorControl(ref Message m)
    {
      Control control = Control.FromHandleInternal(m.LParam);
      if (control != null)
      {
        m.Result = control.InitializeDCForWmCtlColor(m.WParam, m.Msg);
        if (m.Result != IntPtr.Zero)
          return;
      }
      this.DefWndProc(ref m);
    }

    private void WmDisplayChange(ref Message m)
    {
      BufferedGraphicsManager.Current.Invalidate();
      this.DefWndProc(ref m);
    }

    private void WmDrawItem(ref Message m)
    {
      if (m.WParam == IntPtr.Zero)
        this.WmDrawItemMenuItem(ref m);
      else
        this.WmOwnerDraw(ref m);
    }

    private void WmDrawItemMenuItem(ref Message m)
    {
      MenuItem itemFromItemData = MenuItem.GetMenuItemFromItemData(((System.Windows.Forms.NativeMethods.DRAWITEMSTRUCT) m.GetLParam(typeof (System.Windows.Forms.NativeMethods.DRAWITEMSTRUCT))).itemData);
      if (itemFromItemData == null)
        return;
      itemFromItemData.WmDrawItem(ref m);
    }

    private void WmEraseBkgnd(ref Message m)
    {
      if (this.GetStyle(ControlStyles.UserPaint))
      {
        if (!this.GetStyle(ControlStyles.AllPaintingInWmPaint))
        {
          IntPtr wparam = m.WParam;
          if (wparam == IntPtr.Zero)
          {
            m.Result = (IntPtr) 0;
            return;
          }
          else
          {
            System.Windows.Forms.NativeMethods.RECT rect = new System.Windows.Forms.NativeMethods.RECT();
            System.Windows.Forms.UnsafeNativeMethods.GetClientRect(new HandleRef((object) this, this.Handle), out rect);
            using (PaintEventArgs e = new PaintEventArgs(wparam, Rectangle.FromLTRB(rect.left, rect.top, rect.right, rect.bottom)))
              this.PaintWithErrorHandling(e, (short) 1);
          }
        }
        m.Result = (IntPtr) 1;
      }
      else
        this.DefWndProc(ref m);
    }

    private void WmExitMenuLoop(ref Message m)
    {
      if ((int) (long) m.WParam != 0)
      {
        ContextMenu contextMenu = (ContextMenu) this.Properties.GetObject(Control.PropContextMenu);
        if (contextMenu != null)
          contextMenu.OnCollapse(EventArgs.Empty);
      }
      this.DefWndProc(ref m);
    }

    private void WmGetControlName(ref Message m)
    {
      this.MarshalStringToMessage((this.Site == null ? this.Name : this.Site.Name) ?? "", ref m);
    }

    private void WmGetControlType(ref Message m)
    {
      this.MarshalStringToMessage(this.GetType().AssemblyQualifiedName, ref m);
    }

    private void WmGetObject(ref Message m)
    {
      InternalAccessibleObject accessibleObject = (InternalAccessibleObject) null;
      AccessibleObject accessibilityObject = this.GetAccessibilityObject((int) (long) m.LParam);
      if (accessibilityObject != null)
      {
        System.Windows.Forms.IntSecurity.UnmanagedCode.Assert();
        try
        {
          accessibleObject = new InternalAccessibleObject(accessibilityObject);
        }
        finally
        {
          CodeAccessPermission.RevertAssert();
        }
      }
      if (accessibleObject != null)
      {
        Guid refiid = new Guid("{618736E0-3C3D-11CF-810C-00AA00389B71}");
        try
        {
          if ((object) accessibleObject is IAccessible)
            throw new InvalidOperationException(System.Windows.Forms.SR.GetString("ControlAccessibileObjectInvalid"));
          System.Windows.Forms.UnsafeNativeMethods.IAccessibleInternal accessibleInternal = (System.Windows.Forms.UnsafeNativeMethods.IAccessibleInternal) accessibleObject;
          if (accessibleInternal == null)
          {
            m.Result = (IntPtr) 0;
          }
          else
          {
            IntPtr iunknownForObject = Marshal.GetIUnknownForObject((object) accessibleInternal);
            System.Windows.Forms.IntSecurity.UnmanagedCode.Assert();
            try
            {
              m.Result = System.Windows.Forms.UnsafeNativeMethods.LresultFromObject(ref refiid, m.WParam, new HandleRef((object) accessibilityObject, iunknownForObject));
            }
            finally
            {
              CodeAccessPermission.RevertAssert();
              Marshal.Release(iunknownForObject);
            }
          }
        }
        catch (Exception ex)
        {
          throw new InvalidOperationException(System.Windows.Forms.SR.GetString("RichControlLresult"), ex);
        }
      }
      else
        this.DefWndProc(ref m);
    }

    private void WmHelp(ref Message m)
    {
      HelpInfo helpInfo = MessageBox.HelpInfo;
      if (helpInfo != null)
      {
        switch (helpInfo.Option)
        {
          case 1:
            Help.ShowHelp(this, helpInfo.HelpFilePath);
            break;
          case 2:
            Help.ShowHelp(this, helpInfo.HelpFilePath, helpInfo.Keyword);
            break;
          case 3:
            Help.ShowHelp(this, helpInfo.HelpFilePath, helpInfo.Navigator);
            break;
          case 4:
            Help.ShowHelp(this, helpInfo.HelpFilePath, helpInfo.Navigator, helpInfo.Param);
            break;
        }
      }
      System.Windows.Forms.NativeMethods.HELPINFO helpinfo = (System.Windows.Forms.NativeMethods.HELPINFO) m.GetLParam(typeof (System.Windows.Forms.NativeMethods.HELPINFO));
      HelpEventArgs hevent = new HelpEventArgs(new Point(helpinfo.MousePos.x, helpinfo.MousePos.y));
      this.OnHelpRequested(hevent);
      if (hevent.Handled)
        return;
      this.DefWndProc(ref m);
    }

    private void WmInitMenuPopup(ref Message m)
    {
      ContextMenu contextMenu = (ContextMenu) this.Properties.GetObject(Control.PropContextMenu);
      if (contextMenu != null && contextMenu.ProcessInitMenuPopup(m.WParam))
        return;
      this.DefWndProc(ref m);
    }

    private void WmMeasureItem(ref Message m)
    {
      if (m.WParam == IntPtr.Zero)
      {
        MenuItem itemFromItemData = MenuItem.GetMenuItemFromItemData(((System.Windows.Forms.NativeMethods.MEASUREITEMSTRUCT) m.GetLParam(typeof (System.Windows.Forms.NativeMethods.MEASUREITEMSTRUCT))).itemData);
        if (itemFromItemData == null)
          return;
        itemFromItemData.WmMeasureItem(ref m);
      }
      else
        this.WmOwnerDraw(ref m);
    }

    private void WmMenuChar(ref Message m)
    {
      Menu menu = (Menu) this.ContextMenu;
      if (menu == null)
        return;
      menu.WmMenuChar(ref m);
      int num = m.Result != IntPtr.Zero ? 1 : 0;
    }

    private void WmMenuSelect(ref Message m)
    {
      int id = System.Windows.Forms.NativeMethods.Util.LOWORD(m.WParam);
      int num = System.Windows.Forms.NativeMethods.Util.HIWORD(m.WParam);
      IntPtr lparam = m.LParam;
      MenuItem menuItem = (MenuItem) null;
      if ((num & 8192) == 0)
      {
        if ((num & 16) == 0)
        {
          Command commandFromId = Command.GetCommandFromID(id);
          if (commandFromId != null)
          {
            object target = commandFromId.Target;
            if (target != null && target is MenuItem.MenuItemData)
              menuItem = ((MenuItem.MenuItemData) target).baseItem;
          }
        }
        else
          menuItem = this.GetMenuItemFromHandleId(lparam, id);
      }
      if (menuItem != null)
        menuItem.PerformSelect();
      this.DefWndProc(ref m);
    }

    private void WmCreate(ref Message m)
    {
      this.DefWndProc(ref m);
      if (this.parent != null)
        this.parent.UpdateChildZOrder(this);
      this.UpdateBounds();
      this.OnHandleCreated(EventArgs.Empty);
      if (this.GetStyle(ControlStyles.CacheText))
        return;
      this.text = (string) null;
    }

    private void WmDestroy(ref Message m)
    {
      if (!this.RecreatingHandle && !this.Disposing && (!this.IsDisposed && this.GetState(16384)))
      {
        this.OnMouseLeave(EventArgs.Empty);
        this.UnhookMouseEvent();
      }
      this.OnHandleDestroyed(EventArgs.Empty);
      if (!this.Disposing)
      {
        if (!this.RecreatingHandle)
          this.SetState(1, false);
      }
      else
        this.SetState(2, false);
      this.DefWndProc(ref m);
    }

    private void WmKeyChar(ref Message m)
    {
      if (this.ProcessKeyMessage(ref m))
        return;
      this.DefWndProc(ref m);
    }

    private void WmKillFocus(ref Message m)
    {
      this.WmImeKillFocus();
      this.DefWndProc(ref m);
      this.OnLostFocus(EventArgs.Empty);
    }

    private void WmMouseDown(ref Message m, MouseButtons button, int clicks)
    {
      MouseButtons mouseButtons = Control.MouseButtons;
      this.SetState(134217728, true);
      if (!this.GetStyle(ControlStyles.UserMouse))
        this.DefWndProc(ref m);
      else if (button == MouseButtons.Left && this.GetStyle(ControlStyles.Selectable))
        this.FocusInternal();
      if (mouseButtons != Control.MouseButtons)
        return;
      if (!this.GetState2(16))
        this.CaptureInternal = true;
      if (mouseButtons != Control.MouseButtons || !this.Enabled)
        return;
      this.OnMouseDown(new MouseEventArgs(button, clicks, System.Windows.Forms.NativeMethods.Util.SignedLOWORD(m.LParam), System.Windows.Forms.NativeMethods.Util.SignedHIWORD(m.LParam), 0));
    }

    private void WmMouseEnter(ref Message m)
    {
      this.DefWndProc(ref m);
      this.OnMouseEnter(EventArgs.Empty);
    }

    private void WmMouseLeave(ref Message m)
    {
      this.DefWndProc(ref m);
      this.OnMouseLeave(EventArgs.Empty);
    }

    private void WmMouseHover(ref Message m)
    {
      this.DefWndProc(ref m);
      this.OnMouseHover(EventArgs.Empty);
    }

    private void WmMouseMove(ref Message m)
    {
      if (!this.GetStyle(ControlStyles.UserMouse))
        this.DefWndProc(ref m);
      this.OnMouseMove(new MouseEventArgs(Control.MouseButtons, 0, System.Windows.Forms.NativeMethods.Util.SignedLOWORD(m.LParam), System.Windows.Forms.NativeMethods.Util.SignedHIWORD(m.LParam), 0));
    }

    private void WmMouseUp(ref Message m, MouseButtons button, int clicks)
    {
      try
      {
        Point point = this.PointToScreen(new Point(System.Windows.Forms.NativeMethods.Util.SignedLOWORD(m.LParam), System.Windows.Forms.NativeMethods.Util.SignedHIWORD(m.LParam)));
        if (!this.GetStyle(ControlStyles.UserMouse))
          this.DefWndProc(ref m);
        else if (button == MouseButtons.Right)
          this.SendMessage(123, this.Handle, System.Windows.Forms.NativeMethods.Util.MAKELPARAM(point.X, point.Y));
        bool flag = false;
        if ((this.controlStyle & ControlStyles.StandardClick) == ControlStyles.StandardClick && this.GetState(134217728) && (!this.IsDisposed && System.Windows.Forms.UnsafeNativeMethods.WindowFromPoint(point.X, point.Y) == this.Handle))
          flag = true;
        if (flag && !this.ValidationCancelled)
        {
          if (!this.GetState(67108864))
          {
            this.OnClick((EventArgs) new MouseEventArgs(button, clicks, System.Windows.Forms.NativeMethods.Util.SignedLOWORD(m.LParam), System.Windows.Forms.NativeMethods.Util.SignedHIWORD(m.LParam), 0));
            this.OnMouseClick(new MouseEventArgs(button, clicks, System.Windows.Forms.NativeMethods.Util.SignedLOWORD(m.LParam), System.Windows.Forms.NativeMethods.Util.SignedHIWORD(m.LParam), 0));
          }
          else
          {
            this.OnDoubleClick((EventArgs) new MouseEventArgs(button, 2, System.Windows.Forms.NativeMethods.Util.SignedLOWORD(m.LParam), System.Windows.Forms.NativeMethods.Util.SignedHIWORD(m.LParam), 0));
            this.OnMouseDoubleClick(new MouseEventArgs(button, 2, System.Windows.Forms.NativeMethods.Util.SignedLOWORD(m.LParam), System.Windows.Forms.NativeMethods.Util.SignedHIWORD(m.LParam), 0));
          }
        }
        this.OnMouseUp(new MouseEventArgs(button, clicks, System.Windows.Forms.NativeMethods.Util.SignedLOWORD(m.LParam), System.Windows.Forms.NativeMethods.Util.SignedHIWORD(m.LParam), 0));
      }
      finally
      {
        this.SetState(67108864, false);
        this.SetState(134217728, false);
        this.SetState(268435456, false);
        this.CaptureInternal = false;
      }
    }

    private void WmMouseWheel(ref Message m)
    {
      Point point = this.PointToClient(new Point(System.Windows.Forms.NativeMethods.Util.SignedLOWORD(m.LParam), System.Windows.Forms.NativeMethods.Util.SignedHIWORD(m.LParam)));
      HandledMouseEventArgs handledMouseEventArgs = new HandledMouseEventArgs(MouseButtons.None, 0, point.X, point.Y, System.Windows.Forms.NativeMethods.Util.SignedHIWORD(m.WParam));
      this.OnMouseWheel((MouseEventArgs) handledMouseEventArgs);
      m.Result = (IntPtr) (handledMouseEventArgs.Handled ? 0 : 1);
      if (handledMouseEventArgs.Handled)
        return;
      this.DefWndProc(ref m);
    }

    private void WmMove(ref Message m)
    {
      this.DefWndProc(ref m);
      this.UpdateBounds();
    }

    private unsafe void WmNotify(ref Message m)
    {
      System.Windows.Forms.NativeMethods.NMHDR* nmhdrPtr = (System.Windows.Forms.NativeMethods.NMHDR*) (void*) m.LParam;
      if (Control.ReflectMessageInternal(nmhdrPtr->hwndFrom, ref m))
        return;
      if (nmhdrPtr->code == -521)
      {
        m.Result = System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) null, nmhdrPtr->hwndFrom), 8192 + m.Msg, m.WParam, m.LParam);
      }
      else
      {
        if (nmhdrPtr->code == -522)
          System.Windows.Forms.UnsafeNativeMethods.SendMessage(new HandleRef((object) null, nmhdrPtr->hwndFrom), 8192 + m.Msg, m.WParam, m.LParam);
        this.DefWndProc(ref m);
      }
    }

    private void WmNotifyFormat(ref Message m)
    {
      if (Control.ReflectMessageInternal(m.WParam, ref m))
        return;
      this.DefWndProc(ref m);
    }

    private void WmOwnerDraw(ref Message m)
    {
      bool flag = false;
      IntPtr hWnd = System.Windows.Forms.UnsafeNativeMethods.GetDlgItem(new HandleRef((object) null, m.HWnd), (int) (long) m.WParam);
      if (hWnd == IntPtr.Zero)
        hWnd = m.WParam;
      if (!Control.ReflectMessageInternal(hWnd, ref m))
      {
        IntPtr handleFromId = this.window.GetHandleFromID((short) System.Windows.Forms.NativeMethods.Util.LOWORD(m.WParam));
        if (handleFromId != IntPtr.Zero)
        {
          Control control = Control.FromHandleInternal(handleFromId);
          if (control != null)
          {
            m.Result = control.SendMessage(8192 + m.Msg, handleFromId, m.LParam);
            flag = true;
          }
        }
      }
      else
        flag = true;
      if (flag)
        return;
      this.DefWndProc(ref m);
    }

    private void WmPaint(ref Message m)
    {
      bool flag1 = this.DoubleBuffered || this.GetStyle(ControlStyles.AllPaintingInWmPaint) && this.DoubleBufferingEnabled;
      IntPtr handle1 = IntPtr.Zero;
      System.Windows.Forms.NativeMethods.PAINTSTRUCT lpPaint = new System.Windows.Forms.NativeMethods.PAINTSTRUCT();
      bool flag2 = false;
      try
      {
        IntPtr num;
        Rectangle rectangle;
        if (m.WParam == IntPtr.Zero)
        {
          handle1 = this.Handle;
          num = System.Windows.Forms.UnsafeNativeMethods.BeginPaint(new HandleRef((object) this, handle1), out lpPaint);
          flag2 = true;
          rectangle = new Rectangle(lpPaint.rcPaint_left, lpPaint.rcPaint_top, lpPaint.rcPaint_right - lpPaint.rcPaint_left, lpPaint.rcPaint_bottom - lpPaint.rcPaint_top);
        }
        else
        {
          num = m.WParam;
          rectangle = this.ClientRectangle;
        }
        if (flag1 && (rectangle.Width <= 0 || rectangle.Height <= 0))
          return;
        IntPtr handle2 = IntPtr.Zero;
        BufferedGraphics bufferedGraphics = (BufferedGraphics) null;
        System.Drawing.Drawing2D.GraphicsState gstate = (System.Drawing.Drawing2D.GraphicsState) null;
        try
        {
          if (flag1 || m.WParam == IntPtr.Zero)
            handle2 = Control.SetUpPalette(num, false, false);
          if (flag1)
          {
            try
            {
              bufferedGraphics = this.BufferContext.Allocate(num, this.ClientRectangle);
            }
            catch (Exception ex)
            {
              if (System.Windows.Forms.ClientUtils.IsCriticalException(ex))
                throw;
              else
                flag1 = false;
            }
          }
          PaintEventArgs e;
          if (bufferedGraphics != null)
          {
            bufferedGraphics.Graphics.SetClip(rectangle);
            e = new PaintEventArgs(bufferedGraphics.Graphics, rectangle);
            gstate = e.Graphics.Save();
          }
          else
            e = new PaintEventArgs(num, rectangle);
          using (e)
          {
            try
            {
              if (!(m.WParam == IntPtr.Zero) || !this.GetStyle(ControlStyles.AllPaintingInWmPaint))
              {
                if (!flag1)
                  goto label_24;
              }
              this.PaintWithErrorHandling(e, (short) 1);
            }
            finally
            {
              if (gstate != null)
                e.Graphics.Restore(gstate);
              else
                e.ResetGraphics();
            }
label_24:
            this.PaintWithErrorHandling(e, (short) 2);
            if (bufferedGraphics == null)
              return;
            bufferedGraphics.Render();
          }
        }
        finally
        {
          if (handle2 != IntPtr.Zero)
            System.Windows.Forms.SafeNativeMethods.SelectPalette(new HandleRef((object) null, num), new HandleRef((object) null, handle2), 0);
          if (bufferedGraphics != null)
            bufferedGraphics.Dispose();
        }
      }
      finally
      {
        if (flag2)
          System.Windows.Forms.UnsafeNativeMethods.EndPaint(new HandleRef((object) this, handle1), ref lpPaint);
      }
    }

    private void WmPrintClient(ref Message m)
    {
      using (PaintEventArgs e = (PaintEventArgs) new Control.PrintPaintEventArgs(m, m.WParam, this.ClientRectangle))
        this.OnPrint(e);
    }

    private void WmQueryNewPalette(ref Message m)
    {
      IntPtr dc = System.Windows.Forms.UnsafeNativeMethods.GetDC(new HandleRef((object) this, this.Handle));
      try
      {
        Control.SetUpPalette(dc, true, true);
      }
      finally
      {
        System.Windows.Forms.UnsafeNativeMethods.ReleaseDC(new HandleRef((object) this, this.Handle), new HandleRef((object) null, dc));
      }
      this.Invalidate(true);
      m.Result = (IntPtr) 1;
      this.DefWndProc(ref m);
    }

    private void WmSetCursor(ref Message m)
    {
      if (m.WParam == this.InternalHandle && System.Windows.Forms.NativeMethods.Util.LOWORD(m.LParam) == 1)
        Cursor.CurrentInternal = this.Cursor;
      else
        this.DefWndProc(ref m);
    }

    private unsafe void WmWindowPosChanging(ref Message m)
    {
      if (this.IsActiveX)
      {
        System.Windows.Forms.NativeMethods.WINDOWPOS* windowposPtr = (System.Windows.Forms.NativeMethods.WINDOWPOS*) (void*) m.LParam;
        bool flag = false;
        if ((windowposPtr->flags & 2) == 0 && (windowposPtr->x != this.Left || windowposPtr->y != this.Top))
          flag = true;
        if ((windowposPtr->flags & 1) == 0 && (windowposPtr->cx != this.Width || windowposPtr->cy != this.Height))
          flag = true;
        if (flag)
          this.ActiveXUpdateBounds(ref windowposPtr->x, ref windowposPtr->y, ref windowposPtr->cx, ref windowposPtr->cy, windowposPtr->flags);
      }
      this.DefWndProc(ref m);
    }

    private void WmParentNotify(ref Message m)
    {
      int num = System.Windows.Forms.NativeMethods.Util.LOWORD(m.WParam);
      IntPtr hWnd = IntPtr.Zero;
      switch (num)
      {
        case 1:
          hWnd = m.LParam;
          goto case 2;
        case 2:
          if (!(hWnd == IntPtr.Zero) && Control.ReflectMessageInternal(hWnd, ref m))
            break;
          this.DefWndProc(ref m);
          break;
        default:
          hWnd = System.Windows.Forms.UnsafeNativeMethods.GetDlgItem(new HandleRef((object) this, this.Handle), System.Windows.Forms.NativeMethods.Util.HIWORD(m.WParam));
          goto case 2;
      }
    }

    private void WmSetFocus(ref Message m)
    {
      this.WmImeSetFocus();
      if (!this.HostedInWin32DialogManager)
      {
        IContainerControl containerControlInternal = this.GetContainerControlInternal();
        if (containerControlInternal != null)
        {
          ContainerControl containerControl = containerControlInternal as ContainerControl;
          bool flag;
          if (containerControl != null)
          {
            flag = containerControl.ActivateControlInternal(this);
          }
          else
          {
            System.Windows.Forms.IntSecurity.ModifyFocus.Assert();
            try
            {
              flag = containerControlInternal.ActivateControl(this);
            }
            finally
            {
              CodeAccessPermission.RevertAssert();
            }
          }
          if (!flag)
            return;
        }
      }
      this.DefWndProc(ref m);
      this.OnGotFocus(EventArgs.Empty);
    }

    private void WmShowWindow(ref Message m)
    {
      this.DefWndProc(ref m);
      if ((this.state & 16) != 0)
        return;
      bool flag1 = m.WParam != IntPtr.Zero;
      bool visible = this.Visible;
      if (flag1)
      {
        bool state = this.GetState(2);
        this.SetState(2, true);
        bool flag2 = false;
        try
        {
          this.CreateControl();
          flag2 = true;
        }
        finally
        {
          if (!flag2)
            this.SetState(2, state);
        }
      }
      else
      {
        bool flag2 = this.GetTopLevel();
        if (this.ParentInternal != null)
          flag2 = this.ParentInternal.Visible;
        if (flag2)
          this.SetState(2, false);
      }
      if (this.GetState(536870912) || visible == flag1)
        return;
      this.OnVisibleChanged(EventArgs.Empty);
    }

    private void WmUpdateUIState(ref Message m)
    {
      bool flag1 = false;
      bool flag2 = false;
      bool flag3 = (this.uiCuesState & 240) != 0;
      bool flag4 = (this.uiCuesState & 15) != 0;
      if (flag3)
        flag1 = this.ShowKeyboardCues;
      if (flag4)
        flag2 = this.ShowFocusCues;
      this.DefWndProc(ref m);
      int num = System.Windows.Forms.NativeMethods.Util.LOWORD(m.WParam);
      if (num == 3)
        return;
      UICues uicues = UICues.None;
      if ((System.Windows.Forms.NativeMethods.Util.HIWORD(m.WParam) & 2) != 0)
      {
        bool flag5 = num == 2;
        if (flag5 != flag1 || !flag3)
        {
          uicues |= UICues.ChangeKeyboard;
          this.uiCuesState &= -241;
          this.uiCuesState |= flag5 ? 32 : 16;
        }
        if (flag5)
          uicues |= UICues.ShowKeyboard;
      }
      if ((System.Windows.Forms.NativeMethods.Util.HIWORD(m.WParam) & 1) != 0)
      {
        bool flag5 = num == 2;
        if (flag5 != flag2 || !flag4)
        {
          uicues |= UICues.ChangeFocus;
          this.uiCuesState &= -16;
          this.uiCuesState |= flag5 ? 2 : 1;
        }
        if (flag5)
          uicues |= UICues.ShowFocus;
      }
      if ((uicues & UICues.Changed) == UICues.None)
        return;
      this.OnChangeUICues(new UICuesEventArgs(uicues));
      this.Invalidate(true);
    }

    private unsafe void WmWindowPosChanged(ref Message m)
    {
      this.DefWndProc(ref m);
      this.UpdateBounds();
      if (this.parent == null || !(System.Windows.Forms.UnsafeNativeMethods.GetParent(new HandleRef((object) this.window, this.InternalHandle)) == this.parent.InternalHandle) || ((this.state & 256) != 0 || (((System.Windows.Forms.NativeMethods.WINDOWPOS*) (void*) m.LParam)->flags & 4) != 0))
        return;
      this.parent.UpdateChildControlIndex(this);
    }

    private void WndProcException(Exception e)
    {
      Application.OnThreadException(e);
    }

    internal void UpdateImeContextMode()
    {
      ImeMode[] inputLanguageTable = ImeModeConversion.InputLanguageTable;
      if (this.DesignMode || inputLanguageTable == ImeModeConversion.UnsupportedTable || !this.Focused)
        return;
      ImeMode imeMode = ImeMode.Disable;
      ImeMode cachedImeMode = this.CachedImeMode;
      if (this.ImeSupported && this.CanEnableIme)
        imeMode = cachedImeMode == ImeMode.NoControl ? Control.PropagatingImeMode : cachedImeMode;
      if (this.CurrentImeContextMode == imeMode || imeMode == ImeMode.Inherit)
        return;
      ++this.DisableImeModeChangedCount;
      ImeMode propagatingImeMode = Control.PropagatingImeMode;
      try
      {
        ImeContext.SetImeStatus(imeMode, this.Handle);
      }
      finally
      {
        --this.DisableImeModeChangedCount;
        if (imeMode == ImeMode.Disable && inputLanguageTable == ImeModeConversion.ChineseTable)
          Control.PropagatingImeMode = propagatingImeMode;
      }
      if (cachedImeMode == ImeMode.NoControl)
      {
        if (!this.CanEnableIme)
          return;
        Control.PropagatingImeMode = this.CurrentImeContextMode;
      }
      else
      {
        if (this.CanEnableIme)
          this.CachedImeMode = this.CurrentImeContextMode;
        this.VerifyImeModeChanged(imeMode, this.CachedImeMode);
      }
    }

    private void VerifyImeModeChanged(ImeMode oldMode, ImeMode newMode)
    {
      if (!this.ImeSupported || this.DisableImeModeChangedCount != 0 || (newMode == ImeMode.NoControl || oldMode == newMode))
        return;
      this.OnImeModeChanged(EventArgs.Empty);
    }

    internal void VerifyImeRestrictedModeChanged()
    {
      bool canEnableIme = this.CanEnableIme;
      if (this.LastCanEnableIme == canEnableIme)
        return;
      if (this.Focused)
      {
        ++this.DisableImeModeChangedCount;
        try
        {
          this.UpdateImeContextMode();
        }
        finally
        {
          --this.DisableImeModeChangedCount;
        }
      }
      ImeMode oldMode = this.CachedImeMode;
      ImeMode newMode = ImeMode.Disable;
      if (canEnableIme)
      {
        newMode = oldMode;
        oldMode = ImeMode.Disable;
      }
      this.VerifyImeModeChanged(oldMode, newMode);
      this.LastCanEnableIme = canEnableIme;
    }

    internal void OnImeContextStatusChanged(IntPtr handle)
    {
      ImeMode imeMode = ImeContext.GetImeMode(handle);
      if (imeMode == ImeMode.Inherit)
        return;
      ImeMode cachedImeMode = this.CachedImeMode;
      if (!this.CanEnableIme)
        return;
      if (cachedImeMode != ImeMode.NoControl)
      {
        this.CachedImeMode = imeMode;
        this.VerifyImeModeChanged(cachedImeMode, this.CachedImeMode);
      }
      else
        Control.PropagatingImeMode = imeMode;
    }

    private void WmInputLangChange(ref Message m)
    {
      this.UpdateImeContextMode();
      if (ImeModeConversion.InputLanguageTable == ImeModeConversion.UnsupportedTable)
        Control.PropagatingImeMode = ImeMode.Off;
      if (ImeModeConversion.InputLanguageTable == ImeModeConversion.ChineseTable)
        Control.IgnoreWmImeNotify = false;
      Form formInternal = this.FindFormInternal();
      if (formInternal != null)
      {
        InputLanguageChangedEventArgs changedEventArgs = InputLanguage.CreateInputLanguageChangedEventArgs(m);
        formInternal.PerformOnInputLanguageChanged(changedEventArgs);
      }
      this.DefWndProc(ref m);
    }

    private void WmInputLangChangeRequest(ref Message m)
    {
      InputLanguageChangingEventArgs changingEventArgs = InputLanguage.CreateInputLanguageChangingEventArgs(m);
      Form formInternal = this.FindFormInternal();
      if (formInternal != null)
        formInternal.PerformOnInputLanguageChanging(changingEventArgs);
      if (!changingEventArgs.Cancel)
        this.DefWndProc(ref m);
      else
        m.Result = IntPtr.Zero;
    }

    private void WmImeChar(ref Message m)
    {
      if (this.ProcessKeyEventArgs(ref m))
        return;
      this.DefWndProc(ref m);
    }

    private void WmImeEndComposition(ref Message m)
    {
      this.ImeWmCharsToIgnore = -1;
      this.DefWndProc(ref m);
    }

    private void WmImeNotify(ref Message m)
    {
      ImeMode[] inputLanguageTable = ImeModeConversion.InputLanguageTable;
      if (inputLanguageTable == ImeModeConversion.ChineseTable && !Control.lastLanguageChinese)
        Control.IgnoreWmImeNotify = true;
      Control.lastLanguageChinese = inputLanguageTable == ImeModeConversion.ChineseTable;
      if (this.ImeSupported && inputLanguageTable != ImeModeConversion.UnsupportedTable && !Control.IgnoreWmImeNotify)
      {
        switch ((int) m.WParam)
        {
          case 6:
          case 8:
            this.OnImeContextStatusChanged(this.Handle);
            break;
        }
      }
      this.DefWndProc(ref m);
    }

    internal void WmImeSetFocus()
    {
      if (ImeModeConversion.InputLanguageTable == ImeModeConversion.UnsupportedTable)
        return;
      this.UpdateImeContextMode();
    }

    private void WmImeStartComposition(ref Message m)
    {
      this.Properties.SetInteger(Control.PropImeWmCharsToIgnore, 0);
      this.DefWndProc(ref m);
    }

    private void WmImeKillFocus()
    {
      Control topMostParent = this.TopMostParent;
      Form form = topMostParent as Form;
      if (form != null && !form.Modal || (topMostParent.ContainsFocus || Control.propagatingImeMode == ImeMode.Inherit))
        return;
      Control.IgnoreWmImeNotify = true;
      try
      {
        ImeContext.SetImeStatus(Control.PropagatingImeMode, topMostParent.Handle);
        Control.PropagatingImeMode = ImeMode.Inherit;
      }
      finally
      {
        Control.IgnoreWmImeNotify = false;
      }
    }

    internal sealed class ControlNativeWindow : NativeWindow, IWindowTarget
    {
      private Control control;
      private GCHandle rootRef;
      internal IWindowTarget target;

      internal IWindowTarget WindowTarget
      {
        get
        {
          return this.target;
        }
        set
        {
          this.target = value;
        }
      }

      internal ControlNativeWindow(Control control)
      {
        this.control = control;
        this.target = (IWindowTarget) this;
      }

      protected override void OnHandleChange()
      {
        this.target.OnHandleChange(this.Handle);
      }

      public void OnHandleChange(IntPtr newHandle)
      {
        this.control.SetHandle(newHandle);
      }

      protected override void OnThreadException(Exception e)
      {
        this.control.WndProcException(e);
      }

      [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
      public void OnMessage(ref Message m)
      {
        this.control.WndProc(ref m);
      }

      protected override void WndProc(ref Message m)
      {
        switch (m.Msg)
        {
          case 512:
            if (!this.control.GetState(16384))
            {
              this.control.HookMouseEvent();
              if (!this.control.GetState(8192))
              {
                this.control.SendMessage(System.Windows.Forms.NativeMethods.WM_MOUSEENTER, 0, 0);
                break;
              }
              else
              {
                this.control.SetState(8192, false);
                break;
              }
            }
            else
              break;
          case 522:
            this.control.ResetMouseEventArgs();
            break;
          case 675:
            this.control.UnhookMouseEvent();
            break;
        }
        this.target.OnMessage(ref m);
      }

      internal Control GetControl()
      {
        return this.control;
      }

      internal void LockReference(bool locked)
      {
        if (locked)
        {
          if (this.rootRef.IsAllocated)
            return;
          this.rootRef = GCHandle.Alloc((object) this.GetControl(), GCHandleType.Normal);
        }
        else
        {
          if (!this.rootRef.IsAllocated)
            return;
          this.rootRef.Free();
        }
      }
    }

    [ListBindable(false)]
    [ComVisible(false)]
    public class ControlCollection : ArrangedElementCollection, IList, ICollection, System.Collections.IEnumerable, ICloneable
    {
      private int lastAccessedIndex = -1;
      private Control owner;

      public Control Owner
      {
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
        {
          return this.owner;
        }
      }

      public virtual Control this[int index]
      {
        get
        {
          if (index >= 0 && index < this.Count)
            return (Control) this.InnerList[index];
          throw new ArgumentOutOfRangeException("index", System.Windows.Forms.SR.GetString("IndexOutOfRange", new object[1]
          {
            (object) index.ToString((IFormatProvider) CultureInfo.CurrentCulture)
          }));
        }
      }

      public virtual Control this[string key]
      {
        get
        {
          if (string.IsNullOrEmpty(key))
            return (Control) null;
          int index = this.IndexOfKey(key);
          if (this.IsValidIndex(index))
            return this[index];
          else
            return (Control) null;
        }
      }

      public ControlCollection(Control owner)
      {
        this.owner = owner;
      }

      public virtual bool ContainsKey(string key)
      {
        return this.IsValidIndex(this.IndexOfKey(key));
      }

      public virtual void Add(Control value)
      {
        if (value == null)
          return;
        if (value.GetTopLevel())
          throw new ArgumentException(System.Windows.Forms.SR.GetString("TopLevelControlAdd"));
        if (this.owner.CreateThreadId != value.CreateThreadId)
          throw new ArgumentException(System.Windows.Forms.SR.GetString("AddDifferentThreads"));
        Control.CheckParentingCycle(this.owner, value);
        if (value.parent == this.owner)
        {
          value.SendToBack();
        }
        else
        {
          if (value.parent != null)
            value.parent.Controls.Remove(value);
          this.InnerList.Add((object) value);
          if (value.tabIndex == -1)
          {
            int num = 0;
            for (int index = 0; index < this.Count - 1; ++index)
            {
              int tabIndex = this[index].TabIndex;
              if (num <= tabIndex)
                num = tabIndex + 1;
            }
            value.tabIndex = num;
          }
          this.owner.SuspendLayout();
          try
          {
            Control control = value.parent;
            try
            {
              value.AssignParent(this.owner);
            }
            finally
            {
              if (control != value.parent && (this.owner.state & 1) != 0)
              {
                value.SetParentHandle(this.owner.InternalHandle);
                if (value.Visible)
                  value.CreateControl();
              }
            }
            value.InitLayout();
          }
          finally
          {
            this.owner.ResumeLayout(false);
          }
          LayoutTransaction.DoLayout((IArrangedElement) this.owner, (IArrangedElement) value, PropertyNames.Parent);
          this.owner.OnControlAdded(new ControlEventArgs(value));
        }
      }

      int IList.Add(object control)
      {
        if (!(control is Control))
          throw new ArgumentException(System.Windows.Forms.SR.GetString("ControlBadControl"), "control");
        this.Add((Control) control);
        return this.IndexOf((Control) control);
      }

      [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
      public virtual void AddRange(Control[] controls)
      {
        if (controls == null)
          throw new ArgumentNullException("controls");
        if (controls.Length <= 0)
          return;
        this.owner.SuspendLayout();
        try
        {
          for (int index = 0; index < controls.Length; ++index)
            this.Add(controls[index]);
        }
        finally
        {
          this.owner.ResumeLayout(true);
        }
      }

      object ICloneable.Clone()
      {
        Control.ControlCollection controlsInstance = this.owner.CreateControlsInstance();
        controlsInstance.InnerList.AddRange((ICollection) this);
        return (object) controlsInstance;
      }

      public bool Contains(Control control)
      {
        return this.InnerList.Contains((object) control);
      }

      public Control[] Find(string key, bool searchAllChildren)
      {
        if (string.IsNullOrEmpty(key))
          throw new ArgumentNullException("key", System.Windows.Forms.SR.GetString("FindKeyMayNotBeEmptyOrNull"));
        ArrayList @internal = this.FindInternal(key, searchAllChildren, this, new ArrayList());
        Control[] controlArray = new Control[@internal.Count];
        @internal.CopyTo((Array) controlArray, 0);
        return controlArray;
      }

      [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
      public override System.Collections.IEnumerator GetEnumerator()
      {
        return (System.Collections.IEnumerator) new Control.ControlCollection.ControlCollectionEnumerator(this);
      }

      public int IndexOf(Control control)
      {
        return this.InnerList.IndexOf((object) control);
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

      public virtual void Remove(Control value)
      {
        if (value == null || value.ParentInternal != this.owner)
          return;
        value.SetParentHandle(IntPtr.Zero);
        this.InnerList.Remove((object) value);
        value.AssignParent((Control) null);
        LayoutTransaction.DoLayout((IArrangedElement) this.owner, (IArrangedElement) value, PropertyNames.Parent);
        this.owner.OnControlRemoved(new ControlEventArgs(value));
        ContainerControl containerControl = this.owner.GetContainerControlInternal() as ContainerControl;
        if (containerControl == null)
          return;
        containerControl.AfterControlRemoved(value, this.owner);
      }

      void IList.Remove(object control)
      {
        if (!(control is Control))
          return;
        this.Remove((Control) control);
      }

      public void RemoveAt(int index)
      {
        this.Remove(this[index]);
      }

      public virtual void RemoveByKey(string key)
      {
        int index = this.IndexOfKey(key);
        if (!this.IsValidIndex(index))
          return;
        this.RemoveAt(index);
      }

      public virtual void Clear()
      {
        this.owner.SuspendLayout();
        CommonProperties.xClearAllPreferredSizeCaches((IArrangedElement) this.owner);
        try
        {
          while (this.Count != 0)
            this.RemoveAt(this.Count - 1);
        }
        finally
        {
          this.owner.ResumeLayout();
        }
      }

      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
      public int GetChildIndex(Control child)
      {
        return this.GetChildIndex(child, true);
      }

      public virtual int GetChildIndex(Control child, bool throwException)
      {
        int num = this.IndexOf(child);
        if (num == -1 && throwException)
          throw new ArgumentException(System.Windows.Forms.SR.GetString("ControlNotChild"));
        else
          return num;
      }

      internal virtual void SetChildIndexInternal(Control child, int newIndex)
      {
        if (child == null)
          throw new ArgumentNullException("child");
        int childIndex = this.GetChildIndex(child);
        if (childIndex == newIndex)
          return;
        if (newIndex >= this.Count || newIndex == -1)
          newIndex = this.Count - 1;
        this.MoveElement((IArrangedElement) child, childIndex, newIndex);
        child.UpdateZOrder();
        LayoutTransaction.DoLayout((IArrangedElement) this.owner, (IArrangedElement) child, PropertyNames.ChildIndex);
      }

      [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
      public virtual void SetChildIndex(Control child, int newIndex)
      {
        this.SetChildIndexInternal(child, newIndex);
      }

      private ArrayList FindInternal(string key, bool searchAllChildren, Control.ControlCollection controlsToLookIn, ArrayList foundControls)
      {
        if (controlsToLookIn != null)
        {
          if (foundControls != null)
          {
            try
            {
              for (int index = 0; index < controlsToLookIn.Count; ++index)
              {
                if (controlsToLookIn[index] != null && WindowsFormsUtils.SafeCompareStrings(controlsToLookIn[index].Name, key, true))
                  foundControls.Add((object) controlsToLookIn[index]);
              }
              if (searchAllChildren)
              {
                for (int index = 0; index < controlsToLookIn.Count; ++index)
                {
                  if (controlsToLookIn[index] != null && controlsToLookIn[index].Controls != null && controlsToLookIn[index].Controls.Count > 0)
                    foundControls = this.FindInternal(key, searchAllChildren, controlsToLookIn[index].Controls, foundControls);
                }
              }
            }
            catch (Exception ex)
            {
              if (System.Windows.Forms.ClientUtils.IsSecurityOrCriticalException(ex))
                throw;
            }
            return foundControls;
          }
        }
        return (ArrayList) null;
      }

      private bool IsValidIndex(int index)
      {
        if (index >= 0)
          return index < this.Count;
        else
          return false;
      }

      private class ControlCollectionEnumerator : System.Collections.IEnumerator
      {
        private Control.ControlCollection controls;
        private int current;
        private int originalCount;

        public object Current
        {
          [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")] get
          {
            if (this.current == -1)
              return (object) null;
            else
              return (object) this.controls[this.current];
          }
        }

        public ControlCollectionEnumerator(Control.ControlCollection controls)
        {
          this.controls = controls;
          this.originalCount = controls.Count;
          this.current = -1;
        }

        public bool MoveNext()
        {
          if (this.current >= this.controls.Count - 1 || this.current >= this.originalCount - 1)
            return false;
          ++this.current;
          return true;
        }

        public void Reset()
        {
          this.current = -1;
        }
      }
    }

    [ComVisible(true)]
    public class ControlAccessibleObject : AccessibleObject
    {
      private static IntPtr oleAccAvailable = System.Windows.Forms.NativeMethods.InvalidIntPtr;
      private IntPtr handle = IntPtr.Zero;
      private Control ownerControl;

      public override string DefaultAction
      {
        get
        {
          return this.ownerControl.AccessibleDefaultActionDescription ?? base.DefaultAction;
        }
      }

      public override string Description
      {
        get
        {
          return this.ownerControl.AccessibleDescription ?? base.Description;
        }
      }

      public IntPtr Handle
      {
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
        {
          return this.handle;
        }
        set
        {
          System.Windows.Forms.IntSecurity.UnmanagedCode.Demand();
          if (!(this.handle != value))
            return;
          this.handle = value;
          if (Control.ControlAccessibleObject.oleAccAvailable == IntPtr.Zero)
            return;
          bool flag = false;
          if (Control.ControlAccessibleObject.oleAccAvailable == System.Windows.Forms.NativeMethods.InvalidIntPtr)
          {
            Control.ControlAccessibleObject.oleAccAvailable = System.Windows.Forms.UnsafeNativeMethods.LoadLibrary("oleacc.dll");
            flag = Control.ControlAccessibleObject.oleAccAvailable != IntPtr.Zero;
          }
          if (this.handle != IntPtr.Zero && Control.ControlAccessibleObject.oleAccAvailable != IntPtr.Zero)
            this.UseStdAccessibleObjects(this.handle);
          if (!flag)
            return;
          System.Windows.Forms.UnsafeNativeMethods.FreeLibrary(new HandleRef((object) null, Control.ControlAccessibleObject.oleAccAvailable));
        }
      }

      public override string Help
      {
        get
        {
          QueryAccessibilityHelpEventHandler helpEventHandler = (QueryAccessibilityHelpEventHandler) this.Owner.Events[Control.EventQueryAccessibilityHelp];
          if (helpEventHandler == null)
            return base.Help;
          QueryAccessibilityHelpEventArgs e = new QueryAccessibilityHelpEventArgs();
          helpEventHandler((object) this.Owner, e);
          return e.HelpString;
        }
      }

      public override string KeyboardShortcut
      {
        get
        {
          char mnemonic = WindowsFormsUtils.GetMnemonic(this.TextLabel, false);
          if ((int) mnemonic != 0)
            return "Alt+" + (object) mnemonic;
          else
            return (string) null;
        }
      }

      public override string Name
      {
        get
        {
          return this.ownerControl.AccessibleName ?? WindowsFormsUtils.TextWithoutMnemonics(this.TextLabel);
        }
        set
        {
          this.ownerControl.AccessibleName = value;
        }
      }

      public override AccessibleObject Parent
      {
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode), SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)] get
        {
          return base.Parent;
        }
      }

      internal string TextLabel
      {
        get
        {
          if (this.ownerControl.GetStyle(ControlStyles.UseTextForAccessibility))
          {
            string text = this.ownerControl.Text;
            if (!string.IsNullOrEmpty(text))
              return text;
          }
          Label previousLabel = this.PreviousLabel;
          if (previousLabel != null)
          {
            string text = previousLabel.Text;
            if (!string.IsNullOrEmpty(text))
              return text;
          }
          return (string) null;
        }
      }

      public Control Owner
      {
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get
        {
          return this.ownerControl;
        }
      }

      internal Label PreviousLabel
      {
        get
        {
          Control parentInternal = this.Owner.ParentInternal;
          if (parentInternal == null)
            return (Label) null;
          ContainerControl containerControl = parentInternal.GetContainerControlInternal() as ContainerControl;
          if (containerControl == null)
            return (Label) null;
          for (Control nextControl = containerControl.GetNextControl(this.Owner, false); nextControl != null; nextControl = containerControl.GetNextControl(nextControl, false))
          {
            if (nextControl is Label)
              return nextControl as Label;
            if (nextControl.Visible && nextControl.TabStop)
              break;
          }
          return (Label) null;
        }
      }

      public override AccessibleRole Role
      {
        get
        {
          AccessibleRole accessibleRole = this.ownerControl.AccessibleRole;
          if (accessibleRole != AccessibleRole.Default)
            return accessibleRole;
          else
            return base.Role;
        }
      }

      static ControlAccessibleObject()
      {
      }

      public ControlAccessibleObject(Control ownerControl)
      {
        if (ownerControl == null)
          throw new ArgumentNullException("ownerControl");
        this.ownerControl = ownerControl;
        System.Windows.Forms.IntSecurity.UnmanagedCode.Assert();
        try
        {
          this.Handle = ownerControl.Handle;
        }
        finally
        {
          CodeAccessPermission.RevertAssert();
        }
      }

      internal ControlAccessibleObject(Control ownerControl, int accObjId)
      {
        if (ownerControl == null)
          throw new ArgumentNullException("ownerControl");
        this.AccessibleObjectId = accObjId;
        this.ownerControl = ownerControl;
        System.Windows.Forms.IntSecurity.UnmanagedCode.Assert();
        try
        {
          this.Handle = ownerControl.Handle;
        }
        finally
        {
          CodeAccessPermission.RevertAssert();
        }
      }

      internal override int[] GetSysChildOrder()
      {
        if (this.ownerControl.GetStyle(ControlStyles.ContainerControl))
          return this.ownerControl.GetChildWindowsInTabOrder();
        else
          return base.GetSysChildOrder();
      }

      internal override bool GetSysChild(AccessibleNavigation navdir, out AccessibleObject accessibleObject)
      {
        accessibleObject = (AccessibleObject) null;
        Control parentInternal = this.ownerControl.ParentInternal;
        int index = -1;
        Control[] array = (Control[]) null;
        switch (navdir)
        {
          case AccessibleNavigation.Next:
            if (this.IsNonClientObject && parentInternal != null)
            {
              array = parentInternal.GetChildControlsInTabOrder(true);
              index = Array.IndexOf<Control>(array, this.ownerControl);
              if (index != -1)
              {
                ++index;
                break;
              }
              else
                break;
            }
            else
              break;
          case AccessibleNavigation.Previous:
            if (this.IsNonClientObject && parentInternal != null)
            {
              array = parentInternal.GetChildControlsInTabOrder(true);
              index = Array.IndexOf<Control>(array, this.ownerControl);
              if (index != -1)
              {
                --index;
                break;
              }
              else
                break;
            }
            else
              break;
          case AccessibleNavigation.FirstChild:
            if (this.IsClientObject)
            {
              array = this.ownerControl.GetChildControlsInTabOrder(true);
              index = 0;
              break;
            }
            else
              break;
          case AccessibleNavigation.LastChild:
            if (this.IsClientObject)
            {
              array = this.ownerControl.GetChildControlsInTabOrder(true);
              index = array.Length - 1;
              break;
            }
            else
              break;
        }
        if (array == null || array.Length == 0)
          return false;
        if (index >= 0 && index < array.Length)
          accessibleObject = array[index].NcAccessibilityObject;
        return true;
      }

      public override int GetHelpTopic(out string fileName)
      {
        int num = 0;
        QueryAccessibilityHelpEventHandler helpEventHandler = (QueryAccessibilityHelpEventHandler) this.Owner.Events[Control.EventQueryAccessibilityHelp];
        if (helpEventHandler == null)
          return base.GetHelpTopic(out fileName);
        QueryAccessibilityHelpEventArgs e = new QueryAccessibilityHelpEventArgs();
        helpEventHandler((object) this.Owner, e);
        fileName = e.HelpNamespace;
        if (!string.IsNullOrEmpty(fileName))
          System.Windows.Forms.IntSecurity.DemandFileIO(FileIOPermissionAccess.PathDiscovery, fileName);
        try
        {
          num = int.Parse(e.HelpKeyword, (IFormatProvider) CultureInfo.InvariantCulture);
        }
        catch (Exception ex)
        {
          if (System.Windows.Forms.ClientUtils.IsSecurityOrCriticalException(ex))
            throw;
        }
        return num;
      }

      public void NotifyClients(AccessibleEvents accEvent)
      {
        System.Windows.Forms.UnsafeNativeMethods.NotifyWinEvent((int) accEvent, new HandleRef((object) this, this.Handle), -4, 0);
      }

      public void NotifyClients(AccessibleEvents accEvent, int childID)
      {
        System.Windows.Forms.UnsafeNativeMethods.NotifyWinEvent((int) accEvent, new HandleRef((object) this, this.Handle), -4, childID + 1);
      }

      public void NotifyClients(AccessibleEvents accEvent, int objectID, int childID)
      {
        System.Windows.Forms.UnsafeNativeMethods.NotifyWinEvent((int) accEvent, new HandleRef((object) this, this.Handle), objectID, childID + 1);
      }

      public override string ToString()
      {
        if (this.Owner != null)
          return "ControlAccessibleObject: Owner = " + this.Owner.ToString();
        else
          return "ControlAccessibleObject: Owner = null";
      }
    }

    internal sealed class FontHandleWrapper : MarshalByRefObject, IDisposable
    {
      private IntPtr handle;

      internal IntPtr Handle
      {
        get
        {
          return this.handle;
        }
      }

      internal FontHandleWrapper(Font font)
      {
        this.handle = font.ToHfont();
        System.Internal.HandleCollector.Add(this.handle, System.Windows.Forms.NativeMethods.CommonHandles.GDI);
      }

      ~FontHandleWrapper()
      {
        this.Dispose(false);
      }

      public void Dispose()
      {
        this.Dispose(true);
        GC.SuppressFinalize((object) this);
      }

      private void Dispose(bool disposing)
      {
        if (!(this.handle != IntPtr.Zero))
          return;
        System.Windows.Forms.SafeNativeMethods.DeleteObject(new HandleRef((object) this, this.handle));
        this.handle = IntPtr.Zero;
      }
    }

    private class ControlTabOrderHolder
    {
      internal readonly int oldOrder;
      internal readonly int newOrder;
      internal readonly Control control;

      internal ControlTabOrderHolder(int oldOrder, int newOrder, Control control)
      {
        this.oldOrder = oldOrder;
        this.newOrder = newOrder;
        this.control = control;
      }
    }

    private class ControlTabOrderComparer : IComparer
    {
      int IComparer.Compare(object x, object y)
      {
        Control.ControlTabOrderHolder controlTabOrderHolder1 = (Control.ControlTabOrderHolder) x;
        Control.ControlTabOrderHolder controlTabOrderHolder2 = (Control.ControlTabOrderHolder) y;
        int num = controlTabOrderHolder1.newOrder - controlTabOrderHolder2.newOrder;
        if (num == 0)
          num = controlTabOrderHolder1.oldOrder - controlTabOrderHolder2.oldOrder;
        return num;
      }
    }

    private class ActiveXImpl : MarshalByRefObject, IWindowTarget
    {
      private static readonly int hiMetricPerInch = 2540;
      private static readonly int viewAdviseOnlyOnce = BitVector32.CreateMask();
      private static readonly int viewAdvisePrimeFirst = BitVector32.CreateMask(Control.ActiveXImpl.viewAdviseOnlyOnce);
      private static readonly int eventsFrozen = BitVector32.CreateMask(Control.ActiveXImpl.viewAdvisePrimeFirst);
      private static readonly int changingExtents = BitVector32.CreateMask(Control.ActiveXImpl.eventsFrozen);
      private static readonly int saving = BitVector32.CreateMask(Control.ActiveXImpl.changingExtents);
      private static readonly int isDirty = BitVector32.CreateMask(Control.ActiveXImpl.saving);
      private static readonly int inPlaceActive = BitVector32.CreateMask(Control.ActiveXImpl.isDirty);
      private static readonly int inPlaceVisible = BitVector32.CreateMask(Control.ActiveXImpl.inPlaceActive);
      private static readonly int uiActive = BitVector32.CreateMask(Control.ActiveXImpl.inPlaceVisible);
      private static readonly int uiDead = BitVector32.CreateMask(Control.ActiveXImpl.uiActive);
      private static readonly int adjustingRect = BitVector32.CreateMask(Control.ActiveXImpl.uiDead);
      private static Point logPixels = Point.Empty;
      private static int globalActiveXCount = 0;
      private short accelCount = (short) -1;
      private static System.Windows.Forms.NativeMethods.tagOLEVERB[] axVerbs;
      private static bool checkedIE;
      private static bool isIE;
      private Control control;
      private IWindowTarget controlWindowTarget;
      private IntPtr clipRegion;
      private System.Windows.Forms.UnsafeNativeMethods.IOleClientSite clientSite;
      private System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceUIWindow inPlaceUiWindow;
      private System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceFrame inPlaceFrame;
      private ArrayList adviseList;
      private IAdviseSink viewAdviseSink;
      private BitVector32 activeXState;
      private Control.AmbientProperty[] ambientProperties;
      private IntPtr hwndParent;
      private IntPtr accelTable;
      private System.Windows.Forms.NativeMethods.COMRECT adjustRect;

      [Browsable(false)]
      [EditorBrowsable(EditorBrowsableState.Advanced)]
      [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
      internal System.Drawing.Color AmbientBackColor
      {
        get
        {
          Control.AmbientProperty ambientProperty = this.LookupAmbient(-701);
          if (ambientProperty.Empty)
          {
            object obj = (object) null;
            if (this.GetAmbientProperty(-701, ref obj))
            {
              if (obj != null)
              {
                try
                {
                  ambientProperty.Value = (object) ColorTranslator.FromOle(Convert.ToInt32(obj, (IFormatProvider) CultureInfo.InvariantCulture));
                }
                catch (Exception ex)
                {
                  if (System.Windows.Forms.ClientUtils.IsSecurityOrCriticalException(ex))
                    throw;
                }
              }
            }
          }
          if (ambientProperty.Value == null)
            return System.Drawing.Color.Empty;
          else
            return (System.Drawing.Color) ambientProperty.Value;
        }
      }

      [Browsable(false)]
      [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
      [EditorBrowsable(EditorBrowsableState.Advanced)]
      internal Font AmbientFont
      {
        get
        {
          Control.AmbientProperty ambientProperty = this.LookupAmbient(-703);
          if (ambientProperty.Empty)
          {
            object obj = (object) null;
            if (this.GetAmbientProperty(-703, ref obj))
            {
              try
              {
                IntPtr num = IntPtr.Zero;
                System.Windows.Forms.UnsafeNativeMethods.IFont font1 = (System.Windows.Forms.UnsafeNativeMethods.IFont) obj;
                System.Windows.Forms.IntSecurity.ObjectFromWin32Handle.Assert();
                Font font2 = (Font) null;
                try
                {
                  font2 = Font.FromHfont(font1.GetHFont());
                }
                finally
                {
                  CodeAccessPermission.RevertAssert();
                }
                ambientProperty.Value = (object) font2;
              }
              catch (Exception ex)
              {
                if (System.Windows.Forms.ClientUtils.IsSecurityOrCriticalException(ex))
                  throw;
                else
                  ambientProperty.Value = (object) null;
              }
            }
          }
          return (Font) ambientProperty.Value;
        }
      }

      [Browsable(false)]
      [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
      [EditorBrowsable(EditorBrowsableState.Advanced)]
      internal System.Drawing.Color AmbientForeColor
      {
        get
        {
          Control.AmbientProperty ambientProperty = this.LookupAmbient(-704);
          if (ambientProperty.Empty)
          {
            object obj = (object) null;
            if (this.GetAmbientProperty(-704, ref obj))
            {
              if (obj != null)
              {
                try
                {
                  ambientProperty.Value = (object) ColorTranslator.FromOle(Convert.ToInt32(obj, (IFormatProvider) CultureInfo.InvariantCulture));
                }
                catch (Exception ex)
                {
                  if (System.Windows.Forms.ClientUtils.IsSecurityOrCriticalException(ex))
                    throw;
                }
              }
            }
          }
          if (ambientProperty.Value == null)
            return System.Drawing.Color.Empty;
          else
            return (System.Drawing.Color) ambientProperty.Value;
        }
      }

      [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
      [Browsable(false)]
      [EditorBrowsable(EditorBrowsableState.Advanced)]
      internal bool EventsFrozen
      {
        get
        {
          return this.activeXState[Control.ActiveXImpl.eventsFrozen];
        }
        set
        {
          this.activeXState[Control.ActiveXImpl.eventsFrozen] = value;
        }
      }

      internal IntPtr HWNDParent
      {
        get
        {
          return this.hwndParent;
        }
      }

      internal bool IsIE
      {
        [SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.UnmanagedCode)] get
        {
          if (!Control.ActiveXImpl.checkedIE)
          {
            if (this.clientSite == null)
              return false;
            if (Assembly.GetEntryAssembly() == (Assembly) null)
            {
              System.Windows.Forms.UnsafeNativeMethods.IOleContainer container;
              if (System.Windows.Forms.NativeMethods.Succeeded(this.clientSite.GetContainer(out container)) && container is System.Windows.Forms.NativeMethods.IHTMLDocument)
                Control.ActiveXImpl.isIE = true;
              if (container != null && System.Windows.Forms.UnsafeNativeMethods.IsComObject((object) container))
                System.Windows.Forms.UnsafeNativeMethods.ReleaseComObject((object) container);
            }
            Control.ActiveXImpl.checkedIE = true;
          }
          return Control.ActiveXImpl.isIE;
        }
      }

      Point LogPixels
      {
        private get
        {
          if (Control.ActiveXImpl.logPixels.IsEmpty)
          {
            Control.ActiveXImpl.logPixels = new Point();
            IntPtr dc = System.Windows.Forms.UnsafeNativeMethods.GetDC(System.Windows.Forms.NativeMethods.NullHandleRef);
            Control.ActiveXImpl.logPixels.X = System.Windows.Forms.UnsafeNativeMethods.GetDeviceCaps(new HandleRef((object) null, dc), 88);
            Control.ActiveXImpl.logPixels.Y = System.Windows.Forms.UnsafeNativeMethods.GetDeviceCaps(new HandleRef((object) null, dc), 90);
            System.Windows.Forms.UnsafeNativeMethods.ReleaseDC(System.Windows.Forms.NativeMethods.NullHandleRef, new HandleRef((object) null, dc));
          }
          return Control.ActiveXImpl.logPixels;
        }
      }

      static ActiveXImpl()
      {
      }

      internal ActiveXImpl(Control control)
      {
        this.control = control;
        this.controlWindowTarget = control.WindowTarget;
        control.WindowTarget = (IWindowTarget) this;
        this.adviseList = new ArrayList();
        this.activeXState = new BitVector32();
        this.ambientProperties = new Control.AmbientProperty[3]
        {
          new Control.AmbientProperty("Font", -703),
          new Control.AmbientProperty("BackColor", -701),
          new Control.AmbientProperty("ForeColor", -704)
        };
      }

      internal int Advise(IAdviseSink pAdvSink)
      {
        this.adviseList.Add((object) pAdvSink);
        return this.adviseList.Count;
      }

      internal void Close(int dwSaveOption)
      {
        if (this.activeXState[Control.ActiveXImpl.inPlaceActive])
          this.InPlaceDeactivate();
        if (dwSaveOption != 0 && dwSaveOption != 2 || !this.activeXState[Control.ActiveXImpl.isDirty])
          return;
        if (this.clientSite != null)
          this.clientSite.SaveObject();
        this.SendOnSave();
      }

      internal void DoVerb(int iVerb, IntPtr lpmsg, System.Windows.Forms.UnsafeNativeMethods.IOleClientSite pActiveSite, int lindex, IntPtr hwndParent, System.Windows.Forms.NativeMethods.COMRECT lprcPosRect)
      {
        switch (iVerb)
        {
          case -5:
          case -4:
          case -1:
          case 0:
            this.InPlaceActivate(iVerb);
            if (!(lpmsg != IntPtr.Zero))
              break;
            System.Windows.Forms.NativeMethods.MSG msg = (System.Windows.Forms.NativeMethods.MSG) System.Windows.Forms.UnsafeNativeMethods.PtrToStructure(lpmsg, typeof (System.Windows.Forms.NativeMethods.MSG));
            Control control = this.control;
            if (msg.hwnd != this.control.Handle && msg.message >= 512 && msg.message <= 522)
            {
              IntPtr handle = msg.hwnd == IntPtr.Zero ? hwndParent : msg.hwnd;
              System.Windows.Forms.NativeMethods.POINT pt = new System.Windows.Forms.NativeMethods.POINT();
              pt.x = System.Windows.Forms.NativeMethods.Util.LOWORD(msg.lParam);
              pt.y = System.Windows.Forms.NativeMethods.Util.HIWORD(msg.lParam);
              System.Windows.Forms.UnsafeNativeMethods.MapWindowPoints(new HandleRef((object) null, handle), new HandleRef((object) this.control, this.control.Handle), pt, 1);
              Control childAtPoint = control.GetChildAtPoint(new Point(pt.x, pt.y));
              if (childAtPoint != null && childAtPoint != control)
              {
                System.Windows.Forms.UnsafeNativeMethods.MapWindowPoints(new HandleRef((object) control, control.Handle), new HandleRef((object) childAtPoint, childAtPoint.Handle), pt, 1);
                control = childAtPoint;
              }
              msg.lParam = System.Windows.Forms.NativeMethods.Util.MAKELPARAM(pt.x, pt.y);
            }
            if (msg.message == 256 && msg.wParam == (IntPtr) 9)
            {
              control.SelectNextControl((Control) null, Control.ModifierKeys != Keys.Shift, true, true, true);
              break;
            }
            else
            {
              control.SendMessage(msg.message, msg.wParam, msg.lParam);
              break;
            }
          case -3:
            this.UIDeactivate();
            this.InPlaceDeactivate();
            if (!this.activeXState[Control.ActiveXImpl.inPlaceVisible])
              break;
            this.SetInPlaceVisible(false);
            break;
          default:
            Control.ActiveXImpl.ThrowHr(-2147467263);
            break;
        }
      }

      internal void Draw(int dwDrawAspect, int lindex, IntPtr pvAspect, System.Windows.Forms.NativeMethods.tagDVTARGETDEVICE ptd, IntPtr hdcTargetDev, IntPtr hdcDraw, System.Windows.Forms.NativeMethods.COMRECT prcBounds, System.Windows.Forms.NativeMethods.COMRECT lprcWBounds, IntPtr pfnContinue, int dwContinue)
      {
        switch (dwDrawAspect)
        {
          case 1:
          case 16:
          case 32:
            int objectType = System.Windows.Forms.UnsafeNativeMethods.GetObjectType(new HandleRef((object) null, hdcDraw));
            if (objectType == 4)
              Control.ActiveXImpl.ThrowHr(-2147221184);
            System.Windows.Forms.NativeMethods.POINT point1 = new System.Windows.Forms.NativeMethods.POINT();
            System.Windows.Forms.NativeMethods.POINT point2 = new System.Windows.Forms.NativeMethods.POINT();
            System.Windows.Forms.NativeMethods.SIZE size1 = new System.Windows.Forms.NativeMethods.SIZE();
            System.Windows.Forms.NativeMethods.SIZE size2 = new System.Windows.Forms.NativeMethods.SIZE();
            int nMapMode = 1;
            if (!this.control.IsHandleCreated)
              this.control.CreateHandle();
            if (prcBounds != null)
            {
              System.Windows.Forms.NativeMethods.RECT lpRect = new System.Windows.Forms.NativeMethods.RECT(prcBounds.left, prcBounds.top, prcBounds.right, prcBounds.bottom);
              System.Windows.Forms.SafeNativeMethods.LPtoDP(new HandleRef((object) null, hdcDraw), out lpRect, 2);
              nMapMode = System.Windows.Forms.SafeNativeMethods.SetMapMode(new HandleRef((object) null, hdcDraw), 8);
              System.Windows.Forms.SafeNativeMethods.SetWindowOrgEx(new HandleRef((object) null, hdcDraw), 0, 0, point2);
              System.Windows.Forms.SafeNativeMethods.SetWindowExtEx(new HandleRef((object) null, hdcDraw), this.control.Width, this.control.Height, size1);
              System.Windows.Forms.SafeNativeMethods.SetViewportOrgEx(new HandleRef((object) null, hdcDraw), lpRect.left, lpRect.top, point1);
              System.Windows.Forms.SafeNativeMethods.SetViewportExtEx(new HandleRef((object) null, hdcDraw), lpRect.right - lpRect.left, lpRect.bottom - lpRect.top, size2);
            }
            try
            {
              IntPtr num = (IntPtr) 30;
              if (objectType != 12)
              {
                this.control.SendMessage(791, hdcDraw, num);
                break;
              }
              else
              {
                this.control.PrintToMetaFile(new HandleRef((object) null, hdcDraw), num);
                break;
              }
            }
            finally
            {
              if (prcBounds != null)
              {
                System.Windows.Forms.SafeNativeMethods.SetWindowOrgEx(new HandleRef((object) null, hdcDraw), point2.x, point2.y, (System.Windows.Forms.NativeMethods.POINT) null);
                System.Windows.Forms.SafeNativeMethods.SetWindowExtEx(new HandleRef((object) null, hdcDraw), size1.cx, size1.cy, (System.Windows.Forms.NativeMethods.SIZE) null);
                System.Windows.Forms.SafeNativeMethods.SetViewportOrgEx(new HandleRef((object) null, hdcDraw), point1.x, point1.y, (System.Windows.Forms.NativeMethods.POINT) null);
                System.Windows.Forms.SafeNativeMethods.SetViewportExtEx(new HandleRef((object) null, hdcDraw), size2.cx, size2.cy, (System.Windows.Forms.NativeMethods.SIZE) null);
                System.Windows.Forms.SafeNativeMethods.SetMapMode(new HandleRef((object) null, hdcDraw), nMapMode);
              }
            }
          default:
            Control.ActiveXImpl.ThrowHr(-2147221397);
            goto case 1;
        }
      }

      internal static int EnumVerbs(out System.Windows.Forms.UnsafeNativeMethods.IEnumOLEVERB e)
      {
        if (Control.ActiveXImpl.axVerbs == null)
        {
          System.Windows.Forms.NativeMethods.tagOLEVERB tagOleverb1 = new System.Windows.Forms.NativeMethods.tagOLEVERB();
          System.Windows.Forms.NativeMethods.tagOLEVERB tagOleverb2 = new System.Windows.Forms.NativeMethods.tagOLEVERB();
          System.Windows.Forms.NativeMethods.tagOLEVERB tagOleverb3 = new System.Windows.Forms.NativeMethods.tagOLEVERB();
          System.Windows.Forms.NativeMethods.tagOLEVERB tagOleverb4 = new System.Windows.Forms.NativeMethods.tagOLEVERB();
          System.Windows.Forms.NativeMethods.tagOLEVERB tagOleverb5 = new System.Windows.Forms.NativeMethods.tagOLEVERB();
          System.Windows.Forms.NativeMethods.tagOLEVERB tagOleverb6 = new System.Windows.Forms.NativeMethods.tagOLEVERB();
          tagOleverb1.lVerb = -1;
          tagOleverb2.lVerb = -5;
          tagOleverb3.lVerb = -4;
          tagOleverb4.lVerb = -3;
          tagOleverb5.lVerb = 0;
          tagOleverb6.lVerb = -7;
          tagOleverb6.lpszVerbName = System.Windows.Forms.SR.GetString("AXProperties");
          tagOleverb6.grfAttribs = 2;
          Control.ActiveXImpl.axVerbs = new System.Windows.Forms.NativeMethods.tagOLEVERB[5]
          {
            tagOleverb1,
            tagOleverb2,
            tagOleverb3,
            tagOleverb4,
            tagOleverb5
          };
        }
        e = (System.Windows.Forms.UnsafeNativeMethods.IEnumOLEVERB) new Control.ActiveXVerbEnum(Control.ActiveXImpl.axVerbs);
        return 0;
      }

      private static byte[] FromBase64WrappedString(string text)
      {
        if (text.IndexOfAny(new char[3]
        {
          ' ',
          '\r',
          '\n'
        }) == -1)
          return Convert.FromBase64String(text);
        StringBuilder stringBuilder = new StringBuilder(text.Length);
        for (int index = 0; index < text.Length; ++index)
        {
          switch (text[index])
          {
            case '\n':
            case '\r':
            case ' ':
              goto case '\n';
            default:
              stringBuilder.Append(text[index]);
              goto case '\n';
          }
        }
        return Convert.FromBase64String(((object) stringBuilder).ToString());
      }

      internal void GetAdvise(int[] paspects, int[] padvf, IAdviseSink[] pAdvSink)
      {
        if (paspects != null)
          paspects[0] = 1;
        if (padvf != null)
        {
          padvf[0] = 0;
          if (this.activeXState[Control.ActiveXImpl.viewAdviseOnlyOnce])
            padvf[0] |= 4;
          if (this.activeXState[Control.ActiveXImpl.viewAdvisePrimeFirst])
            padvf[0] |= 2;
        }
        if (pAdvSink == null)
          return;
        pAdvSink[0] = this.viewAdviseSink;
      }

      private bool GetAmbientProperty(int dispid, ref object obj)
      {
        if (this.clientSite is System.Windows.Forms.UnsafeNativeMethods.IDispatch)
        {
          System.Windows.Forms.UnsafeNativeMethods.IDispatch dispatch = (System.Windows.Forms.UnsafeNativeMethods.IDispatch) this.clientSite;
          object[] pVarResult = new object[1];
          Guid riid = Guid.Empty;
          int hr = -2147467259;
          System.Windows.Forms.IntSecurity.UnmanagedCode.Assert();
          try
          {
            hr = dispatch.Invoke(dispid, ref riid, System.Windows.Forms.NativeMethods.LOCALE_USER_DEFAULT, 2, new System.Windows.Forms.NativeMethods.tagDISPPARAMS(), pVarResult, (System.Windows.Forms.NativeMethods.tagEXCEPINFO) null, (IntPtr[]) null);
          }
          finally
          {
            CodeAccessPermission.RevertAssert();
          }
          if (System.Windows.Forms.NativeMethods.Succeeded(hr))
          {
            obj = pVarResult[0];
            return true;
          }
        }
        return false;
      }

      internal System.Windows.Forms.UnsafeNativeMethods.IOleClientSite GetClientSite()
      {
        return this.clientSite;
      }

      [SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.UnmanagedCode)]
      internal int GetControlInfo(System.Windows.Forms.NativeMethods.tagCONTROLINFO pCI)
      {
        if ((int) this.accelCount == -1)
        {
          ArrayList mnemonicList = new ArrayList();
          this.GetMnemonicList(this.control, mnemonicList);
          this.accelCount = (short) mnemonicList.Count;
          if ((int) this.accelCount > 0)
          {
            int num1 = System.Windows.Forms.UnsafeNativeMethods.SizeOf(typeof (System.Windows.Forms.NativeMethods.ACCEL));
            IntPtr num2 = Marshal.AllocHGlobal(num1 * (int) this.accelCount * 2);
            try
            {
              System.Windows.Forms.NativeMethods.ACCEL accel = new System.Windows.Forms.NativeMethods.ACCEL();
              accel.cmd = (short) 0;
              this.accelCount = (short) 0;
              foreach (char key in mnemonicList)
              {
                IntPtr ptr1 = (IntPtr) ((long) num2 + (long) ((int) this.accelCount * num1));
                if ((int) key >= 65 && (int) key <= 90)
                {
                  accel.fVirt = (byte) 17;
                  accel.key = (short) ((int) System.Windows.Forms.UnsafeNativeMethods.VkKeyScan(key) & (int) byte.MaxValue);
                  Marshal.StructureToPtr((object) accel, ptr1, false);
                  ++this.accelCount;
                  IntPtr ptr2 = (IntPtr) ((long) ptr1 + (long) num1);
                  accel.fVirt = (byte) 21;
                  Marshal.StructureToPtr((object) accel, ptr2, false);
                }
                else
                {
                  accel.fVirt = (byte) 17;
                  short num3 = System.Windows.Forms.UnsafeNativeMethods.VkKeyScan(key);
                  if (((int) num3 & 256) != 0)
                    accel.fVirt |= (byte) 4;
                  accel.key = (short) ((int) num3 & (int) byte.MaxValue);
                  Marshal.StructureToPtr((object) accel, ptr1, false);
                }
                ++accel.cmd;
                ++this.accelCount;
              }
              if (this.accelTable != IntPtr.Zero)
              {
                System.Windows.Forms.UnsafeNativeMethods.DestroyAcceleratorTable(new HandleRef((object) this, this.accelTable));
                this.accelTable = IntPtr.Zero;
              }
              this.accelTable = System.Windows.Forms.UnsafeNativeMethods.CreateAcceleratorTable(new HandleRef((object) null, num2), (int) this.accelCount);
            }
            finally
            {
              if (num2 != IntPtr.Zero)
                Marshal.FreeHGlobal(num2);
            }
          }
        }
        pCI.cAccel = this.accelCount;
        pCI.hAccel = this.accelTable;
        return 0;
      }

      internal void GetExtent(int dwDrawAspect, System.Windows.Forms.NativeMethods.tagSIZEL pSizel)
      {
        if ((dwDrawAspect & 1) != 0)
        {
          Size size = this.control.Size;
          Point point = this.PixelToHiMetric(size.Width, size.Height);
          pSizel.cx = point.X;
          pSizel.cy = point.Y;
        }
        else
          Control.ActiveXImpl.ThrowHr(-2147221397);
      }

      private void GetMnemonicList(Control control, ArrayList mnemonicList)
      {
        char mnemonic = WindowsFormsUtils.GetMnemonic(control.Text, true);
        if ((int) mnemonic != 0)
          mnemonicList.Add((object) mnemonic);
        foreach (Control control1 in (ArrangedElementCollection) control.Controls)
        {
          if (control1 != null)
            this.GetMnemonicList(control1, mnemonicList);
        }
      }

      private string GetStreamName()
      {
        string str = this.control.GetType().FullName;
        int length = str.Length;
        if (length > 31)
          str = str.Substring(length - 31);
        return str;
      }

      internal int GetWindow(out IntPtr hwnd)
      {
        if (!this.activeXState[Control.ActiveXImpl.inPlaceActive])
        {
          hwnd = IntPtr.Zero;
          return -2147467259;
        }
        else
        {
          hwnd = this.control.Handle;
          return 0;
        }
      }

      private Point HiMetricToPixel(int x, int y)
      {
        return new Point()
        {
          X = (this.LogPixels.X * x + Control.ActiveXImpl.hiMetricPerInch / 2) / Control.ActiveXImpl.hiMetricPerInch,
          Y = (this.LogPixels.Y * y + Control.ActiveXImpl.hiMetricPerInch / 2) / Control.ActiveXImpl.hiMetricPerInch
        };
      }

      [SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.UnmanagedCode)]
      internal void InPlaceActivate(int verb)
      {
        System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceSite oleInPlaceSite = this.clientSite as System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceSite;
        if (oleInPlaceSite == null)
          return;
        if (!this.activeXState[Control.ActiveXImpl.inPlaceActive])
        {
          int hr = oleInPlaceSite.CanInPlaceActivate();
          if (hr != 0)
          {
            if (System.Windows.Forms.NativeMethods.Succeeded(hr))
              hr = -2147467259;
            Control.ActiveXImpl.ThrowHr(hr);
          }
          oleInPlaceSite.OnInPlaceActivate();
          this.activeXState[Control.ActiveXImpl.inPlaceActive] = true;
        }
        if (!this.activeXState[Control.ActiveXImpl.inPlaceVisible])
        {
          System.Windows.Forms.NativeMethods.tagOIFI lpFrameInfo = new System.Windows.Forms.NativeMethods.tagOIFI();
          lpFrameInfo.cb = System.Windows.Forms.UnsafeNativeMethods.SizeOf(typeof (System.Windows.Forms.NativeMethods.tagOIFI));
          IntPtr num = IntPtr.Zero;
          IntPtr window = oleInPlaceSite.GetWindow();
          System.Windows.Forms.NativeMethods.COMRECT lprcPosRect = new System.Windows.Forms.NativeMethods.COMRECT();
          System.Windows.Forms.NativeMethods.COMRECT lprcClipRect = new System.Windows.Forms.NativeMethods.COMRECT();
          if (this.inPlaceUiWindow != null && System.Windows.Forms.UnsafeNativeMethods.IsComObject((object) this.inPlaceUiWindow))
          {
            System.Windows.Forms.UnsafeNativeMethods.ReleaseComObject((object) this.inPlaceUiWindow);
            this.inPlaceUiWindow = (System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceUIWindow) null;
          }
          if (this.inPlaceFrame != null && System.Windows.Forms.UnsafeNativeMethods.IsComObject((object) this.inPlaceFrame))
          {
            System.Windows.Forms.UnsafeNativeMethods.ReleaseComObject((object) this.inPlaceFrame);
            this.inPlaceFrame = (System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceFrame) null;
          }
          System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceFrame ppFrame;
          System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceUIWindow ppDoc;
          oleInPlaceSite.GetWindowContext(out ppFrame, out ppDoc, lprcPosRect, lprcClipRect, lpFrameInfo);
          this.SetObjectRects(lprcPosRect, lprcClipRect);
          this.inPlaceFrame = ppFrame;
          this.inPlaceUiWindow = ppDoc;
          this.hwndParent = window;
          System.Windows.Forms.UnsafeNativeMethods.SetParent(new HandleRef((object) this.control, this.control.Handle), new HandleRef((object) null, window));
          this.control.CreateControl();
          this.clientSite.ShowObject();
          this.SetInPlaceVisible(true);
        }
        if (verb != 0 && verb != -4 || this.activeXState[Control.ActiveXImpl.uiActive])
          return;
        this.activeXState[Control.ActiveXImpl.uiActive] = true;
        oleInPlaceSite.OnUIActivate();
        if (!this.control.ContainsFocus)
          this.control.FocusInternal();
        this.inPlaceFrame.SetActiveObject((System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceActiveObject) this.control, (string) null);
        if (this.inPlaceUiWindow != null)
          this.inPlaceUiWindow.SetActiveObject((System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceActiveObject) this.control, (string) null);
        int num1 = this.inPlaceFrame.SetBorderSpace((System.Windows.Forms.NativeMethods.COMRECT) null);
        if (System.Windows.Forms.NativeMethods.Failed(num1) && num1 != -2147221491 && (num1 != -2147221087 && num1 != -2147467263))
          System.Windows.Forms.UnsafeNativeMethods.ThrowExceptionForHR(num1);
        if (this.inPlaceUiWindow == null)
          return;
        int num2 = this.inPlaceFrame.SetBorderSpace((System.Windows.Forms.NativeMethods.COMRECT) null);
        if (!System.Windows.Forms.NativeMethods.Failed(num2) || num2 == -2147221491 || (num2 == -2147221087 || num2 == -2147467263))
          return;
        System.Windows.Forms.UnsafeNativeMethods.ThrowExceptionForHR(num2);
      }

      internal void InPlaceDeactivate()
      {
        if (!this.activeXState[Control.ActiveXImpl.inPlaceActive])
          return;
        if (this.activeXState[Control.ActiveXImpl.uiActive])
          this.UIDeactivate();
        this.activeXState[Control.ActiveXImpl.inPlaceActive] = false;
        this.activeXState[Control.ActiveXImpl.inPlaceVisible] = false;
        System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceSite oleInPlaceSite = this.clientSite as System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceSite;
        if (oleInPlaceSite != null)
        {
          System.Windows.Forms.IntSecurity.UnmanagedCode.Assert();
          try
          {
            oleInPlaceSite.OnInPlaceDeactivate();
          }
          finally
          {
            CodeAccessPermission.RevertAssert();
          }
        }
        this.control.Visible = false;
        this.hwndParent = IntPtr.Zero;
        if (this.inPlaceUiWindow != null && System.Windows.Forms.UnsafeNativeMethods.IsComObject((object) this.inPlaceUiWindow))
        {
          System.Windows.Forms.UnsafeNativeMethods.ReleaseComObject((object) this.inPlaceUiWindow);
          this.inPlaceUiWindow = (System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceUIWindow) null;
        }
        if (this.inPlaceFrame == null || !System.Windows.Forms.UnsafeNativeMethods.IsComObject((object) this.inPlaceFrame))
          return;
        System.Windows.Forms.UnsafeNativeMethods.ReleaseComObject((object) this.inPlaceFrame);
        this.inPlaceFrame = (System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceFrame) null;
      }

      internal int IsDirty()
      {
        return this.activeXState[Control.ActiveXImpl.isDirty] ? 0 : 1;
      }

      private bool IsResourceProp(PropertyDescriptor prop)
      {
        TypeConverter converter = prop.Converter;
        System.Type[] typeArray = new System.Type[2]
        {
          typeof (string),
          typeof (byte[])
        };
        foreach (System.Type type in typeArray)
        {
          if (converter.CanConvertTo(type) && converter.CanConvertFrom(type))
            return false;
        }
        return prop.GetValue((object) this.control) is ISerializable;
      }

      internal void Load(System.Windows.Forms.UnsafeNativeMethods.IStorage stg)
      {
        System.Windows.Forms.UnsafeNativeMethods.IStream stream = (System.Windows.Forms.UnsafeNativeMethods.IStream) null;
        System.Windows.Forms.IntSecurity.UnmanagedCode.Assert();
        try
        {
          stream = stg.OpenStream(this.GetStreamName(), IntPtr.Zero, 16, 0);
        }
        catch (COMException ex)
        {
          if (ex.ErrorCode == -2147287038)
            stream = stg.OpenStream(this.GetType().FullName, IntPtr.Zero, 16, 0);
          else
            throw;
        }
        finally
        {
          CodeAccessPermission.RevertAssert();
        }
        this.Load(stream);
        if (!System.Windows.Forms.UnsafeNativeMethods.IsComObject((object) stg))
          return;
        System.Windows.Forms.UnsafeNativeMethods.ReleaseComObject((object) stg);
      }

      internal void Load(System.Windows.Forms.UnsafeNativeMethods.IStream stream)
      {
        Control.ActiveXImpl.PropertyBagStream propertyBagStream = new Control.ActiveXImpl.PropertyBagStream();
        propertyBagStream.Read(stream);
        this.Load((System.Windows.Forms.UnsafeNativeMethods.IPropertyBag) propertyBagStream, (System.Windows.Forms.UnsafeNativeMethods.IErrorLog) null);
        if (!System.Windows.Forms.UnsafeNativeMethods.IsComObject((object) stream))
          return;
        System.Windows.Forms.UnsafeNativeMethods.ReleaseComObject((object) stream);
      }

      internal void Load(System.Windows.Forms.UnsafeNativeMethods.IPropertyBag pPropBag, System.Windows.Forms.UnsafeNativeMethods.IErrorLog pErrorLog)
      {
        PropertyDescriptorCollection properties = TypeDescriptor.GetProperties((object) this.control, new Attribute[1]
        {
          (Attribute) DesignerSerializationVisibilityAttribute.Visible
        });
        for (int index = 0; index < properties.Count; ++index)
        {
          try
          {
            object pVar = (object) null;
            int hr = -2147467259;
            System.Windows.Forms.IntSecurity.UnmanagedCode.Assert();
            try
            {
              hr = pPropBag.Read(properties[index].Name, out pVar, pErrorLog);
            }
            finally
            {
              CodeAccessPermission.RevertAssert();
            }
            if (System.Windows.Forms.NativeMethods.Succeeded(hr))
            {
              if (pVar != null)
              {
                string str = (string) null;
                int num = 0;
                try
                {
                  if (pVar.GetType() != typeof (string))
                    pVar = (object) Convert.ToString(pVar, (IFormatProvider) CultureInfo.InvariantCulture);
                  if (this.IsResourceProp(properties[index]))
                  {
                    MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(pVar.ToString()));
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    properties[index].SetValue((object) this.control, binaryFormatter.Deserialize((Stream) memoryStream));
                  }
                  else
                  {
                    TypeConverter converter = properties[index].Converter;
                    object obj = (object) null;
                    if (converter.CanConvertFrom(typeof (string)))
                      obj = converter.ConvertFromInvariantString(pVar.ToString());
                    else if (converter.CanConvertFrom(typeof (byte[])))
                    {
                      string text = pVar.ToString();
                      obj = converter.ConvertFrom((ITypeDescriptorContext) null, CultureInfo.InvariantCulture, (object) Control.ActiveXImpl.FromBase64WrappedString(text));
                    }
                    properties[index].SetValue((object) this.control, obj);
                  }
                }
                catch (Exception ex)
                {
                  str = ((object) ex).ToString();
                  num = !(ex is ExternalException) ? -2147467259 : ((ExternalException) ex).ErrorCode;
                }
                if (str != null)
                {
                  if (pErrorLog != null)
                    pErrorLog.AddError(properties[index].Name, new System.Windows.Forms.NativeMethods.tagEXCEPINFO()
                    {
                      bstrSource = this.control.GetType().FullName,
                      bstrDescription = str,
                      scode = num
                    });
                }
              }
            }
          }
          catch (Exception ex)
          {
            if (System.Windows.Forms.ClientUtils.IsSecurityOrCriticalException(ex))
              throw;
          }
        }
        if (!System.Windows.Forms.UnsafeNativeMethods.IsComObject((object) pPropBag))
          return;
        System.Windows.Forms.UnsafeNativeMethods.ReleaseComObject((object) pPropBag);
      }

      private Control.AmbientProperty LookupAmbient(int dispid)
      {
        for (int index = 0; index < this.ambientProperties.Length; ++index)
        {
          if (this.ambientProperties[index].DispID == dispid)
            return this.ambientProperties[index];
        }
        return this.ambientProperties[0];
      }

      internal IntPtr MergeRegion(IntPtr region)
      {
        if (this.clipRegion == IntPtr.Zero)
          return region;
        if (region == IntPtr.Zero)
          return this.clipRegion;
        try
        {
          IntPtr rectRgn = System.Windows.Forms.SafeNativeMethods.CreateRectRgn(0, 0, 0, 0);
          try
          {
            System.Windows.Forms.SafeNativeMethods.CombineRgn(new HandleRef((object) null, rectRgn), new HandleRef((object) null, region), new HandleRef((object) this, this.clipRegion), 4);
            System.Windows.Forms.SafeNativeMethods.DeleteObject(new HandleRef((object) null, region));
          }
          catch
          {
            System.Windows.Forms.SafeNativeMethods.DeleteObject(new HandleRef((object) null, rectRgn));
            throw;
          }
          return rectRgn;
        }
        catch (Exception ex)
        {
          if (!System.Windows.Forms.ClientUtils.IsSecurityOrCriticalException(ex))
            return region;
          throw;
        }
      }

      private void CallParentPropertyChanged(Control control, string propName)
      {
        switch (propName)
        {
          case "BackColor":
            control.OnParentBackColorChanged(EventArgs.Empty);
            break;
          case "BackgroundImage":
            control.OnParentBackgroundImageChanged(EventArgs.Empty);
            break;
          case "BindingContext":
            control.OnParentBindingContextChanged(EventArgs.Empty);
            break;
          case "Enabled":
            control.OnParentEnabledChanged(EventArgs.Empty);
            break;
          case "Font":
            control.OnParentFontChanged(EventArgs.Empty);
            break;
          case "ForeColor":
            control.OnParentForeColorChanged(EventArgs.Empty);
            break;
          case "RightToLeft":
            control.OnParentRightToLeftChanged(EventArgs.Empty);
            break;
          case "Visible":
            control.OnParentVisibleChanged(EventArgs.Empty);
            break;
        }
      }

      internal void OnAmbientPropertyChange(int dispID)
      {
        if (dispID != -1)
        {
          for (int index = 0; index < this.ambientProperties.Length; ++index)
          {
            if (this.ambientProperties[index].DispID == dispID)
            {
              this.ambientProperties[index].ResetValue();
              this.CallParentPropertyChanged(this.control, this.ambientProperties[index].Name);
              return;
            }
          }
          object obj = new object();
          switch (dispID)
          {
            case -713:
              IButtonControl buttonControl = this.control as IButtonControl;
              if (buttonControl == null || !this.GetAmbientProperty(-713, ref obj))
                break;
              buttonControl.NotifyDefault((bool) obj);
              break;
            case -710:
              if (!this.GetAmbientProperty(-710, ref obj))
                break;
              this.activeXState[Control.ActiveXImpl.uiDead] = (bool) obj;
              break;
          }
        }
        else
        {
          for (int index = 0; index < this.ambientProperties.Length; ++index)
          {
            this.ambientProperties[index].ResetValue();
            this.CallParentPropertyChanged(this.control, this.ambientProperties[index].Name);
          }
        }
      }

      internal void OnDocWindowActivate(int fActivate)
      {
        if (!this.activeXState[Control.ActiveXImpl.uiActive] || fActivate == 0 || this.inPlaceFrame == null)
          return;
        System.Windows.Forms.IntSecurity.UnmanagedCode.Assert();
        int num;
        try
        {
          num = this.inPlaceFrame.SetBorderSpace((System.Windows.Forms.NativeMethods.COMRECT) null);
        }
        finally
        {
          CodeAccessPermission.RevertAssert();
        }
        if (!System.Windows.Forms.NativeMethods.Failed(num) || num == -2147221087 || num == -2147467263)
          return;
        System.Windows.Forms.UnsafeNativeMethods.ThrowExceptionForHR(num);
      }

      internal void OnFocus(bool focus)
      {
        if (this.activeXState[Control.ActiveXImpl.inPlaceActive] && this.clientSite is System.Windows.Forms.UnsafeNativeMethods.IOleControlSite)
        {
          System.Windows.Forms.IntSecurity.UnmanagedCode.Assert();
          try
          {
            ((System.Windows.Forms.UnsafeNativeMethods.IOleControlSite) this.clientSite).OnFocus(focus ? 1 : 0);
          }
          finally
          {
            CodeAccessPermission.RevertAssert();
          }
        }
        if (!focus || !this.activeXState[Control.ActiveXImpl.inPlaceActive] || this.activeXState[Control.ActiveXImpl.uiActive])
          return;
        this.InPlaceActivate(-4);
      }

      private Point PixelToHiMetric(int x, int y)
      {
        return new Point()
        {
          X = (Control.ActiveXImpl.hiMetricPerInch * x + (this.LogPixels.X >> 1)) / this.LogPixels.X,
          Y = (Control.ActiveXImpl.hiMetricPerInch * y + (this.LogPixels.Y >> 1)) / this.LogPixels.Y
        };
      }

      internal void QuickActivate(System.Windows.Forms.UnsafeNativeMethods.tagQACONTAINER pQaContainer, System.Windows.Forms.UnsafeNativeMethods.tagQACONTROL pQaControl)
      {
        this.LookupAmbient(-701).Value = (object) ColorTranslator.FromOle((int) pQaContainer.colorBack);
        this.LookupAmbient(-704).Value = (object) ColorTranslator.FromOle((int) pQaContainer.colorFore);
        if (pQaContainer.pFont != null)
        {
          Control.AmbientProperty ambientProperty = this.LookupAmbient(-703);
          System.Windows.Forms.IntSecurity.UnmanagedCode.Assert();
          try
          {
            IntPtr num = IntPtr.Zero;
            Font font = Font.FromHfont(((System.Windows.Forms.UnsafeNativeMethods.IFont) pQaContainer.pFont).GetHFont());
            ambientProperty.Value = (object) font;
          }
          catch (Exception ex)
          {
            if (System.Windows.Forms.ClientUtils.IsSecurityOrCriticalException(ex))
              throw;
            else
              ambientProperty.Value = (object) null;
          }
          finally
          {
            CodeAccessPermission.RevertAssert();
          }
        }
        pQaControl.cbSize = System.Windows.Forms.UnsafeNativeMethods.SizeOf(typeof (System.Windows.Forms.UnsafeNativeMethods.tagQACONTROL));
        this.SetClientSite(pQaContainer.pClientSite);
        if (pQaContainer.pAdviseSink != null)
          this.SetAdvise(1, 0, (IAdviseSink) pQaContainer.pAdviseSink);
        System.Windows.Forms.IntSecurity.UnmanagedCode.Assert();
        int misc;
        try
        {
          this.control.GetMiscStatus(1, out misc);
        }
        finally
        {
          CodeAccessPermission.RevertAssert();
        }
        pQaControl.dwMiscStatus = misc;
        if (pQaContainer.pUnkEventSink != null && this.control is UserControl)
        {
          System.Type defaultEventsInterface = Control.ActiveXImpl.GetDefaultEventsInterface(this.control.GetType());
          if (defaultEventsInterface != (System.Type) null)
          {
            System.Windows.Forms.IntSecurity.UnmanagedCode.Assert();
            try
            {
              Control.ActiveXImpl.AdviseHelper.AdviseConnectionPoint((object) this.control, pQaContainer.pUnkEventSink, defaultEventsInterface, out pQaControl.dwEventCookie);
            }
            catch (Exception ex)
            {
              if (System.Windows.Forms.ClientUtils.IsSecurityOrCriticalException(ex))
                throw;
            }
            finally
            {
              CodeAccessPermission.RevertAssert();
            }
          }
        }
        if (pQaContainer.pPropertyNotifySink != null && System.Windows.Forms.UnsafeNativeMethods.IsComObject((object) pQaContainer.pPropertyNotifySink))
          System.Windows.Forms.UnsafeNativeMethods.ReleaseComObject((object) pQaContainer.pPropertyNotifySink);
        if (pQaContainer.pUnkEventSink == null || !System.Windows.Forms.UnsafeNativeMethods.IsComObject(pQaContainer.pUnkEventSink))
          return;
        System.Windows.Forms.UnsafeNativeMethods.ReleaseComObject(pQaContainer.pUnkEventSink);
      }

      private static System.Type GetDefaultEventsInterface(System.Type controlType)
      {
        System.Type type = (System.Type) null;
        object[] customAttributes = controlType.GetCustomAttributes(typeof (ComSourceInterfacesAttribute), false);
        if (customAttributes.Length > 0)
        {
          string str = ((ComSourceInterfacesAttribute) customAttributes[0]).Value.Split(new char[1])[0];
          type = controlType.Module.Assembly.GetType(str, false);
          if (type == (System.Type) null)
            type = System.Type.GetType(str, false);
        }
        return type;
      }

      internal void Save(System.Windows.Forms.UnsafeNativeMethods.IStorage stg, bool fSameAsLoad)
      {
        System.Windows.Forms.UnsafeNativeMethods.IStream stream = (System.Windows.Forms.UnsafeNativeMethods.IStream) null;
        System.Windows.Forms.IntSecurity.UnmanagedCode.Assert();
        try
        {
          stream = stg.CreateStream(this.GetStreamName(), 4113, 0, 0);
        }
        finally
        {
          CodeAccessPermission.RevertAssert();
        }
        this.Save(stream, true);
        System.Windows.Forms.UnsafeNativeMethods.ReleaseComObject((object) stream);
      }

      internal void Save(System.Windows.Forms.UnsafeNativeMethods.IStream stream, bool fClearDirty)
      {
        Control.ActiveXImpl.PropertyBagStream propertyBagStream = new Control.ActiveXImpl.PropertyBagStream();
        this.Save((System.Windows.Forms.UnsafeNativeMethods.IPropertyBag) propertyBagStream, fClearDirty, false);
        System.Windows.Forms.IntSecurity.UnmanagedCode.Assert();
        try
        {
          propertyBagStream.Write(stream);
        }
        finally
        {
          CodeAccessPermission.RevertAssert();
        }
        if (!System.Windows.Forms.UnsafeNativeMethods.IsComObject((object) stream))
          return;
        System.Windows.Forms.UnsafeNativeMethods.ReleaseComObject((object) stream);
      }

      [SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.UnmanagedCode)]
      internal void Save(System.Windows.Forms.UnsafeNativeMethods.IPropertyBag pPropBag, bool fClearDirty, bool fSaveAllProperties)
      {
        PropertyDescriptorCollection properties = TypeDescriptor.GetProperties((object) this.control, new Attribute[1]
        {
          (Attribute) DesignerSerializationVisibilityAttribute.Visible
        });
        for (int index = 0; index < properties.Count; ++index)
        {
          object pVar;
          if (fSaveAllProperties || properties[index].ShouldSerializeValue((object) this.control))
          {
            if (this.IsResourceProp(properties[index]))
            {
              MemoryStream memoryStream = new MemoryStream();
              new BinaryFormatter().Serialize((Stream) memoryStream, properties[index].GetValue((object) this.control));
              byte[] numArray = new byte[(int) memoryStream.Length];
              memoryStream.Position = 0L;
              memoryStream.Read(numArray, 0, numArray.Length);
              pVar = (object) Convert.ToBase64String(numArray);
              pPropBag.Write(properties[index].Name, ref pVar);
            }
            else
            {
              TypeConverter converter = properties[index].Converter;
              if (converter.CanConvertFrom(typeof (string)))
              {
                pVar = (object) converter.ConvertToInvariantString(properties[index].GetValue((object) this.control));
                pPropBag.Write(properties[index].Name, ref pVar);
              }
              else if (converter.CanConvertFrom(typeof (byte[])))
              {
                pVar = (object) Convert.ToBase64String((byte[]) converter.ConvertTo((ITypeDescriptorContext) null, CultureInfo.InvariantCulture, properties[index].GetValue((object) this.control), typeof (byte[])));
                pPropBag.Write(properties[index].Name, ref pVar);
              }
            }
          }
        }
        if (System.Windows.Forms.UnsafeNativeMethods.IsComObject((object) pPropBag))
          System.Windows.Forms.UnsafeNativeMethods.ReleaseComObject((object) pPropBag);
        if (!fClearDirty)
          return;
        this.activeXState[Control.ActiveXImpl.isDirty] = false;
      }

      private void SendOnSave()
      {
        int count = this.adviseList.Count;
        System.Windows.Forms.IntSecurity.UnmanagedCode.Assert();
        for (int index = 0; index < count; ++index)
          ((IAdviseSink) this.adviseList[index]).OnSave();
      }

      internal void SetAdvise(int aspects, int advf, IAdviseSink pAdvSink)
      {
        if ((aspects & 1) == 0)
          Control.ActiveXImpl.ThrowHr(-2147221397);
        this.activeXState[Control.ActiveXImpl.viewAdvisePrimeFirst] = (advf & 2) != 0;
        this.activeXState[Control.ActiveXImpl.viewAdviseOnlyOnce] = (advf & 4) != 0;
        if (this.viewAdviseSink != null && System.Windows.Forms.UnsafeNativeMethods.IsComObject((object) this.viewAdviseSink))
          System.Windows.Forms.UnsafeNativeMethods.ReleaseComObject((object) this.viewAdviseSink);
        this.viewAdviseSink = pAdvSink;
        if (!this.activeXState[Control.ActiveXImpl.viewAdvisePrimeFirst])
          return;
        this.ViewChanged();
      }

      internal void SetClientSite(System.Windows.Forms.UnsafeNativeMethods.IOleClientSite value)
      {
        if (this.clientSite != null)
        {
          if (value == null)
          {
            --Control.ActiveXImpl.globalActiveXCount;
            if (Control.ActiveXImpl.globalActiveXCount == 0 && this.IsIE)
            {
              new PermissionSet(PermissionState.Unrestricted).Assert();
              try
              {
                MethodInfo method = typeof (SystemEvents).GetMethod("Shutdown", BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.InvokeMethod, (Binder) null, new System.Type[0], new ParameterModifier[0]);
                if (method != (MethodInfo) null)
                  method.Invoke((object) null, (object[]) null);
              }
              finally
              {
                CodeAccessPermission.RevertAssert();
              }
            }
          }
          if (System.Windows.Forms.UnsafeNativeMethods.IsComObject((object) this.clientSite))
          {
            System.Windows.Forms.IntSecurity.UnmanagedCode.Assert();
            try
            {
              Marshal.FinalReleaseComObject((object) this.clientSite);
            }
            finally
            {
              CodeAccessPermission.RevertAssert();
            }
          }
        }
        this.clientSite = value;
        if (this.clientSite != null)
          this.control.Site = (ISite) new Control.AxSourcingSite((IComponent) this.control, this.clientSite, "ControlAxSourcingSite");
        else
          this.control.Site = (ISite) null;
        object obj = new object();
        if (this.GetAmbientProperty(-710, ref obj))
          this.activeXState[Control.ActiveXImpl.uiDead] = (bool) obj;
        if (this.control is IButtonControl && this.GetAmbientProperty(-710, ref obj))
          ((IButtonControl) this.control).NotifyDefault((bool) obj);
        if (this.clientSite == null)
        {
          if (this.accelTable != IntPtr.Zero)
          {
            System.Windows.Forms.UnsafeNativeMethods.DestroyAcceleratorTable(new HandleRef((object) this, this.accelTable));
            this.accelTable = IntPtr.Zero;
            this.accelCount = (short) -1;
          }
          if (this.IsIE)
            this.control.Dispose();
        }
        else
        {
          ++Control.ActiveXImpl.globalActiveXCount;
          if (Control.ActiveXImpl.globalActiveXCount == 1 && this.IsIE)
          {
            new PermissionSet(PermissionState.Unrestricted).Assert();
            try
            {
              MethodInfo method = typeof (SystemEvents).GetMethod("Startup", BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.InvokeMethod, (Binder) null, new System.Type[0], new ParameterModifier[0]);
              if (method != (MethodInfo) null)
                method.Invoke((object) null, (object[]) null);
            }
            finally
            {
              CodeAccessPermission.RevertAssert();
            }
          }
        }
        this.control.OnTopMostActiveXParentChanged(EventArgs.Empty);
      }

      [SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.UnmanagedCode)]
      internal void SetExtent(int dwDrawAspect, System.Windows.Forms.NativeMethods.tagSIZEL pSizel)
      {
        if ((dwDrawAspect & 1) != 0)
        {
          if (this.activeXState[Control.ActiveXImpl.changingExtents])
            return;
          this.activeXState[Control.ActiveXImpl.changingExtents] = true;
          try
          {
            Size size1 = new Size(this.HiMetricToPixel(pSizel.cx, pSizel.cy));
            if (this.activeXState[Control.ActiveXImpl.inPlaceActive])
            {
              System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceSite oleInPlaceSite = this.clientSite as System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceSite;
              if (oleInPlaceSite != null)
              {
                Rectangle bounds = this.control.Bounds;
                bounds.Location = new Point(bounds.X, bounds.Y);
                Size size2 = new Size(size1.Width, size1.Height);
                bounds.Width = size2.Width;
                bounds.Height = size2.Height;
                oleInPlaceSite.OnPosRectChange(System.Windows.Forms.NativeMethods.COMRECT.FromXYWH(bounds.X, bounds.Y, bounds.Width, bounds.Height));
              }
            }
            this.control.Size = size1;
            if (this.control.Size.Equals((object) size1))
              return;
            this.activeXState[Control.ActiveXImpl.isDirty] = true;
            if (!this.activeXState[Control.ActiveXImpl.inPlaceActive])
              this.ViewChanged();
            if (this.activeXState[Control.ActiveXImpl.inPlaceActive] || this.clientSite == null)
              return;
            this.clientSite.RequestNewObjectLayout();
          }
          finally
          {
            this.activeXState[Control.ActiveXImpl.changingExtents] = false;
          }
        }
        else
          Control.ActiveXImpl.ThrowHr(-2147221397);
      }

      private void SetInPlaceVisible(bool visible)
      {
        this.activeXState[Control.ActiveXImpl.inPlaceVisible] = visible;
        this.control.Visible = visible;
      }

      internal void SetObjectRects(System.Windows.Forms.NativeMethods.COMRECT lprcPosRect, System.Windows.Forms.NativeMethods.COMRECT lprcClipRect)
      {
        Rectangle a = Rectangle.FromLTRB(lprcPosRect.left, lprcPosRect.top, lprcPosRect.right, lprcPosRect.bottom);
        if (this.activeXState[Control.ActiveXImpl.adjustingRect])
        {
          this.adjustRect.left = a.X;
          this.adjustRect.top = a.Y;
          this.adjustRect.right = a.Width + a.X;
          this.adjustRect.bottom = a.Height + a.Y;
        }
        else
        {
          this.activeXState[Control.ActiveXImpl.adjustingRect] = true;
          try
          {
            this.control.Bounds = a;
          }
          finally
          {
            this.activeXState[Control.ActiveXImpl.adjustingRect] = false;
          }
        }
        bool flag = false;
        if (this.clipRegion != IntPtr.Zero)
        {
          this.clipRegion = IntPtr.Zero;
          flag = true;
        }
        if (lprcClipRect != null)
        {
          Rectangle b = Rectangle.FromLTRB(lprcClipRect.left, lprcClipRect.top, lprcClipRect.right, lprcClipRect.bottom);
          Rectangle rectangle = b.IsEmpty ? a : Rectangle.Intersect(a, b);
          if (!rectangle.Equals((object) a))
          {
            System.Windows.Forms.NativeMethods.RECT rect = System.Windows.Forms.NativeMethods.RECT.FromXYWH(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
            System.Windows.Forms.UnsafeNativeMethods.MapWindowPoints(new HandleRef((object) null, System.Windows.Forms.UnsafeNativeMethods.GetParent(new HandleRef((object) this.control, this.control.Handle))), new HandleRef((object) this.control, this.control.Handle), out rect, 2);
            this.clipRegion = System.Windows.Forms.SafeNativeMethods.CreateRectRgn(rect.left, rect.top, rect.right, rect.bottom);
            flag = true;
          }
        }
        if (flag && this.control.IsHandleCreated)
        {
          IntPtr handle = this.clipRegion;
          Region region = this.control.Region;
          if (region != null)
            handle = this.MergeRegion(this.control.GetHRgn(region));
          System.Windows.Forms.UnsafeNativeMethods.SetWindowRgn(new HandleRef((object) this.control, this.control.Handle), new HandleRef((object) this, handle), System.Windows.Forms.SafeNativeMethods.IsWindowVisible(new HandleRef((object) this.control, this.control.Handle)));
        }
        this.control.Invalidate();
      }

      internal static void ThrowHr(int hr)
      {
        throw new ExternalException(System.Windows.Forms.SR.GetString("ExternalException"), hr);
      }

      internal int TranslateAccelerator(ref System.Windows.Forms.NativeMethods.MSG lpmsg)
      {
        bool flag = false;
        switch (lpmsg.message)
        {
          case 256:
          case 258:
          case 260:
          case 262:
            flag = true;
            break;
        }
        Message msg = Message.Create(lpmsg.hwnd, lpmsg.message, lpmsg.wParam, lpmsg.lParam);
        if (flag)
        {
          Control control = Control.FromChildHandleInternal(lpmsg.hwnd);
          if (control != null && (this.control == control || this.control.Contains(control)))
          {
            switch (Control.PreProcessControlMessageInternal(control, ref msg))
            {
              case PreProcessControlState.MessageProcessed:
                lpmsg.message = msg.Msg;
                lpmsg.wParam = msg.WParam;
                lpmsg.lParam = msg.LParam;
                return 0;
              case PreProcessControlState.MessageNeeded:
                System.Windows.Forms.UnsafeNativeMethods.TranslateMessage(out lpmsg);
                if (System.Windows.Forms.SafeNativeMethods.IsWindowUnicode(new HandleRef((object) null, lpmsg.hwnd)))
                  System.Windows.Forms.UnsafeNativeMethods.DispatchMessageW(ref lpmsg);
                else
                  System.Windows.Forms.UnsafeNativeMethods.DispatchMessageA(ref lpmsg);
                return 0;
            }
          }
        }
        int num = 1;
        System.Windows.Forms.UnsafeNativeMethods.IOleControlSite oleControlSite = this.clientSite as System.Windows.Forms.UnsafeNativeMethods.IOleControlSite;
        if (oleControlSite != null)
        {
          int grfModifiers = 0;
          if ((int) System.Windows.Forms.UnsafeNativeMethods.GetKeyState(16) < 0)
            grfModifiers |= 1;
          if ((int) System.Windows.Forms.UnsafeNativeMethods.GetKeyState(17) < 0)
            grfModifiers |= 2;
          if ((int) System.Windows.Forms.UnsafeNativeMethods.GetKeyState(18) < 0)
            grfModifiers |= 4;
          System.Windows.Forms.IntSecurity.UnmanagedCode.Assert();
          try
          {
            num = oleControlSite.TranslateAccelerator(ref lpmsg, grfModifiers);
          }
          finally
          {
            CodeAccessPermission.RevertAssert();
          }
        }
        return num;
      }

      internal int UIDeactivate()
      {
        if (!this.activeXState[Control.ActiveXImpl.uiActive])
          return 0;
        this.activeXState[Control.ActiveXImpl.uiActive] = false;
        if (this.inPlaceUiWindow != null)
          this.inPlaceUiWindow.SetActiveObject((System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceActiveObject) null, (string) null);
        System.Windows.Forms.IntSecurity.UnmanagedCode.Assert();
        this.inPlaceFrame.SetActiveObject((System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceActiveObject) null, (string) null);
        System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceSite oleInPlaceSite = this.clientSite as System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceSite;
        if (oleInPlaceSite != null)
          oleInPlaceSite.OnUIDeactivate(0);
        return 0;
      }

      internal void Unadvise(int dwConnection)
      {
        if (dwConnection > this.adviseList.Count || this.adviseList[dwConnection - 1] == null)
          Control.ActiveXImpl.ThrowHr(-2147221500);
        IAdviseSink adviseSink = (IAdviseSink) this.adviseList[dwConnection - 1];
        this.adviseList.RemoveAt(dwConnection - 1);
        if (adviseSink == null || !System.Windows.Forms.UnsafeNativeMethods.IsComObject((object) adviseSink))
          return;
        System.Windows.Forms.UnsafeNativeMethods.ReleaseComObject((object) adviseSink);
      }

      internal void UpdateBounds(ref int x, ref int y, ref int width, ref int height, int flags)
      {
        if (this.activeXState[Control.ActiveXImpl.adjustingRect] || !this.activeXState[Control.ActiveXImpl.inPlaceVisible])
          return;
        System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceSite oleInPlaceSite = this.clientSite as System.Windows.Forms.UnsafeNativeMethods.IOleInPlaceSite;
        if (oleInPlaceSite == null)
          return;
        System.Windows.Forms.NativeMethods.COMRECT lprcPosRect = new System.Windows.Forms.NativeMethods.COMRECT();
        if ((flags & 2) != 0)
        {
          lprcPosRect.left = this.control.Left;
          lprcPosRect.top = this.control.Top;
        }
        else
        {
          lprcPosRect.left = x;
          lprcPosRect.top = y;
        }
        if ((flags & 1) != 0)
        {
          lprcPosRect.right = lprcPosRect.left + this.control.Width;
          lprcPosRect.bottom = lprcPosRect.top + this.control.Height;
        }
        else
        {
          lprcPosRect.right = lprcPosRect.left + width;
          lprcPosRect.bottom = lprcPosRect.top + height;
        }
        this.adjustRect = lprcPosRect;
        this.activeXState[Control.ActiveXImpl.adjustingRect] = true;
        System.Windows.Forms.IntSecurity.UnmanagedCode.Assert();
        try
        {
          oleInPlaceSite.OnPosRectChange(lprcPosRect);
        }
        finally
        {
          CodeAccessPermission.RevertAssert();
          this.adjustRect = (System.Windows.Forms.NativeMethods.COMRECT) null;
          this.activeXState[Control.ActiveXImpl.adjustingRect] = false;
        }
        if ((flags & 2) == 0)
        {
          x = lprcPosRect.left;
          y = lprcPosRect.top;
        }
        if ((flags & 1) != 0)
          return;
        width = lprcPosRect.right - lprcPosRect.left;
        height = lprcPosRect.bottom - lprcPosRect.top;
      }

      internal void UpdateAccelTable()
      {
        this.accelCount = (short) -1;
        System.Windows.Forms.UnsafeNativeMethods.IOleControlSite oleControlSite = this.clientSite as System.Windows.Forms.UnsafeNativeMethods.IOleControlSite;
        if (oleControlSite == null)
          return;
        System.Windows.Forms.IntSecurity.UnmanagedCode.Assert();
        oleControlSite.OnControlInfoChanged();
      }

      internal void ViewChangedInternal()
      {
        this.ViewChanged();
      }

      private void ViewChanged()
      {
        if (this.viewAdviseSink == null || this.activeXState[Control.ActiveXImpl.saving])
          return;
        System.Windows.Forms.IntSecurity.UnmanagedCode.Assert();
        try
        {
          this.viewAdviseSink.OnViewChange(1, -1);
        }
        finally
        {
          CodeAccessPermission.RevertAssert();
        }
        if (!this.activeXState[Control.ActiveXImpl.viewAdviseOnlyOnce])
          return;
        if (System.Windows.Forms.UnsafeNativeMethods.IsComObject((object) this.viewAdviseSink))
          System.Windows.Forms.UnsafeNativeMethods.ReleaseComObject((object) this.viewAdviseSink);
        this.viewAdviseSink = (IAdviseSink) null;
      }

      void IWindowTarget.OnHandleChange(IntPtr newHandle)
      {
        this.controlWindowTarget.OnHandleChange(newHandle);
      }

      void IWindowTarget.OnMessage(ref Message m)
      {
        if (this.activeXState[Control.ActiveXImpl.uiDead] && (m.Msg >= 512 && m.Msg <= 522 || m.Msg >= 161 && m.Msg <= 169 || m.Msg >= 256 && m.Msg <= 264))
          return;
        System.Windows.Forms.IntSecurity.UnmanagedCode.Assert();
        this.controlWindowTarget.OnMessage(ref m);
      }

      internal static class AdviseHelper
      {
        public static bool AdviseConnectionPoint(object connectionPoint, object sink, System.Type eventInterface, out int cookie)
        {
          using (Control.ActiveXImpl.AdviseHelper.ComConnectionPointContainer cpc = new Control.ActiveXImpl.AdviseHelper.ComConnectionPointContainer(connectionPoint, true))
            return Control.ActiveXImpl.AdviseHelper.AdviseConnectionPoint(cpc, sink, eventInterface, out cookie);
        }

        internal static bool AdviseConnectionPoint(Control.ActiveXImpl.AdviseHelper.ComConnectionPointContainer cpc, object sink, System.Type eventInterface, out int cookie)
        {
          using (Control.ActiveXImpl.AdviseHelper.ComConnectionPoint connectionPoint = cpc.FindConnectionPoint(eventInterface))
          {
            using (Control.ActiveXImpl.AdviseHelper.SafeIUnknown safeIunknown = new Control.ActiveXImpl.AdviseHelper.SafeIUnknown(sink, true))
              return connectionPoint.Advise(safeIunknown.DangerousGetHandle(), out cookie);
          }
        }

        internal class SafeIUnknown : SafeHandle
        {
          public override sealed bool IsInvalid
          {
            get
            {
              if (!this.IsClosed)
                return IntPtr.Zero == this.handle;
              else
                return true;
            }
          }

          public SafeIUnknown(object obj, bool addRefIntPtr)
            : this(obj, addRefIntPtr, Guid.Empty)
          {
          }

          public SafeIUnknown(object obj, bool addRefIntPtr, Guid iid)
            : base(IntPtr.Zero, true)
          {
            RuntimeHelpers.PrepareConstrainedRegions();
            try
            {
            }
            finally
            {
              IntPtr pUnk1;
              if (obj is IntPtr)
              {
                pUnk1 = (IntPtr) obj;
                if (addRefIntPtr)
                  Marshal.AddRef(pUnk1);
              }
              else
                pUnk1 = Marshal.GetIUnknownForObject(obj);
              if (iid != Guid.Empty)
              {
                IntPtr pUnk2 = pUnk1;
                try
                {
                  pUnk1 = Control.ActiveXImpl.AdviseHelper.SafeIUnknown.InternalQueryInterface(pUnk1, ref iid);
                }
                finally
                {
                  Marshal.Release(pUnk2);
                }
              }
              this.handle = pUnk1;
            }
          }

          private static IntPtr InternalQueryInterface(IntPtr pUnk, ref Guid iid)
          {
            IntPtr ppv;
            if (Marshal.QueryInterface(pUnk, ref iid, out ppv) != 0 || ppv == IntPtr.Zero)
              throw new InvalidCastException(System.Windows.Forms.SR.GetString("AxInterfaceNotSupported"));
            else
              return ppv;
          }

          protected override sealed bool ReleaseHandle()
          {
            IntPtr pUnk = this.handle;
            this.handle = IntPtr.Zero;
            if (IntPtr.Zero != pUnk)
              Marshal.Release(pUnk);
            return true;
          }

          protected V LoadVtable<V>()
          {
            return (V) Marshal.PtrToStructure(Marshal.ReadIntPtr(this.handle, 0), typeof (V));
          }
        }

        internal sealed class ComConnectionPointContainer : Control.ActiveXImpl.AdviseHelper.SafeIUnknown
        {
          private Control.ActiveXImpl.AdviseHelper.ComConnectionPointContainer.VTABLE vtbl;

          public ComConnectionPointContainer(object obj, bool addRefIntPtr)
            : base(obj, addRefIntPtr, typeof (System.Runtime.InteropServices.ComTypes.IConnectionPointContainer).GUID)
          {
            this.vtbl = this.LoadVtable<Control.ActiveXImpl.AdviseHelper.ComConnectionPointContainer.VTABLE>();
          }

          public Control.ActiveXImpl.AdviseHelper.ComConnectionPoint FindConnectionPoint(System.Type eventInterface)
          {
            Control.ActiveXImpl.AdviseHelper.ComConnectionPointContainer.FindConnectionPointD connectionPointD = (Control.ActiveXImpl.AdviseHelper.ComConnectionPointContainer.FindConnectionPointD) Marshal.GetDelegateForFunctionPointer(this.vtbl.FindConnectionPointPtr, typeof (Control.ActiveXImpl.AdviseHelper.ComConnectionPointContainer.FindConnectionPointD));
            IntPtr ppv = IntPtr.Zero;
            Guid guid = eventInterface.GUID;
            if (connectionPointD(this.handle, ref guid, out ppv) == 0 && !(ppv == IntPtr.Zero))
              return new Control.ActiveXImpl.AdviseHelper.ComConnectionPoint((object) ppv, false);
            throw new ArgumentException(System.Windows.Forms.SR.GetString("AXNoConnectionPoint", new object[1]
            {
              (object) eventInterface.Name
            }));
          }

          [StructLayout(LayoutKind.Sequential)]
          private class VTABLE
          {
            public IntPtr QueryInterfacePtr;
            public IntPtr AddRefPtr;
            public IntPtr ReleasePtr;
            public IntPtr EnumConnectionPointsPtr;
            public IntPtr FindConnectionPointPtr;
          }

          [UnmanagedFunctionPointer(CallingConvention.StdCall)]
          private delegate int FindConnectionPointD(IntPtr This, ref Guid iid, out IntPtr ppv);
        }

        internal sealed class ComConnectionPoint : Control.ActiveXImpl.AdviseHelper.SafeIUnknown
        {
          private Control.ActiveXImpl.AdviseHelper.ComConnectionPoint.VTABLE vtbl;

          public ComConnectionPoint(object obj, bool addRefIntPtr)
            : base(obj, addRefIntPtr, typeof (System.Runtime.InteropServices.ComTypes.IConnectionPoint).GUID)
          {
            this.vtbl = this.LoadVtable<Control.ActiveXImpl.AdviseHelper.ComConnectionPoint.VTABLE>();
          }

          public bool Advise(IntPtr punkEventSink, out int cookie)
          {
            return ((Control.ActiveXImpl.AdviseHelper.ComConnectionPoint.AdviseD) Marshal.GetDelegateForFunctionPointer(this.vtbl.AdvisePtr, typeof (Control.ActiveXImpl.AdviseHelper.ComConnectionPoint.AdviseD)))(this.handle, punkEventSink, out cookie) == 0;
          }

          [StructLayout(LayoutKind.Sequential)]
          private class VTABLE
          {
            public IntPtr QueryInterfacePtr;
            public IntPtr AddRefPtr;
            public IntPtr ReleasePtr;
            public IntPtr GetConnectionInterfacePtr;
            public IntPtr GetConnectionPointContainterPtr;
            public IntPtr AdvisePtr;
            public IntPtr UnadvisePtr;
            public IntPtr EnumConnectionsPtr;
          }

          [UnmanagedFunctionPointer(CallingConvention.StdCall)]
          private delegate int AdviseD(IntPtr This, IntPtr punkEventSink, out int cookie);
        }
      }

      private class PropertyBagStream : System.Windows.Forms.UnsafeNativeMethods.IPropertyBag
      {
        private Hashtable bag = new Hashtable();

        [SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.UnmanagedCode)]
        internal void Read(System.Windows.Forms.UnsafeNativeMethods.IStream istream)
        {
          Stream stream = (Stream) new DataStreamFromComStream(istream);
          byte[] buffer = new byte[4096];
          int offset = 0;
          int num1 = stream.Read(buffer, offset, 4096);
          int num2 = num1;
          while (num1 == 4096)
          {
            byte[] numArray = new byte[buffer.Length + 4096];
            Array.Copy((Array) buffer, (Array) numArray, buffer.Length);
            buffer = numArray;
            offset += 4096;
            num1 = stream.Read(buffer, offset, 4096);
            num2 += num1;
          }
          Stream serializationStream = (Stream) new MemoryStream(buffer);
          BinaryFormatter binaryFormatter = new BinaryFormatter();
          try
          {
            this.bag = (Hashtable) binaryFormatter.Deserialize(serializationStream);
          }
          catch (Exception ex)
          {
            if (System.Windows.Forms.ClientUtils.IsSecurityOrCriticalException(ex))
              throw;
            else
              this.bag = new Hashtable();
          }
        }

        [SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.UnmanagedCode)]
        int System.Windows.Forms.UnsafeNativeMethods.IPropertyBag.Read(string pszPropName, ref object pVar, System.Windows.Forms.UnsafeNativeMethods.IErrorLog pErrorLog)
        {
          if (!this.bag.Contains((object) pszPropName))
            return -2147024809;
          pVar = this.bag[(object) pszPropName];
          return 0;
        }

        [SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.UnmanagedCode)]
        int System.Windows.Forms.UnsafeNativeMethods.IPropertyBag.Write(string pszPropName, ref object pVar)
        {
          this.bag[(object) pszPropName] = pVar;
          return 0;
        }

        [SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.UnmanagedCode)]
        internal void Write(System.Windows.Forms.UnsafeNativeMethods.IStream istream)
        {
          new BinaryFormatter().Serialize((Stream) new DataStreamFromComStream(istream), (object) this.bag);
        }
      }
    }

    private class AxSourcingSite : ISite, IServiceProvider
    {
      private IComponent component;
      private System.Windows.Forms.UnsafeNativeMethods.IOleClientSite clientSite;
      private string name;
      private HtmlShimManager shimManager;

      public IComponent Component
      {
        get
        {
          return this.component;
        }
      }

      public IContainer Container
      {
        get
        {
          return (IContainer) null;
        }
      }

      public bool DesignMode
      {
        get
        {
          return false;
        }
      }

      public string Name
      {
        get
        {
          return this.name;
        }
        set
        {
          if (value != null && this.name != null)
            return;
          this.name = value;
        }
      }

      internal AxSourcingSite(IComponent component, System.Windows.Forms.UnsafeNativeMethods.IOleClientSite clientSite, string name)
      {
        this.component = component;
        this.clientSite = clientSite;
        this.name = name;
      }

      public object GetService(System.Type service)
      {
        object obj = (object) null;
        if (service == typeof (HtmlDocument))
        {
          System.Windows.Forms.UnsafeNativeMethods.IOleContainer container1;
          int container2;
          try
          {
            System.Windows.Forms.IntSecurity.UnmanagedCode.Assert();
            container2 = this.clientSite.GetContainer(out container1);
          }
          finally
          {
            CodeAccessPermission.RevertAssert();
          }
          if (System.Windows.Forms.NativeMethods.Succeeded(container2) && container1 is System.Windows.Forms.UnsafeNativeMethods.IHTMLDocument)
          {
            if (this.shimManager == null)
              this.shimManager = new HtmlShimManager();
            obj = (object) new HtmlDocument(this.shimManager, container1 as System.Windows.Forms.UnsafeNativeMethods.IHTMLDocument);
          }
        }
        else if (this.clientSite.GetType().IsAssignableFrom(service))
        {
          System.Windows.Forms.IntSecurity.UnmanagedCode.Demand();
          obj = (object) this.clientSite;
        }
        return obj;
      }
    }

    private class ActiveXFontMarshaler : ICustomMarshaler
    {
      private static Control.ActiveXFontMarshaler instance;

      public void CleanUpManagedData(object obj)
      {
      }

      public void CleanUpNativeData(IntPtr pObj)
      {
        Marshal.Release(pObj);
      }

      internal static ICustomMarshaler GetInstance(string cookie)
      {
        if (Control.ActiveXFontMarshaler.instance == null)
          Control.ActiveXFontMarshaler.instance = new Control.ActiveXFontMarshaler();
        return (ICustomMarshaler) Control.ActiveXFontMarshaler.instance;
      }

      public int GetNativeDataSize()
      {
        return -1;
      }

      public IntPtr MarshalManagedToNative(object obj)
      {
        Font font = (Font) obj;
        System.Windows.Forms.NativeMethods.tagFONTDESC fontdesc = new System.Windows.Forms.NativeMethods.tagFONTDESC();
        System.Windows.Forms.NativeMethods.LOGFONT logfont = new System.Windows.Forms.NativeMethods.LOGFONT();
        System.Windows.Forms.IntSecurity.ObjectFromWin32Handle.Assert();
        try
        {
          font.ToLogFont((object) logfont);
        }
        finally
        {
          CodeAccessPermission.RevertAssert();
        }
        fontdesc.lpstrName = font.Name;
        fontdesc.cySize = (long) ((double) font.SizeInPoints * 10000.0);
        fontdesc.sWeight = (short) logfont.lfWeight;
        fontdesc.sCharset = (short) logfont.lfCharSet;
        fontdesc.fItalic = font.Italic;
        fontdesc.fUnderline = font.Underline;
        fontdesc.fStrikethrough = font.Strikeout;
        Guid guid = typeof (System.Windows.Forms.UnsafeNativeMethods.IFont).GUID;
        IntPtr iunknownForObject = Marshal.GetIUnknownForObject((object) System.Windows.Forms.UnsafeNativeMethods.OleCreateFontIndirect(fontdesc, ref guid));
        IntPtr ppv;
        int num = Marshal.QueryInterface(iunknownForObject, ref guid, out ppv);
        Marshal.Release(iunknownForObject);
        if (System.Windows.Forms.NativeMethods.Failed(num))
          Marshal.ThrowExceptionForHR(num);
        return ppv;
      }

      public object MarshalNativeToManaged(IntPtr pObj)
      {
        System.Windows.Forms.UnsafeNativeMethods.IFont font = (System.Windows.Forms.UnsafeNativeMethods.IFont) Marshal.GetObjectForIUnknown(pObj);
        IntPtr hfont = IntPtr.Zero;
        System.Windows.Forms.IntSecurity.UnmanagedCode.Assert();
        try
        {
          hfont = font.GetHFont();
        }
        finally
        {
          CodeAccessPermission.RevertAssert();
        }
        System.Windows.Forms.IntSecurity.ObjectFromWin32Handle.Assert();
        try
        {
          return (object) Font.FromHfont(hfont);
        }
        catch (Exception ex)
        {
          if (!System.Windows.Forms.ClientUtils.IsSecurityOrCriticalException(ex))
            return (object) Control.DefaultFont;
          throw;
        }
        finally
        {
          CodeAccessPermission.RevertAssert();
        }
      }
    }

    private class ActiveXVerbEnum : System.Windows.Forms.UnsafeNativeMethods.IEnumOLEVERB
    {
      private System.Windows.Forms.NativeMethods.tagOLEVERB[] verbs;
      private int current;

      internal ActiveXVerbEnum(System.Windows.Forms.NativeMethods.tagOLEVERB[] verbs)
      {
        this.verbs = verbs;
        this.current = 0;
      }

      public int Next(int celt, System.Windows.Forms.NativeMethods.tagOLEVERB rgelt, int[] pceltFetched)
      {
        int num = 0;
        if (celt != 1)
          celt = 1;
        while (celt > 0 && this.current < this.verbs.Length)
        {
          rgelt.lVerb = this.verbs[this.current].lVerb;
          rgelt.lpszVerbName = this.verbs[this.current].lpszVerbName;
          rgelt.fuFlags = this.verbs[this.current].fuFlags;
          rgelt.grfAttribs = this.verbs[this.current].grfAttribs;
          --celt;
          ++this.current;
          ++num;
        }
        if (pceltFetched != null)
          pceltFetched[0] = num;
        return celt != 0 ? 1 : 0;
      }

      public int Skip(int celt)
      {
        if (this.current + celt < this.verbs.Length)
        {
          this.current += celt;
          return 0;
        }
        else
        {
          this.current = this.verbs.Length;
          return 1;
        }
      }

      public void Reset()
      {
        this.current = 0;
      }

      public void Clone(out System.Windows.Forms.UnsafeNativeMethods.IEnumOLEVERB ppenum)
      {
        ppenum = (System.Windows.Forms.UnsafeNativeMethods.IEnumOLEVERB) new Control.ActiveXVerbEnum(this.verbs);
      }
    }

    private class AmbientProperty
    {
      private string name;
      private int dispID;
      private object value;
      private bool empty;

      internal string Name
      {
        get
        {
          return this.name;
        }
      }

      internal int DispID
      {
        get
        {
          return this.dispID;
        }
      }

      internal bool Empty
      {
        get
        {
          return this.empty;
        }
      }

      internal object Value
      {
        get
        {
          return this.value;
        }
        set
        {
          this.value = value;
          this.empty = false;
        }
      }

      internal AmbientProperty(string name, int dispID)
      {
        this.name = name;
        this.dispID = dispID;
        this.value = (object) null;
        this.empty = true;
      }

      internal void ResetValue()
      {
        this.empty = true;
        this.value = (object) null;
      }
    }

    private class MetafileDCWrapper : IDisposable
    {
      private HandleRef hBitmapDC = System.Windows.Forms.NativeMethods.NullHandleRef;
      private HandleRef hBitmap = System.Windows.Forms.NativeMethods.NullHandleRef;
      private HandleRef hOriginalBmp = System.Windows.Forms.NativeMethods.NullHandleRef;
      private HandleRef hMetafileDC = System.Windows.Forms.NativeMethods.NullHandleRef;
      private System.Windows.Forms.NativeMethods.RECT destRect;

      internal IntPtr HDC
      {
        get
        {
          return this.hBitmapDC.Handle;
        }
      }

      internal MetafileDCWrapper(HandleRef hOriginalDC, Size size)
      {
        if (size.Width < 0 || size.Height < 0)
          throw new ArgumentException("size", System.Windows.Forms.SR.GetString("ControlMetaFileDCWrapperSizeInvalid"));
        this.hMetafileDC = hOriginalDC;
        this.destRect = new System.Windows.Forms.NativeMethods.RECT(0, 0, size.Width, size.Height);
        this.hBitmapDC = new HandleRef((object) this, System.Windows.Forms.UnsafeNativeMethods.CreateCompatibleDC(System.Windows.Forms.NativeMethods.NullHandleRef));
        int deviceCaps1 = System.Windows.Forms.UnsafeNativeMethods.GetDeviceCaps(this.hBitmapDC, 14);
        int deviceCaps2 = System.Windows.Forms.UnsafeNativeMethods.GetDeviceCaps(this.hBitmapDC, 12);
        this.hBitmap = new HandleRef((object) this, System.Windows.Forms.SafeNativeMethods.CreateBitmap(size.Width, size.Height, deviceCaps1, deviceCaps2, IntPtr.Zero));
        this.hOriginalBmp = new HandleRef((object) this, System.Windows.Forms.SafeNativeMethods.SelectObject(this.hBitmapDC, this.hBitmap));
      }

      ~MetafileDCWrapper()
      {
        this.Dispose();
      }

      void IDisposable.Dispose()
      {
        if (this.hBitmapDC.Handle == IntPtr.Zero || this.hMetafileDC.Handle == IntPtr.Zero)
          return;
        if (this.hBitmap.Handle == IntPtr.Zero)
          return;
        try
        {
          this.DICopy(this.hMetafileDC, this.hBitmapDC, this.destRect, true);
          System.Windows.Forms.SafeNativeMethods.SelectObject(this.hBitmapDC, this.hOriginalBmp);
          System.Windows.Forms.SafeNativeMethods.DeleteObject(this.hBitmap);
          System.Windows.Forms.UnsafeNativeMethods.DeleteCompatibleDC(this.hBitmapDC);
        }
        finally
        {
          this.hBitmapDC = System.Windows.Forms.NativeMethods.NullHandleRef;
          this.hBitmap = System.Windows.Forms.NativeMethods.NullHandleRef;
          this.hOriginalBmp = System.Windows.Forms.NativeMethods.NullHandleRef;
          GC.SuppressFinalize((object) this);
        }
      }

      private unsafe bool DICopy(HandleRef hdcDest, HandleRef hdcSrc, System.Windows.Forms.NativeMethods.RECT rect, bool bStretch)
      {
        bool flag = false;
        HandleRef hObject = new HandleRef((object) this, System.Windows.Forms.SafeNativeMethods.CreateBitmap(1, 1, 1, 1, IntPtr.Zero));
        if (hObject.Handle == IntPtr.Zero)
          return flag;
        try
        {
          HandleRef handleRef = new HandleRef((object) this, System.Windows.Forms.SafeNativeMethods.SelectObject(hdcSrc, hObject));
          if (handleRef.Handle == IntPtr.Zero)
            return flag;
          System.Windows.Forms.SafeNativeMethods.SelectObject(hdcSrc, handleRef);
          System.Windows.Forms.NativeMethods.BITMAP bm = new System.Windows.Forms.NativeMethods.BITMAP();
          if (System.Windows.Forms.UnsafeNativeMethods.GetObject(handleRef, Marshal.SizeOf((object) bm), bm) == 0)
            return flag;
          System.Windows.Forms.NativeMethods.BITMAPINFO_FLAT bitmapinfoFlat = new System.Windows.Forms.NativeMethods.BITMAPINFO_FLAT();
          bitmapinfoFlat.bmiHeader_biSize = Marshal.SizeOf(typeof (System.Windows.Forms.NativeMethods.BITMAPINFOHEADER));
          bitmapinfoFlat.bmiHeader_biWidth = bm.bmWidth;
          bitmapinfoFlat.bmiHeader_biHeight = bm.bmHeight;
          bitmapinfoFlat.bmiHeader_biPlanes = (short) 1;
          bitmapinfoFlat.bmiHeader_biBitCount = bm.bmBitsPixel;
          bitmapinfoFlat.bmiHeader_biCompression = 0;
          bitmapinfoFlat.bmiHeader_biSizeImage = 0;
          bitmapinfoFlat.bmiHeader_biXPelsPerMeter = 0;
          bitmapinfoFlat.bmiHeader_biYPelsPerMeter = 0;
          bitmapinfoFlat.bmiHeader_biClrUsed = 0;
          bitmapinfoFlat.bmiHeader_biClrImportant = 0;
          bitmapinfoFlat.bmiColors = new byte[1024];
          long num = (long) (1 << (int) bm.bmBitsPixel * (int) bm.bmPlanes);
          if (num <= 256L)
          {
            byte[] lppe = new byte[Marshal.SizeOf(typeof (System.Windows.Forms.NativeMethods.PALETTEENTRY)) * 256];
            System.Windows.Forms.SafeNativeMethods.GetSystemPaletteEntries(hdcSrc, 0, (int) num, lppe);
            fixed (byte* numPtr1 = bitmapinfoFlat.bmiColors)
              fixed (byte* numPtr2 = lppe)
              {
                System.Windows.Forms.NativeMethods.RGBQUAD* rgbquadPtr = (System.Windows.Forms.NativeMethods.RGBQUAD*) numPtr1;
                System.Windows.Forms.NativeMethods.PALETTEENTRY* paletteentryPtr = (System.Windows.Forms.NativeMethods.PALETTEENTRY*) numPtr2;
                for (long index = 0L; index < (long) (int) num; ++index)
                {
                  ((System.Windows.Forms.NativeMethods.RGBQUAD*) ((IntPtr) rgbquadPtr + (IntPtr) (index * (long) sizeof (System.Windows.Forms.NativeMethods.RGBQUAD))))->rgbRed = ((System.Windows.Forms.NativeMethods.PALETTEENTRY*) ((IntPtr) paletteentryPtr + (IntPtr) (index * (long) sizeof (System.Windows.Forms.NativeMethods.PALETTEENTRY))))->peRed;
                  ((System.Windows.Forms.NativeMethods.RGBQUAD*) ((IntPtr) rgbquadPtr + (IntPtr) (index * (long) sizeof (System.Windows.Forms.NativeMethods.RGBQUAD))))->rgbBlue = ((System.Windows.Forms.NativeMethods.PALETTEENTRY*) ((IntPtr) paletteentryPtr + (IntPtr) (index * (long) sizeof (System.Windows.Forms.NativeMethods.PALETTEENTRY))))->peBlue;
                  ((System.Windows.Forms.NativeMethods.RGBQUAD*) ((IntPtr) rgbquadPtr + (IntPtr) (index * (long) sizeof (System.Windows.Forms.NativeMethods.RGBQUAD))))->rgbGreen = ((System.Windows.Forms.NativeMethods.PALETTEENTRY*) ((IntPtr) paletteentryPtr + (IntPtr) (index * (long) sizeof (System.Windows.Forms.NativeMethods.PALETTEENTRY))))->peGreen;
                }
              }
          }
          byte[] numArray = new byte[((long) bm.bmBitsPixel * (long) bm.bmWidth + 7L) / 8L * (long) bm.bmHeight];
          if (System.Windows.Forms.SafeNativeMethods.GetDIBits(hdcSrc, handleRef, 0, bm.bmHeight, numArray, ref bitmapinfoFlat, 0) == 0)
            return flag;
          int XDest;
          int YDest;
          int nDestWidth;
          int nDestHeight;
          if (bStretch)
          {
            XDest = rect.left;
            YDest = rect.top;
            nDestWidth = rect.right - rect.left;
            nDestHeight = rect.bottom - rect.top;
          }
          else
          {
            XDest = rect.left;
            YDest = rect.top;
            nDestWidth = bm.bmWidth;
            nDestHeight = bm.bmHeight;
          }
          if (System.Windows.Forms.SafeNativeMethods.StretchDIBits(hdcDest, XDest, YDest, nDestWidth, nDestHeight, 0, 0, bm.bmWidth, bm.bmHeight, numArray, ref bitmapinfoFlat, 0, 13369376) == -1)
            return flag;
          else
            return true;
        }
        finally
        {
          System.Windows.Forms.SafeNativeMethods.DeleteObject(hObject);
        }
      }
    }

    private class ThreadMethodEntry : IAsyncResult
    {
      private object invokeSyncObject = new object();
      internal Control caller;
      internal Control marshaler;
      internal Delegate method;
      internal object[] args;
      internal object retVal;
      internal Exception exception;
      internal bool synchronous;
      private bool isCompleted;
      private ManualResetEvent resetEvent;
      internal ExecutionContext executionContext;
      internal SynchronizationContext syncContext;

      public object AsyncState
      {
        get
        {
          return (object) null;
        }
      }

      public WaitHandle AsyncWaitHandle
      {
        get
        {
          if (this.resetEvent == null)
          {
            lock (this.invokeSyncObject)
            {
              if (this.resetEvent == null)
              {
                this.resetEvent = new ManualResetEvent(false);
                if (this.isCompleted)
                  this.resetEvent.Set();
              }
            }
          }
          return (WaitHandle) this.resetEvent;
        }
      }

      public bool CompletedSynchronously
      {
        get
        {
          return this.isCompleted && this.synchronous;
        }
      }

      public bool IsCompleted
      {
        get
        {
          return this.isCompleted;
        }
      }

      internal ThreadMethodEntry(Control caller, Control marshaler, Delegate method, object[] args, bool synchronous, ExecutionContext executionContext)
      {
        this.caller = caller;
        this.marshaler = marshaler;
        this.method = method;
        this.args = args;
        this.exception = (Exception) null;
        this.retVal = (object) null;
        this.synchronous = synchronous;
        this.isCompleted = false;
        this.resetEvent = (ManualResetEvent) null;
        this.executionContext = executionContext;
      }

      ~ThreadMethodEntry()
      {
        if (this.resetEvent == null)
          return;
        this.resetEvent.Close();
      }

      internal void Complete()
      {
        lock (this.invokeSyncObject)
        {
          this.isCompleted = true;
          if (this.resetEvent == null)
            return;
          this.resetEvent.Set();
        }
      }
    }

    private class ControlVersionInfo
    {
      private string companyName;
      private string productName;
      private string productVersion;
      private FileVersionInfo versionInfo;
      private Control owner;

      internal string CompanyName
      {
        get
        {
          if (this.companyName == null)
          {
            object[] customAttributes = this.owner.GetType().Module.Assembly.GetCustomAttributes(typeof (AssemblyCompanyAttribute), false);
            if (customAttributes != null && customAttributes.Length > 0)
              this.companyName = ((AssemblyCompanyAttribute) customAttributes[0]).Company;
            if (this.companyName == null || this.companyName.Length == 0)
            {
              this.companyName = this.GetFileVersionInfo().CompanyName;
              if (this.companyName != null)
                this.companyName = this.companyName.Trim();
            }
            if (this.companyName == null || this.companyName.Length == 0)
            {
              string str = this.owner.GetType().Namespace ?? string.Empty;
              int length = str.IndexOf("/");
              this.companyName = length == -1 ? str : str.Substring(0, length);
            }
          }
          return this.companyName;
        }
      }

      internal string ProductName
      {
        get
        {
          if (this.productName == null)
          {
            object[] customAttributes = this.owner.GetType().Module.Assembly.GetCustomAttributes(typeof (AssemblyProductAttribute), false);
            if (customAttributes != null && customAttributes.Length > 0)
              this.productName = ((AssemblyProductAttribute) customAttributes[0]).Product;
            if (this.productName == null || this.productName.Length == 0)
            {
              this.productName = this.GetFileVersionInfo().ProductName;
              if (this.productName != null)
                this.productName = this.productName.Trim();
            }
            if (this.productName == null || this.productName.Length == 0)
            {
              string str = this.owner.GetType().Namespace ?? string.Empty;
              int num = str.IndexOf(".");
              this.productName = num == -1 ? str : str.Substring(num + 1);
            }
          }
          return this.productName;
        }
      }

      internal string ProductVersion
      {
        get
        {
          if (this.productVersion == null)
          {
            object[] customAttributes = this.owner.GetType().Module.Assembly.GetCustomAttributes(typeof (AssemblyInformationalVersionAttribute), false);
            if (customAttributes != null && customAttributes.Length > 0)
              this.productVersion = ((AssemblyInformationalVersionAttribute) customAttributes[0]).InformationalVersion;
            if (this.productVersion == null || this.productVersion.Length == 0)
            {
              this.productVersion = this.GetFileVersionInfo().ProductVersion;
              if (this.productVersion != null)
                this.productVersion = this.productVersion.Trim();
            }
            if (this.productVersion.Length == 0)
              this.productVersion = "1.0.0.0";
          }
          return this.productVersion;
        }
      }

      internal ControlVersionInfo(Control owner)
      {
        this.owner = owner;
      }

      private FileVersionInfo GetFileVersionInfo()
      {
        if (this.versionInfo == null)
        {
          new FileIOPermission(PermissionState.None)
          {
            AllFiles = FileIOPermissionAccess.PathDiscovery
          }.Assert();
          string fullyQualifiedName;
          try
          {
            fullyQualifiedName = this.owner.GetType().Module.FullyQualifiedName;
          }
          finally
          {
            CodeAccessPermission.RevertAssert();
          }
          new FileIOPermission(FileIOPermissionAccess.Read, fullyQualifiedName).Assert();
          try
          {
            this.versionInfo = FileVersionInfo.GetVersionInfo(fullyQualifiedName);
          }
          finally
          {
            CodeAccessPermission.RevertAssert();
          }
        }
        return this.versionInfo;
      }
    }

    private sealed class MultithreadSafeCallScope : IDisposable
    {
      private bool resultedInSet;

      internal MultithreadSafeCallScope()
      {
        if (Control.checkForIllegalCrossThreadCalls && !Control.inCrossThreadSafeCall)
        {
          Control.inCrossThreadSafeCall = true;
          this.resultedInSet = true;
        }
        else
          this.resultedInSet = false;
      }

      void IDisposable.Dispose()
      {
        if (!this.resultedInSet)
          return;
        Control.inCrossThreadSafeCall = false;
      }
    }

    private sealed class PrintPaintEventArgs : PaintEventArgs
    {
      private Message m;

      internal Message Message
      {
        get
        {
          return this.m;
        }
      }

      internal PrintPaintEventArgs(Message m, IntPtr dc, Rectangle clipRect)
        : base(dc, clipRect)
      {
        this.m = m;
      }
    }
  }
}
