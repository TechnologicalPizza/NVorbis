﻿namespace NVorbis.Contracts
{
    internal interface IFactory
    {
        ICodebook CreateCodebook();
        IFloor CreateFloor(IPacket packet);
        IResidue CreateResidue(IPacket packet);
        IMapping CreateMapping(IPacket packet);
        IMode CreateMode();
        IMdct CreateMdct();
        IHuffman CreateHuffman();
    }
}
