using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ape_expresionesArbolesBinarios
{
    class Arbol
    {
        Nodo ultimo, primero, temp;

        Stack<string> pila1 = new Stack<string>();      //Para resolver con PreOrder
        Stack<double> pila2 = new Stack<double>();

        Queue<string> cola1 = new Queue<string>();      //Para resolver con PostOrder
        Stack<double> pila3 = new Stack<double>();

        public void leerExpresion(string vExpresion)
        {
            //Se hace la lista con cada caracter de la expresión
            for (int i = 0; i < vExpresion.Length; i++)
            {
                crearLista(new Nodo(vExpresion[i].ToString()));
            }
            //Después de la lista hace el árbol
            hacerArbol();
        }

        public void crearLista(Nodo nuevoN)
        {
            //Crea la lista al descomponer la expresión matemática
            if (primero == null)
            {
                primero = nuevoN;
                ultimo = nuevoN;
            }
            else
            {
                nuevoN.anterior = ultimo;
                ultimo.siguiente = nuevoN;
                ultimo = nuevoN;
            }
        }

        public void hacerArbol()
        {
            //Hace árbol jerarquizando
            multYDiv();
            sumaYResta();
        }

        public void multYDiv()
        {
            temp = primero;

            while (temp != null)
            {
                if (temp.dato == "*" || temp.dato == "x" || temp.dato == "/")
                {
                    temp.izq = temp.anterior;
                    temp.der = temp.siguiente;
                    if (temp.anterior == primero)
                    {
                        primero = temp;
                        temp.anterior = null;
                    }
                    else
                    {
                        temp.anterior = temp.anterior.anterior;
                        temp.anterior.siguiente = temp;
                    }
                    temp.siguiente = temp.siguiente.siguiente;
                    if (temp.siguiente != null)
                        temp.siguiente.anterior = temp;
                }

                temp = temp.siguiente;
            }
        }

        public void sumaYResta()
        {
            temp = primero;

            while (temp != null)
            {
                if (temp.dato == "-" || temp.dato == "+")
                {
                    temp.izq = temp.anterior;
                    temp.der = temp.siguiente;
                    if (temp.anterior == primero)
                    {
                        primero = temp;
                        temp.anterior = null;
                    }
                    else
                    {
                        temp.anterior = temp.anterior.anterior;
                        temp.anterior.siguiente = temp;
                    }
                    temp.siguiente = temp.siguiente.siguiente;
                    if (temp.siguiente != null)
                        temp.siguiente.anterior = temp;
                }

                temp = temp.siguiente;
            }
            
        }

        ////////////////////  INORDER - INICIO  ////////////////////
        public string inOrder()
        {
            if (primero == null)
                return "";
            else
                return inOrder(primero);
        }

        private string inOrder(Nodo R)
        {
            string inor = "";

            if (R.izq != null)
                inor += inOrder(R.izq);

            inor += R.ToString();

            if (R.der != null)
                inor += inOrder(R.der);

            return inor;
        }
        ////////////////////  INORDER - FIN  ////////////////////

        ////////////////////  PREORDER - INICIO  ////////////////////
        public string preOrder()
        {
            if (primero == null)
                return "";
            else
                return preOrder(primero);
        }

        private string preOrder(Nodo R)
        {
            string preor = "";

            preor += R.ToString();
            pila1.Push(R.dato.ToString());  //Al mismo tiempo que saca el preOrder, lo va guardando en la pila para sacar el resultado

            if (R.izq != null)
                preor += preOrder(R.izq);

            if (R.der != null)
                preor += preOrder(R.der);

                return preor;
        }
        ////////////////////  PREORDER - FIN  ////////////////////

        ////////////////////  RESOLVER EN PREORDER - INICIO  ////////////////////
        public double resolverPreOrder()
        {
            while (pila1.Peek() != primero.dato)
                operacionesPreOrder();

            operacionesPreOrder();

            return pila2.Peek();
        }

        public void operacionesPreOrder()
        {
            double vIzq, vDer, vResult;

            if (pila1.Peek() != "+" && pila1.Peek() != "-" && pila1.Peek() != "*" && pila1.Peek() != "x" && pila1.Peek() != "/")
                pila2.Push(Convert.ToDouble(pila1.Pop()));
            else
            {
                vIzq = Convert.ToDouble(pila2.Pop());
                vDer = Convert.ToDouble(pila2.Pop());
                char operador = Convert.ToChar(pila1.Pop());

                switch (operador)
                {
                    case '-':
                        vResult = vIzq - vDer;
                        break;
                    case '*':
                    case 'x':
                        vResult = vIzq * vDer;
                        break;
                    case '/':
                        vResult = vIzq / vDer;
                        break;
                    default:
                        vResult = vIzq + vDer;
                        break;
                }
                pila2.Push(vResult);
            }
        }
        ////////////////////  RESOLVER EN PREORDER - FIN  ////////////////////

        ////////////////////  POSTORDER - INICIO  ////////////////////
        public string postOrder()
        {
            if (primero == null)
                return "";
            else
                return postOrder(primero);
        }

        private string postOrder(Nodo R)
        {
            string postor = "";

            if (R.izq != null)
                postor += postOrder(R.izq);

            if (R.der != null)
                postor += postOrder(R.der);

            postor += R.ToString();
            cola1.Enqueue(R.dato.ToString());  //Al mismo tiempo que saca el postOrder, lo va guardando en la cola para sacar el resultado

            return postor;
        }
        ////////////////////  POSTORDER - FIN  ////////////////////

        ////////////////////  RESOLVER EN POSTORDER - INICIO  ////////////////////
        public double resolverPostOrder()
        {
            while (cola1.Peek() != primero.dato)
                operacionesPostOrder();

            operacionesPostOrder();

            return pila3.Peek();
        }

        public void operacionesPostOrder()
        {
            double vIzq, vDer, vResult;

            if (cola1.Peek() != "+" && cola1.Peek() != "-" && cola1.Peek() != "*" && cola1.Peek() != "x" && cola1.Peek() != "/")
                pila3.Push(Convert.ToDouble(cola1.Dequeue()));
            else
            {
                vDer = Convert.ToDouble(pila3.Pop());
                vIzq = Convert.ToDouble(pila3.Pop());
                char operador = Convert.ToChar(cola1.Dequeue());

                switch (operador)
                {
                    case '-':
                        vResult = vIzq - vDer;
                        break;
                    case '*':
                    case 'x':
                        vResult = vIzq * vDer;
                        break;
                    case '/':
                        vResult = vIzq / vDer;
                        break;
                    default:
                        vResult = vIzq + vDer;
                        break;
                }
                pila3.Push(vResult);
            }
        }
        ////////////////////  RESOLVER EN POSTORDER - FIN  ////////////////////

        public string mostrar()
        {
            //Este método imprime la raíz del árbol
            string vExpresion = "";
            temp = primero;

            while (temp != null)
            {
                vExpresion += Convert.ToChar(temp.dato).ToString(); //Convierte el dato de código ASCII a caracter
                temp = temp.siguiente;
            }

            return vExpresion;
        }
    }
}
