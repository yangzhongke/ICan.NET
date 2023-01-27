﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using Vanara.PInvoke;
using static Vanara.PInvoke.User32;

namespace ICan.AutoGUI
{
	public class DynamicMenuItem : DynamicObject
	{
		private HWND hwnd;
		private HMENU menu;
		private uint menuId;
		public DynamicMenuItem(HWND hwnd,HMENU menu, uint menuId)
		{
			this.hwnd = hwnd;
			this.menu = menu;
			this.menuId = menuId;
		}

		public override bool TryGetMember(GetMemberBinder binder, out object result)
		{
			DynamicMenuItem? menuItem = NativeHelpers.FindMenuItem(hwnd, menu, binder.Name);
			if(menuItem!=null)
			{
				result = menuItem;
				return true;
			}
			return base.TryGetMember(binder, out result);
		}

		public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
		{
			DynamicMenuItem? menuItem = NativeHelpers.FindMenuItem(hwnd, menu, binder.Name);
			if (menuItem != null)
			{
				result = menuItem;
				User32.SendMessage(hwnd, WindowMessage.WM_COMMAND, menuItem.menuId, IntPtr.Zero);
				return true;
			}
			return base.TryInvokeMember(binder, args, out result);
		}

		public override IEnumerable<string> GetDynamicMemberNames()
		{
			return NativeHelpers.GetSubMenuItems(menu).Select(e=>e.Text);
		}
	}
}
