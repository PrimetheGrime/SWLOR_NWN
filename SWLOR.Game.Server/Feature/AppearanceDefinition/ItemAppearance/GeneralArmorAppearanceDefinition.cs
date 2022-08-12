﻿namespace SWLOR.Game.Server.Feature.AppearanceDefinition.ItemAppearance
{
    public class GeneralArmorAppearanceDefinition: IArmorAppearanceDefinition
    {
        public int[] Helmet { get; } = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 14, 15, 16, 17, 18, 19, 20, 21, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 95, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 153, 154, 166, 167, 174, 175, 176, 177, 178, 180, 181, 183, 184, 185, 186, 187, 188, 212, 220, 250 };
        public int[] Cloak { get; } = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 70, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 160, 161, 162, 165, 166, 169, 175, 195, 205, 214, 217 };
        public int[] Neck { get; } = { 1, 2, 3, 4, 5, 6, 7, 8, 10, 26, 30, 31, 32, 50, 63, 95, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 121, 122, 123, 124, 125, 126, 127, 128, 129, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 198, 199, 201, 203, 250, 254, 257, 258, 259 };
        public int[] Torso { get; } = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 72, 75, 76, 77, 78, 79, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 163, 166, 167, 168, 171, 172, 173, 175, 176, 177, 178, 179, 180, 181, 182, 183, 184, 185, 186, 187, 188, 189, 190, 191, 193, 196, 197, 198, 199, 200, 201, 202, 203, 210, 212, 219, 220, 221, 222, 247, 248, 249, 250, 253, 258, 259 };
        public int[] Belt { get; } = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 19, 20, 21, 22, 23, 24, 25, 26, 30, 31, 32, 63, 70, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 140, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 188, 189, 190, 191, 192, 198, 218, 219, 220, 221 };
        public int[] Pelvis { get; } = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 40, 41, 42, 50, 63, 75, 101, 102, 103, 104, 105, 106, 108, 109, 110, 111, 117, 122, 123, 140, 141, 142, 143, 144, 146, 151, 153, 154, 156, 157, 161, 163, 164, 165, 166, 186, 198, 199, 201, 202, 203, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 250, 253, 257, 258, 259 };

        public int[] Shoulder { get; } = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 54, 55, 56, 57, 58, 100, 101, 102, 122, 123, 140, 141, 185, 186, 197, 198, 199, 219, 220, 221, 222, 249, 250 };
        public int[] Bicep { get; } = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 17, 20, 21, 22, 30, 31, 32, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 68, 75, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 140, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 182, 183, 186, 198, 199, 201, 202, 203, 246, 247, 248, 249, 250, 257, 258, 259 };
        public int[] Forearm { get; } = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 28, 30, 40, 41, 54, 55, 56, 57, 58, 63, 75, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 140, 141, 142, 143, 144, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 167, 168, 169, 186, 198, 199, 200, 201, 203, 215, 219, 220, 221, 244, 245, 246, 247, 250, 257, 258, 259 };
        public int[] Hand { get; } = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 14, 63, 75, 100, 101, 109, 110, 111, 113, 121, 122, 150, 151, 152, 153, 154, 155, 186, 192, 193, 194, 195, 196, 198, 201, 203, 215, 245, 246, 250, 257, 258, 259 };

        public int[] Thigh { get; } = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 23, 24, 30, 31, 50, 51, 52, 53, 54, 63, 75, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 116, 117, 118, 121, 122, 123, 140, 141, 142, 143, 146, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 186, 198, 199, 201, 202, 203, 220, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 253, 254, 255, 257, 258, 259 };
        public int[] Shin { get; } = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 23, 26, 27, 30, 50, 51, 54, 55, 56, 57, 63, 75, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 102, 103, 104, 105, 106, 107, 108, 109, 110, 116, 117, 121, 128, 129, 130, 131, 132, 140, 141, 142, 143, 146, 151, 152, 153, 154, 155, 156, 157, 158, 160, 161, 162, 164, 165, 166, 186, 198, 199, 201, 202, 203, 219, 220, 221, 222, 223, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 253, 254, 255, 257, 258 };
        public int[] Foot { get; } = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 18, 30, 50, 51, 52, 63, 75, 80, 81, 82, 83, 101, 102, 103, 104, 105, 106, 107, 110, 116, 117, 118, 121, 122, 123, 124, 145, 146, 151, 152, 154, 155, 156, 157, 158, 160, 186, 190, 198, 199, 200, 201, 202, 203, 205, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 253, 254, 255, 257, 258, 259 };
        public int[] Robe { get; } = { 0, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 121, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 169, 170, 173, 174, 182, 183, 184, 185, 186, 187, 190, 191, 192, 193, 194, 195, 196, 197, 198, 200, 201, 202, 203, 204, 205, 206, 221, 222, 223, 226, 227, 230, 234, 235, 236, 247, 248, 249, 250, 252, 253, 254, 259 };

    }
}