﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ColorPicker.Migrations;

/// <inheritdoc />
public partial class Init : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Group",
            columns: table => new
            {
                Id = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                Name = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Group", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Color",
            columns: table => new
            {
                Id = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                Name = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                Value = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                GroupId = table.Column<int>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Color", x => x.Id);
                table.ForeignKey(
                    name: "FK_Color_Group_GroupId",
                    column: x => x.GroupId,
                    principalTable: "Group",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            name: "IX_Color_GroupId",
            table: "Color",
            column: "GroupId");

        migrationBuilder.InsertData(table: "Group", column: "Name", values: new[] { "General", "Html", "Material Design", "RAL Classic", "Traditional Japan", "Elementary" });

        migrationBuilder.InsertData(table: "Color", columns: new[] { "Name", "Value", "GroupId" }, values: new[,] {
            { "Air Force Blue","5D8AA8","1" }, { "Alice Blue","F0F8FF","1" }, { "Alizarin Crimson","E32636","1" }, { "Almond","EFDECD","1" }, { "Amaranth","E52B50","1" }, { "Amber","FFBF00","1" }, { "American Rose","FF033E","1" }, { "Amethyst","9966CC","1" }, { "Anti Flash White","F2F3F4","1" }, { "Antique White","FAEBD7","1" }, { "Apple Green","8DB600","1" }, { "Asparagus","7BA05B","1" }, { "Aqua","00FFFF","1" }, { "Aquamarine","7FFFD4","1" }, { "Army Green","4B5320","1" }, { "Arsenic","3B444B","1" }, { "Azure","007FFF","1" }, { "Battleship Grey","848482","1" }, { "Beige","F5F5DC","1" }, { "Bistre","3D2B1F","1" }, { "Bittersweet","FE6F5E","1" }, { "Black","000000","1" }, { "Blond","FAF0BE","1" }, { "Blue","0000FF","1" }, { "Bondi Blue","0095B6","1" }, { "Boston University Red","CC0000","1" }, { "Brass","B5A642","1" }, { "Bright Green","66FF00","1" }, { "Bright Turquoise","08E8DE","1" }, { "Bright Violet","CD00CD","1" }, { "Bronze","CD7F32","1" }, { "Brown","964B00","1" }, { "Buff","F0DC82","1" }, { "Burgundy","900020","1" }, { "Burnt Orange","CC5500","1" }, { "Burnt Sienna","E97451","1" }, { "Burnt Umber","8A3324","1" }, { "Camel","C19A6B","1" }, { "Camouflage Green","78866B","1" }, { "Canonical Aubergine","772953","1" }, { "Cardinal","C41E3A","1" }, { "Carmine","960018","1" }, { "Carrot","ED9121","1" }, { "Celadon","ACE1AF","1" }, { "Cerise","DE3163","1" }, { "Cerulean","007BA7","1" }, { "Cerulean Blue","2A52BE","1" }, { "Chartreuse","7FFF00","1" }, { "Chestnut","CD5C5C","1" }, { "Chocolate","D2691E","1" }, { "Cinnamon","7B3F00","1" }, { "Cobalt","0047AB","1" }, { "Copper","B87333","1" }, { "Coral","FF7F50","1" }, { "Corn","FBEC5D","1" }, { "Cornflower Blue","6495ED","1" }, { "Cream","FFFDD0","1" }, { "Crimson","DC143C","1" }, { "Cyan","00FFFF","1" }, { "Dark Blue","00008B","1" }, { "Dark Brown","654321","1" }, { "Dark Cerulean","08457E","1" }, { "Dark Chestnut","986960","1" }, { "Dark Coral","CD5B45","1" }, { "Dark Goldenrod","B8860B","1" }, { "Dark Green","013220","1" }, { "Dark Indigo","310062","1" }, { "Dark Khaki","BDB76B","1" }, { "Dark Olive","556832","1" }, { "Dark Pastel Green","03C03C","1" }, { "Dark Peach","FFDAB9","1" }, { "Dark Pink","E75480","1" }, { "Dark Salmon","E9967A","1" }, { "Dark Scarlet","560319","1" }, { "Dark Slate Gray","2F4F4F","1" }, { "Dark Spring Green","177245","1" }, { "Dark Tan","918151","1" }, { "Dark Tangerine","FFA812","1" }, { "Dark Tea Green","BADBAD","1" }, { "Dark Turquoise","116062","1" }, { "Dark Violet","423189","1" }, { "Deep Pink","FF1493","1" }, { "Deep Sky Blue","00BFFF","1" }, { "Denim","1560BD","1" }, { "Dodger Blue","1E90FF","1" }, { "Emerald","50C878","1" }, { "Eggplant","990066","1" }, { "Fawn","E5AA70","1" }, { "Fern Green","4F7942","1" }, { "Fire Brick","B22222","1" }, { "Flax","EEDC82","1" }, { "Fuchsia","FF00FF","1" }, { "Gamboge","E49B0F","1" }, { "Gold","FFD700","1" }, { "Goldenrod","DAA520","1" }, { "Gray","808080","1" }, { "Gray Asparagus","465945","1" }, { "Gray Tea Green","CADABA","1" }, { "Green","00FF00","1" }, { "Green Yellow","ADFF2F","1" }, { "Gradus Blue","007DFF","1" }, { "Heliotrope","DF73FF","1" }, { "Hot Pink","FC0FC0","1" }, { "Indigo","4B0082","1" }, { "International Orange","FF4F00","1" }, { "Indian Red","CD5C5C","1" }, { "Jade","00A86B","1" }, { "Khaki","C3B091","1" }, { "Klein Blue","3A75C4","1" }, { "Lavender","E6E6FA","1" }, { "Lavender Blush","FFF0F5","1" }, { "Lemon","FDE910","1" }, { "Lemon Cream","FFFACD","1" }, { "Light Brown","CD853F","1" }, { "Lilac","C8A2C8","1" }, { "Lime","CCFF00","1" }, { "Linen","FAF0E6","1" }, { "Lawn Green","7CFC00","1" }, { "Magenta","FF00FF","1" }, { "Malachite","0BDA51","1" }, { "Maroon","800000","1" }, { "Mauve","993366","1" }, { "Midnight Blue","003366","1" }, { "Mint Green","98FF98","1" }, { "Moss Green","ADDFAD","1" }, { "Mountbatten Pink","997A8D","1" }, { "Mustard","FFDB58","1" }, { "Navajo White","FFDEAD","1" }, { "Navy","000080","1" }, { "Ochre","CC7722","1" }, { "Old Gold","CFB53B","1" }, { "Olive","808000","1" }, { "Olive Drab","6B8E23","1" }, { "Orange","FFA500","1" }, { "Orchid","DA70D6","1" }, { "Old Lace","FDF5E6","1" }, { "Pale Blue","AFEEEE","1" }, { "Pale Brown","987654","1" }, { "Pale Carmine","AF4035","1" }, { "Pale Chestnut","DDADAF","1" }, { "Pale Cornflower Blue","ABCDEF","1" }, { "Pale Magenta","F984E5","1" }, { "Pale Mauve","996666","1" }, { "Pale Pink","FADADD","1" }, { "Pale Red Violet","DB7093","1" }, { "Pale Sandy Brown","DABDAB","1" }, { "Pale Yellow","F0DC82","1" }, { "Pang","C7FCEC","1" }, { "Papaya Whip","FFEFD5","1" }, { "Pastel Green","77DD77","1" }, { "Pastel Pink","FFD1DC","1" }, { "Peach","FFE5B4","1" }, { "Peach Orange","FFCC99","1" }, { "Peach Yellow","FADFAD","1" }, { "Pear","D1E231","1" }, { "Periwinkle","CCCCFF","1" }, { "Persian Blue","6600FF","1" }, { "Pine Green","01796F","1" }, { "Pink","FFC0CB","1" }, { "Pink Orange","FF9966","1" }, { "Plum","660066","1" }, { "Powder Blue","9EB9D4","1" }, { "Puce","CC8899","1" }, { "Prussian Blue","003153","1" }, { "Pumpkin","FF7518","1" }, { "Purple","800080","1" }, { "Raw Umber","734A12","1" }, { "Red","FF0000","1" }, { "Red Violet","C71585","1" }, { "Robin Egg Blue","00CCCC","1" }, { "Royal Blue","4169E1","1" }, { "Russet","755A57","1" }, { "Rust","B7410E","1" }, { "Rosy Brown","BC8F8F","1" }, { "Safety Orange","FF9900","1" }, { "Saffron","F4C430","1" }, { "Sapphire","082567","1" }, { "Sana","F39643","1" }, { "Salmon","FF8C69","1" }, { "Sandy Brown","F4A460","1" }, { "Sangria","92000A","1" }, { "Scarlet","FF2400","1" }, { "School Bus Yellow","FFD800","1" }, { "Sea Green","2E8B57","1" }, { "Seashell","FFF5EE","1" }, { "Selective Yellow","FFBA00","1" }, { "Sepia","704214","1" }, { "Silver","C0C0C0","1" }, { "Slate Gray","708090","1" }, { "Spring Green","00FF7F","1" }, { "Steel Blue","4682B4","1" }, { "Swamp Green","ACB78E","1" }, { "Tan","D2B48C","1" }, { "Tenne","CD5700","1" }, { "Tangerine","FFCC00","1" }, { "Tea Green","D0F0C0","1" }, { "Teal","008080","1" }, { "Thistle","D8BFD8","1" }, { "Turquoise","30D5C8","1" }, { "Titian","D53E07","1" }, { "Transport Red","CC0605","1" }, { "Tomato","FF6347","1" }, { "Ultramarine","120A8F","1" }, { "United Nations Blue","5B92E5","1" }, { "Ubuntu Orange","DD4814","1" }, { "Vanilla","F3E5AB","1" }, { "Vermilion","E34234","1" }, { "Violet","8B00FF","1" }, { "Violet Eggplant","991199","1" }, { "Viridian","40826D","1" }, { "Wheat","F5DEB3","1" }, { "White","FFFFFF","1" }, { "Wisteria","C9A0DC","1" }, { "Wine","722F37","1" }, { "Xanadu","738678","1" }, { "Yellow","FFFF00","1" }, { "Zinnwaldite","EBC2AF","1" }, { "Zaffre","0014A8","1" }, { "Aliceblue","F0F8FF","2" }, { "Antiquewhite","FAEBD7","2" }, { "Aqua","00FFFF","2" }, { "Aquamarine","7FFFD4","2" }, { "Azure","F0FFFF","2" }, { "Beige","F5F5DC","2" }, { "Bisque","FFE4C4","2" }, { "Black","000000","2" }, { "Blanchedalmond","FFEBCD","2" }, { "Blue","0000FF","2" }, { "Blueviolet","8A2BE2","2" }, { "Brown","A52A2A","2" }, { "Burlywood","DEB887","2" }, { "Cadetblue","5F9EA0","2" }, { "Chartreuse","7FFF00","2" }, { "Chocolate","D2691E","2" }, { "Coral","FF7F50","2" }, { "Cornflowerblue","6495ED","2" }, { "Cornsilk","FFF8DC","2" }, { "Crimson","DC143C","2" }, { "Cyan","00FFFF","2" }, { "Darkblue","00008B","2" }, { "Darkcyan","008B8B","2" }, { "Darkgoldenrod","B8860B","2" }, { "Darkgray","A9A9A9","2" }, { "Darkgrey","A9A9A9","2" }, { "Darkgreen","006400","2" }, { "Darkkhaki","BDB76B","2" }, { "Darkmagenta","8B008B","2" }, { "Darkolivegreen","556B2F","2" }, { "Darkorange","FF8C00","2" }, { "Darkorchid","9932CC","2" }, { "Darkred","8B0000","2" }, { "Darksalmon","E9967A","2" }, { "Darkseagreen","8FBC8F","2" }, { "Darkslateblue","483D8B","2" }, { "Darkslategray","2F4F4F","2" }, { "Darkslategrey","2F4F4F","2" }, { "Darkturquoise","00CED1","2" }, { "Darkviolet","9400D3","2" }, { "Deeppink","FF1493","2" }, { "Deepskyblue","00BFFF","2" }, { "Dimgray","696969","2" }, { "Dimgrey","696969","2" }, { "Dodgerblue","1E90FF","2" }, { "Firebrick","B22222","2" }, { "Floralwhite","FFFAF0","2" }, { "Forestgreen","228B22","2" }, { "Fuchsia","FF00FF","2" }, { "Gainsboro","DCDCDC","2" }, { "Ghostwhite","F8F8FF","2" }, { "Gold","FFD700","2" }, { "Goldenrod","DAA520","2" }, { "Gray","808080","2" }, { "Grey","808080","2" }, { "Green","008000","2" }, { "Greenyellow","ADFF2F","2" }, { "Honeydew","F0FFF0","2" }, { "Hotpink","FF69B4","2" }, { "Indianred","CD5C5C","2" }, { "Indigo","4B0082","2" }, { "Ivory","FFFFF0","2" }, { "Khaki","F0E68C","2" }, { "Lavender","E6E6FA","2" }, { "Lavenderblush","FFF0F5","2" }, { "Lawngreen","7CFC00","2" }, { "Lemonchiffon","FFFACD","2" }, { "Lightblue","ADD8E6","2" }, { "Lightcoral","F08080","2" }, { "Lightcyan","E0FFFF","2" }, { "Lightgoldenrodyellow","FAFAD2","2" }, { "Lightgray","D3D3D3","2" }, { "Lightgrey","D3D3D3","2" }, { "Lightgreen","90EE90","2" }, { "Lightpink","FFB6C1","2" }, { "Lightsalmon","FFA07A","2" }, { "Lightseagreen","20B2AA","2" }, { "Lightskyblue","87CEFA","2" }, { "Lightslategray","778899","2" }, { "Lightslategrey","778899","2" }, { "Lightsteelblue","B0C4DE","2" }, { "Lightyellow","FFFFE0","2" }, { "Lime","00FF00","2" }, { "Limegreen","32CD32","2" }, { "Linen","FAF0E6","2" }, { "Magenta","FF00FF","2" }, { "Maroon","800000","2" }, { "Mediumaquamarine","66CDAA","2" }, { "Mediumblue","0000CD","2" }, { "Mediumorchid","BA55D3","2" }, { "Mediumpurple","9370DB","2" }, { "Mediumseagreen","3CB371","2" }, { "Mediumslateblue","7B68EE","2" }, { "Mediumspringgreen","00FA9A","2" }, { "Mediumturquoise","48D1CC","2" }, { "Mediumvioletred","C71585","2" }, { "Midnightblue","191970","2" }, { "Mintcream","F5FFFA","2" }, { "Mistyrose","FFE4E1","2" }, { "Moccasin","FFE4B5","2" }, { "Navajowhite","FFDEAD","2" }, { "Navy","000080","2" }, { "Oldlace","FDF5E6","2" }, { "Olive","808000","2" }, { "Olivedrab","6B8E23","2" }, { "Orange","FFA500","2" }, { "Orangered","FF4500","2" }, { "Orchid","DA70D6","2" }, { "Palegoldenrod","EEE8AA","2" }, { "Palegreen","98FB98","2" }, { "Paleturquoise","AFEEEE","2" }, { "Palevioletred","DB7093","2" }, { "Papayawhip","FFEFD5","2" }, { "Peachpuff","FFDAB9","2" }, { "Peru","CD853F","2" }, { "Pink","FFC0CB","2" }, { "Plum","DDA0DD","2" }, { "Powderblue","B0E0E6","2" }, { "Purple","800080","2" }, { "Rebeccapurple","663399","2" }, { "Red","FF0000","2" }, { "Rosybrown","BC8F8F","2" }, { "Royalblue","4169E1","2" }, { "Saddlebrown","8B4513","2" }, { "Salmon","FA8072","2" }, { "Sandybrown","F4A460","2" }, { "Seagreen","2E8B57","2" }, { "Seashell","FFF5EE","2" }, { "Sienna","A0522D","2" }, { "Silver","C0C0C0","2" }, { "Skyblue","87CEEB","2" }, { "Slateblue","6A5ACD","2" }, { "Slategray","708090","2" }, { "Slategrey","708090","2" }, { "Snow","FFFAFA","2" }, { "Springgreen","00FF7F","2" }, { "Steelblue","4682B4","2" }, { "Tan","D2B48C","2" }, { "Teal","008080","2" }, { "Thistle","D8BFD8","2" }, { "Tomato","FF6347","2" }, { "Turquoise","40E0D0","2" }, { "Violet","EE82EE","2" }, { "Wheat","F5DEB3","2" }, { "White","FFFFFF","2" }, { "Whitesmoke","F5F5F5","2" }, { "Yellow","FFFF00","2" }, { "Yellowgreen","9ACD32","2" }, { "Red 50","FFEBEE","3" }, { "Red 100","FFCDD2","3" }, { "Red 200","EF9A9A","3" }, { "Red 300","E57373","3" }, { "Red 400","EF5350","3" }, { "Red 500","F44336","3" }, { "Red 600","E53935","3" }, { "Red 700","D32F2F","3" }, { "Red 800","C62828","3" }, { "Red 900","B71C1C","3" }, { "Red A100","FF8A80","3" }, { "Red A200","FF5252","3" }, { "Red A400","FF1744","3" }, { "Red A700","D50000","3" }, { "Pink 50","FCE4EC","3" }, { "Pink 100","F8BBD0","3" }, { "Pink 200","F48FB1","3" }, { "Pink 300","F06292","3" }, { "Pink 400","EC407A","3" }, { "Pink 500","E91E63","3" }, { "Pink 600","D81B60","3" }, { "Pink 700","C2185B","3" }, { "Pink 800","AD1457","3" }, { "Pink 900","880E4F","3" }, { "Pink A100","FF80AB","3" }, { "Pink A200","FF4081","3" }, { "Pink A400","F50057","3" }, { "Pink A700","C51162","3" }, { "Purple 50","F3E5F5","3" }, { "Purple 100","E1BEE7","3" }, { "Purple 200","CE93D8","3" }, { "Purple 300","BA68C8","3" }, { "Purple 400","AB47BC","3" }, { "Purple 500","9C27B0","3" }, { "Purple 600","8E24AA","3" }, { "Purple 700","7B1FA2","3" }, { "Purple 800","6A1B9A","3" }, { "Purple 900","4A148C","3" }, { "Purple A100","EA80FC","3" }, { "Purple A200","E040FB","3" }, { "Purple A400","D500F9","3" }, { "Purple A700","AA00FF","3" }, { "Deep Purple 50","EDE7F6","3" }, { "Deep Purple 100","D1C4E9","3" }, { "Deep Purple 200","B39DDB","3" }, { "Deep Purple 300","9575CD","3" }, { "Deep Purple 400","7E57C2","3" }, { "Deep Purple 500","673AB7","3" }, { "Deep Purple 600","5E35B1","3" }, { "Deep Purple 700","512DA8","3" }, { "Deep Purple 800","4527A0","3" }, { "Deep Purple 900","311B92","3" }, { "Deep Purple A100","B388FF","3" }, { "Deep Purple A200","7C4DFF","3" }, { "Deep Purple A400","651FFF","3" }, { "Deep Purple A700","6200EA","3" }, { "Indigo 50","E8EAF6","3" }, { "Indigo 100","C5CAE9","3" }, { "Indigo 200","9FA8DA","3" }, { "Indigo 300","7986CB","3" }, { "Indigo 400","5C6BC0","3" }, { "Indigo 500","3F51B5","3" }, { "Indigo 600","3949AB","3" }, { "Indigo 700","303F9F","3" }, { "Indigo 800","283593","3" }, { "Indigo 900","1A237E","3" }, { "Indigo A100","8C9EFF","3" }, { "Indigo A200","536DFE","3" }, { "Indigo A400","3D5AFE","3" }, { "Indigo A700","304FFE","3" }, { "Blue 50","E3F2FD","3" }, { "Blue 100","BBDEFB","3" }, { "Blue 200","90CAF9","3" }, { "Blue 300","64B5F6","3" }, { "Blue 400","42A5F5","3" }, { "Blue 500","2196F3","3" }, { "Blue 600","1E88E5","3" }, { "Blue 700","1976D2","3" }, { "Blue 800","1565C0","3" }, { "Blue 900","0D47A1","3" }, { "Blue A100","82B1FF","3" }, { "Blue A200","448AFF","3" }, { "Blue A400","2979FF","3" }, { "Blue A700","2962FF","3" }, { "Light Blue 50","E1F5FE","3" }, { "Light Blue 100","B3E5FC","3" }, { "Light Blue 200","81D4FA","3" }, { "Light Blue 300","4FC3F7","3" }, { "Light Blue 400","29B6F6","3" }, { "Light Blue 500","03A9F4","3" }, { "Light Blue 600","039BE5","3" }, { "Light Blue 700","0288D1","3" }, { "Light Blue 800","0277BD","3" }, { "Light Blue 900","01579B","3" }, { "Light Blue A100","80D8FF","3" }, { "Light Blue A200","40C4FF","3" }, { "Light Blue A400","00B0FF","3" }, { "Light Blue A700","0091EA","3" }, { "Cyan 50","E0F7FA","3" }, { "Cyan 100","B2EBF2","3" }, { "Cyan 200","80DEEA","3" }, { "Cyan 300","4DD0E1","3" }, { "Cyan 400","26C6DA","3" }, { "Cyan 500","00BCD4","3" }, { "Cyan 600","00ACC1","3" }, { "Cyan 700","0097A7","3" }, { "Cyan 800","00838F","3" }, { "Cyan 900","006064","3" }, { "Cyan A100","84FFFF","3" }, { "Cyan A200","18FFFF","3" }, { "Cyan A400","00E5FF","3" }, { "Cyan A700","00B8D4","3" }, { "Teal 50","E0F2F1","3" }, { "Teal 100","B2DFDB","3" }, { "Teal 200","80CBC4","3" }, { "Teal 300","4DB6AC","3" }, { "Teal 400","26A69A","3" }, { "Teal 500","009688","3" }, { "Teal 600","00897B","3" }, { "Teal 700","00796B","3" }, { "Teal 800","00695C","3" }, { "Teal 900","004D40","3" }, { "Teal A100","A7FFEB","3" }, { "Teal A200","64FFDA","3" }, { "Teal A400","1DE9B6","3" }, { "Teal A700","00BFA5","3" }, { "Green 50","E8F5E9","3" }, { "Green 100","C8E6C9","3" }, { "Green 200","A5D6A7","3" }, { "Green 300","81C784","3" }, { "Green 400","66BB6A","3" }, { "Green 500","4CAF50","3" }, { "Green 600","43A047","3" }, { "Green 700","388E3C","3" }, { "Green 800","2E7D32","3" }, { "Green 900","1B5E20","3" }, { "Green A100","B9F6CA","3" }, { "Green A200","69F0AE","3" }, { "Green A400","00E676","3" }, { "Green A700","00C853","3" }, { "Light Green 50","F1F8E9","3" }, { "Light Green 100","DCEDC8","3" }, { "Light Green 200","C5E1A5","3" }, { "Light Green 300","AED581","3" }, { "Light Green 400","9CCC65","3" }, { "Light Green 500","8BC34A","3" }, { "Light Green 600","7CB342","3" }, { "Light Green 700","689F38","3" }, { "Light Green 800","558B2F","3" }, { "Light Green 900","33691E","3" }, { "Light Green A100","CCFF90","3" }, { "Light Green A200","B2FF59","3" }, { "Light Green A400","76FF03","3" }, { "Light Green A700","64DD17","3" }, { "Lime 50","F9FBE7","3" }, { "Lime 100","F0F4C3","3" }, { "Lime 200","E6EE9C","3" }, { "Lime 300","DCE775","3" }, { "Lime 400","D4E157","3" }, { "Lime 500","CDDC39","3" }, { "Lime 600","C0CA33","3" }, { "Lime 700","AFB42B","3" }, { "Lime 800","9E9D24","3" }, { "Lime 900","827717","3" }, { "Lime A100","F4FF81","3" }, { "Lime A200","EEFF41","3" }, { "Lime A400","C6FF00","3" }, { "Lime A700","AEEA00","3" }, { "Yellow 50","FFFDE7","3" }, { "Yellow 100","FFF9C4","3" }, { "Yellow 200","FFF59D","3" }, { "Yellow 300","FFF176","3" }, { "Yellow 400","FFEE58","3" }, { "Yellow 500","FFEB3B","3" }, { "Yellow 600","FDD835","3" }, { "Yellow 700","FBC02D","3" }, { "Yellow 800","F9A825","3" }, { "Yellow 900","F57F17","3" }, { "Yellow A100","FFFF8D","3" }, { "Yellow A200","FFFF00","3" }, { "Yellow A400","FFEA00","3" }, { "Yellow A700","FFD600","3" }, { "Amber 50","FFF8E1","3" }, { "Amber 100","FFECB3","3" }, { "Amber 200","FFE082","3" }, { "Amber 300","FFD54F","3" }, { "Amber 400","FFCA28","3" }, { "Amber 500","FFC107","3" }, { "Amber 600","FFB300","3" }, { "Amber 700","FFA000","3" }, { "Amber 800","FF8F00","3" }, { "Amber 900","FF6F00","3" }, { "Amber A100","FFE57F","3" }, { "Amber A200","FFD740","3" }, { "Amber A400","FFC400","3" }, { "Amber A700","FFAB00","3" }, { "Orange 50","FFF3E0","3" }, { "Orange 100","FFE0B2","3" }, { "Orange 200","FFCC80","3" }, { "Orange 300","FFB74D","3" }, { "Orange 400","FFA726","3" }, { "Orange 500","FF9800","3" }, { "Orange 600","FB8C00","3" }, { "Orange 700","F57C00","3" }, { "Orange 800","EF6C00","3" }, { "Orange 900","E65100","3" }, { "Orange A100","FFD180","3" }, { "Orange A200","FFAB40","3" }, { "Orange A400","FF9100","3" }, { "Orange A700","FF6D00","3" }, { "Deep Orange 50","FBE9E7","3" }, { "Deep Orange 100","FFCCBC","3" }, { "Deep Orange 200","FFAB91","3" }, { "Deep Orange 300","FF8A65","3" }, { "Deep Orange 400","FF7043","3" }, { "Deep Orange 500","FF5722","3" }, { "Deep Orange 600","F4511E","3" }, { "Deep Orange 700","E64A19","3" }, { "Deep Orange 800","D84315","3" }, { "Deep Orange 900","BF360C","3" }, { "Deep Orange A100","FF9E80","3" }, { "Deep Orange A200","FF6E40","3" }, { "Deep Orange A400","FF3D00","3" }, { "Deep Orange A700","DD2C00","3" }, { "Brown 50","EFEBE9","3" }, { "Brown 100","D7CCC8","3" }, { "Brown 200","BCAAA4","3" }, { "Brown 300","A1887F","3" }, { "Brown 400","8D6E63","3" }, { "Brown 500","795548","3" }, { "Brown 600","6D4C41","3" }, { "Brown 700","5D4037","3" }, { "Brown 800","4E342E","3" }, { "Brown 900","3E2723","3" }, { "Grey 50","FAFAFA","3" }, { "Grey 100","F5F5F5","3" }, { "Grey 200","EEEEEE","3" }, { "Grey 300","E0E0E0","3" }, { "Grey 400","BDBDBD","3" }, { "Grey 500","9E9E9E","3" }, { "Grey 600","757575","3" }, { "Grey 700","616161","3" }, { "Grey 800","424242","3" }, { "Grey 900","212121","3" }, { "Blue Grey 50","ECEFF1","3" }, { "Blue Grey 100","CFD8DC","3" }, { "Blue Grey 200","B0BEC5","3" }, { "Blue Grey 300","90A4AE","3" }, { "Blue Grey 400","78909C","3" }, { "Blue Grey 500","607D8B","3" }, { "Blue Grey 600","546E7A","3" }, { "Blue Grey 700","455A64","3" }, { "Blue Grey 800","37474F","3" }, { "Blue Grey 900","263238","3" }, { "Black","000000","3" }, { "White","FFFFFF","3" }, { "1000","CDBA88","4" }, { "1001","D0B084","4" }, { "1002","D2AA6D","4" }, { "1003","F9A800","4" }, { "1004","E49E00","4" }, { "1005","CB8E00","4" }, { "1006","E29000","4" }, { "1007","E88C00","4" }, { "1011","AF804F","4" }, { "1012","DDAF27","4" }, { "1013","E3D9C6","4" }, { "1014","DDC49A","4" }, { "1015","E6D2B5","4" }, { "1016","F1DD38","4" }, { "1017","F6A950","4" }, { "1018","FACA30","4" }, { "1019","A48F7A","4" }, { "1020","A08F65","4" }, { "1021","F6B600","4" }, { "1023","F7B500","4" }, { "1024","BA8F4C","4" }, { "1026","FFFF00","4" }, { "1027","A77F0E","4" }, { "1028","FF9B00","4" }, { "1032","E2A300","4" }, { "1033","F99A1C","4" }, { "1034","EB9C52","4" }, { "1035","908370","4" }, { "1036","80643F","4" }, { "1037","F09200","4" }, { "2000","DD7907","4" }, { "2001","BE4E20","4" }, { "2002","C63927","4" }, { "2003","FA842B","4" }, { "2004","E75B12","4" }, { "2005","FF2300","4" }, { "2007","FFA421","4" }, { "2008","F3752C","4" }, { "2009","E15501","4" }, { "2010","D4652F","4" }, { "2011","EC7C25","4" }, { "2012","DB6A50","4" }, { "2013","954527","4" }, { "3000","AB2524","4" }, { "3001","A02128","4" }, { "3002","A1232B","4" }, { "3003","8D1D2C","4" }, { "3004","701F29","4" }, { "3005","5E2028","4" }, { "3007","402225","4" }, { "3009","703731","4" }, { "3011","7E292C","4" }, { "3012","CB8D73","4" }, { "3013","9C322E","4" }, { "3014","D47479","4" }, { "3015","E1A6AD","4" }, { "3016","AC4034","4" }, { "3017","D3545F","4" }, { "3018","D14152","4" }, { "3020","C1121C","4" }, { "3022","D56D56","4" }, { "3024","F70000","4" }, { "3026","FF0000","4" }, { "3027","B42041","4" }, { "3028","E72512","4" }, { "3031","AC323B","4" }, { "3032","711521","4" }, { "3033","B24C43","4" }, { "4001","8A5A83","4" }, { "4002","933D50","4" }, { "4003","D15B8F","4" }, { "4004","691639","4" }, { "4005","83639D","4" }, { "4006","992572","4" }, { "4007","4A203B","4" }, { "4008","904684","4" }, { "4009","A38995","4" }, { "4010","C63678","4" }, { "4011","8773A1","4" }, { "4012","6B6880","4" }, { "5000","384C70","4" }, { "5001","1F4764","4" }, { "5002","2B2C7C","4" }, { "5003","2A3756","4" }, { "5004","1D1F2A","4" }, { "5005","154889","4" }, { "5007","41678D","4" }, { "5008","313C48","4" }, { "5009","2E5978","4" }, { "5010","13447C","4" }, { "5011","232C3F","4" }, { "5012","3481B8","4" }, { "5013","232D53","4" }, { "5014","6C7C98","4" }, { "5015","2874B2","4" }, { "5017","0E518D","4" }, { "5018","21888F","4" }, { "5019","1A5784","4" }, { "5020","0B4151","4" }, { "5021","07737A","4" }, { "5022","2F2A5A","4" }, { "5023","4D668E","4" }, { "5024","6A93B0","4" }, { "5025","296478","4" }, { "5026","102C54","4" }, { "6000","327662","4" }, { "6001","28713E","4" }, { "6002","276235","4" }, { "6003","4B573E","4" }, { "6004","0E4243","4" }, { "6005","0F4336","4" }, { "6006","40433B","4" }, { "6007","283424","4" }, { "6008","35382E","4" }, { "6009","26392F","4" }, { "6010","3E753B","4" }, { "6011","68825B","4" }, { "6012","31403D","4" }, { "6013","797C5A","4" }, { "6014","444337","4" }, { "6015","3D403A","4" }, { "6016","026A52","4" }, { "6017","468641","4" }, { "6018","48A43F","4" }, { "6019","B7D9B1","4" }, { "6020","354733","4" }, { "6021","86A47C","4" }, { "6022","3E3C32","4" }, { "6024","008754","4" }, { "6025","53753C","4" }, { "6026","005D52","4" }, { "6027","81C0BB","4" }, { "6028","2D5546","4" }, { "6029","007243","4" }, { "6032","0F8558","4" }, { "6033","478A84","4" }, { "6034","7FB0B2","4" }, { "6035","1B542C","4" }, { "6036","005D4C","4" }, { "6037","25E712","4" }, { "6038","00F700","4" }, { "7000","7E8B92","4" }, { "7001","8F999F","4" }, { "7002","817F68","4" }, { "7003","7A7B6D","4" }, { "7004","9EA0A1","4" }, { "7005","6B716F","4" }, { "7006","756F61","4" }, { "7008","746643","4" }, { "7009","5B6259","4" }, { "7010","575D57","4" }, { "7011","555D61","4" }, { "7012","596163","4" }, { "7013","555548","4" }, { "7015","51565C","4" }, { "7016","373F43","4" }, { "7021","2E3234","4" }, { "7022","4B4D46","4" }, { "7023","818479","4" }, { "7024","474A50","4" }, { "7026","374447","4" }, { "7030","939388","4" }, { "7031","5D6970","4" }, { "7032","B9B9A8","4" }, { "7033","818979","4" }, { "7034","939176","4" }, { "7035","CBD0CC","4" }, { "7036","9A9697","4" }, { "7037","7C7F7E","4" }, { "7038","B4B8B0","4" }, { "7039","6B695F","4" }, { "7040","9DA3A6","4" }, { "7042","8F9695","4" }, { "7043","4E5451","4" }, { "7044","BDBDB2","4" }, { "7045","91969A","4" }, { "7046","82898E","4" }, { "7047","CFD0CF","4" }, { "7048","888175","4" }, { "8000","887142","4" }, { "8001","9C6B30","4" }, { "8002","7B5141","4" }, { "8003","80542F","4" }, { "8004","8F4E35","4" }, { "8007","6F4A2F","4" }, { "8008","6F4F28","4" }, { "8011","5A3A29","4" }, { "8012","673831","4" }, { "8014","49392D","4" }, { "8015","633A34","4" }, { "8016","4C2F26","4" }, { "8017","44322D","4" }, { "8019","3F3A3A","4" }, { "8022","211F20","4" }, { "8023","A65E2F","4" }, { "8024","79553C","4" }, { "8025","755C49","4" }, { "8028","4E3B2B","4" }, { "8029","773C27","4" }, { "9001","EFEBDC","4" }, { "9002","DDDED4","4" }, { "9003","F4F8F4","4" }, { "9004","2E3032","4" }, { "9005","0A0A0D","4" }, { "9006","A5A8A6","4" }, { "9007","8F8F8C","4" }, { "9010","F7F9EF","4" }, { "9011","292C2F","4" }, { "9016","F7FBF5","4" }, { "9017","2A2D2F","4" }, { "9018","CFD3CD","4" }, { "9022","9C9C9C","4" }, { "9023","7E8182","4" }, { "Ikkonzome","F08F90","5" }, { "Kobai Iro","DB5A6B","5" }, { "Sakura Iro","FCC9B9","5" }, { "Usubeni","F2666C","5" }, { "Momo Iro","F47983","5" }, { "Nakabeni","C93756","5" }, { "Arazome","FFB3A7","5" }, { "Tokiha Iro","F58F84","5" }, { "Choshun Iro","B95754","5" }, { "Enji Iro","9D2933","5" }, { "Jinzamomi","F7665A","5" }, { "Umenezumi","97645A","5" }, { "Akabeni","C3272B","5" }, { "Azuki Iro","672422","5" }, { "Ebicha","5E2824","5" }, { "Akebono Iro","FA7B62","5" }, { "Shojohi","DC3023","5" }, { "Kakishibu Iro","934337","5" }, { "Benitobi","913228","5" }, { "Kurotobi","351E1C","5" }, { "Terigaki","D34E36","5" }, { "Edocha","A13D2D","5" }, { "Hihada Iro","752E23","5" }, { "Araishu","FF7952","5" }, { "Tokigaracha","E68364","5" }, { "Sohi","E35C38","5" }, { "Karacha","B35C44","5" }, { "Sodenkaracha","9B533F","5" }, { "Kurikawacha","60281E","5" }, { "Tobi Iro","4C221B","5" }, { "Sakuranezumi","AC8181","5" }, { "Karakurenai","C91F37","5" }, { "Kokiake","7B3B3A","5" }, { "Mizugaki","B56C60","5" }, { "Suoko","A24F46","5" }, { "Shinshu","8F1D21","5" }, { "Ginshu","BC2D29","5" }, { "Kiriume","8B352D","5" }, { "Sango Iro","F8674F","5" }, { "Shikancha","AB4C3D","5" }, { "Benikaba","9D2B22","5" }, { "Benihibata","6F3028","5" }, { "Benihi","F35336","5" }, { "Ake","CF3A24","5" }, { "Bengara Iro","913225","5" }, { "Shishi Iro","F9906F","5" }, { "Akako Iro","F07F5E","5" }, { "Otan","FF4E20","5" }, { "Enshucha","CB6649","5" }, { "Kabacha","B14A30","5" }, { "Suzumecha","8C4736","5" }, { "Momoshiocha","542D24","5" }, { "Kurumizome","9F7462","5" }, { "Korozen","592B1F","5" }, { "Kokikuchinashi","F57F4F","5" }, { "Taisha Iro","9F5233","5" }, { "Tonocha Red","985538","5" }, { "Sharegaki","FFA26B","5" }, { "Kanzo Iro","FF8936","5" }, { "Beniukon","FB8136","5" }, { "Kenpozome","2E211B","5" }, { "Kohaku Iro","CA6924","5" }, { "Kuchiba Iro","D57835","5" }, { "Chojizome","A96232","5" }, { "Fushizome","8C5939","5" }, { "Susutake Iro","593A27","5" }, { "Odo Iro","BE7F51","5" }, { "Kigaracha","B7702D","5" }, { "Kaba Iro","B64925","5" }, { "Kogecha","351F19","5" }, { "Araigaki","EC8254","5" }, { "Akashirotsurubami","EC956C","5" }, { "Sencha Iro","824B35","5" }, { "Usugaki","FCA474","5" }, { "Umezome","FA9258","5" }, { "Chojicha","8F583C","5" }, { "Biwacha","AB6134","5" }, { "Usuko","FFA565","5" }, { "Kincha","C66B27","5" }, { "Kitsune Iro","985629","5" }, { "Kyara Iro","6A432D","5" }, { "Shiracha","C48E69","5" }, { "Kinsusutake","7D4E2D","5" }, { "Kobicha","6B4423","5" }, { "Asagi","F7BB7D","5" }, { "Tamago Iro","FFA631","5" }, { "Yamabukicha","CB7E1F","5" }, { "Namakabe Iro","785E49","5" }, { "Tomorokoshi Iro","FAA945","5" }, { "Kitsurubami","BB8141","5" }, { "Hanaba Iro","FFB94E","5" }, { "Ukon Iro","E69B3A","5" }, { "Rikyushiracha","B0927A","5" }, { "Aku Iro","7F6B5D","5" }, { "Rokocha","665343","5" }, { "Nataneyu Iro","A17917","5" }, { "Uguisucha","5C4827","5" }, { "Kariyasu","E2B13C","5" }, { "Mushikuri Iro","D3B17D","5" }, { "Hiwacha","957B38","5" }, { "Uguisu Iro","645530","5" }, { "Yamabuki Iro","FFA400","5" }, { "Hajizome","E08A1E","5" }, { "Kuwazome Yellow","C57F2E","5" }, { "Kuchinashi","FFB95A","5" }, { "Shirotsurubami","CE9F6F","5" }, { "Too","FFB61E","5" }, { "Torinoko Iro","E2BE9F","5" }, { "Kikuchiba","E29C45","5" }, { "Rikyucha","826B58","5" }, { "Higosusutake","7F5D3B","5" }, { "Mirucha","4C3D30","5" }, { "Kimirucha","896C39","5" }, { "Nanohanacha","E3B130","5" }, { "Kihada","F3C13A","5" }, { "Aokuchiba","AA8736","5" }, { "Ominaeshi","D9B611","5" }, { "Hiwa Iro","BDA928","5" }, { "Yanagicha","9C8A4D","5" }, { "Aikobicha","473F2D","5" }, { "Miru Iro","524B2A","5" }, { "Baikocha","857C55","5" }, { "Hiwamoegi","7A942E","5" }, { "Urahayanagi","BCB58C","5" }, { "Yanagizome","8C9E5E","5" }, { "Aoni","52593B","5" }, { "Aoshirotsurubami","BBA46D","5" }, { "Rikancha","534A32","5" }, { "Koke Iro","8B7D3A","5" }, { "Sensaicha","3B3429","5" }, { "Iwaicha","5E5545","5" }, { "Yanagisusutake","4D4B3A","5" }, { "Usumoegi","8DB255","5" }, { "Moegi","5B8930","5" }, { "Matsuba Iro","454D32","5" }, { "Usuao","8C9C76","5" }, { "Yanaginezumi","817B69","5" }, { "Sensaimidori","374231","5" }, { "Byakuroku","A5BA93","5" }, { "Rokusho","407A52","5" }, { "Onandocha","3D4035","5" }, { "Rikyunezumi","656255","5" }, { "Mushiao","2D4436","5" }, { "Tonocha Green","5A6457","5" }, { "Seiji Iro","819C8B","5" }, { "Sabitetsuonando","3A403B","5" }, { "Omeshicha","354E4B","5" }, { "Wakatake Iro","6B9362","5" }, { "Oitake Iro","5E644F","5" }, { "Midori","2A603B","5" }, { "Sabiseiji","898A74","5" }, { "Tokusa Iro","3D5D42","5" }, { "Aotake Iro","006442","5" }, { "Birodo","224634","5" }, { "Aimirucha","2E372E","5" }, { "Mizuasagi","749F8D","5" }, { "Seiheki","3A6960","5" }, { "Tetsu Iro","2B3733","5" }, { "Korainando","203838","5" }, { "Minatonezumi","757D75","5" }, { "Tetsuonando","2B3736","5" }, { "Sabiasagi","6A7F7A","5" }, { "Asagi Iro","48929B","5" }, { "Sabionando","455859","5" }, { "Ai Iro","264348","5" }, { "Hanaasagi","1D697C","5" }, { "Masuhana Iro","4D646C","5" }, { "Noshimehana Iro","344D56","5" }, { "Sora Iro","4D8FAC","5" }, { "Gunjo Iro","5D8CAE","5" }, { "Kachi Iro","181B26","5" }, { "Konjo Iro","003171","5" }, { "Benimidori","78779B","5" }, { "Fujinezumi","766980","5" }, { "Fuji Iro","89729E","5" }, { "Aonibi","4F4944","5" }, { "Mizu Iro","86ABA5","5" }, { "Kamenozoki","C6C2B6","5" }, { "Shinbashi Iro","006C7F","5" }, { "Ainezumi","5C544E","5" }, { "Onando Iro","364141","5" }, { "Chigusa Iro","317589","5" }, { "Hanada","044F67","5" }, { "Omeshionando","3D4C51","5" }, { "Kurotsurubami","252321","5" }, { "Kon","192236","5" }, { "Ruri Iro","1F4788","5" }, { "Rurikon","1B294B","5" }, { "Konkikyo","191F45","5" }, { "Benikakehana Iro","5A4F74","5" }, { "Futaai","614E6E","5" }, { "Fujimurasaki","875F9A","5" }, { "Shion Iro","976E9A","5" }, { "Shikon","2B2028","5" }, { "Usu Iro","A87CA0","5" }, { "Sumire Iro","5B3256","5" }, { "Kurobeni","23191E","5" }, { "Benifuji","BB7796","5" }, { "Hatobanezumi","755D5B","5" }, { "Ebizome","6D2B50","5" }, { "Botan","A4345D","5" }, { "Nisemurasaki","43242A","5" }, { "Suo","7E2639","5" }, { "Benikeshinezumi","44312E","5" }, { "Kikyo Iro","5D3F6A","5" }, { "Metsushi","3F313A","5" }, { "Kokimurasaki","3A243B","5" }, { "Hashita Iro","8D608C","5" }, { "Murasaki","4F284B","5" }, { "Ayame Iro","763568","5" }, { "Kakitsubata","491E3C","5" }, { "Budonezumi","63424B","5" }, { "Fujisusutake","4D3B3C","5" }, { "Umemurasaki","8F4155","5" }, { "Murasakitobi","512C31","5" }, { "Kuwazome Violet","59292C","5" }, { "Shironeri","FFDDCA","5" }, { "Ginnezumi","97867C","5" }, { "Dobunezumi","4B3C39","5" }, { "Binrojizome","352925","5" }, { "Kokushoku","171412","5" }, { "Shironezumi","B9A193","5" }, { "Sunezumi","6E5F57","5" }, { "Aisumicha","393432","5" }, { "Sumi Iro","27221F","5" }, { "Aijiro","EBF6F7","5" }, { "Strawberry 100","FF8C82","6" }, { "Strawberry 300","ED5353","6" }, { "Strawberry 500","C6262E","6" }, { "Strawberry 700","A10705","6" }, { "Strawberry 900","7A0000","6" }, { "Orange 100","FFC27D","6" }, { "Orange 300","FFA154","6" }, { "Orange 500","F37329","6" }, { "Orange 700","CC3B02","6" }, { "Orange 900","A62100","6" }, { "Banana 100","FFF394","6" }, { "Banana 300","FFE16B","6" }, { "Banana 500","F9C440","6" }, { "Banana 700","D48E15","6" }, { "Banana 900","AD5F00","6" }, { "Lime 100","D1FF82","6" }, { "Lime 300","9BDB4D","6" }, { "Lime 500","68B723","6" }, { "Lime 700","3A9104","6" }, { "Lime 900","206B00","6" }, { "Blueberry 100","8CD5FF","6" }, { "Blueberry 300","64BAFF","6" }, { "Blueberry 500","3689E6","6" }, { "Blueberry 700","0D52BF","6" }, { "Blueberry 900","002E99","6" }, { "Grape 100","E4C6FA","6" }, { "Grape 300","CD9EF7","6" }, { "Grape 500","A56DE2","6" }, { "Grape 700","7239B3","6" }, { "Grape 900","452981","6" }, { "Cocoa 100","A3907C","6" }, { "Cocoa 300","8A715E","6" }, { "Cocoa 500","715344","6" }, { "Cocoa 700","57392D","6" }, { "Cocoa 900","3D211B","6" }, { "Silver 100","FAFAFA","6" }, { "Silver 300","D4D4D4","6" }, { "Silver 500","ABACAE","6" }, { "Silver 700","7E8087","6" }, { "Silver 900","555761","6" }, { "Slate 100","95A3AB","6" }, { "Slate 300","667885","6" }, { "Slate 500","485A6C","6" }, { "Slate 700","273445","6" }, { "Slate 900","0E141F","6" }, { "Black 100","666666","6" }, { "Black 300","4D4D4D","6" }, { "Black 500","333333","6" }, { "Black 700","1A1A1A","6" }, { "Black 900","000000","6" }
        });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Color");

        migrationBuilder.DropTable(
            name: "Group");
    }
}
