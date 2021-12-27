stream.WritePositiveInt(1000000, 21);
            stream.WriteVInt(0, 4);
            stream.WritePositiveInt(0, 1);
            stream.WriteInt(-1, 4);

            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(0, 1);


            stream.WritePositiveInt(0, 5);
            stream.WritePositiveInt(0, 6);
            stream.WritePositiveInt(0, 5);
            stream.WritePositiveInt(0, 6);

            /* stream.WriteVInt(0, 3);

             for (int i = 0; i < 6; i++)
             {
                 stream.WritePositiveInt(0, 1);
                 stream.WritePositiveInt(0, 1);

                 // unk
                 stream.WritePositiveInt(0, 4); // ??

                 if (i == 0)
                 {
                     stream.WritePositiveInt(0, 1);
                     stream.WritePositiveInt(0, 1);
                 }
             }

             stream.WriteVInt(0, 3);*/

            stream.WritePositiveInt(1, 1);
            stream.WritePositiveInt(1, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(0, 12);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(1, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(1, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(1, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(1, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(1, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(1, 1);
            /*stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(0, 1);*/

            for (int i = 0; i < 6; i++)
            {
                stream.WritePositiveInt(0, 1);
                stream.WritePositiveInt(0, 1);
            }

            stream.WritePositiveInt(0, 4);

            // shit

            stream.WritePositiveInt(1, 8);

            stream.WritePositiveInt(16, 5);
            stream.WritePositiveInt(0, 8);

            stream.WritePositiveInt(0, 14);

            stream.WriteVInt(2550, 4);
            stream.WriteVInt(150, 4);
            stream.WriteVInt(0, 3);
            stream.WriteVInt(0, 4);
            stream.WritePositiveInt(10, 4);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(4, 3);
            stream.WritePositiveInt(0, 1);
            stream.WriteInt(63, 6);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(1, 1);
            stream.WritePositiveInt(1, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(0, 2);
            stream.WritePositiveInt(3600, 13);
            stream.WritePositiveInt(3600, 13);
            stream.WritePositiveInt(1, 1);
            stream.WritePositiveInt(1, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(0, 4);
            stream.WritePositiveInt(0, 2);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(0, 9);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(0, 5);
            stream.WritePositiveInt(1, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(1, 1);
            stream.WritePositiveInt(3000, 12);
            stream.WritePositiveInt(1, 1);
            stream.WritePositiveInt(0, 1);
            stream.WritePositiveInt(1, 1);

            stream.WritePositiveInt(0, 8);