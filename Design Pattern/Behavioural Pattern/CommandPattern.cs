using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviouralPattern.CommandPattern
{
    // 요구사항을 객체로 캡슐화하는 것을 목표로 함
    // 요청이 서로 다른 사용자, 시간 또는 프로젝트에 따라 달라질 수 있을 때 유용함

    // 매개변수를 사용하여 여러 요구 사항을 추가할 수 있음
    // 요청 내역을 큐에 저장하거나 로그로 기록할 수 있음
    // 작업취소 기능도 지원 가능
    // 실행될 기능을 캡슐화하여 여러 기능을 실행할 수 있는 재사용성이 높은 클래스를 설계

    // 클라이언트: 처리 과정은 궁금하지 않고 결과만 올바르게  출력되면 됨.

    // ConcreteCommand: Command 인터페이스를 구현함. 특정 행동(Execute)와 Receiver 사이를 연결함. 
    // Invoker: 명령이 들어 있어 Execute 메소드를 통해 Command에게 특정 작업을 수행해달라고 요청함
    // Receiver: 요구사항을 처리하기 위해 실제 작동하는 클래스

    #region Command (interface)
    public interface Command
    {
        void Execute();

        void Undo();
    }
    #endregion

    #region Receiver
    public class Light
    {
        string location;

        public Light(string location)
        {
            this.location = location;
        }

        public void On()
        {
            Console.WriteLine($"{location} light on");
        }

        public void Off()
        {
            Console.WriteLine($"{location} light off");
        }
    }

    public class Stereo
    {
        string location;

        public Stereo(string location)
        {
            this.location = location;
        }

        public void On()
        {
            Console.WriteLine($"{location} stereo on");
        }

        public void Off()
        {
            Console.WriteLine($"{location} stereo off");
        }

        public void SetCD()
        {
            Console.WriteLine($"{location} stereo set CD");
        }

        public void SetDVD()
        {
            Console.WriteLine($"{location} stereo set DVD");
        }

        public void SetRadio()
        {
            Console.WriteLine($"{location} stereo set Radio");
        }
    }

    public class CeilingFan
    {
        public const int HIGH = 3;
        public const int MEDIUM = 2;
        public const int LOW = 1;
        public const int OFF = 0;

        string location;
        int speed;

        public int Speed
        {
            get { return speed; }
        }

        public CeilingFan(string location)
        {
            this.location = location;
        }

        public void High()
        {
            speed = HIGH;
            Console.WriteLine($"{location} ceiling fan on. Speed: High");
        }

        public void Medium()
        {
            speed = MEDIUM;
            Console.WriteLine($"{location} ceiling fan on. Speed: Medium");
        }

        public void Low()
        {
            speed = LOW;
            Console.WriteLine($"{location} ceiling fan on. Speed: Low");
        }

        public void Off()
        {
            speed = OFF;
            Console.WriteLine($"{location} ceiling fan off");
        }
    }
    #endregion

    #region ConcreteCommand
    public class LightOnCommand : Command
    {
        Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.On();
        }

        public void Undo()
        {
            light.Off();
        }
    }

    public class LightOffCommand:Command
    {
        Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.Off();
        }

        public void Undo()
        {
            light.On();
        }
    }

    public class StereoOnCDCommand : Command
    {
        Stereo stereo;

        public StereoOnCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.On();
            stereo.SetCD();
        }

        public void Undo()
        {
            stereo.Off();
        }
    }

    public class StereoOffCommand : Command
    {
        Stereo stereo;

        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.Off();
        }

        public void Undo()
        {
            stereo.On();
        }
    }

    public abstract class CeilingFanCommand: Command
    {
        protected CeilingFan ceilingFan;
        int prevSpeed;

        public CeilingFanCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public virtual void Execute()
        {
            prevSpeed = ceilingFan.Speed;
        }

        public void Undo()
        {
            switch (prevSpeed)
            {
                case CeilingFan.HIGH:
                    ceilingFan.High(); break;
                case CeilingFan.MEDIUM:
                    ceilingFan.Medium(); break;
                case CeilingFan.LOW:
                    ceilingFan.Low(); break;
                default:
                    ceilingFan.Off(); break;
            }
        }
    }
    
    public class CeilingFanHighCommand: CeilingFanCommand
    {
        public CeilingFanHighCommand(CeilingFan ceilingFan) : base(ceilingFan) { }

        public override void Execute()
        {
            base.Execute();
            ceilingFan.High();
        }
    }

    public class CeilingFanMediumCommand : CeilingFanCommand
    {
        public CeilingFanMediumCommand(CeilingFan ceilingFan) : base(ceilingFan) { }

        public override void Execute()
        {
            base.Execute();
            ceilingFan.Medium();
        }
    }

    public class CeilingFanLowCommand : CeilingFanCommand
    {
        public CeilingFanLowCommand(CeilingFan ceilingFan) : base(ceilingFan) { }

        public override void Execute()
        {
            base.Execute();
            ceilingFan.Low();
        }
    }

    public class CeilingFanOffCommand : CeilingFanCommand
    {
        public CeilingFanOffCommand(CeilingFan ceilingFan) : base(ceilingFan) { }

        public override void Execute()
        {
            base.Execute();
            ceilingFan.Off();
        }
    }

    public class NoCommand : Command
    {
        public void Execute()
        {

        }

        public void Undo()
        {

        }
    }

    public class MacroCommand : Command
    {
        Command[] commands;

        public MacroCommand(Command[] commands)
        {
            this.commands = commands;
        }

        public void Execute()
        {
            for(int i=0; i<commands.Length; i++)
            {
                commands[i].Execute();
            }
        }

        public void Undo()
        {
            for(int i=0; i < commands.Length; i++)
            {
                commands[i].Undo();
            }
        }
    }
    #endregion

    #region Invoker
    public class SimpleRemoteControl
    {
        Command slot;

        public SimpleRemoteControl() { }

        public void SetCommand(Command command)
        {
            slot=command;
        }

        public void ButtonWasPressed()
        {
            slot.Execute();
        }
    }

    public class RemoteControl
    {
        Command[] onCommands;
        Command[] offCommands;
        Command undoCommand;

        public RemoteControl()
        {
            onCommands = new Command[7];
            offCommands = new Command[7];

            Command noCommand = new NoCommand();

            for(int i=0; i<7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }

            undoCommand = noCommand;
        }

        public void SetCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
            undoCommand = onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
            undoCommand = offCommands[slot];
        }

        public void UndoButtonWasPushed()
        {
            undoCommand.Undo();
        }

        public new string ToString()
        {
            StringBuilder stringBuilder= new StringBuilder();

            stringBuilder.Append("\n------ Remote Control -------\n");

            for(int i=0; i< onCommands.Length; i++)
            {
                stringBuilder.Append($"[slot {i}] {onCommands[i].GetType().Name}\t{offCommands[i].GetType().Name}\n");
            }

            return stringBuilder.ToString();
        }
    }
    #endregion

    public class RemoteControlTest
    {
        public static void main(string[] args)
        {
            SimpleRemoteControl simpleRemoteControl = new SimpleRemoteControl();

            Light light = new Light("");
            LightOnCommand lightOnCommand= new LightOnCommand(light);

            simpleRemoteControl.SetCommand(lightOnCommand);
            simpleRemoteControl.ButtonWasPressed();

            ///

            RemoteControl remoteControl = new RemoteControl();

            Light kitchinLight = new Light("kitchen");
            Stereo livingRoomStereo = new Stereo("livingRoom");
            CeilingFan ceilingFan = new CeilingFan("livingRoom");

            LightOnCommand kitchinLightOn = new LightOnCommand(kitchinLight);
            LightOffCommand kitchinLightOff = new LightOffCommand(kitchinLight);

            StereoOnCDCommand stereoOnCD = new StereoOnCDCommand(livingRoomStereo);
            StereoOffCommand stereoOff = new StereoOffCommand(livingRoomStereo);

            CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            Command[] allOn = { kitchinLightOn, stereoOnCD, ceilingFanHigh };
            Command[] allOff = { kitchinLightOff, stereoOff, ceilingFanOff };

            MacroCommand allOnMacro = new MacroCommand(allOn);
            MacroCommand allOffMacro = new MacroCommand(allOff);

            remoteControl.SetCommand(0, kitchinLightOn, kitchinLightOff);
            remoteControl.SetCommand(1, stereoOnCD, stereoOff);
            remoteControl.SetCommand(2, ceilingFanHigh, ceilingFanOff);
            remoteControl.SetCommand(3, ceilingFanMedium, ceilingFanOff);

            remoteControl.SetCommand(4, allOnMacro, allOffMacro);

            Console.WriteLine("현재 리모컨 버튼 매핑 현황");
            Console.WriteLine(remoteControl);

            Console.WriteLine("명령 수행");

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);

            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);
            
            // undo
            remoteControl.OnButtonWasPushed(2);
            remoteControl.OffButtonWasPushed(2);

            remoteControl.UndoButtonWasPushed();

            remoteControl.OnButtonWasPushed(3);

            remoteControl.UndoButtonWasPushed();

            // macro
            remoteControl.OnButtonWasPushed(4);
            remoteControl.OffButtonWasPushed(4);
        }
    }
}
