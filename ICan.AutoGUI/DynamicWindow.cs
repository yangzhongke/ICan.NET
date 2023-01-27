using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using Vanara.PInvoke;
using static Vanara.PInvoke.User32;

namespace ICan.AutoGUI
{
	public class DynamicWindow: DynamicObject
	{
		private HWND hwnd;
		public DynamicWindow(HWND hwnd)
		{
			this.hwnd = hwnd;
		}
		public override bool TryGetMember(GetMemberBinder binder, out object result)
		{
			HMENU menu = GetMenu(hwnd);
			DynamicMenuItem? menuItem = NativeHelpers.FindMenuItem(hwnd, menu, binder.Name);
			if (menuItem != null)
			{
				result = menuItem;
				return true;
			}
			return base.TryGetMember(binder, out result);
		}

		public override IEnumerable<string> GetDynamicMemberNames()
		{
			var menu = GetMenu(hwnd);
			return NativeHelpers.GetSubMenuItems(menu).Select(e => e.Text);
		}
	}
}
