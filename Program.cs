using System;

namespace ReadOnlyVectorTask {
    // В пространстве имен ReadOnlyVectorTask сделайте класс ReadOnlyVector
    public class ReadOnlyVector {
        // с двумя публичными readonly-полями X и Y,
        public readonly double X;
        public readonly double Y;
        
        // которые устанавливаются в конструкторе.
        public ReadOnlyVector(double x, double y) {
            X = x;
            Y = y;
        }

        // ReadOnlyVector должен содержать метод Add(ReadOnlyVector other),
        public ReadOnlyVector Add(ReadOnlyVector other) {
            // // который возвращает сумму векторов.
            return new ReadOnlyVector(X + other.X, Y + other.Y);
        }

        // При работе с readonly классами часто хочется изготовить вектор "такой же,
        // но с другим значением поля X или Y". 
        // Обеспечьте такую функциональность с помощью методов WithX(double)
        public ReadOnlyVector WithX(double x) {
            return new ReadOnlyVector(x, Y);
        }
        //  и WithY(double)
        public ReadOnlyVector WithY(double y) {
            return new ReadOnlyVector(X, y);
        }
    }
}

/*
 * Материалы:
 * Практика «Вектор» // ULearn.me URL: https://ulearn.me/course/basicprogramming/Praktika_Vektor__e6b85bbf-1dbf-4099-84db-906579169b8d (дата обращения: 27.11.2022).
 * Классы // ULearn.me URL: https://ulearn.me/course/basicprogramming/Klassy_9eb68528-17cb-4d7f-99f3-40210a8f6cef (дата обращения: 27.11.2022).
 * Статическое и динамическое // ULearn.me URL: https://ulearn.me/course/basicprogramming/Staticheskoe_i_dinamicheskoe_9ab27cb1-cd14-4248-89d5-5981490bb766 (дата обращения: 27.11.2022).
 * Методы расширения // ULearn.me URL: https://ulearn.me/course/basicprogramming/Metody_rasshireniya_01a1f9a5-c475-4af3-bef3-060f92e69a92 (дата обращения: 27.11.2022).
 * Вычисление длины вектора по его координатам. // URL: http://images.myshared.ru/4/159798/slide_3.jpg (дата обращения: 27.11.2022).
 * Как вычислить сумму векторов // URL: https://prezentacii.org/upload/cloud/19/01/114609/images/screen9.jpg (дата обращения: 27.11.2022).
 * Поля readonly // Ulearn.me URL: https://ulearn.me/course/basicprogramming/Polya_readonly_3f87c4cb-495d-4e12-8b61-d7134e5351da (дата обращения: 11.12.2022).
 * Конструкторы // Ulearn.me URL: https://ulearn.me/course/basicprogramming/Konstruktory_87ee724d-8b7d-4d9e-b4f7-ea29c0f055ff (дата обращения: 11.12.2022).
 */