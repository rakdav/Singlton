﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class IPhoneDeveloper : IDeveloper
    {
        private Phone phone;
        public IPhoneDeveloper() => phone = new Phone();
        public void CreateBox() => phone.AppendData("Создаем Iphone");
        public void CreateDisplay() => phone.AppendData("Создаем корпус");
        public Phone GetPhone() => phone;
        public void SyttemInstall() => phone.AppendData("Устанавливаем OS IOS");
    }
}