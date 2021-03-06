﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using designPatterns.behaviour;
using designPatterns.Creational;
using designPatterns.Structural;

namespace designPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Creational Patterns

            //## Factory DP
            //CreationDP.FactoryDP();

            //## Abstract Factory DP
            //CreationDP.AbstractFactoryDP();

            //#Prototype DP
            //CreationDP.ProtoTypeDP();

            //## Singleton  DP
            //CreationDP.SingletonDP();

            //## Builder DP
            //CreationDP.BuilderDP();

            #endregion


            #region Structural

            //## Adapter DP
            //StructureDP.AdapterDP();

            //## Bridge DP
            //StructureDP.BridgeDP();

            //## Flyweight DP
            //Flyweight.Test();

            //##Composite DP
            //StructureDP.CompositeDP();

            //##Decorator DP
            //StructureDP.Decorator();

            //##Proxy DP
            //StructureDP.Proxy();

            #endregion

            #region Behaviour

            //BehavioursDP.ChainOfResp();

            //Command Design Pattern
            //BehavioursDP.CommandDP();

            #endregion

            Console.ReadLine();
        }
    }

    /// <summary>
    /// Creation Design Patterns
    /// </summary>
    public static class CreationDP
    {

        public static void FactoryDP()
        {
            var fac = new Factory();
            fac.Demonstrate();
        }

        public static void AbstractFactoryDP()
        {
            ICar car1 = AbstractFactory.CreateCar(1);
            ICar car2 = AbstractFactory.CreateCar(2);

            Console.WriteLine($"Abstract create car 1 -{car1.GetCarModel()} and car 2 {car2.GetCarModel()}");

        }

        public static void ProtoTypeDP()
        {
            var PtDp = new Prototype();
            PtDp.Demonstrate();
        }

        public static void SingletonDP()
        {
            var sdp = new SingleTon();
            sdp.Demonstrate();
        }

        public static void BuilderDP()
        {
            var BDP = new Builder();
            BDP.Demonstrate();
        }
    }



    public static class StructureDP
    {

        public static void AdapterDP()
        {
            var adap = new Adapter();

            Console.WriteLine($"the new Adapter value is {adap.GetNewMEthod()}");
        }

        public static void BridgeDP()
        {
            var bridge = new Bridge();
            bridge.Demonstrate();
        }

        public static void CompositeDP()
        {
            var compositeDP = new Composite();

            compositeDP.Demonstrate();

        }

        public static void Facade()
        {   
            var fas = new Facade();
            fas.GetTempretureInformation("1000");
        }

        public static void Proxy()
        {
            var prox = new Proxy();
            prox.demonstrate();
        }

        public static void Decorator()
        {
            var decor = new DecoratorDP();
            decor.Demonstrate();
        }
    }


    public static class BehavioursDP
    {
        public static void ChainOfResp()
        {
            var cOr = new ChainOFResponsabillity();
            cOr.Test();
        }

        public static void CommandDP()
        {
            var cmd =new Command();
            cmd.Demonstrate();
        }

    }
}
