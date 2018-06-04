using SharpDX.XInput;
using System;
using System.Threading;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace RLStaller
{
    public partial class MainWindow : Form
    {
        private const int MaxControllers = 4;
        private const int NumBindings = 3;
        private const int UpdateRate = 1;

        private Properties.Settings settings;

        private object updateLock;
        private bool stallPressed;

        private Controller selectedController;
        private InputSimulator inputSimulator;
        private VirtualKeyCode[] keyBindings;
        private GamepadButtonFlags stallBinding;

        /// <summary>
        /// Initializes the MainWindow instance.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            settings = Properties.Settings.Default;

            updateLock = new object();
            stallPressed = false;

            inputSimulator = new InputSimulator();
            keyBindings = new VirtualKeyCode[NumBindings];

            for (int i = 0; i < MaxControllers; i++)
            {
                Controller c = new Controller((UserIndex)i);
                controllerComboBox.Items.Add(c);

                if (selectedController == null && c.IsConnected)
                    controllerComboBox.SelectedIndex = i;
            }

            foreach (var value in Enum.GetValues(typeof(GamepadButtonFlags)))
                stallComboBox.Items.Add(value);
        }

        /// <summary>
        /// Launches the background controller input updater.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadWindow(object sender, EventArgs e)
        {
            LoadSettings();

            new Thread(new ThreadStart(BackgroundUpdater))
            {
                IsBackground = true
            }.Start();
        }

        /// <summary>
        /// Saves the user settings when the window is closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseWindow(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        /// <summary>
        /// Loads existing user settings and applies those settings to the
        /// application.
        /// </summary>
        private void LoadSettings()
        {
            if (settings.ControllerID >= 0 &&
                settings.ControllerID < MaxControllers)
                controllerComboBox.SelectedIndex = settings.ControllerID;
            else
                settings.ControllerID = controllerComboBox.SelectedIndex;

            stallComboBox.SelectedIndex = settings.StallButton;

            LoadBindingSettings(settings.AirSteerLeft, airSteerButton);
            LoadBindingSettings(settings.AirRollRight, airRollButton);
            LoadBindingSettings(settings.Jump, jumpButton);
        }

        /// <summary>
        /// Loads the bindings settings with the given id and value, and
        /// updates the corresponding button.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        /// <param name="button"></param>
        private void LoadBindingSettings(int value, Button button)
        {
            UpdateBinding((int)button.Tag, (VirtualKeyCode)value);
            RefreshBindingButtton(button);
        }

        /// <summary>
        /// Saves the user settings currently entered into the application.
        /// </summary>
        private void SaveSettings()
        {
            settings.ControllerID = controllerComboBox.SelectedIndex;
            settings.StallButton = stallComboBox.SelectedIndex;
            settings.AirSteerLeft = (int)keyBindings[0];
            settings.AirRollRight = (int)keyBindings[1];
            settings.Jump = (int)keyBindings[2];

            settings.Save();
        }

        /// <summary>
        /// Continuously updates controller input.
        /// </summary>
        private void BackgroundUpdater()
        {
            while (true)
            {
                lock (updateLock)
                    UpdateController();

                Thread.Sleep(UpdateRate);
            }
        }

        /// <summary>
        /// Updates controller input for the current selected controller and
        /// write keyboard output if necessary.
        /// </summary>
        private void UpdateController()
        {
            if (selectedController == null || !selectedController.IsConnected)
                return;

            State state;

            try
            {
                state = selectedController.GetState();
            }
            catch (SharpDX.SharpDXException)
            {
                return;
            }

            if (stallBinding != GamepadButtonFlags.None &&
                (state.Gamepad.Buttons & stallBinding) != 0)
            {
                if (!stallPressed)
                {
                    stallPressed = true;
                    for (int i = 0; i < NumBindings; i++)
                        inputSimulator.Keyboard.KeyDown(keyBindings[i]);
                }
            }
            else if (stallPressed)
            {
                stallPressed = false;
                for (int i = 0; i < NumBindings; i++)
                    inputSimulator.Keyboard.KeyUp(keyBindings[i]);
            }
        }

        /// <summary>
        /// Updates the binding for the given binding id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="keyCode"></param>
        private void UpdateBinding(int id, VirtualKeyCode keyCode)
        {
            lock (updateLock)
                keyBindings[id] = keyCode;
        }

        /// <summary>
        /// Updates the text for the given binding button.
        /// </summary>
        /// <param name="button"></param>
        private void RefreshBindingButtton(Button button)
        {
            button.Text = ((Keys)keyBindings[(int)button.Tag]).ToString();
        }

        /// <summary>
        /// Disables controller input updating, changes the selected
        /// controller, and reenables controller input updating.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ControllerSelectedIndexChanged(object sender, EventArgs e)
        {
            lock (updateLock)
            {
                selectedController =
                    (Controller)controllerComboBox.SelectedItem;
                notFoundLabel.Visible = !selectedController.IsConnected;
            }
        }

        /// <summary>
        /// Disables controller input updating, updates the stall binding,
        /// and reenables controller input updating.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StallSelectedIndexChanged(object sender, EventArgs e)
        {
            lock (updateLock)
                stallBinding = (GamepadButtonFlags)stallComboBox.SelectedItem;
        }

        /// <summary>
        /// Updates the bind button text when a bind button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BindButtonClick(object sender, EventArgs e)
        {
            ((Button)sender).Text = "<press any key>";
        }

        /// <summary>
        /// Remaps the keybinding corresponding selected button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BindButtonKeyDown(object sender, KeyEventArgs e)
        {
            UpdateBinding((int)(((Button)sender).Tag), (VirtualKeyCode)e.KeyCode);

            ActiveControl = controllerLabel;
        }

        /// <summary>
        /// Sets the text of the given button when focus is left
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BindButtonLeave(object sender, EventArgs e)
        {
            RefreshBindingButtton((Button)sender);
        }
    }
}
