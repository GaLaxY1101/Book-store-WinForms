using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookStoreForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(FormProvider.StartPage);
        }
        
        public class FormProvider
        {
            private static startPage _startPage;
            public static startPage StartPage
            {
                get
                {
                    if (_startPage == null)
                    {
                        _startPage = new startPage();
                    }
                    return _startPage;
                }
            }

            private static bookPage _bookPage;

            public static bookPage BookPage
            {
                get
                {
                    if (_bookPage == null)
                    {
                        _bookPage = new bookPage();
                    }
                    return _bookPage;
                }
            }

            private static shoppingCart _shopingCart;

            public static shoppingCart ShoppingCart
            {
                get
                {
                    if (_shopingCart == null)
                    {
                        _shopingCart = new shoppingCart();
                    }
                    return _shopingCart;
                }
            }

            private static createOrderForm _createOrderForm;

            public static createOrderForm CreateOrderForm
            {
                get
                {
                    if (_createOrderForm == null)
                    {
                        _createOrderForm = new createOrderForm();
                    }
                    return _createOrderForm;
                }
            }

            private static ordersForm _orderForm;

            public static ordersForm OrderForm
            {
                get
                {
                    if (_orderForm == null)
                    {
                        _orderForm = new ordersForm();
                    }
                    return _orderForm;
                }
            }
        }
    }
}