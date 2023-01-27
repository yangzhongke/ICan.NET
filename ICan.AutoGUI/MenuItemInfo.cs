using Vanara.PInvoke;

namespace ICan.AutoGUI
{
	internal class MenuItemInfo
	{
		public string Text { get; set; }
		public uint MenuItemId { get; set; }
		public HMENU HSubMenu { get; set; }
	}
}
