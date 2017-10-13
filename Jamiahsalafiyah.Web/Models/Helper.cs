﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jamiahsalafiyah.Web.Models
{
    public static class Helper
    {
        public static IEnumerable<IEnumerable<T>> Batch<T>(this IEnumerable<T> source, int batchSize)
        {
            List<T> buffer = new List<T>(batchSize);

            foreach (T item in source)
            {
                buffer.Add(item);

                if (buffer.Count >= batchSize)
                {
                    yield return buffer;
                    buffer = new List<T>(batchSize);
                }
            }
            if (buffer.Count > 0)
            {
                yield return buffer;
            }
        }

        public static IEnumerable<IEnumerable<T>> SearchBatch<T>(this IEnumerable<T> source, int batchSize)
        {
            List<T> buffer = new List<T>(batchSize);

            foreach (T item in source)
            {
                buffer.Add(item);

                if (buffer.Count >= batchSize)
                {
                    yield return buffer;
                    buffer = new List<T>(batchSize);
                }
            }
            if (buffer.Count > 0)
            {
                yield return buffer;
            }
        }
    }
}