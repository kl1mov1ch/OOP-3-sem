using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace LAB09
{
    class SoftwareCollection : IEnumerator, IEnumerable
    {
        private Software[] _sofware;
        private int _index;

        public SoftwareCollection()
        {
            _index = -1;
            _sofware = Array.Empty<Software>();
        }


        //Реализация интерфейсов
        public bool MoveNext()
        {
            if (_index == _sofware.Length - 1)
            {
                Reset();
                return false;
            }

            _index++;
            return true;
        }

        public void Reset()
        {
            _index = -1;
        }

        public object Current
        {
            get
            {
                return _sofware[_index];
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (var i = 0; i < _sofware.Length; i++)
                yield return _sofware[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //Другие методы
        public void Add(Software figure)
        {
            ++_index;
            var tmp = new Software[_index + 1];
            _sofware.CopyTo(tmp, 0);
            _sofware = tmp;
            _sofware[_index] = figure;
        }
        public void Insert(int index, Software figure)
        {
            if (index < 0 || index > _index)
                throw new ArgumentOutOfRangeException();

            ++_index;
            var tmp = new Software[_index + 1];
            _sofware.CopyTo(tmp, 0);
            _sofware = tmp;
            for (int i = _index - 1; i >= index; i--)
                _sofware[i + 1] = _sofware[i];

            _sofware[index] = figure;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 && index >= _index)
                throw new ArgumentOutOfRangeException();

            _sofware = _sofware.Where((val, idx) => idx != index).ToArray();
            _index--;
        }
        public int Search(Software figure)
        {
            return Array.IndexOf(_sofware, figure);
        }
        public void Show()
        {
            foreach (var item in _sofware)
            {
                Console.WriteLine($"{item.ToString()}");
            }
        }

        //Индексатор
        public Software this[int index]
        {
            get => _sofware[index];
            private set => _sofware[index] = value;
        }
    }
}
