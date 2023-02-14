using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Set
{
    public partial class Set<T> : IEnumerable
    {

        //Коллекция хранимых данных
        List<T> _items = new List<T>();

        //Количество элементов
        public int Count => _items.Count;

        //Добавление данных во множество

        public void Add(T item)
        {
            //Проверка вхлоных двнных на нулевой элемент
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            //Множество может содержать только уникальные элементы
            //Если множество уже содержит такое  элемент, то не добавляем его
            if (!_items.Contains(item))
            {
                _items.Add(item);
            }
        }

        public void Remove(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            if (!_items.Contains(item))
            {
                throw new KeyNotFoundException($"Элемента {item} нет в этом множестве");
            }
            _items.Remove(item);
        }

        public static Set<T> Union(Set<T> set1, Set<T> set2)
        {
            if (set1 == null)
            {
                throw new ArgumentNullException(nameof(set1));
            }

            if (set2 == null)
            {
                throw new ArgumentNullException(nameof(set1));
            }

            //Результирующее множество
            var resultSet = new Set<T>();
            // Элемент данных результирующего множества
            var items = new List<T>();

            //Если первое входное множество содержит данные, то добавим их в результирующее множество 
            if (set1._items != null && set2._items.Count > 0)
            {
                items.AddRange(new List<T>(set1._items));
            }

            if (set2._items != null && set2._items.Count > 0)
            {
                items.AddRange(new List<T>(set2._items));
            }

            resultSet._items = items.Distinct().ToList();

            return resultSet;

        }


        public static Set<T> Intersection(Set<T> set1, Set<T> set2)
        {
            if (set1 == null)
            {
                throw new ArgumentNullException(nameof(set1));
            }

            if (set2 == null)
            {
                throw new ArgumentNullException(nameof(set1));
            }

            //Результирующее множество
            var resultSet = new Set<T>();

            if (set1.Count < set2.Count)
            {
                foreach (var item in set1._items)
                {
                    //Если элемент первого множества содержится во втором, то добавляем его в резутьтирующее множество
                    if (set2._items.Contains(item))
                    {
                        resultSet.Add(item);
                    }
                }
            }
            else
            {
                //Если элемент второго множества содержится в первом, то добавляем его в резутьтирующее множество
                foreach (var item in set2._items)
                {
                    if (set1._items.Contains(item))
                    {
                        resultSet.Add(item);
                    }
                }
            }
            return resultSet;
        }

        public static Set<T> Difference(Set<T> set1, Set<T> set2)
        {
            if (set1 == null)
            {
                throw new ArgumentNullException(nameof(set1));
            }

            if (set2 == null)
            {
                throw new ArgumentNullException(nameof(set1));
            }

            var resultSet = new Set<T>();

            foreach (var item in set1._items)
            {
                if (!set2._items.Contains(item))
                {
                    resultSet.Add(item);
                }
            }

            foreach (var item in set2._items)
            {
                if (!set1._items.Contains(item))
                {
                    resultSet.Add(item);
                }
            }

            resultSet._items = resultSet._items.Distinct().ToList();

            return resultSet;
        }

        public static bool Subset(Set<T> set1, Set<T> set2)
        {
            if (set1 == null)
            {
                throw new ArgumentNullException(nameof(set1));
            }

            if (set2 == null)
            {
                throw new ArgumentNullException(nameof(set1));
            }

            var result = set1._items.All(s => set2._items.Contains(s));
            return result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        public static Set<T> operator +(Set<T> set1, Set<T> set2)
        {
            return Union(set1, set2);
        }

        public static bool operator <(Set<T> set1, Set<T> set2)
        {
            return Subset(set1, set2);
        }
        public static bool operator >(Set<T> set1, Set<T> set2)
        {
            return Subset(set1, set2);
        }

        public static Set<T> operator -(Set<T> set, T item)
        {
            set.Remove(item);
            return set;
        }

        public static Set<T> operator *(Set<T> set1, Set<T> set2)
        {
            return Intersection(set1, set2);
        }
    }
    public partial class Set<T>
    {
        public class Production
        {
            static string nameOrganization = "БГТУ";
            int id;
            static int counter;

            static Production()
            {
                counter = 0;
            }

            public Production()
            {
                counter++;
                id = counter;
            }

            public override string ToString()
            {
                return nameOrganization;
            }
        }

        public class Developer
        {
            static string nameDeveloper = "Антон";
            int id;
            static int counter;

            static Developer()
            {
                counter = 0;
            }

            public Developer()
            {
                counter++;
                id = counter;
            }

            public override string ToString()
            {
                return nameDeveloper;
            }
        }

        public static class StaticOperation
        {
            public static void Point(ref Set<string> set)
            {
                for (int i = 0; i < set._items.Count; i++)
                {
                    set._items[i] += ".";
                }
            }

            public static void DeleteNullElements(ref Set<string> set)
            {
                for (int i = 0; i < set._items.Count; i++)
                {
                    if (set._items[i] == "0")
                    {
                        set._items[i].Remove(i);
                        i--;
                    }
                }
            }
        }


    }
}
