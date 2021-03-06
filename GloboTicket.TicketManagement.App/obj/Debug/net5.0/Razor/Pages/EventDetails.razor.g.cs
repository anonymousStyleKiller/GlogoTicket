#pragma checksum "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d7c336aad48e2df82291f36a4b0a89473669367"
// <auto-generated/>
#pragma warning disable 1591
namespace GloboTicket.TicketManagement.App.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\_Imports.razor"
using GloboTicket.TicketManagement.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\_Imports.razor"
using GloboTicket.TicketManagement.App.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\_Imports.razor"
using GloboTicket.TicketManagement.App.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/eventdetails")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/eventdetails/{eventid}")]
    public partial class EventDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddAttribute(1, "class", "page-title");
            __builder.AddContent(2, "Details for ");
            __builder.AddContent(3, 
#nullable restore
#line 4 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventDetails.razor"
                                    EventDetailViewModel.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.AddContent(5, 
#nullable restore
#line 6 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventDetails.razor"
 Message

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventDetails.razor"
                  EventDetailViewModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventDetails.razor"
                                                        HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n\r\n    ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group row");
                __builder2.AddMarkupContent(17, "<label for=\"name\" class=\"col-sm-3\">Event name: </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "id", "name");
                __builder2.AddAttribute(20, "class", "form-control col-sm-8");
                __builder2.AddAttribute(21, "placeholder", "Enter event name");
                __builder2.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventDetails.razor"
                                                                         EventDetailViewModel.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EventDetailViewModel.Name = __value, EventDetailViewModel.Name))));
                __builder2.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EventDetailViewModel.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n        ");
                __Blazor.GloboTicket.TicketManagement.App.Pages.EventDetails.TypeInference.CreateValidationMessage_0(__builder2, 26, 27, "offset-sm-3 col-sm-8", 28, 
#nullable restore
#line 15 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventDetails.razor"
                                                               () => EventDetailViewModel.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n\r\n    ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group row");
                __builder2.AddMarkupContent(32, "<label for=\"price\" class=\"col-sm-3\">Ticket price: </label>\r\n        ");
                __Blazor.GloboTicket.TicketManagement.App.Pages.EventDetails.TypeInference.CreateInputNumber_1(__builder2, 33, 34, "phonenumber", 35, "form-control col-sm-8", 36, "Enter price", 37, 
#nullable restore
#line 20 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventDetails.razor"
                                                                                  EventDetailViewModel.Price

#line default
#line hidden
#nullable disable
                , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EventDetailViewModel.Price = __value, EventDetailViewModel.Price)), 39, () => EventDetailViewModel.Price);
                __builder2.AddMarkupContent(40, "\r\n        ");
                __Blazor.GloboTicket.TicketManagement.App.Pages.EventDetails.TypeInference.CreateValidationMessage_2(__builder2, 41, 42, "offset-sm-3 col-sm-8", 43, 
#nullable restore
#line 21 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventDetails.razor"
                                                               () => EventDetailViewModel.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n\r\n    ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group row");
                __builder2.AddMarkupContent(47, "<label for=\"artist\" class=\"col-sm-3\">Artist name: </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(48);
                __builder2.AddAttribute(49, "id", "artist");
                __builder2.AddAttribute(50, "class", "form-control col-sm-8");
                __builder2.AddAttribute(51, "placeholder", "Enter artist");
                __builder2.AddAttribute(52, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventDetails.razor"
                                                                           EventDetailViewModel.Artist

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EventDetailViewModel.Artist = __value, EventDetailViewModel.Artist))));
                __builder2.AddAttribute(54, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EventDetailViewModel.Artist));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n        ");
                __Blazor.GloboTicket.TicketManagement.App.Pages.EventDetails.TypeInference.CreateValidationMessage_3(__builder2, 56, 57, "offset-sm-3 col-sm-8", 58, 
#nullable restore
#line 28 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventDetails.razor"
                                                               () => EventDetailViewModel.Artist

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n\r\n    ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-group row");
                __builder2.AddMarkupContent(62, "<label for=\"date\" class=\"col-sm-3\">Event date: </label>\r\n        ");
                __Blazor.GloboTicket.TicketManagement.App.Pages.EventDetails.TypeInference.CreateInputDate_4(__builder2, 63, 64, "date", 65, "form-control col-sm-8", 66, 
#nullable restore
#line 34 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventDetails.razor"
                                                                         EventDetailViewModel.Date

#line default
#line hidden
#nullable disable
                , 67, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EventDetailViewModel.Date = __value, EventDetailViewModel.Date)), 68, () => EventDetailViewModel.Date);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n\r\n    ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "form-group row");
                __builder2.AddMarkupContent(72, "<label for=\"description\" class=\"col-sm-3\">Description: </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(73);
                __builder2.AddAttribute(74, "id", "description");
                __builder2.AddAttribute(75, "class", "form-control col-sm-8");
                __builder2.AddAttribute(76, "placeholder", "Enter description");
                __builder2.AddAttribute(77, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventDetails.razor"
                                                                                    EventDetailViewModel.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EventDetailViewModel.Description = __value, EventDetailViewModel.Description))));
                __builder2.AddAttribute(79, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EventDetailViewModel.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(80, "\r\n        ");
                __Blazor.GloboTicket.TicketManagement.App.Pages.EventDetails.TypeInference.CreateValidationMessage_5(__builder2, 81, 82, "offset-sm-3 col-sm-8", 83, 
#nullable restore
#line 40 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventDetails.razor"
                                                               () => EventDetailViewModel.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n\r\n    ");
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "form-group row");
                __builder2.AddMarkupContent(87, "<label for=\"imageurl\" class=\"col-sm-3\">Image: </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(88);
                __builder2.AddAttribute(89, "id", "imageurl");
                __builder2.AddAttribute(90, "class", "form-control col-sm-8");
                __builder2.AddAttribute(91, "placeholder", "Enter image URL");
                __builder2.AddAttribute(92, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventDetails.razor"
                                                                             EventDetailViewModel.ImageUrl

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(93, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EventDetailViewModel.ImageUrl = __value, EventDetailViewModel.ImageUrl))));
                __builder2.AddAttribute(94, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EventDetailViewModel.ImageUrl));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(95, "\r\n        ");
                __Blazor.GloboTicket.TicketManagement.App.Pages.EventDetails.TypeInference.CreateValidationMessage_6(__builder2, 96, 97, "offset-sm-3 col-sm-8", 98, 
#nullable restore
#line 46 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventDetails.razor"
                                                               () => EventDetailViewModel.ImageUrl

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n\r\n    ");
                __builder2.OpenElement(100, "div");
                __builder2.AddAttribute(101, "class", "form-group row");
                __builder2.AddMarkupContent(102, "<label for=\"category\" class=\"col-sm-3\">Category: </label>\r\n        ");
                __Blazor.GloboTicket.TicketManagement.App.Pages.EventDetails.TypeInference.CreateInputSelect_7(__builder2, 103, 104, "category", 105, "form-control col-sm-8", 106, 
#nullable restore
#line 51 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventDetails.razor"
                                                                               SelectedCategoryId

#line default
#line hidden
#nullable disable
                , 107, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SelectedCategoryId = __value, SelectedCategoryId)), 108, () => SelectedCategoryId, 109, (__builder3) => {
#nullable restore
#line 52 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventDetails.razor"
             foreach (var category in Categories)
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(110, "option");
                    __builder3.AddAttribute(111, "value", 
#nullable restore
#line 54 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventDetails.razor"
                                category.CategoryId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(112, 
#nullable restore
#line 54 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventDetails.razor"
                                                      category.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 55 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventDetails.razor"
            }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\r\n\r\n    ");
                __builder2.AddMarkupContent(114, "<button type=\"submit\" class=\"submit-button\">Save event</button>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 63 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventDetails.razor"
 if (SelectedEventId != Guid.Empty)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(115, "p");
            __builder.OpenElement(116, "button");
            __builder.AddAttribute(117, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventDetails.razor"
                          DeleteEvent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(118, "class", "delete-button");
            __builder.AddContent(119, "Delete event");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 68 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventDetails.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(120, "<br>\r\n");
            __builder.OpenElement(121, "p");
            __builder.AddAttribute(122, "class", "back-to-catalog mt-3");
            __builder.AddMarkupContent(123, "<img src=\"img/back-arrow.svg\">");
            __builder.OpenElement(124, "a");
            __builder.AddAttribute(125, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventDetails.razor"
                                                                              NavigateToOverview

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(126, "Back to overview");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.GloboTicket.TicketManagement.App.Pages.EventDetails
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
