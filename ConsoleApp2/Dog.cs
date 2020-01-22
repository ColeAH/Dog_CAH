using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2 {
	public class Dog {

		private int age;
		private string name;

		public Dog() {
			age = 0;
			name = "";
		}

		public Dog(int age, string name) {
			this.setAge(age);
			this.setName(name);
		}

		public int calcDogYears() {
			int dogYears = 15 + (this.age - 1) * 7;
			return dogYears;
		}

		public int getAge() {
			return age;
		}

		public void setAge(int age) {
			if (age < 0)
				this.age = 0;
			else
				this.age = age;
		}

		public string getName() {
			return name;
		}

		public void setName(string Name) {
			bool valid = true;
			char[] n = name.ToCharArray();

			foreach (char c in n) {
				if (!Char.IsLetter(c)) {
					valid = false;
					break;
				}
			}

			if (valid)
				this.name = name;
			else
				this.name = "";
		}

		public string toString() {
			return ("Dog [age = " + age + ", name = " + name + "]");
		}
	}
}
