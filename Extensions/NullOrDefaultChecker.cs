﻿namespace LuffyMoney.Extensions
{
    /// <summary>
    /// Классы расширений для проверки объекта на дефолтное значение.
    /// </summary>
    public static class NullOrDefaultChecker
    {
        /// <summary>
        /// Проверка строки на null или пустое значение (с учётом пробелов).
        /// </summary>
        /// <param name="str">Строка.</param>
        /// <returns>Признак дефолтной строки (null или пустая строка/пробелы).</returns>
        public static bool IsNullOrDefault(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }

        /// <summary>
        /// Проверка объекта на null или дефолтное значение для структур.
        /// </summary>
        /// <typeparam name="T">Тип объекта.</typeparam>
        /// <param name="obj">Объект для проверки.</param>
        /// <returns>Признак дефолтного объекта.</returns>
        public static bool IsNullOrDefault<T>(this T obj)
            where T : struct
        {
            return obj.Equals(default(T));
        }

        /// <summary>
        /// Проверка объекта на null или дефолтное значение для объектов класса.
        /// </summary>
        /// <typeparam name="T">Тип объекта.</typeparam>
        /// <param name="obj">Объект для проверки.</param>
        /// <returns>Признак дефолтного объекта.</returns>
        public static bool IsNullOrDefault<T>(this T? obj)
            where T : struct
        {
            return obj == null || obj.Value.IsNullOrDefault();
        }

        /// <summary>
        /// Проверка списка на null или пустое значение.
        /// </summary>
        /// <typeparam name="T">Тип объекта.</typeparam>
        /// <param name="obj">Объект для проверки.</param>
        /// <returns>Признак дефолтного объекта.</returns>
        public static bool IsNullOrDefault<T>(this IEnumerable<T> obj)
        {
            return obj == null || !obj.Any();
        }

        /// <summary>
        /// Проверка коллекции на null или пустое значение.
        /// </summary>
        /// <typeparam name="T">Тип объекта.</typeparam>
        /// <param name="obj">Объект для проверки.</param>
        /// <returns>Признак дефолтного объекта.</returns>
        public static bool IsNullOrDefault<T>(this ICollection<T> obj)
        {
            return obj == null || obj.Count == 0;
        }
    }
}
