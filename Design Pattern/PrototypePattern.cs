using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.PrototypePattern
{
    // DB에 접근하여 데이터를 가져오는 행위는 비용이 큼
    // 따라서 DB에 접근하여 가져온 데이터를 필요에 따라 새로운 객체에 복사하여 데이터 수정 작업을 진행하는 것이 효율적임
    // shallow copy일지 deep copy일지는 경우에 따라 선택적으로 진행

    // 객체 생성 비용과 시간을 줄일 수 있음
    // 새로운 객체 생성 과정에서 발생할 수 있는 오버헤드 줄일 수 있음
    // 객체 생성 방법이 복잡하거나 생성할 객체의 타입이 동적으로 결정되는 경우 유용함

    // Clone 구현이 어렵거나 불가능한 경우에 지양한다

    public class Employees : ICloneable
    {
        List<string> empList;

        public Employees()
        {
            empList = new List<string>();
        }

        public Employees(List<string> empList)
        {
            this.empList = empList;
        }

        public void LoadData()
        {
            empList.Add("Ann");
            empList.Add("David");
            empList.Add("John");
            empList.Add("Methew");
        }

        public object Clone()
        {
            List<string> temp = empList.ToList();

            return new Employees(temp);
        }
    }

    public abstract class ProtoType
    {
        public abstract ProtoType Clone();
    }

    public class ConcreteProtoTypeA:ProtoType
    {
        public override ProtoType Clone()
        {
            return (ConcreteProtoTypeA)this.MemberwiseClone();
        }
    }

    public class ConcreteProtoTypeB:ProtoType
    {
        public override ProtoType Clone()
        {
            return (ConcreteProtoTypeB)this.MemberwiseClone();
        }
    }
}
