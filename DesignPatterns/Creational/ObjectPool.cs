using System;
using System.Collections.Generic;

namespace ConsoleProject.Creational
{
    public class ObjectPool
    {
        private readonly IList<DummyObject> _availableObjects = new List<DummyObject>();
        private readonly IList<DummyObject> _inUseObjects = new List<DummyObject>();

        public DummyObject GetObject()
        {
            lock (_availableObjects)
            {
                DummyObject objReturned;
                if (_availableObjects.Count == 0)
                {
                    objReturned = new DummyObject();
                }
                else
                {
                    objReturned = _availableObjects[0];
                    _availableObjects.Remove(objReturned);
                }
                _inUseObjects.Add(objReturned);
                return objReturned;
            }
        }

        public void ReleaseObject(DummyObject objReleased)
        {
            CleanObject(objReleased);

            lock (_availableObjects)
            {
                _availableObjects.Add(objReleased);
                _inUseObjects.Remove(objReleased);
            }
        }

        public int GetTotalCount()
        {
            return _availableObjects.Count + _inUseObjects.Count;
        }

        private void CleanObject(DummyObject objReleased)
        {
            objReleased.TextualData = null;
        }
    }

    public class DummyObject
    {
        private readonly DateTime _createdAt = DateTime.Now;

        public string TextualData { get; set; }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }
    }
}
