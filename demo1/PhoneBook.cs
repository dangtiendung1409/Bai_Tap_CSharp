using System;
using System.Collections.Generic;
namespace BaiTapCSharp.demo1

{

    class PhoneBook : Phone
    {
        private List<string[]> PhoneList = new List<string[]>();

        public override void InsertPhone(string name, string phone)
        {
            bool found = false;
            foreach (string[] entry in PhoneList)
            {
                if (entry[0] == name)
                {
                    if (entry[1] != phone)
                    {
                        entry[1] = phone;
                        Console.WriteLine("Cập nhật số điện thoại của " + name );
                    }
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                string[] newEntry = new string[2];
                newEntry[0] = name;
                newEntry[1] = phone;
                PhoneList.Add(newEntry);
                Console.WriteLine("Thêm liên hệ mới: " + name );
            }
        }

        public override void RemovePhone(string name)
        {
            PhoneList.RemoveAll(entry => entry[0] == name);
            Console.WriteLine("Xoá liên hệ có tên " + name);
        }

        public override void UpdatePhone(string name, string newPhone)
        {
            foreach (string[] entry in PhoneList)
            {
                if (entry[0] == name)
                {
                    entry[1] = newPhone;
                    Console.WriteLine("Cập nhật số điện thoại của  " + name);
                    break;
                }
            }
        }

        public override void SearchPhone(string name)
        {
            foreach (string[] entry in PhoneList)
            {
                if (entry[0] == name)
                {
                    Console.WriteLine("Tên: " + entry[0] + ", Số điện thoại: " + entry[1]);
                    return;
                }
            }
            Console.WriteLine("Không tìm thấy liên hệ có tên " + name);
        }

        public override void Sort()
        {
            PhoneList.Sort((entry1, entry2) => entry1[0].CompareTo(entry2[0]));
            Console.WriteLine("Danh sách đã được sắp xếp.");
        }
    }
}

