﻿using System.Collections.Generic;

namespace NVorbis.Contracts
{
    interface IHuffman
    {
        int TableBits { get; }
        IReadOnlyList<HuffmanListNode> PrefixTree { get; }
        IReadOnlyList<HuffmanListNode> OverflowList { get; }

        void GenerateTable(IReadOnlyList<int> values, int[] lengthList, int[] codeList);
    }
}
