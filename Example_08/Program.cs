// Для начала необходимо определить вершины треугольника.
// Определим мы их следующим образом: Для первой точки - первой вершины, например, 
// «xa», отступ по Х будет в 01 символ, и для «ya» отступ также будет равняться 1 символу.
// Следующая вершина будет для второй точки — «xb». Она будет находиться по аналогии с примером. 
// Если до этого отступ равнялся 1, то здесь мы отступим хотя бы 10 точек, хотя можно и побольше.
// Зададим отступ от левого края снова 1 символ, а для отступа от верхнего края — «yb» — отступ будет 30 точек.

// int xa = 1;   
// int ya = 1;  
// int xb = 1;
// int yb = 30;
// int xc = 40;
// int yc = 20
//
// we will write the same code below more compactly


int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

// Определим 3 точку(xc; yc). Если на рисунке у нас
// точка примерно (1; 30) отступ по игреку 
// будет такой же — 30, а по иксу сделаем, например, 40.
// Если понадобится, позже мы подправим эти числа.
// перезададим xc = 80

Console.Clear();
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;

int count = 0;

while (count < 100)
{
    int what = new Random().Next(0, 3); // [0;3)  0 1 2 
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1;
}


// instead of writing: <count = count + 1> often use
// count +=1 or count++;  
