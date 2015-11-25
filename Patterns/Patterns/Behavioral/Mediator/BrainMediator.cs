namespace Patterns.Behavioral.Mediator
{
    public class BrainMediator
    {
        private Ear _ear;
        private Face _face;

        // Для з'єднання вуха з мозком
        // або для підключення сестеми до загального посередника щоб він міг її використовувати
        public Ear Ear
        {
            set { _ear = value; }
        }

        // Для з'єднання обличчя з мозком
        // або для підключення сестеми до загального посередника щоб він міг її використовувати
        public Face Face
        {
            set { _face = value; }
        }

        /// <summary>
        /// Коли в одній з модерованих систем відбулася зміна вона автоматично повідомляє про це медіатор
        /// а той в свою чергу викликає іншу систему слугуючи посередником.
        /// </summary>
        /// <param name="bodyPart">
        ///     Оскільки повідомлення може прийти від будь якої системи використовується їх спільний предок.
        ///     Точка входу в посередник. Розрулює взаємодію між системами.
        ///     Теоретично таких способів розрулювання може бути багато.
        /// </param>
        public void OnBodyChanged(BodyPart bodyPart)
        {
            if (bodyPart is Ear)
            {
                var sounds = _ear.GetSounds();

                switch (sounds)
                {
                    case "cool":
                        _face.Smile();
                        break;
                    default:
                        _face.AskForDetails();
                        break;
                }
            }
            else if (bodyPart is Face)
            {
                // something else
            }
        }
    }
}
