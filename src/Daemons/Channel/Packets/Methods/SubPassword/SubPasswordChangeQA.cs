﻿/*
    Copyright © 2010 The Divinity Project; 2013-2016 Dignity Team; 2016-2018 CentrinoGames.
    All rights reserved.
    https://github.com/CentrinoGames/Minerva
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

#endregion

namespace Minerva
{
    partial class PacketProtocol
    {
        public static void SubPasswordChangeQA(PacketReader packet, PacketBuilder builder, ClientHandler client, EventHandler events)
        {
            packet.Skip(4);
            var question = packet.ReadInt();
            var answer = packet.ReadString(16).Trim('\0');

            var syncServer = client.Metadata["syncServer"] as SyncReceiver;
            SubpassManagement.SetSubPass(syncServer, client.AccountID, string.Empty, question, answer);

            builder.New(0x416);
            {
                builder += 1;
                builder += 1;
            }

            client.Send(builder, "SubPasswordChangeQA");
        }
    }
}