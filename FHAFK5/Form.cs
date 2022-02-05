using Gma.System.MouseKeyHook;
using System;
using System.Drawing;
using System.Windows.Forms;
using SimWinInput;
using System.Collections.Generic;
using System.Threading;

namespace FHAFK5
{
    /// <summary>
    /// This is the main GUI for the application. It also hosts the backend.
    /// </summary>
    public partial class Form : System.Windows.Forms.Form
    {
        public Mode mode = Mode.GAMEPAD;
        public bool enabled = false;
        public bool paused = false;
        public int gamepadIndex = 1;
        private SimGamePad gamePad;
        private Point mouse = new Point(0, 0);
        private IKeyboardMouseEvents globalHook;
        private RandomInt randomInt = new RandomInt();

        /// <summary>
        /// Initializes and prepares the form, sets up toggle keybind.
        /// </summary>
        public Form()
        {
            // Initialize form
            InitializeComponent();

            // Set title
            this.title.Text = this.Text;

            // Set mode - Switch is not appropriate for this activity as it is going through 3 buttons and checking values and setting the mode to
            if (gamepadButton.Checked) 
                mode = Mode.GAMEPAD;
            else if (keyboardButton.Checked) 
                mode = Mode.KEYBOARD;
            else if (mouseButton.Checked) 
                mode = Mode.MOUSE;
            else
                mode = Mode.GAMEPAD;

            // Set buttons
            redrawButtons();
            redrawEnabled();

            // Set up keybind
            globalHook = Hook.GlobalEvents();
            globalHook.MouseMoveExt += MouseMoveEvent;

            Hook.GlobalEvents().OnCombination(new Dictionary<Combination, Action>
            {
                {Combination.FromString("Control+Y"), () => {
                    // Toggle enabled
                    if (enabled == true) 
                        enabled = false;
                    else 
                        enabled = true;

                    // Redraw buttons
                    redrawEnabled();
                }}
            });
        }

        /// <summary>
        /// Spawns and plugs in gamepad, hooks functionality to timer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Load(object sender, EventArgs e)
        {
            // Initialize gamepad
            gamePad = SimGamePad.Instance;
            gamePad.Initialize();
            gamePad.PlugIn();

            // Hook functionality to timer
            this.timer1.Tick += new EventHandler(functionalityTick);
            this.timer1.Interval = 500;
            this.timer1.Start();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Unplug gamepad
            gamePad.Unplug();
        }

        // Mouse move event
        private void MouseMoveEvent(object sender, MouseEventExtArgs e)
        {
            mouse = new Point(e.X, e.Y);
        }

        // Keybind
        private void KeyBindEvent(object sender, KeyPressEventArgs e)
        {

            redrawEnabled();
        }

        // Toolbar functions
        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Radio button functions
        /// <summary>
        /// Updates the buttons by matching the mode with the button and setting wether the button is either checked or not.
        /// </summary>
        private void redrawButtons()
        {
            switch (mode)
            {
                case Mode.GAMEPAD:
                    gamepadButton.Checked = true;
                    keyboardButton.Checked = false;
                    mouseButton.Checked = false;
                    break;
                case Mode.KEYBOARD:
                    gamepadButton.Checked = false;
                    keyboardButton.Checked = true;
                    mouseButton.Checked = false;
                    break;
                case Mode.MOUSE:
                    gamepadButton.Checked = false;
                    keyboardButton.Checked = false;
                    mouseButton.Checked = true;
                    break;
            }

            this.infoBar.Value = 0;
            enabled = false;
            paused = false;
        }

        /// <summary>
        /// Called on gamepadButton checked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private bool alertedGamepad = false;
        private void gamepadButton_CheckedChanged(object sender, EventArgs e)
        {
            if (gamepadButton.Checked == true)
            {
                if (!alertedGamepad)
                {
                    MessageBox.Show("This (gamepad mode) is a work in progress (beta) and may not work.");
                    alertedGamepad = true;
                }

                mode = Mode.GAMEPAD;
                redrawButtons();
            }
        }

        /// <summary>
        /// Called on keyboardButton checked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private bool alertedKeyboard = false;
        private void keyboardButton_CheckedChanged(object sender, EventArgs e)
        {
            if (keyboardButton.Checked == true)
            {
                if (!alertedKeyboard)
                {
                    MessageBox.Show("This (keyboard mode) may interfer with driving.");
                    alertedKeyboard = true;
                }

                mode = Mode.KEYBOARD;
                redrawButtons();
            }
        }

        /// <summary>
        /// Called on mouseButton checked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private bool alertedMouse = false;
        private void mouseButton_CheckedChanged(object sender, EventArgs e)
        {
            if (mouseButton.Checked == true)
            {
                if (!alertedMouse)
                {
                    MessageBox.Show("This (mouse mode) will not automatically drive forward. This is also a work in progress (beta) and may not work.");
                    alertedMouse = true;
                }

                mode = Mode.MOUSE;
                redrawButtons();
            }
        }

        // Drag form functions
        bool mouseDown;
        private Point offset;

        /// <summary>
        /// Enabled mouseDown - allows the window to be moved.
        /// </summary>
        /// <param name="e"></param>
        private void onMouseDown(MouseEventArgs e)
        {
            // Set the original cooridnates as offset and enable mouseDown
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        /// <summary>
        /// Disables mouseDown - prevents the window from being moved.
        /// </summary>
        /// <param name="e"></param>
        private void onMouseUp(MouseEventArgs e)
        {
            // Disable mouseDown
            mouseDown = false;
        }

        /// <summary>
        /// Called on mouse move - matches window location if being dragged.
        /// </summary>
        /// <param name="e"></param>
        private void onMouseMove(MouseEventArgs e)
        {
            // Only move on mouse down
            if (mouseDown == true)
            {
                Point currentWindowPosition = PointToScreen(e.Location);
                Location = new Point(currentWindowPosition.X - offset.X, currentWindowPosition.Y - offset.Y);
            }
        }

        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            onMouseDown(e);
        }

