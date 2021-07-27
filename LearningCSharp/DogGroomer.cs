using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    public class DogGroomer
    {

        public void WashTheDog(Dog dog)
        {
            //dog.Name = "The Dog " + dog.Name + " is now clean and groomed";
            //dog.Name = string.Format("The Dog {0} is now clean and groomed", dog.Name);
            dog.Name = $"The Dog {dog.Name} is now clean and groomed!";
        }

        public void WashTheNumber(ref int aNumber)
        {
            aNumber = aNumber * 2;
        }
    }
}
