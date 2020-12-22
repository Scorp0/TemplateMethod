using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main()
        {
            Pawn pawn = new Pawn();
            Castle castle = new Castle();
            Knight knight = new Knight();
            pawn.Action();
            castle.Action();
            knight.Action();
            Console.Read();
        }
    }
    abstract class Checkmate
    {
        public void Action()
        {
            Move();
            Attack();
            StopAction();
        }
        public abstract void Move();
        public abstract void Attack();
        public virtual void StopAction()
        {
            Console.WriteLine("Ход завершен\n");
        }
    }

    class Pawn : Checkmate
    {
        public override void Move()
        {
            Console.WriteLine("Идем пешкой");
        }
        public override void Attack()
        {
            Console.WriteLine("Бьем фигуру по диагонали");
        }
    }
    class Castle : Checkmate
    {
        public override void Move()
        {
            Console.WriteLine("Идем ладьей");
        }
        public override void Attack()
        {
            Console.WriteLine("Бьем фигуру либо горизонтально, либо вертикально");
        }
    }
    class Knight : Checkmate
    {
        public override void Move()
        {
            Console.WriteLine("Ход конём");
        }
        public override void Attack()
        {
            Console.WriteLine("Бьем фигуры буквой Г");
        }
    }
}
