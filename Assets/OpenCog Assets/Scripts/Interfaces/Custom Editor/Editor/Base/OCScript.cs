
/// Unity3D OpenCog World Embodiment Program
/// Copyright (C) 2013  Novamente
///
/// This program is free software: you can redistribute it and/or modify
/// it under the terms of the GNU Affero General Public License as
/// published by the Free Software Foundation, either version 3 of the
/// License, or (at your option) any later version.
///
/// This program is distributed in the hope that it will be useful,
/// but WITHOUT ANY WARRANTY; without even the implied warranty of
/// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
/// GNU Affero General Public License for more details.
///
/// You should have received a copy of the GNU Affero General Public License
/// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using UnityEngine;
using System.Collections;
using ProtoBuf;
using System.Collections.Generic;
using UnityEditor;

namespace OpenCog
{

namespace Serialization
{

/// <summary>
/// The OpenCog Script.  Provides meta-data utility for storing and retrieving
/// Unity MonoScripts (components which encapsulate MonoBehaviors).  Used to
/// synchronoize missing MonoBehavior script references together with the base
/// OpenCog Editor and to auto-generate derived OpenCog Editors for use in the
/// inspector.  Typically generated by the OpenCog Automated Script Scanner.
/// </summary>
#region Class Attributes

[ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
#endregion
public class OCScript
{

	/////////////////////////////////////////////////////////////////////////////

  #region Private Member Data

	/////////////////////////////////////////////////////////////////////////////

	/// <summary>
	/// All of the serialized properties.
	/// </summary>
	public Dictionary<string, OCPropertyField> _properties;

	/// <summary>
	/// The instance ID.
	/// </summary>
	public int _ID;

	/// <summary>
	/// The script itself.
	/// </summary>
	public MonoScript _script;

	/////////////////////////////////////////////////////////////////////////////

  #endregion

	/////////////////////////////////////////////////////////////////////////////

  #region Accessors and Mutators

	/////////////////////////////////////////////////////////////////////////////

	/// <summary>
	/// Gets or sets the properties.
	/// </summary>
	/// <value>
	/// The properties.
	/// </value>
	public Dictionary<string, OCPropertyField> Properties
	{
		get{ return _properties; }
		set{ _properties = value; }
	}

	/// <summary>
	/// Gets or sets the ID.
	/// </summary>
	/// <value>
	/// The ID.
	/// </value>
	public int ID
	{
		get{ return _ID; }
		set{ _ID = value; }
	}

	/// <summary>
	/// Gets or sets the script.
	/// </summary>
	/// <value>
	/// The script.
	/// </value>
	public MonoScript Script
	{
		get{ return _script; }
		set{ _script = value; }
	}

	/////////////////////////////////////////////////////////////////////////////

  #endregion

	/////////////////////////////////////////////////////////////////////////////

  #region Public Member Functions

	/////////////////////////////////////////////////////////////////////////////

	public OCScript(int ID, MonoScript Script, Dictionary<string, OCPropertyField> Properties)
	{
		_ID = ID;
		_script = Script;
		_properties = Properties;
	}

	/////////////////////////////////////////////////////////////////////////////

  #endregion

	/////////////////////////////////////////////////////////////////////////////

  #region Private Member Functions

	/////////////////////////////////////////////////////////////////////////////

	/////////////////////////////////////////////////////////////////////////////

  #endregion

	/////////////////////////////////////////////////////////////////////////////

}// class OCScript

}// namespace Serialization

}// namespace OpenCog



