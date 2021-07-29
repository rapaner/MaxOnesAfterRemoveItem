namespace MaxOnesAfterRemoveItem
{
    /// <summary>
    /// Методы с массивами
    /// </summary>
    public static class ArrayFunctions
    {
        /// <summary>
        /// Расчет максимальной последовательности единиц после удаления любого элемента
        /// </summary>
        /// <param name="byteArray">Массив байт</param>
        public static uint MaxOnesAfterRemoveItem(byte[] byteArray)
        {
            //  максимальная последовательность
            uint maxSequence = 0;

            //  предыдущая последовательность единиц
            uint previousOnesSequence = 0;

            //  текущая последовательность единиц
            uint currentOnesSequence = 0;

            //  последовательность нулей
            uint zerosSequence = 0;

            for (int i = 0; i < byteArray.Length; i++)
            {
                byte element = byteArray[i];

                if (element == 0)
                {
                    //  если единиц не было - поиск первой единицы
                    if (currentOnesSequence == 0 && previousOnesSequence == 0)
                    {
                        continue;
                    }
                    //  если единицы были
                    else
                    {
                        //  если предыдущий элемент 0 - прибавляем последовательность нулей
                        if (byteArray[i - 1] == 0)
                        {
                            zerosSequence++;
                            continue;
                        }

                        //  если предыдущий элемент 1
                        if (byteArray[i - 1] == 1)
                        {
                            //  если текущая последовательность больше максимальной - она становится максимальной
                            if (currentOnesSequence > maxSequence)
                            {
                                maxSequence = currentOnesSequence;
                            }

                            //  если была предыдущая последовательность, между ней и текущей один 0 и их сумма больше максимальной - максимальная становится их суммой
                            if (previousOnesSequence > 0 && zerosSequence == 1 && maxSequence < previousOnesSequence + currentOnesSequence)
                            {
                                maxSequence = previousOnesSequence + currentOnesSequence;
                            }

                            previousOnesSequence = currentOnesSequence;
                            currentOnesSequence = 0;
                            zerosSequence = 1;
                        }
                    }
                }

                if (element == 1)
                {
                    currentOnesSequence++;

                    //  если текущий элемент последний в списке
                    if (i + 1 == byteArray.Length)
                    {
                        //  если весь массив из единиц - максимальная на единицу меньше длины
                        if (currentOnesSequence == byteArray.Length)
                        {
                            maxSequence = currentOnesSequence - 1;
                        }
                        else
                        {
                            //  если текущая последовательность больше максимальной - она становится максимальной
                            if (currentOnesSequence > maxSequence)
                            {
                                maxSequence = currentOnesSequence;
                            }

                            //  если была предыдущая последовательность и между ней и текущей один 0 - максимальная становится их суммой
                            if (previousOnesSequence > 0 && zerosSequence == 1 && maxSequence < previousOnesSequence + currentOnesSequence)
                            {
                                maxSequence = previousOnesSequence + currentOnesSequence;
                            }
                        }
                    }
                }
            }

            return maxSequence;
        }
    }
}