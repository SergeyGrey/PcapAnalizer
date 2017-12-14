﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PcapVisualizer.Presentation
{
    /// <summary>
    /// Презентер визуализатора
    /// </summary>
    public class VisualizerPresenter
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="view">Вид визуализатора</param>
        /// <param name="presenter">Презентер контроллера параметров фильтрации</param>
        public VisualizerPresenter(IVisualizerView view, FilterParametersPresenter presenter)
        {
            View = view;
            FilterParametersPresenter = presenter;

            View.ViewModel = new ResultPacketsViewModel();

            FilterParametersPresenter.View.PacketChosen += View.ControlView.ViewModel.ResetProtocol;
            FilterParametersPresenter.View.PacketChosen += View.ViewModel.Parse;
            FilterParametersPresenter.View.ViewModel.FilterChanged += View.ViewModel.Filter;
        }

        /// <summary>
        /// Получает или задает вид
        /// </summary>
        public IVisualizerView View { get; set; }

        /// <summary>
        /// Получает или задает представление управления фильтром
        /// </summary>
        public FilterParametersPresenter FilterParametersPresenter { get; set; }

        /// <summary>
        /// Инициализирует модель представления
        /// </summary>
        /// <param name="viewModel">Модель</param>
        public void Initialize(ResultPacketsViewModel viewModel)
        {
            View.ViewModel = viewModel;
        }
    }
}
