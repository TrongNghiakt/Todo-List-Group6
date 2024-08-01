using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todolist
{
    public static class TaskStateManager
    {
        // Lưu trạng thái checkbox với khóa là một chuỗi kết hợp StartTime và EndTime
        private static Dictionary<string, bool> checkedItems = new Dictionary<string, bool>();

        // Lấy trạng thái của checkbox
        public static bool GetCheckedState(string key)
        {
            return checkedItems.ContainsKey(key) && checkedItems[key];
        }

        // Đặt trạng thái của checkbox
        public static void SetCheckedState(string key, bool state)
        {
            checkedItems[key] = state;
        }

        // Xóa tất cả trạng thái
        public static void Clear()
        {
            checkedItems.Clear();
        }
    }
}
