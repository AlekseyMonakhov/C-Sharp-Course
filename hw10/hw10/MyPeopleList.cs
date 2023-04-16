using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    public class MyPeopleList : IEnumerable<Person>
    {
        private Person[] _persons;

        public MyPeopleList(Person[] persons)
        {
            _persons = persons;
        }

        public IEnumerator GetEnumerator()
        {
            return new PeopleListEnum(_persons);
        }

        IEnumerator<Person> IEnumerable<Person>.GetEnumerator()
        {
            return (IEnumerator<Person>)GetEnumerator();
        }
    }

    public class PeopleListEnum : IEnumerator<Person>
    {
        public object Current 
        { 
            get 
            { 
                return _persons[_index]; 
            } 
        }

        Person IEnumerator<Person>.Current => (Person)Current;

        private readonly Person[] _persons;
        private int _index = -1;

        public PeopleListEnum(Person[] persons)
        {
            _persons = persons;
        }

        public bool MoveNext()
        {
            if (++_index == _persons.Length)
            {
                return false;
            }

            return true;
        }

        public void Reset()
        {
            _index = -1;
        }

        public void Dispose()
        {
        }
    }
}
