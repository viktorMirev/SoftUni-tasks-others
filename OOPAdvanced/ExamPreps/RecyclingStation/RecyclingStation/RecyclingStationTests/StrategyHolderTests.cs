using NUnit.Framework;
using RecyclingStation.Logic.Attributes;
using RecyclingStation.Logic.Strategies;
using RecyclingStation.WasteDisposal;
using RecyclingStation.WasteDisposal.Attributes;
using RecyclingStation.WasteDisposal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingStationTests
{
    [TestFixture]
    public class StrategyHolderTests
    {
        [Test]
        public void TestAddSome()
        {
            IGarbageDisposalStrategy ds = new BurnableDisposalStrategy();
            Type type = typeof(DisposableAttribute);
            IStrategyHolder sh = new StrategyHolder();
            Dictionary<Type, IGarbageDisposalStrategy> dic = new Dictionary<Type, IGarbageDisposalStrategy>();
            dic.Add(type, ds);
            IGarbageDisposalStrategy ss = new  StorableDisposalStrategy();
            dic.Add(typeof(BurnableAttribute), ss);


            sh.AddStrategy(type, ds);
            sh.AddStrategy(typeof(BurnableAttribute), ss);

            Assert.AreEqual(sh.GetDisposalStrategies, dic);
            
        }

        [Test]
        public void TestAdd()
        {
            IGarbageDisposalStrategy ds = new BurnableDisposalStrategy();
            Type type = typeof(DisposableAttribute);
            IStrategyHolder sh = new StrategyHolder();
            Dictionary<Type, IGarbageDisposalStrategy> dic = new Dictionary<Type, IGarbageDisposalStrategy>();
            
    

            Assert.IsTrue(sh.AddStrategy(type, ds));

        }

        [Test]
        public void TestRemove()
        {
            IGarbageDisposalStrategy ds = new BurnableDisposalStrategy();
            Type type = typeof(DisposableAttribute);
            IStrategyHolder sh = new StrategyHolder();
            Dictionary<Type, IGarbageDisposalStrategy> dic = new Dictionary<Type, IGarbageDisposalStrategy>();
            
            IGarbageDisposalStrategy ss = new StorableDisposalStrategy();
            dic.Add(typeof(BurnableAttribute), ss);


            sh.AddStrategy(type, ds);
            sh.AddStrategy(typeof(BurnableAttribute), ss);
            sh.RemoveStrategy(type);

            Assert.AreEqual(sh.GetDisposalStrategies, dic);

        }

        [Test]
        public void TestRemoveOne()
        {
            IGarbageDisposalStrategy ds = new BurnableDisposalStrategy();
            Type type = typeof(DisposableAttribute);
            IStrategyHolder sh = new StrategyHolder();
            Dictionary<Type, IGarbageDisposalStrategy> dic = new Dictionary<Type, IGarbageDisposalStrategy>();
           
            sh.AddStrategy(type,ds);

            Assert.IsTrue(sh.RemoveStrategy(type));

        }

        [Test]
        public void TestRemoveFromEmpty()
        {
            IGarbageDisposalStrategy ds = new BurnableDisposalStrategy();
            Type type = typeof(DisposableAttribute);
            IStrategyHolder sh = new StrategyHolder();
            Dictionary<Type, IGarbageDisposalStrategy> dic = new Dictionary<Type, IGarbageDisposalStrategy>();
            dic.Add(type, ds);
           

            sh.AddStrategy(type, ds);
            sh.RemoveStrategy(type);
   

            Assert.IsFalse(sh.RemoveStrategy(type));

        }

        [Test]
        public void TestIfIsIreadonly()
        {
            IStrategyHolder sh = new StrategyHolder();
            

            Assert.IsTrue(sh.GetDisposalStrategies.GetType().GetInterfaces().Contains(typeof(IReadOnlyCollection<>)),$"Expected {typeof(IReadOnlyCollection<>)} ");
        }
    }
}