        private void dragPanel_MouseUp(object sender, MouseEventArgs e)
        {
            onMouseUp(e);
        }

        private void dragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            onMouseMove(e);
        }

        private void title_MouseDown(object sender, MouseEventArgs e)
        {
            onMouseDown(e);
        }

        private void title_MouseUp(object sender, MouseEventArgs e)
        {
            onMouseUp(e);
        }

        private void title_MouseMove(object sender, MouseEventArgs e)
        {
            onMouseMove(e);
        }

        private void minimize_MouseDown(object sender, MouseEventArgs e)
        {
            onMouseDown(e);
        }

        private void minimize_MouseUp(object sender, MouseEventArgs e)
        {
            onMouseUp(e);
        }

        private void minimize_MouseMove(object sender, MouseEventArgs e)
        {
            onMouseMove(e);
        }

        private void close_MouseDown(object sender, MouseEventArgs e)
        {
            onMouseDown(e);
        }

        private void close_MouseUp(object sender, MouseEventArgs e)
        {
            onMouseUp(e);
        }

        private void close_MouseMove(object sender, MouseEventArgs e)
        {
            onMouseMove(e);
        }

        // Enabled control
        private void redrawEnabled()
        {
            // Set if the buttons are enabled
            if (enabled)
            {
                start.Enabled = false;
                stop.Enabled = true;
            }
            else
            {
                start.Enabled = true;
                stop.Enabled = false;
            }

            // Hide the disabled buttons by only showing enabled ones
            start.Visible = start.Enabled;
            stop.Visible = stop.Enabled;
        }

        private void start_Click(object sender, EventArgs e)
        {
            // Set enabled to true
            enabled = true;

            // Redraw buttons
            redrawEnabled();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            // Set enabled to false
            enabled = false;

            // Redraw buttons
            redrawEnabled();
        }

        // Paused control
        private void Form_MouseEnter(object sender, EventArgs e)
        {
            paused = true;
        }

        private void Form_MouseLeave(object sender, EventArgs e)
        {
            paused = false;
        }
        private void Form_Activated(object sender, EventArgs e)
        {
            paused = true;
        }

        private void Form_Deactivate(object sender, EventArgs e)
        {
            paused = false;
        }

        // Set timer speed
        private void timerSpeed_ValueChanged(object sender, EventArgs e)
        {
            // Set the timer interval to the timer speed (strictly converted to int)
            this.timer1.Interval = (int)timerSpeed.Value;
        }

        // Backend
        /// <summary>
        /// The controller, updates the infobar, summons and starts threads matching functionality, toggled by enabled and (not) paused.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private bool wasKeyboard = false;
        private void functionalityTick(object sender, EventArgs e)
        {
            // Set the infobar to empty
            this.infoBar.Value = 0;

            // Check if it should run
            if (enabled && !paused)
            {
                Thread functionThread;

                switch (mode)
                {
                    case Mode.GAMEPAD:
                        // Create and launch gamepad function thread
                        functionThread = new Thread(gamepadFunction);
                        functionThread.Start();
                        break;
                    case Mode.KEYBOARD:
                        // Create and launch keyboard function thread
                        functionThread = new Thread(keyboardFunction);
                        functionThread.Start();
                        wasKeyboard = true; // Used to lift key back up
                        break;
                    case Mode.MOUSE:
                        // Create and launch mouse function thread
                        functionThread = new Thread(mouseFunction);
                        functionThread.Start();
                        break;
                }

                // Set the infobar to 100
                this.infoBar.Value = 100;

                if (mode != Mode.KEYBOARD && wasKeyboard)
                {
                    // Disable wasKeyboard
                    wasKeyboard = false;

                    // Lift key up
                    SimKeyboard.KeyUp((byte)87); // 65 is keycode for W
                }
            }
        }

        /// <summary>
        /// Anti-afk for controller..
        /// </summary>
        private void gamepadFunction()
        {
            // Drive forward - hold right trigger (490ms)
            gamePad.Use(GamePadControl.RightTrigger, gamepadIndex, 490); 

            // Anti-afk - click the left stick (10ms)
            gamePad.Use(GamePadControl.LeftStickClick, gamepadIndex, 10);

            return;
        }

        /// <summary>
        /// Anti-afk for keyboard.
        /// </summary>
        private bool keyPressSide = false; // True = A, false = D
        private void keyboardFunction()
        {
            // Drive forward - push down W
            SimKeyboard.KeyDown((byte)87); // 65 is keycode for W

            // Anti-afk - press A and D to turn the car
            if (keyPressSide)
                SimKeyboard.Press((byte)65, 10); // 65 is keycode for A
            else 
                SimKeyboard.Press((byte)68, 10); // 68 is keycode for D
            keyPressSide = !keyPressSide;

            return;
        }

        /// <summary>
        /// Anti-afk for mouse.
        /// </summary>
        private void mouseFunction()
        {
            // Anti-afk - randomize mouse movement (12 pixels)
            SimMouse.Act(SimMouse.Action.RightButtonDown, mouse.X, mouse.Y);
            SimMouse.Act(SimMouse.Action.MoveOnly, mouse.X + randomInt.randomInt(-12, 12), mouse.Y + randomInt.randomInt(-12, 12));
            SimMouse.Act(SimMouse.Action.RightButtonUp, mouse.X, mouse.Y);

            return;
        }
    }
}
