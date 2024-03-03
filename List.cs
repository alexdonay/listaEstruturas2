using System;
using static System.Net.Mime.MediaTypeNames;

namespace listaEstrutura
{
    internal class List
    {
        Nodo root;
        public List() { }
        override public string ToString()
        {
            try
            {

                string str = "";
                if (this.root == null)
                {
                    throw new Exception("sem dados a exibir");
                }
                Nodo activeNodo = this.root;
                while (activeNodo != null)
                {
                    if (activeNodo == this.root)
                    {
                        str = activeNodo.value.ToString();
                    }
                    else
                    {
                        str = $"{str}, {activeNodo.value}";
                    }

                    activeNodo = activeNodo.nextNodo;

                }
                return str;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "";
            }
        }
        public void addNodo(int value)
        {
            if (this.root == null)
            {
                this.root = new Nodo(value);
            }
            else
            {
                Nodo activeNodo = this.root;
                while (activeNodo.nextNodo != null)
                {
                    activeNodo = activeNodo.nextNodo;
                }
                activeNodo.nextNodo = new Nodo(value);
            }
        }
        public void removeNodoByValue(int value)

        {
            try
            {

                if (this.root == null)
                {
                    throw new Exception("A lista está vazia");
                }

                if (this.root.value == value)
                {
                    this.root = this.root.nextNodo;
                    return;
                }

                Nodo activeNodo = this.root;


                while (activeNodo.nextNodo != null && activeNodo.nextNodo.value != value)
                {
                    activeNodo = activeNodo.nextNodo;
                    activeNodo.nextNodo = activeNodo?.nextNodo;
                }

                if (activeNodo.nextNodo != null)
                {
                    activeNodo.nextNodo = activeNodo.nextNodo.nextNodo;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void removeNodeByIndex(int index)
        {
            try

            {
                Nodo activeNodo = this.root;


                if (index < 0)
                {
                    throw new Exception("O indice não pode ser negativo");
                }
                if (this.root == null)
                {
                    throw new Exception("A lista está vazia");
                }
                if (index == 0)
                {
                    this.root = this.root.nextNodo;
                    return;
                }
                if (index == 1)
                {
                    activeNodo.nextNodo = activeNodo.nextNodo.nextNodo;
                    return;
                }
                for (int i = 1; i < index; i++)
                {
                    activeNodo = activeNodo.nextNodo;

                    if (activeNodo == null)
                    {
                        throw new Exception("O indice está fora dos limites");
                    }
                }
                activeNodo.nextNodo = activeNodo.nextNodo.nextNodo;

            }
            catch (Exception e) { Console.WriteLine(e); }
        }
        public void order()
        {
            if (this.root == null || this.root.nextNodo == null)
            {
                Console.WriteLine("Nada a ordernar");
            }
            if (this.root.value > this.root.nextNodo.value)
            {
                Nodo temp = this.root;
                this.root = temp.nextNodo;
                temp.nextNodo = this.root.nextNodo;
                this.root.nextNodo = temp;
                this.order();
                return;
            }
            Nodo active = this.root;

            while (active.nextNodo != null)
            {
                if (active.value > active.nextNodo.value)
                {
                    int valueAux = 0;
                    valueAux = active.value;
                    active.value = active.nextNodo.value;
                    active.nextNodo.value = valueAux;
                    this.order();
                    return;

                }
                else
                {
                    Nodo temp = active;
                    active = temp.nextNodo;

                }
            }
        }
        public void changeValueByIndex(int index, int value)
        {
            try
            {
                if (index < 0)
                {
                    throw new Exception("O valor está fora dos limites");
                }
                Nodo activeNodo = this.root;

                for (int i = 0; i < index; i++)
                {
                    if (activeNodo == null)
                    {
                        throw new Exception("o valor nao foi encontrado");
                    }
                    else
                    {

                        Nodo temp = activeNodo;
                        activeNodo = temp.nextNodo;

                    }
                }
                activeNodo.value = value;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
