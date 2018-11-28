﻿/*
    Copyright © 2010 The Divinity Project; 2013-2016 Dignity Team; 2016-2018 CentrinoGames.
    All rights reserved.
    http://board.thedivinityproject.com
    http://www.ragezone.com


    This file is part of Minerva.

    Minerva is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    any later version.

    Minerva is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Minerva.  If not, see <http://www.gnu.org/licenses/>.
*/

#region Includes

using System;
using System.Collections.Generic;

using DItem = Minerva.Structures.Database.Item;
using CItem = Minerva.Structures.Client.Item;

#endregion

namespace Minerva
{
    partial class PacketProtocol
    {

        public static void MeritSystem(PacketReader packet, PacketBuilder builder, ClientHandler client, EventHandler events)
        {
            var unk1 = packet.ReadByte();
            var unk2 = packet.ReadByte();
            var unk3 = packet.ReadByte();
            var unk4 = packet.ReadByte();
            var unk5 = packet.ReadByte();
            var unk6 = packet.ReadByte();
            var unk7 = packet.ReadByte();
            var unk8 = packet.ReadByte();/*
            var unk9 = packet.ReadByte();
            var unk10 = packet.ReadByte();
            var unk11 = packet.ReadByte();
            var unk12 = packet.ReadByte();*/

#if DEBUG
            Log.Notice("" + unk1 + " " + unk2 + " " + unk3 + " " + unk3 + " " + unk4 + " " + unk5 + " " + unk6 + " " + unk7 + " " + unk8 + "");
#endif



            builder.New(0x9F3);
            {
                builder += 1;
                builder += (ushort)0;
            }

            client.Send(builder, "MeritSystem");
        }
    }
}
