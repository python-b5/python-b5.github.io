ScriptMessage("The mod will now be installed.\nWARNING: This may take a while!");

Data.Code.ByName("gml_Object_mus_Create_0").AppendGML(@"love2014_00 = audio_create_stream(""mus/love2014/mus00.ogg"")
love2014_01 = audio_create_stream(""mus/love2014/mus01.ogg"")
love2014_02 = audio_create_stream(""mus/love2014/mus02.ogg"")
love2014_03 = audio_create_stream(""mus/love2014/mus03.ogg"")
love2014_04 = audio_create_stream(""mus/love2014/mus04.ogg"")
love2014_05 = audio_create_stream(""mus/love2014/mus05.ogg"")
love2014_06 = audio_create_stream(""mus/love2014/mus06.ogg"")
love2014_07 = audio_create_stream(""mus/love2014/mus07.ogg"")
love2014_08 = audio_create_stream(""mus/love2014/mus08.ogg"")
love2014_09 = audio_create_stream(""mus/love2014/mus09.ogg"")
love2014_10 = audio_create_stream(""mus/love2014/mus10.ogg"")
love2014_11 = audio_create_stream(""mus/love2014/mus11.ogg"")", Data);

ReplaceTextInGML(("gml_Object_mus_Other_10"), @"if (room == room_LOVE_01)
            newloop = love01
        if (room == room_LOVE_02)
            newloop = love02
        if (room == room_LOVE_03)
            newloop = love03
        if (room == room_LOVE_04)
            newloop = love04
        if (room == room_LOVE_05)
            newloop = love05
        if (room == room_LOVE_06)
            newloop = love06
        if (room == room_LOVE_07)
            newloop = love07
        if (room == room_LOVE_08)
            newloop = love08
        if (room == room_LOVE_09)
            newloop = love09
        if (room == room_LOVE_10)
            newloop = love10
        if (room == room_LOVE_11)
            newloop = love11
        if (room == room_LOVE_12)
            newloop = love12
        if (room == room_LOVE_13)
            newloop = love13
        if (room == room_LOVE_14)
            newloop = love14
        if (room == room_LOVE_15)
            newloop = love15
        if (room == room_LOVE_16)
            newloop = love16
        if (room == room_LOVE_17)
            newloop = love17", @"if (room == room_LOVE_01)
            newloop = love2014_01
        if (room == room_LOVE_02)
            newloop = love2014_02
        if (room == room_LOVE_03)
            newloop = love2014_03
        if (room == room_LOVE_04)
            newloop = love2014_04
        if (room == room_LOVE_05)
            newloop = love2014_05
        if (room == room_LOVE_06)
            newloop = love2014_06
        if (room == room_LOVE_07)
            newloop = love2014_07
        if (room == room_LOVE_08)
            newloop = love2014_08
        if (room == room_LOVE_09)
            newloop = love2014_09
        if (room == room_LOVE_10)
            newloop = love2014_10
        if (room == room_LOVE_11)
            newloop = love2014_11
        if (room == room_LOVE_12)
            newloop = love2014_01
        if (room == room_LOVE_13)
            newloop = love2014_03
        if (room == room_LOVE_14)
            newloop = love2014_05
        if (room == room_LOVE_15)
            newloop = love2014_07
        if (room == room_LOVE_16)
            newloop = love2014_00
        if (room == room_LOVE_17)
            newloop = love2014_00", true);

ReplaceTextInGML(("gml_GlobalScript_scr_pause"), "case room_LOVE_01:", "case room_LOVE_01: nowplaying = \"Nocturne\"; break;", true);
ReplaceTextInGML(("gml_GlobalScript_scr_pause"), "case 5:", "case 5: nowplaying = \"Daft Boss Music [Take it Slow Mix]\"; break;", true);
ReplaceTextInGML(("gml_GlobalScript_scr_pause"), "case 6:", "case 6: nowplaying = \"The Lost Sonic Level\"; break;", true);
ReplaceTextInGML(("gml_GlobalScript_scr_pause"), "case 7:", "case 7: nowplaying = \"Kid\"; break;", true);
ReplaceTextInGML(("gml_GlobalScript_scr_pause"), "case 8:", "case 8: nowplaying = \"Nocturne [Chip Mix]\"; break;", true);
ReplaceTextInGML(("gml_GlobalScript_scr_pause"), "case 9:", "case 9: nowplaying = \"Miniature Mystery\"; break;", true);
ReplaceTextInGML(("gml_GlobalScript_scr_pause"), "case 10:", "case 10: nowplaying = \"Daft Boss Music [Heavy Beat Mix]\"; break;", true);
ReplaceTextInGML(("gml_GlobalScript_scr_pause"), "case 11:", "case 11: nowplaying = \"Rubber Zombie\"; break;", true);
ReplaceTextInGML(("gml_GlobalScript_scr_pause"), "case 12:", "case 12: nowplaying = \"Monkey Peas\"; break;", true);
ReplaceTextInGML(("gml_GlobalScript_scr_pause"), "case 13:", "case 13: nowplaying = \"The Lost Sonic Level [999]\"; break;", true);
ReplaceTextInGML(("gml_GlobalScript_scr_pause"), "case 14:", "case 14: nowplaying = \"Cardiac Arrest\"; break;", true);
ReplaceTextInGML(("gml_GlobalScript_scr_pause"), "case 15:", "case 15: nowplaying = \"Nocturne\"; break;", true);
ReplaceTextInGML(("gml_GlobalScript_scr_pause"), "case 16:", "case 16: nowplaying = \"The Lost Sonic Level\"; break;", true);
ReplaceTextInGML(("gml_GlobalScript_scr_pause"), "case 17:", "case 17: nowplaying = \"Nocturne [Chip Mix]\"; break;", true);
ReplaceTextInGML(("gml_GlobalScript_scr_pause"), "case 18:", "case 18: nowplaying = \"Daft Boss Music [Heavy Beat Mix]\"; break;", true);
ReplaceTextInGML(("gml_GlobalScript_scr_pause"), "case 19:", "case 19: nowplaying = \"Game Over\"; break;", true);
ReplaceTextInGML(("gml_GlobalScript_scr_pause"), "case 20:", "case 20: nowplaying = \"Game Over\"; break;", true);

ScriptMessage("Mod successfully installed!\nMake sure the LOVE 2014 music is present in the correct location, or the game will crash upon startup.");
